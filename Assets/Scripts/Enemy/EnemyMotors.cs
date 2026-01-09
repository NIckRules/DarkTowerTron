using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Physics;
using UnityEngine;

namespace DarkTowerTron.Enemy
{
    // We implement IMover so the PluggableAIController can talk to us directly.
    public class EnemyMotor : MonoBehaviour, IPoolable, IMover
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        // The underlying Physics Engine (KinematicMover or UnityCharacterMover)
        private IMover _physicsMover;

        // Internal State
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed; // For smooth hovering
        private Collider[] _neighbors = new Collider[10]; // For separation

        // --- IMover Interface Properties (Pass-Through) ---
        public Vector3 Velocity => _physicsMover != null ? _physicsMover.Velocity : Vector3.zero;
        public bool IsGrounded => _physicsMover != null && _physicsMover.IsGrounded;

        private void Awake()
        {
            // 1. Find the REAL physics mover attached to this object.
            // Since EnemyMotor acts as a wrapper, we need to find the "Other" IMover.
            var allMovers = GetComponents<IMover>();
            foreach (var m in allMovers)
            {
                // Cast to interface to compare references
                if (m != (IMover)this)
                {

                    GameLogger.Log(LogChannel.AI, "[EnemyMotor] Found Physics Mover: " + m.GetType().Name, this.gameObject);

                    _physicsMover = m;
                    break;
                }
            }

            // 2. Fallback Safety: If no physics mover exists, add the default KinematicMover.
            if (_physicsMover == null)
            {
                _physicsMover = gameObject.AddComponent<KinematicMover>();
            }

            if (allyLayer == 0) allyLayer = 1 << GameConstants.LAYER_ENEMY;
        }

        // --- IPoolable Implementation ---

        public void OnSpawn()
        {
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Forward the spawn event to the physics engine if it supports it
            if (_physicsMover is IPoolable p) p.OnSpawn();
        }

        public void OnDespawn()
        {
            _currentVelocity = Vector3.zero;
            if (_physicsMover is IPoolable p) p.OnDespawn();
        }

        // --- IMover Implementation (The Logic) ---

        public void Teleport(Vector3 pos) => _physicsMover?.Teleport(pos);

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            // Optionally enable/disable the physics mover too, 
            // though usually we want physics to run even if AI logic is paused.
        }

        /// <summary>
        /// Receives a Direction (usually Magnitude 1) from the AI.
        /// Applies Speed, Acceleration, Hovering, and Separation.
        /// </summary>
        public void Move(Vector3 inputVector)
        {

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Called with Input: " + inputVector.ToString("F2"), this.gameObject);

            if (stats == null || _physicsMover == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Input: " + inputVector.ToString("F2"), this.gameObject);

            // 1. Apply Speed Stats
            // The AI sends a direction. We make it a Velocity based on stats.
            Vector3 targetVel = inputVector.normalized * stats.moveSpeed;

            // 2. Separation Logic (Don't stack on top of other enemies)
            if (stats.moveSpeed > 0.1f)
            {
                targetVel += CalculateSeparation();
            }

            // 3. Inertia (Acceleration)
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 4. Knockback Decay
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. Vertical Logic (Hover vs Gravity)
            if (stats.rideHeight > 0)
            {
                // --- HOVER LOGIC ---
                float groundY = -999f;
                Vector3 rayOrigin = transform.position + Vector3.up * 1.0f;

                // Cast down to find floor/obstacles
                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 20f, GameConstants.MASK_PHYSICS_OBSTACLES))
                {
                    groundY = hit.point.y;
                }
                else
                {
                    // No ground? Maintain current relative height
                    groundY = transform.position.y - stats.rideHeight;
                }

                float targetY = groundY + stats.rideHeight;
                float currentY = transform.position.y;

                // Smoothly interpolate height
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // Convert position change back to velocity for the Mover
                finalVelocity.y = (newY - currentY) / dt;
            }
            else
            {
                // --- GRAVITY LOGIC ---
                if (!_physicsMover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard Gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick to ground
                }
            }

            // 6. Final Execution
            _physicsMover.Move(finalVelocity);
        }

        // --- Helper Methods ---

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                // Prevent division by zero
                if (dist < 0.01f) direction = Random.insideUnitSphere;

                // Stronger push the closer they are
                pushVector += direction.normalized / (dist + 0.1f);
            }

            return pushVector * stats.separationForce;
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }

        public void FaceTarget(Vector3 targetPos)
        {
            // Ignore Y axis for rotation
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.rotationSpeed * Time.deltaTime);
            }
        }

        public void FaceCombatTarget(Vector3 targetPos)
        {
            // Ignore Y axis
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                // Use COMBAT rotation speed (slower/smoother) instead of navigation speed
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.combatRotationSpeed * Time.deltaTime);
            }
        }
    }
}