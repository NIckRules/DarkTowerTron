using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        // Dictionary mapping a Prefab's InstanceID to a Queue of recycled objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();
        // Dictionary mapping a Spawned Object's InstanceID to the Prefab ID it came from (so we know where to return it)
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

            // 1. POOLED OBJECT
            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();

                // CRITICAL FIX: Move it BEFORE waking it up
                objectToSpawn.transform.position = position;
                objectToSpawn.transform.rotation = rotation;

                objectToSpawn.SetActive(true); // Now OnEnable fires at the correct location
            }
            // 2. NEW OBJECT
            else
            {
                // CRITICAL FIX: Instantiate AT position/rotation directly
                objectToSpawn = Instantiate(prefab, position, rotation);
                // OnEnable fires immediately here, but position is already correct
            }

            // NEW: Interface Call
            var poolable = objectToSpawn.GetComponent<IPoolable>();
            if (poolable != null) poolable.OnSpawn();

            // 3. Track it
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

            // Only pool objects we know about; otherwise destroy them
            if (_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                // NEW: Interface Call
                var poolable = obj.GetComponent<IPoolable>();
                if (poolable != null) poolable.OnDespawn();

                int poolKey = _spawnedObjectsParentId[instanceKey];

                obj.SetActive(false);
                obj.transform.SetParent(transform); // Organize hierarchy

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                Destroy(obj);
            }
        }
    }
}