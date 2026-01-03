using UnityEngine;

namespace DarkTowerTron.Combat.Strategies
{
    public interface IMovementStrategy
    {
        /// <summary>
        /// Called once when the projectile is spawned/reset.
        /// </summary>
        void Initialize(Transform transform, Vector3 direction, float speed);

        /// <summary>
        /// Called every frame to apply movement.
        /// </summary>
        void Move(Transform transform, float deltaTime);
    }
}