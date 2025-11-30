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

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
        }

        void FixedUpdate()
        {
            HandleMovement();
            HandleRotation();
        }

        void HandleMovement()
        {
            // 1. Input
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 inputDir = new Vector3(x, 0, z).normalized;

            // 2. Calculate Target Velocity
            Vector3 targetVel = inputDir * moveSpeed;

            // 3. Apply Acceleration (The "Weight")
            // Instead of snapping instantly, we move towards the target speed over time.
            rb.velocity = Vector3.MoveTowards(rb.velocity, targetVel, acceleration * Time.fixedDeltaTime);
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
    }
}