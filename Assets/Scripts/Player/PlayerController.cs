using UnityEngine;
using DarkTowerTron.Player; // Need this to access PlayerStats

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 10f;
        public float acceleration = 40f;

        [Header("Dash Settings")]
        public float dashSpeed = 25f;
        public float dashDuration = 0.2f;
        public float dashCooldown = 0.8f;
        public TrailRenderer dashTrail; // Assign in Inspector

        private Rigidbody rb;
        private Camera cam;
        private PlayerStats stats;

        // State Management
        private bool isDashing = false;
        private float dashTimer;
        private float dashCooldownTimer;
        private Vector3 dashDirection;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
            stats = GetComponent<PlayerStats>();
        }

        void Update()
        {
            // Handle Dash Input in Update (Input checking is more responsive here)
            if (dashCooldownTimer > 0) dashCooldownTimer -= Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space) && dashCooldownTimer <= 0 && !isDashing)
            {
                StartDash();
            }
        }

        void FixedUpdate()
        {
            if (isDashing)
            {
                HandleDash();
            }
            else
            {
                HandleMovement();
                HandleRotation();
            }
        }

        void StartDash()
        {
            isDashing = true;
            dashTimer = dashDuration;
            dashCooldownTimer = dashCooldown;
            stats.isInvincible = true; // iFrames ON

            // Enable Trail
            if (dashTrail) dashTrail.emitting = true;

            // Determine Direction: Dash towards WASD input, or Forward if standing still
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 inputDir = new Vector3(x, 0, z).normalized;

            if (inputDir == Vector3.zero)
            {
                // Dash where aiming if not moving
                dashDirection = transform.forward;
            }
            else
            {
                // Dash relative to Camera (like normal movement)
                Vector3 camForward = cam.transform.forward;
                Vector3 camRight = cam.transform.right;
                camForward.y = 0; camRight.y = 0;
                camForward.Normalize(); camRight.Normalize();

                dashDirection = (camForward * z) + (camRight * x);
            }
        }

        void HandleDash()
        {
            // Apply constant velocity
            rb.velocity = dashDirection * dashSpeed;

            dashTimer -= Time.fixedDeltaTime;
            if (dashTimer <= 0)
            {
                EndDash();
            }
        }

        void EndDash()
        {
            isDashing = false;
            stats.isInvincible = false; // iFrames OFF
            if (dashTrail) dashTrail.emitting = false;

            // Cut velocity slightly so you don't slide forever after dash
            rb.velocity = rb.velocity * 0.5f;
        }

        void HandleMovement()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            Vector3 camForward = cam.transform.forward;
            Vector3 camRight = cam.transform.right;
            camForward.y = 0; camRight.y = 0;
            camForward.Normalize(); camRight.Normalize();

            Vector3 moveDir = (camForward * z) + (camRight * x);
            Vector3 targetVel = moveDir * moveSpeed;

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
                    Quaternion targetRotation = Quaternion.LookRotation(lookDir);
                    rb.MoveRotation(targetRotation);
                }
            }
        }
    }
}