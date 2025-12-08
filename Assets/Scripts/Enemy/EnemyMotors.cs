using UnityEngine;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(KinematicMover))]
    public class EnemyMotor : MonoBehaviour
    {
        [Header("Movement Settings")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f;
        public float acceleration = 20f;

        [Header("Flight Settings")]
        [Tooltip("Height above ground. Set 0 for ground units.")]
        public float rideHeight = 0f;
        public float verticalSmoothTime = 0.5f; // How fast they float up

        private KinematicMover _mover;
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed; // For SmoothDamp

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();

            // AUTO-CONFIGURATION:
            // If this unit flies, disable the physics gravity so it doesn't fall.
            // We assume KinematicMover exposes gravity or we just fight it.
            // Since KinematicMover gravity is private, we will rely on the "Hover" logic
            // providing enough force to counteract it, OR ideally, you set Gravity 0 in Inspector.

            // Note: For this to work perfectly, ensure KinematicMover Gravity is 0 on the Prefab
            // OR we can fight it here. Let's fight it mathematically.
        }

        public void Move(Vector3 desiredDirection)
        {
            float dt = Time.deltaTime;
            Vector3 targetVel = desiredDirection * moveSpeed;

            // 1. Horizontal Movement (Inertia)
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, acceleration * dt);

            // 2. Knockback Decay
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            // 3. FLIGHT LOGIC (Ride Height)
            // We calculate the Y velocity needed to reach rideHeight
            float currentY = transform.position.y;
            float targetY = rideHeight;
            float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, verticalSmoothTime);

            // Calculate delta needed this frame
            float verticalMotion = newY - currentY;

            // 4. Combine
            // We flatten the physics/knockback Y and replace it with our calculated Hover Y
            Vector3 finalMotion = (_currentVelocity + _knockbackForce) * dt;
            finalMotion.y = verticalMotion;

            // 5. Execute
            _mover.Move(finalMotion);
        }

        public void FaceTarget(Vector3 targetPosition)
        {
            Vector3 dir = targetPosition - transform.position;
            dir.y = 0;

            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0; // Ensure knockback is flat
            _knockbackForce += force;
        }
    }
}