using UnityEngine;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Settings")]
        public float moveSpeed = 6f; // "Instant 6 u/s velocity" per design doc

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
            // 1. GetAxisRaw Horizontal & Vertical.
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            // 2. Camera-Relative Direction
            // We project camera vectors onto the ground plane (y=0)
            Vector3 camForward = cam.transform.forward;
            Vector3 camRight = cam.transform.right;

            camForward.y = 0;
            camRight.y = 0;
            camForward.Normalize();
            camRight.Normalize();

            // 3. Combine and Normalize
            Vector3 moveDir = (camForward * z + camRight * x).normalized;

            // 4. Set rb.velocity = direction * moveSpeed. (No acceleration/smoothing).
            // We preserve Y velocity for gravity if needed, though usually 0 in this prototype.
            rb.velocity = new Vector3(moveDir.x * moveSpeed, rb.velocity.y, moveDir.z * moveSpeed);
        }

        void HandleRotation()
        {
            // 1. Raycast from Camera to GroundPlane.
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero); // Plane at Y=0
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                // 2. Get point.
                Vector3 point = ray.GetPoint(rayDistance);

                // 3. Calculate lookDir (point - transform.position).
                Vector3 lookDir = point - transform.position;
                lookDir.y = 0; // Keep it flat

                // 4. Set rotation
                if (lookDir.sqrMagnitude > 0.001f)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(lookDir);
                    rb.MoveRotation(targetRotation);
                }
            }
        }
    }
}