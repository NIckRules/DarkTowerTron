using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core; // For IPoolable

namespace DarkTowerTron.Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        // Dictionary mapping Prefab InstanceID -> Queue of Objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();
        // Dictionary mapping Spawned Object InstanceID -> Prefab InstanceID
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            int poolKey = prefab.GetInstanceID();

            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objectToSpawn;

            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();
                // Move before waking up to prevent visual flicker/logic errors
                objectToSpawn.transform.position = position;
                objectToSpawn.transform.rotation = rotation;
                objectToSpawn.SetActive(true);
            }
            else
            {
                objectToSpawn = Instantiate(prefab, position, rotation);
            }

            // Call IPoolable.OnSpawn
            var poolables = objectToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            // Track relationship
            int instanceKey = objectToSpawn.GetInstanceID();
            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }

            return objectToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                // Call IPoolable.OnDespawn
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                int poolKey = _spawnedObjectsParentId[instanceKey];

                // CRITICAL FIX-001: Remove tracking entry to prevent memory leak
                _spawnedObjectsParentId.Remove(instanceKey);

                obj.SetActive(false);
                obj.transform.SetParent(transform);

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                // Not a pooled object? Just destroy it.
                Destroy(obj);
            }
        }
    }
}