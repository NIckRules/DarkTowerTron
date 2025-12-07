using UnityEngine;

namespace DarkTowerTron.Core
{
    public class CameraRig : MonoBehaviour
    {
        [Header("Target")]
        public Transform target; // Assign the Player

        [Header("Isometric Settings")]
        public float pitch = 45f;   // Angle (e.g., 45 degrees)
        public float distance = 25f; // Zoom
        public float smoothTime = 0.1f; // 0.1 is snappy but smooth. 0 is hard-lock.

        private Vector3 _currentVelocity;

        // Run AFTER PlayerMovement (Update) and KinematicMover (Update)
        private void LateUpdate()
        {
            if (target == null) return;

            // 1. Math: Calculate exact isometric position based on angle/distance
            float rad = pitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * distance;
            float zOffset = -(Mathf.Cos(rad) * distance);

            Vector3 targetPos = target.position + new Vector3(0, yOffset, zOffset);

            // 2. Smooth Follow
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVelocity, smoothTime);

            // 3. Lock Rotation
            transform.rotation = Quaternion.Euler(pitch, 0, 0);
        }
    }
}