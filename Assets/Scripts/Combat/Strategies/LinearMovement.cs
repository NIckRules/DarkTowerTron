using UnityEngine;

namespace DarkTowerTron.Combat.Strategies
{
    public class LinearMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _direction;

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _direction = direction.normalized;
            
            // Align visual rotation immediately
            transform.rotation = Quaternion.LookRotation(_direction);
        }

        public void Move(Transform transform, float deltaTime)
        {
            // Simple translation
            transform.Translate(_direction * _speed * deltaTime, Space.World);
        }
    }
}