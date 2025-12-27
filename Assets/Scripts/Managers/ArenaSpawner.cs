using UnityEngine;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints; // This gets updated by WaveTrigger

        public GameObject SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            // SAFETY CHECK 1: Prefab missing
            if (prefab == null) return null;

            // SAFETY CHECK 2: No points assigned (The Fix for your error)
            if (spawnPoints == null || spawnPoints.Length == 0)
            {
                Debug.LogError("ArenaSpawner ERROR: Attempted to spawn enemy, but 'Spawn Points' list is Empty! Did the WaveTrigger assign them?");
                return null;
            }

            Transform sp;

            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
            {
                sp = spawnPoints[forcedIndex];
            }
            else
            {
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            }

            // Check if the specific point is null (deleted object)
            if (sp == null)
            {
                Debug.LogError("ArenaSpawner ERROR: A spawn point in the list is NULL.");
                return null;
            }

            Vector3 offset = Random.insideUnitSphere * 2.0f;
            offset.y = 1.0f; // Air drop

            return PoolManager.Instance.Spawn(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }
    }
}