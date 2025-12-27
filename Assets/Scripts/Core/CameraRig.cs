using UnityEngine;

namespace DarkTowerTron.Core
{
    public class CameraRig : MonoBehaviour
    {
        [Header("Target")]
        public Transform target;

        [Header("Default Settings")]
        public float defaultPitch = 45f;
        public float defaultDistance = 25f;
        public float smoothTime = 0.1f;

        // Internal State
        private float _targetPitch;
        private float _targetDistance;

        // Locking State
        private bool _lockX = false;
        private bool _lockZ = false;
        private Vector3 _lockPosition = Vector3.zero;

        private Vector3 _currentVelocity;

        private void Start()
        {
            ResetToDefault();
        }

        public void ResetToDefault()
        {
            _targetPitch = defaultPitch;
            _targetDistance = defaultDistance;
            _lockX = false;
            _lockZ = false;
        }

        // Called by CameraZone
        public void OverrideCamera(float newPitch, float newDist, bool lockX, bool lockZ, Vector3 lockPos)
        {
            // If -1, keep current/default. Otherwise update.
            if (newPitch > 0) _targetPitch = newPitch;
            if (newDist > 0) _targetDistance = newDist;

            _lockX = lockX;
            _lockZ = lockZ;
            _lockPosition = lockPos;
        }

        private void LateUpdate()
        {
            if (target == null) return;

            // 1. Determine Target Base Position
            Vector3 followPos = target.position;

            // 2. Apply Locks (The Side-Scroller Logic)
            if (_lockX) followPos.x = _lockPosition.x; // Lock horizontal
            if (_lockZ) followPos.z = _lockPosition.z; // Lock depth

            // 3. Smoothly Interpolate Settings
            float currentPitch = transform.eulerAngles.x;
            float usedPitch = Mathf.LerpAngle(currentPitch, _targetPitch, Time.deltaTime * 2f);

            // Simple Lerp for distance is usually enough, or use SmoothDamp if you want fancy zoom
            float currentDist = (transform.position - followPos).magnitude; // Approx
            float usedDist = Mathf.Lerp(currentDist, _targetDistance, Time.deltaTime * 2f);

            // 4. Calculate Offset Math
            float rad = usedPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance; // Use target dist directly for stability
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);

            // 5. Final Position
            Vector3 targetPos = followPos + new Vector3(0, yOffset, zOffset);

            // 6. Execute Move
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(usedPitch, 0, 0);
        }
    }
}