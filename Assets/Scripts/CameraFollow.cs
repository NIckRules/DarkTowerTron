using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target")]
    public Transform player;

    [Header("Offset Settings")]
    public Vector3 offset; // We will set this automatically
    public float smoothTime = 0.15f; // Smooth follow delay

    private Vector3 currentVelocity;

    void Start()
    {
        // Auto-find player if not assigned
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null) player = playerObj.transform;
            else Debug.LogWarning("CameraFollow: No Player assigned and no object with tag 'Player' found!");
        }

        // Calculate the initial offset based on where you placed the camera in the Scene.
        // This locks the specific angle you set in the Editor.
        if (player != null)
        {
            offset = transform.position - player.position;
        }
    }

    /// <summary>
    /// Instantly moves the camera to the target position, bypassing smoothing.
    /// Useful for initialization or after teleporting the player.
    /// </summary>
    public void SnapToTarget()
    {
        if (player == null) return;
        transform.position = player.position + offset;
        currentVelocity = Vector3.zero;
    }

    void LateUpdate()
    {
        if (player == null) return;

        // 1. Determine where the camera wants to be
        Vector3 targetPosition = player.position + offset;

        // 2. Smoothly drift there
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);

        // REMOVED: transform.LookAt(player); 
        // We do not want the camera to rotate. The angle must remain rock solid.
    }
}