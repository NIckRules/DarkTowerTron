using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Patterns;

namespace DarkTowerTron.Systems.VFX
{
    public class VFXService : MonoBehaviour, IVFXService
    {
        private IPoolService _pool;

        private void Start()
        {
            _pool = ServiceLocator.Get<IPoolService>();
        }

        // --- IVFXService Implementation ---

        public void SpawnVFX(GameObject vfxPrefab, Vector3 position, Quaternion rotation)
        {
            if (vfxPrefab == null || _pool == null) return;
            _pool.Spawn(vfxPrefab, position, rotation);
        }

        public void SpawnVFX(GameObject vfxPrefab, Transform parent, Vector3 localOffset)
        {
            if (vfxPrefab == null || _pool == null) return;
            _pool.Spawn(vfxPrefab, parent.position + localOffset, Quaternion.identity, parent);
        }
    }
}