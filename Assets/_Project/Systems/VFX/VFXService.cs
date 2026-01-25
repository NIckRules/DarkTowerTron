using UnityEngine;
using DarkTowerTron.Core.Services; 
using DarkTowerTron.Core.Patterns; 

namespace DarkTowerTron.Systems.VFX
{
    public class VFXService : MonoBehaviour, IVFXService
    {
        private IPoolService _pool;

        private void Awake()
        {
            ServiceLocator.Register<IVFXService>(this);
        }

        private void Start()
        {
            _pool = ServiceLocator.Get<IPoolService>();
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IVFXService>(this);
        }

        // --- IVFXService Implementation ---

        // 1. Signature from Error CS0535
        public void SpawnVFX(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            Spawn(prefab, position, rotation, 0f);
        }

        // 2. Signature from Error CS0535
        public void SpawnVFX(GameObject prefab, Transform parent, Vector3 offset)
        {
            if (prefab == null) return;
            EnsurePool();

            // Calculate world position
            Vector3 pos = (parent != null) ? parent.position + parent.TransformDirection(offset) : offset;
            Quaternion rot = (parent != null) ? parent.rotation : Quaternion.identity;

            GameObject instance = _pool.Spawn(prefab, pos, rot);
            
            // Optional: Parent it if it's meant to stick (like a status effect)
            if (parent != null && instance != null)
            {
                instance.transform.SetParent(parent);
            }
        }

        // 3. The "Spawn" method we fixed previously (Wrapper / Main Logic)
        public void Spawn(GameObject prefab, Vector3 position, Quaternion rotation, float duration = 0f)
        {
            if (prefab == null) return;
            EnsurePool();

            GameObject instance = _pool.Spawn(prefab, position, rotation);

            if (instance != null && duration > 0f)
            {
                _pool.Despawn(instance, duration);
            }
        }

        private void EnsurePool()
        {
            if (_pool == null) _pool = ServiceLocator.Get<IPoolService>();
        }
    }
}