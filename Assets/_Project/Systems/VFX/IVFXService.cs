using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.VFX
{
    public interface IVFXService : IGameService
    {
        // Spawn with optional duration/delay before despawn
        void Spawn(GameObject prefab, Vector3 position, Quaternion rotation, float duration = 0f);

        // Fire and forget
        void SpawnVFX(GameObject vfxPrefab, Vector3 position, Quaternion rotation);

        // Spawn attached to a moving target (e.g., status effects)
        void SpawnVFX(GameObject vfxPrefab, Transform parent, Vector3 localOffset);
    }
}