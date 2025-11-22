using UnityEngine;

namespace DarkTowerTron.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 10f;
        public float acceleration = 40f; // High = snappy

        private Rigidbody rb;
        private Camera cam;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
        }

        void FixedUpdate()
        {
            // --- 1. MOVEMENT ---
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            // Calculate Camera-Relative Direction
            Vector3 camForward = cam.transform.forward;
            Vector3 camRight = cam.transform.right;

            // Flatten inputs so looking down doesn't slow us
            camForward.y = 0;
            camRight.y = 0;
            camForward.Normalize();
            camRight.Normalize();

            Vector3 moveDir = (camForward * z) + (camRight * x);
            Vector3 targetVel = moveDir * moveSpeed;

            // Apply Velocity
            rb.velocity = Vector3.MoveTowards(rb.velocity, targetVel, acceleration * Time.fixedDeltaTime);

            // --- 2. ROTATION ---
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                Vector3 point = ray.GetPoint(rayDistance);
                Vector3 lookDir = point - transform.position;
                lookDir.y = 0; // Keep it flat

                if (lookDir != Vector3.zero)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(lookDir);
                    rb.MoveRotation(targetRotation);
                }
            }
        }
    }
}