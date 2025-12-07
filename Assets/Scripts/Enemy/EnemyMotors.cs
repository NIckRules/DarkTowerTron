using UnityEngine;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(KinematicMover))]
    public class EnemyMotor : MonoBehaviour
    {
        [Header("Settings")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f;
        public float acceleration = 20f; // Slower acceleration = heavy feel

        private KinematicMover _mover;
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
        }

        /// <summary>
        /// Moves the enemy in a specific direction with momentum.
        /// </summary>
        public void Move(Vector3 desiredDirection)
        {
            float dt = Time.deltaTime;
            Vector3 targetVel = desiredDirection * moveSpeed;

            // Apply inertia/acceleration
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, acceleration * dt);

            // Apply Knockback decay
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            // Execute Move via Physics
            _mover.Move((_currentVelocity + _knockbackForce) * dt);
        }

        /// <summary>
        /// Rotates the enemy to look at a specific target position.
        /// </summary>
        public void FaceTarget(Vector3 targetPosition)
        {
            Vector3 dir = targetPosition - transform.position;
            dir.y = 0; // Keep flat
            
            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }
    }
}