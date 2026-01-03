using UnityEngine;

namespace DarkTowerTron.Combat.Strategies
{
    public class HomingMovement : IMovementStrategy
    {
        private Transform _target;
        private float _turnSpeed;
        private float _speed;
        
        // State
        private Vector3 _currentDirection;

        public HomingMovement(Transform target, float turnSpeed)
        {
            _target = target;
            _turnSpeed = turnSpeed;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _currentDirection = direction.normalized;
            transform.rotation = Quaternion.LookRotation(_currentDirection);
        }

        public void Move(Transform transform, float deltaTime)
        {
            // 1. Target Tracking
            if (_target != null)
            {
                Vector3 dirToTarget = (_target.position - transform.position).normalized;
                
                // Smoothly rotate current direction towards target
                _currentDirection = Vector3.RotateTowards(
                    _currentDirection, 
                    dirToTarget, 
                    _turnSpeed * Mathf.Deg2Rad * deltaTime, 
                    0.0f
                );
            }
            // If target is null (died), we just keep flying in the last known _currentDirection (Linear)

            // 2. Apply Rotation & Movement
            transform.rotation = Quaternion.LookRotation(_currentDirection);
            transform.Translate(_currentDirection * _speed * deltaTime, Space.World);
        }
    }
}