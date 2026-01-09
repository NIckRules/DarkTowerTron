using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DarkTowerTron.Core.Services
{
    public class PoolManager : MonoBehaviour
    {
        // Dictionary mapping Prefab InstanceID -> Queue of inactive objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();

        // Dictionary mapping Spawned Object InstanceID -> Prefab InstanceID (to know where to return it)
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private Transform _poolRoot;

        private void Awake()
        {
            // Create a clean container so the Hierarchy doesn't get messy
            GameObject rootObj = new GameObject("Pool_Container");
            _poolRoot = rootObj.transform;
            DontDestroyOnLoad(rootObj);
        }

        private void OnEnable() => SceneManager.activeSceneChanged += OnSceneChanged;
        private void OnDisable() => SceneManager.activeSceneChanged -= OnSceneChanged;

        private void OnSceneChanged(Scene current, Scene next)
        {
            // Clear tracking lists, but logic dictates we should also clear the physical container
            // if we want a fresh start per scene (usually safer for references).
            ClearPools();
        }

        public void ClearPools()
        {
            _poolDictionary.Clear();
            _spawnedObjectsParentId.Clear();

            // Nuke the physical objects
            foreach (Transform child in _poolRoot)
            {
                Destroy(child.gameObject);
            }

            GameLogger.Log(LogChannel.System, "Pool memory flushed.", gameObject);
        }

        /// <summary>
        /// Call this during Loading Screens to prevent stutter during gameplay.
        /// </summary>
        public void Prewarm(GameObject prefab, int count)
        {
            if (prefab == null) return;

            int poolKey = prefab.GetInstanceID();

            // Initialize the queue if missing
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            for (int i = 0; i < count; i++)
            {
                GameObject obj = CreateNewInstance(prefab, poolKey);
                // Immediately disable and enqueue
                obj.SetActive(false);
                obj.transform.SetParent(_poolRoot);
                _poolDictionary[poolKey].Enqueue(obj);
            }
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            if (prefab == null) return null;

            int poolKey = prefab.GetInstanceID();

            // 1. Ensure Queue Exists
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objToSpawn = null;

            // 2. Try Dequeue (Find inactive)
            if (_poolDictionary[poolKey].Count > 0)
            {
                objToSpawn = _poolDictionary[poolKey].Dequeue();

                // Validation: Was it destroyed externally?
                while (objToSpawn == null && _poolDictionary[poolKey].Count > 0)
                {
                    objToSpawn = _poolDictionary[poolKey].Dequeue();
                }
            }

            // 3. If missing or null, Create New
            if (objToSpawn == null)
            {
                objToSpawn = CreateNewInstance(prefab, poolKey);
            }

            // 4. Setup
            objToSpawn.transform.SetPositionAndRotation(position, rotation);
            objToSpawn.SetActive(true);

            // NOTE: We don't unparent from _poolRoot. 
            // Keeping them organized under one parent is cleaner for the Hierarchy view,
            // though slightly (negligibly) more expensive for Transform updates.
            // For a solo dev, clean Hierarchy > Micro-optimization.

            // 5. Interface Call
            var poolables = objToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            return objToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            if (obj == null) return;
            if (!obj.scene.isLoaded) { Destroy(obj); return; }

            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.TryGetValue(instanceKey, out int poolKey))
            {
                // Interface Call
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                obj.SetActive(false);

                // Reparent to root to keep scene tidy
                if (obj.transform.parent != _poolRoot)
                    obj.transform.SetParent(_poolRoot);

                // Add back to queue
                if (!_poolDictionary.ContainsKey(poolKey))
                    _poolDictionary[poolKey] = new Queue<GameObject>();

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                // Wasn't pooled? Just destroy.
                Destroy(obj);
            }
        }

        // Helper to keep logic DRY
        private GameObject CreateNewInstance(GameObject prefab, int poolKey)
        {
            GameObject obj = Instantiate(prefab, _poolRoot); // Spawn directly in root
            int instanceKey = obj.GetInstanceID();

            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }
            return obj;
        }
    }
}