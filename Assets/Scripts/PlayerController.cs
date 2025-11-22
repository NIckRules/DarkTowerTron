using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 10f;
    public float acceleration = 40f; // High = snappy, Low = ice skating

    private Rigidbody rb;
    private Camera cam;
    private Vector3 targetVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    void Update()
    {
        // 1. Rotation (Aiming) - Kept the same
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
                transform.rotation = Quaternion.LookRotation(lookDir);
            }
        }
    }

    void FixedUpdate()
    {
        // 2. Input
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 inputDir = new Vector3(x, 0, z).normalized;

        // 3. Camera-Relative Correction
        // We take the Camera's rotation, strip away the X and Z tilt, and keep only the Y (Yaw)
        Vector3 camForward = cam.transform.forward;
        Vector3 camRight = cam.transform.right;

        // Flatten them so looking down doesn't slow us down
        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        // Combine inputs with camera vectors
        Vector3 moveDir = (camForward * z) + (camRight * x);

        // 4. Inertia (Velocity Smoothing)
        Vector3 targetVel = moveDir * moveSpeed;

        // MoveTowards is linear (Clean/Arcade), Lerp is curved (Organic/Slippery)
        // For Hades-like, MoveTowards feels tighter.
        rb.velocity = Vector3.MoveTowards(rb.velocity, targetVel, acceleration * Time.fixedDeltaTime);
    }
}