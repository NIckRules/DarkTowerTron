using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Enemy
{
    // Do not require a specific mover so we can swap implementations.
    public class EnemyMotor : MonoBehaviour, IPoolable
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        private IMover _mover;
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed;
        private Collider[] _neighbors = new Collider[10];

        private void Awake()
        {
            // Auto-detect any IMover implementation (KinematicMover, UnityCharacterMover, etc.)
            _mover = GetComponent<IMover>();

            if (_mover == null)
            {
                // Safe default
                _mover = gameObject.AddComponent<KinematicMover>();
            }
            if (allyLayer == 0) allyLayer = 1 << GameConstants.LAYER_ENEMY;
        }

        private void OnEnable()
        {
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // REMOVED: The code that snapped transform.position.y = 0
            // logic: We trust the Spawner to put us where we need to be.
            // If rideHeight > 0, the Update loop will naturally float us up/down to that height.
            OnSpawn();
        }

        // --- IPoolable ---
        public void OnSpawn()
        {
            // Reset Physics State
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Reset Position logic
            // (Removed y=0 snap. Spawner is responsible for initial Y. If rideHeight > 0, Update loop will float us.)
        }

        public void OnDespawn()
        {
            // Stop moving immediately so we don't drift while in the pool
            _currentVelocity = Vector3.zero;
        }

        public void Move(Vector3 desiredDirection)
        {
            if (stats == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;
            Vector3 targetVel = desiredDirection * stats.moveSpeed;

            // 1. Separation
            if (stats.moveSpeed > 0.1f)
            {
                Vector3 separationPush = CalculateSeparation();
                targetVel += separationPush;
            }

            // 2. Inertia
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 3. Knockback
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            // 4. COMBINE
            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. VERTICAL LOGIC (Flight vs Gravity)
            if (stats.rideHeight > 0)
            {
                // A. Determine Ground Height
                float groundY = -999f; // Fallback (Void)

                // Start raycast slightly above current position to catch the floor even if we clipped in slightly
                Vector3 rayOrigin = transform.position + Vector3.up * 1.0f;

                // Cast down 20 units (Enough for high hoverers)
                // Use OBSTACLES mask (Ground + Default + Wall) so they hover over bridges/crates too
                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 20f, GameConstants.MASK_PHYSICS_OBSTACLES))
                {
                    groundY = hit.point.y;
                }
                else
                {
                    // No ground found? Maintain current height (don't fall into void)
                    groundY = transform.position.y - stats.rideHeight;
                }

                // B. Calculate Target Y
                float targetY = groundY + stats.rideHeight;

                // C. Smoothly Fly There
                float currentY = transform.position.y;
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // D. Convert to Velocity for the KinematicMover
                float verticalVel = (newY - currentY) / dt;
                finalVelocity.y = verticalVel;
            }
            else
            {
                // WALKING: Apply Gravity if not grounded
                if (!_mover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick
                }
            }

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;

            // Use stats.separationRadius
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                if (dist < 0.01f) direction = Random.insideUnitSphere;

                pushVector += direction.normalized / (dist + 0.1f);
            }

            // Use stats.separationForce
            return pushVector * stats.separationForce;
        }

        // Standard Face Target (Uses Navigation Speed)
        public void FaceTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.rotationSpeed);
        }

        // Combat Face Target (Uses Slower Combat Speed)
        public void FaceCombatTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.combatRotationSpeed);
        }

        // Helper to avoid duplicate code
        private void RotateTowards(Vector3 targetPosition, float speed)
        {
            Vector3 dir = targetPosition - transform.position;
            dir.y = 0; 
            
            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, speed * Time.deltaTime);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }
    }
}