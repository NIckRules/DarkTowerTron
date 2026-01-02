using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Needed for cleanup
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Services
{
    public class PoolManager : MonoBehaviour
    {
        // REMOVED: public static PoolManager Instance;

        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private void Awake()
        {
            // REMOVED: Singleton check
        }

        private void OnEnable() => SceneManager.activeSceneChanged += OnSceneChanged;
        private void OnDisable() => SceneManager.activeSceneChanged -= OnSceneChanged;

        // CRITICAL FIX: When scene changes, all GameObjects in the scene are destroyed.
        // We must clear our references, or we hold onto "Missing" objects.
        private void OnSceneChanged(Scene current, Scene next)
        {
            ClearPools();
        }

        public void ClearPools()
        {
            _poolDictionary.Clear();
            _spawnedObjectsParentId.Clear();
            
            // Destroy any children still hanging under this transform (if any were reparented)
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            
            GameLogger.Log(LogChannel.System, "PoolManager cleaned up for new scene.", gameObject);
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            if (prefab == null) return null;

            int poolKey = prefab.GetInstanceID();

            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objectToSpawn;

            // Simple validation: Ensure queue item isn't null (destroyed externally)
            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();
                
                // Safety check: Was it destroyed?
                while (objectToSpawn == null && _poolDictionary[poolKey].Count > 0)
                {
                    objectToSpawn = _poolDictionary[poolKey].Dequeue();
                }

                if (objectToSpawn == null)
                {
                    objectToSpawn = Instantiate(prefab, position, rotation);
                }
                else
                {
                    objectToSpawn.transform.position = position;
                    objectToSpawn.transform.rotation = rotation;
                    objectToSpawn.SetActive(true);
                }
            }
            else
            {
                objectToSpawn = Instantiate(prefab, position, rotation);
            }

            // Interface Logic
            var poolables = objectToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            // Track ID
            int instanceKey = objectToSpawn.GetInstanceID();
            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }

            return objectToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            if (obj == null) return;

            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                int poolKey = _spawnedObjectsParentId[instanceKey];
                
                // PREVENT LEAK: Remove from tracking
                _spawnedObjectsParentId.Remove(instanceKey);

                obj.SetActive(false);
                obj.transform.SetParent(transform); // Store under manager

                // Add back to queue
                if (!_poolDictionary.ContainsKey(poolKey)) 
                    _poolDictionary[poolKey] = new Queue<GameObject>();
                    
                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                Destroy(obj);
            }
        }
    }
}