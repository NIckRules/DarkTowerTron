using UnityEngine;
using DarkTowerTron.Gameplay.Player; // Access to PlayerController

namespace DarkTowerTron.Gameplay.Cameras
{
    [DefaultExecutionOrder(-10)] // Initialize before Triggers
    public class CameraRig : MonoBehaviour
    {
        public static CameraRig Instance { get; private set; }

        [Header("Targeting")]
        [SerializeField] private Transform _target;
        [SerializeField] private bool _autoFindPlayer = true;

        [Header("Default Settings")]
        [SerializeField] private float _defaultPitch = 45f;
        [SerializeField] private float _defaultDistance = 25f;
        
        [Header("Motion Settings")]
        [SerializeField] private float _smoothTime = 0.1f;
        [SerializeField] private float _rotationSmoothSpeed = 2f;

        // Internal State
        private float _targetPitch;
        private float _targetDistance;

        // Locking State (for 2.5D sections)
        private bool _lockX = false;
        private bool _lockZ = false;
        private Vector3 _lockPosition = Vector3.zero;

        // Velocity for SmoothDamp
        private Vector3 _currentVelocity;

        private void Awake()
        {
            // Singleton Registration
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;

            ResetToDefault();
        }

        private void Start()
        {
            if (_target == null && _autoFindPlayer)
            {
                if (PlayerController.Instance != null)
                {
                    _target = PlayerController.Instance.transform;
                }
            }
        }

        private void LateUpdate()
        {
            if (_target == null) return;

            HandleCameraMovement();
        }

        public void ResetToDefault()
        {
            _targetPitch = _defaultPitch;
            _targetDistance = _defaultDistance;
            _lockX = false;
            _lockZ = false;
        }

        /// <summary>
        /// Called by CameraZones to override angle/distance or lock axes.
        /// Pass -1 to keep existing pitch/distance.
        /// </summary>
        public void OverrideCamera(float newPitch, float newDist, bool lockX, bool lockZ, Vector3 lockPos)
        {
            if (newPitch > 0) _targetPitch = newPitch;
            if (newDist > 0) _targetDistance = newDist;

            _lockX = lockX;
            _lockZ = lockZ;
            _lockPosition = lockPos;
        }

        private void HandleCameraMovement()
        {
            // 1. Determine Base Follow Position (Target or Locked Axis)
            Vector3 followPos = _target.position;

            if (_lockX) followPos.x = _lockPosition.x;
            if (_lockZ) followPos.z = _lockPosition.z;

            // 2. Calculate Desired Offset based on Target Pitch/Distance
            // Note: We intentionally don't lerp the Pitch/Distance variables themselves to avoid "Double Smoothing".
            // We calculate the *ideal* destination and let SmoothDamp handle the smoothing.
            
            float rad = _targetPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance;
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);
            
            Vector3 desiredPosition = followPos + new Vector3(0, yOffset, zOffset);

            // 3. Move Position (Smooth)
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref _currentVelocity, _smoothTime);

            // 4. Rotate (Smooth)
            // We always look at the followPos (or slightly ahead/offset if desired)
            // Or strictly adhere to the pitch:
            Quaternion targetRotation = Quaternion.Euler(_targetPitch, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * _rotationSmoothSpeed);
        }
        
        /// <summary>
        /// Instant snap to target (useful for respawns).
        /// </summary>
        public void SnapToTarget()
        {
            if (_target == null) return;
            
            // Force logic once without smoothing
            Vector3 followPos = _target.position;
            if (_lockX) followPos.x = _lockPosition.x;
            if (_lockZ) followPos.z = _lockPosition.z;

            float rad = _targetPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance;
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);

            transform.position = followPos + new Vector3(0, yOffset, zOffset);
            transform.rotation = Quaternion.Euler(_targetPitch, 0, 0);
            
            _currentVelocity = Vector3.zero;
        }
    }
}