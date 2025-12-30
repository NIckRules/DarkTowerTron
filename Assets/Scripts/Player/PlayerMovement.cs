using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Wall Repulsion")]
        public float wallBuffer = 0.7f;
        public float repulsionForce = 10f;
        public LayerMask wallLayer;

        [Header("Physics")]
        public float gravity = 20f;

        [Header("Safety Net")]
        public float safeGroundTimer = 0.5f;

        // Public Properties
        public Vector3 MoveInput => _inputDir;
        public Vector3 LastSafePosition { get; private set; }

        // Dependencies
        private KinematicMover _mover;
        private PlayerStats _stats;
        private Camera _cam;

        // State
        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;
        private float _gravitySuspendTimer = 0f;
        private float _groundedTimer;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _stats = GetComponent<PlayerStats>();
            _cam = Camera.main;

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", "Wall");
        }

        private void Start()
        {
            LastSafePosition = transform.position;
        }

        private void Update()
        {
            // Update Timers
            if (_gravitySuspendTimer > 0) _gravitySuspendTimer -= Time.deltaTime;

            HandleVelocity();
            HandleSafeGround();
        }

        // --- PUBLIC API ---

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
                // Hardcoded rotation speed is fine, or add to stats if needed
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 25f * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, LayerMask.GetMask(GameConstants.LAYER_GROUND)))
            {
                Vector3 lookDir = hit.point - transform.position;
                LookAtDirection(lookDir);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0; // Flatten
            _externalForce += force;
        }

        public void SuspendGravity(float duration)
        {
            _gravitySuspendTimer = duration;
            if (_externalForce.y < 0) _externalForce.y = 0;
            if (_currentVelocity.y < 0) _currentVelocity.y = 0;
        }

        public void ResetVelocity()
        {
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _inputDir = Vector3.zero;
        }

        // --- INTERNAL LOGIC ---

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target Velocity (Input + Wall Repulsion)
            Vector3 targetVel = _inputDir * _stats.MoveSpeed;
            Vector3 wallPush = CalculateWallRepulsion();
            targetVel += wallPush;

            // 2. Accelerate / Decelerate
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, _stats.Acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, 40f * dt); // Default friction
                if (_currentVelocity.magnitude < 0.01f) _currentVelocity = Vector3.zero;
            }

            // 3. Handle External Forces (Knockback decay)
            if (_externalForce.magnitude > 0.1f)
            {
                _externalForce = Vector3.Lerp(_externalForce, Vector3.zero, 5f * dt);
            }
            else
            {
                _externalForce = Vector3.zero;
            }

            Vector3 finalVelocity = _currentVelocity + _externalForce;

            // 4. Apply Gravity
            if (!_mover.IsGrounded && _gravitySuspendTimer <= 0)
            {
                finalVelocity.y -= gravity;
            }
            else if (_mover.IsGrounded)
            {
                finalVelocity.y = -2f; // Stick to ground
            }
            else
            {
                finalVelocity.y = 0f; // Hovering
            }

            // 5. Execute
            _mover.Move(finalVelocity);
        }

        private Vector3 CalculateWallRepulsion()
        {
            Vector3 push = Vector3.zero;
            Collider[] buffer = new Collider[5];
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, buffer, wallLayer);

            for (int i = 0; i < count; i++)
            {
                Vector3 closestPoint = buffer[i].ClosestPoint(transform.position + Vector3.up);
                Vector3 dir = (transform.position - closestPoint);
                dir.y = 0;

                float dist = dir.magnitude;
                if (dist < wallBuffer)
                {
                    push += dir.normalized * repulsionForce;
                }
            }
            return push;
        }

        private void HandleSafeGround()
        {
            // Raycast check for center-mass stability
            bool isCenterSupported = UnityEngine.Physics.Raycast(
                transform.position + Vector3.up * 0.5f,
                Vector3.down,
                2.0f,
                LayerMask.GetMask(GameConstants.LAYER_GROUND)
            );

            if (_mover.IsGrounded && isCenterSupported)
            {
                _groundedTimer += Time.deltaTime;
                if (_groundedTimer > safeGroundTimer)
                {
                    LastSafePosition = transform.position + Vector3.up * 0.2f;
                }
            }
            else
            {
                _groundedTimer = 0f;
            }
        }
    }
}