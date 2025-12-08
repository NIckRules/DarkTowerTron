using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Physics
{
    public class KinematicMover : MonoBehaviour
    {
        [Header("Settings")]
        public LayerMask obstacleMask;
        [SerializeField] private float _skinWidth = 0.015f;

        [Header("Gravity")]
        public float gravity = 20f; // Default gravity for ground units

        private Collider _collider;
        private RaycastHit[] _hitBuffer = new RaycastHit[5];
        private bool _isGrounded;

        // Public Property to check state
        public bool IsGrounded => _isGrounded;

        private void Awake()
        {
            _collider = GetComponent<Collider>();

            if (obstacleMask == 0)
            {
                obstacleMask = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
            }
        }

        public void Move(Vector3 motion, float bounciness = 0f)
        {
            float dt = Time.deltaTime;

            // 1. Apply Gravity (If enabled)
            // We verify ground status first to avoid infinite accumulation
            CheckGround();

            if (gravity > 0)
            {
                if (!_isGrounded)
                {
                    // Fall
                    motion.y -= gravity * dt;
                }
                else if (motion.y <= 0)
                {
                    // Snap to ground (prevents micro-bouncing)
                    motion.y = -2f * dt;
                }
            }

            // 2. Resolve Collisions
            Vector3 finalMotion = ResolveCollisions(motion, bounciness);

            // 3. Apply
            transform.Translate(finalMotion, Space.World);
        }

        private void CheckGround()
        {
            // Simple SphereCast down to see if we are standing on something
            Vector3 p1, p2;
            float radius;
            GetCapsulePoints(out p1, out p2, out radius);

            // Cast slightly down
            _isGrounded = UnityEngine.Physics.SphereCast(p1, radius * 0.9f, Vector3.down, out RaycastHit hit, 0.1f, obstacleMask);
        }

        private Vector3 ResolveCollisions(Vector3 desiredMotion, float bounciness)
        {
            float distance = desiredMotion.magnitude;
            if (distance < Mathf.Epsilon) return Vector3.zero;

            Vector3 direction = desiredMotion.normalized;
            Vector3 p1, p2;
            float radius;
            GetCapsulePoints(out p1, out p2, out radius);

            int hits = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1, p2, radius, direction, _hitBuffer, distance + _skinWidth, obstacleMask
            );

            RaycastHit closestHit = new RaycastHit();
            float closestDist = float.MaxValue;
            bool hitFound = false;

            for (int i = 0; i < hits; i++)
            {
                if (_hitBuffer[i].transform == transform) continue;
                if (_hitBuffer[i].collider.isTrigger) continue;

                if (_hitBuffer[i].distance < closestDist)
                {
                    closestHit = _hitBuffer[i];
                    closestDist = _hitBuffer[i].distance;
                    hitFound = true;
                }
            }

            if (hitFound)
            {
                float snapDist = Mathf.Max(0, closestDist - _skinWidth);
                Vector3 moveSnap = direction * snapDist;
                Vector3 remaining = desiredMotion - (direction * closestDist);

                if (bounciness > 0)
                {
                    Vector3 reflect = Vector3.Reflect(remaining, closestHit.normal);
                    return moveSnap + (reflect * bounciness);
                }
                else
                {
                    Vector3 slide = Vector3.ProjectOnPlane(remaining, closestHit.normal);
                    return moveSnap + slide;
                }
            }

            return desiredMotion;
        }

        private void GetCapsulePoints(out Vector3 p1, out Vector3 p2, out float radius)
        {
            if (_collider is CapsuleCollider cap)
            {
                radius = cap.radius;
                float height = Mathf.Max(0, cap.height / 2f - radius);
                p1 = transform.position + cap.center + Vector3.up * height;
                p2 = transform.position + cap.center - Vector3.up * height;
            }
            else
            {
                radius = 0.5f;
                p1 = transform.position;
                p2 = p1;
            }
        }
    }
}