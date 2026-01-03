using UnityEngine;
using DarkTowerTron.Core;

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
            transform.rotation = Quaternion.LookRotation(_direction);
        }

        public void Move(Transform transform, float deltaTime)
        {
            transform.Translate(_direction * _speed * deltaTime, Space.World);
        }
    }
}