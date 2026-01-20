using UnityEngine;

namespace DarkTowerTron.Core.Physics
{
    public interface IMovementStrategy
    {
        void Initialize(Transform transform, Vector3 direction, float speed);
        void Move(Transform transform, float deltaTime);
    }
}