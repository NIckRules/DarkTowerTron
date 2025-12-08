using UnityEngine;
using System.Collections.Generic;

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

            // 1. Create pool if it doesn't exist
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objectToSpawn;

            // 2. Try to dequeue an inactive object
            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();
            }
            else
            {
                // 3. If empty, instantiate new
                objectToSpawn = Instantiate(prefab);
            }

            // 4. Setup
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = rotation;
            objectToSpawn.SetActive(true);

            // 5. Track it (Map the instance to the pool key)
            // We use Add/Set logic to ensure we don't crash on re-adding
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