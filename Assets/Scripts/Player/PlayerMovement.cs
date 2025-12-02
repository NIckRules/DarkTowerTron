using UnityEngine;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Settings")]
        public float moveSpeed = 11f;     // Increased from 6
        public float acceleration = 50f;  // High = snappy, Low = ice skating. 50 is a good "heavy" spot.

        private Rigidbody rb;
        private Camera cam;
        private Vector3 externalImpact = Vector3.zero; // Stores the push

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
        }

        void FixedUpdate()
        {
            HandleMovement();
            HandleRotation();
            HandleImpactDecay(); // NEW
        }

        void HandleMovement()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 inputDir = new Vector3(x, 0, z).normalized;
            Vector3 targetVel = inputDir * moveSpeed;

            // NEW: Add the impact vector to your movement
            Vector3 finalVelocity = Vector3.MoveTowards(rb.velocity, targetVel, acceleration * Time.fixedDeltaTime);
            rb.velocity = finalVelocity + externalImpact;
        }

        void HandleRotation()
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                Vector3 point = ray.GetPoint(rayDistance);
                Vector3 lookDir = point - transform.position;
                lookDir.y = 0; 
                
                if (lookDir != Vector3.zero)
                {
                    rb.MoveRotation(Quaternion.LookRotation(lookDir));
                }
            }
        }

        // NEW Method to apply the jolt
        public void ApplyKnockback(Vector3 direction, float force)
        {
            direction.y = 0; // Keep it flat
            externalImpact += direction.normalized * force;
        }

        void HandleImpactDecay()
        {
            // Smoothly reduce the impact to zero (Damping)
            if (externalImpact.magnitude > 0.2f)
            {
                externalImpact = Vector3.Lerp(externalImpact, Vector3.zero, 5f * Time.fixedDeltaTime);
            }
            else
            {
                externalImpact = Vector3.zero;
            }
        }
    }
}