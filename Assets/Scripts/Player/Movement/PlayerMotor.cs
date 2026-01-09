using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Physics;
using DarkTowerTron.Player.Stats;
using UnityEngine;

namespace DarkTowerTron.Player.Movement
{
    // Intentionally not requiring a specific mover so we can swap implementations.
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMotor : MonoBehaviour
    {
        [Header("Mover Selection")]
        [Tooltip("If true, attempts to use UnityCharacterMover. If false, uses KinematicMover.")]
        public bool useUnityController = false;

        [Header("Wall Repulsion")]
        public float wallBuffer = 0.6f; // Keep this (Collider size dependency)

        [Header("Safety Net")]
        public float safeGroundTimer = 0.5f; // Time required to be grounded to count as "Safe"
        
        // Read-only property for the Health script to access
        public Vector3 LastSafePosition { get; private set; }

        // Expose input for Blitz
        public Vector3 MoveInput => _inputDir;

        private IMover _mover;
        private Camera _cam;
        private PlayerStats _stats;

        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;
        private float _groundedTimer;
        private float _gravitySuspendTimer = 0f;
        
        // Cache for optimization
        private Collider[] _wallBuffer = new Collider[5];

        private void Awake()
        {
            _cam = Camera.main;
            _stats = GetComponent<PlayerStats>();

            InitializeMover();
        }

        private void Start()
        {
            LastSafePosition = transform.position;
        }

        private void InitializeMover()
        {
            var kMover = GetComponent<KinematicMover>();
            var uMover = GetComponent<UnityCharacterMover>();

            // Disable both initially
            if (kMover) kMover.SetEnabled(false);
            if (uMover) uMover.SetEnabled(false);

            if (useUnityController)
            {
                if (uMover == null) uMover = gameObject.AddComponent<UnityCharacterMover>();
                _mover = uMover;

                // Disable collision on KinematicMover (CapsuleCollider) to avoid double collision
                if (kMover && kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = false;
            }
            else
            {
                if (kMover == null) kMover = gameObject.AddComponent<KinematicMover>();
                _mover = kMover;

                // Re-enable CapsuleCollider
                if (kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = true;
            }

            _mover?.SetEnabled(true);
            if (_mover != null) GameLogger.Log(LogChannel.Player, $"[PlayerMovement] Using Mover: {_mover.GetType().Name}");
        }

        [ContextMenu("Swap Mover")]
        public void SwapMover()
        {
            useUnityController = !useUnityController;
            InitializeMover();
        }

        public void SetMoveInput(Vector3 dir)
        {
            _inputDir = dir;
        }

        public void LookAtDirection(Vector3 direction)
        {
            direction.y = 0;
            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion targetRot = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, _stats.RotationSpeed * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            // Use UnityEngine.Physics to disambiguate
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, GameConstants.MASK_GROUND_ONLY))
            {
                Vector3 lookDir = hit.point - transform.position;
                LookAtDirection(lookDir);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _externalForce += force;
        }

        private void Update()
        {

            if (_gravitySuspendTimer > 0) _gravitySuspendTimer -= Time.deltaTime;

            HandleVelocity();
            HandleSafeGround();
        }

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target (Inputs)
            Vector3 targetVel = _inputDir * _stats.MoveSpeed;
            Vector3 wallPush = CalculateWallRepulsion();
            targetVel += wallPush;

            // 2. Acceleration
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, _stats.Acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, _stats.Deceleration * dt);
                if (_currentVelocity.magnitude < 0.01f) _currentVelocity = Vector3.zero;
            }

            // 3. External Forces (Recoil/Knockback)
            if (_externalForce.magnitude > 0.1f)
            {
                _externalForce = Vector3.Lerp(_externalForce, Vector3.zero, 5f * dt);
            }
            else
            {
                _externalForce = Vector3.zero;
            }

            // 4. COMBINE (No dt multiplication here!)
            Vector3 finalVelocity = _currentVelocity + _externalForce;

            // --- GRAVITY LOGIC UPDATE ---
            // Only apply gravity if NOT grounded AND NOT suspended
            if (!_mover.IsGrounded && _gravitySuspendTimer <= 0)
            {
                finalVelocity.y -= _stats.Gravity;
            }
            else if (_mover.IsGrounded)
            {
                finalVelocity.y = -2f; // Stick to ground
            }
            else
            {
                // We are in Air + Suspended = Zero Gravity (Hover)
                finalVelocity.y = 0f;
            }
            // ----------------------------

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        // NEW METHOD: Call this when teleporting/respawning
        public void ResetVelocity()
        {
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _inputDir = Vector3.zero; // Optional: Stop input until player presses again
        }

        public void Teleport(Vector3 position)
        {
            // 1. Reset Velocities
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _gravitySuspendTimer = 0f;

            // 2. Delegate to the Interface (which handles the CC enable/disable safety)
            if (_mover != null)
            {
                _mover.Teleport(position);
            }
            else
            {
                transform.position = position;
            }
        }

        private void HandleSafeGround()
        {
            // STRICT CHECK:
            // 1. Must be physically grounded (Motor check)
            // 2. Must have ground directly beneath center (Raycast check)
            // This prevents saving "The Edge" as a safe spot.
            
            bool isCenterSupported = false;
            
            // Cast from slightly up, downwards. Check GROUND layer only.
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, 2.0f, GameConstants.MASK_GROUND_ONLY))
            {
                isCenterSupported = true;
            }

            if (_mover.IsGrounded && isCenterSupported)
            {
                _groundedTimer += Time.deltaTime;
                if (_groundedTimer > safeGroundTimer)
                {
                    // Save position slightly higher to prevent floor clipping
                    LastSafePosition = transform.position + Vector3.up * 0.2f;
                }
            }
            else
            {
                _groundedTimer = 0f;
            }
        }

        private Vector3 CalculateWallRepulsion()
        {
            Vector3 push = Vector3.zero;

            // CHANGE: Use Constant instead of variable
            int layerMask = GameConstants.MASK_WALLS;

            // Find walls within buffer range
            // We use the player's position + slight up offset (center of mass)
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, _wallBuffer, layerMask);

            for (int i = 0; i < count; i++)
            {
                Collider wall = _wallBuffer[i];

                // Find the closest point on the wall's surface to the player
                Vector3 closestPoint = wall.ClosestPoint(transform.position + Vector3.up);

                // Calculate direction AWAY from wall
                Vector3 dir = (transform.position - closestPoint);
                dir.y = 0; // Keep it flat

                float dist = dir.magnitude;

                // If we are actually inside/touching/near the wall
                if (dist < wallBuffer)
                {
                    // The closer we are, the stronger the push
                    // Normalized push * strength
                    push += dir.normalized * _stats.WallRepulsion;
                }
            }

            return push;
        }

        public void SuspendGravity(float duration)
        {
            _gravitySuspendTimer = duration;

            // CRITICAL: Kill existing downward momentum immediately
            // so we don't carry "falling speed" into the hover.
            if (_externalForce.y < 0) _externalForce.y = 0;
            if (_currentVelocity.y < 0) _currentVelocity.y = 0;
        }
    }
}