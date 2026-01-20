using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.Patterns
{
    public interface IPoolService : IGameService
    {
        // The essential contract
        T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component;
        GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation);

        void Despawn(GameObject instance, float delay = 0f);

        // Optional: Prewarming
        void Prewarm(GameObject prefab, int count);
    }
}