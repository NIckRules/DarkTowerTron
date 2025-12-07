using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Physics
{
    public class KinematicMover : MonoBehaviour
    {
        [Header("Settings")]
        public LayerMask obstacleMask; // Assign 'Wall' and 'Default'
        [SerializeField] private float _skinWidth = 0.015f;
        
        private Collider _collider;
        private RaycastHit[] _hitBuffer = new RaycastHit[5];

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            
            // Auto-configure mask if empty
            if (obstacleMask == 0) 
            {
                // Exclude Player, Projectile, Ground, AfterImage
                // Include Default, Wall
                obstacleMask = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
            }
        }

        /// <summary>
        /// Moves the object, sliding along obstacles.
        /// </summary>
        /// <param name="motion">Delta movement (Velocity * deltaTime)</param>
        public void Move(Vector3 motion, float bounciness = 0f)
        {
            Vector3 finalMotion = ResolveCollisions(motion, bounciness);
            transform.Translate(finalMotion, Space.World);
        }

        private Vector3 ResolveCollisions(Vector3 desiredMotion, float bounciness)
        {
            float distance = desiredMotion.magnitude;
            if (distance < Mathf.Epsilon) return Vector3.zero;

            Vector3 direction = desiredMotion.normalized;
            Vector3 p1, p2;
            float radius;
            GetCapsulePoints(out p1, out p2, out radius);

            // Cast forward to find walls
            int hits = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1, p2, radius, direction, _hitBuffer, distance + _skinWidth, obstacleMask
            );

            // Find closest valid hit
            RaycastHit closestHit = new RaycastHit();
            float closestDist = float.MaxValue;
            bool hitFound = false;

            for (int i = 0; i < hits; i++)
            {
                if (_hitBuffer[i].transform == transform) continue; // Skip self
                if (_hitBuffer[i].collider.isTrigger) continue;     // Skip triggers

                if (_hitBuffer[i].distance < closestDist)
                {
                    closestHit = _hitBuffer[i];
                    closestDist = _hitBuffer[i].distance;
                    hitFound = true;
                }
            }

            if (hitFound)
            {
                // Snap to wall
                float snapDist = Mathf.Max(0, closestDist - _skinWidth);
                Vector3 moveSnap = direction * snapDist;
                
                // Calculate remainder
                Vector3 remaining = desiredMotion - (direction * closestDist);

                if (bounciness > 0)
                {
                    // Bounce
                    Vector3 reflect = Vector3.Reflect(remaining, closestHit.normal);
                    return moveSnap + (reflect * bounciness);
                }
                else
                {
                    // Slide
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
                p2 = transform.position;
            }
        }
    }
}