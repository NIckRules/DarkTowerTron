using UnityEngine;

namespace DarkTowerTron.Cameras
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("Target")]
        public Transform player;

        [Header("Isometric Settings")]
        public float distance = 20f;
        public float height = 20f;
        public float angle = 45f;

        [Header("Smooth Settings")]
        public float smoothTime = 0.15f;

        private Vector3 currentVelocity;
        private Vector3 fixedOffset; // The offset we will maintain
        private Quaternion lockedRotation; // The rotation we will enforce

        void Start()
        {
            if (player == null) return;

            // 1. Calculate where the camera SHOULD be based on math
            Vector3 startPos = CalculateTargetPosition(player.position);

            // 2. Move there immediately
            transform.position = startPos;

            // 3. Rotate to look at the player ONCE
            transform.LookAt(player.position);

            // 4. LOCK these values. We will never calculate them again.
            lockedRotation = transform.rotation;
            fixedOffset = transform.position - player.position;
        }

        void FixedUpdate()
        {
            if (player == null) return;

            // 5. Move smoothly to the position that maintains the offset
            Vector3 targetPos = player.position + fixedOffset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref currentVelocity, smoothTime);

            // 6. Enforce the locked rotation. Do NOT LookAt(player).
            transform.rotation = lockedRotation;
        }

        // Helper Math to find the isometric spot
        Vector3 CalculateTargetPosition(Vector3 target)
        {
            float xOffset = -distance * Mathf.Sin(angle * Mathf.Deg2Rad);
            float zOffset = -distance * Mathf.Cos(angle * Mathf.Deg2Rad);

            return new Vector3(
                target.x + xOffset,
                target.y + height,
                target.z + zOffset
            );
        }

        // This allows you to tweak sliders in Editor and see the result instantly
        void OnValidate()
        {
            if (player != null)
            {
                Vector3 pos = CalculateTargetPosition(player.position);
                transform.position = pos;
                transform.LookAt(player.position);
            }
        }
    }
}