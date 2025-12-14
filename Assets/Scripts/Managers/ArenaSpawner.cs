using UnityEngine;
using DarkTowerTron.Managers; // For PoolManager

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        /// <summary>
        /// Spawns an enemy at a specific index or random location.
        /// </summary>
        public void SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints.Length == 0 || prefab == null) return;

            Transform sp;

            // 1. Determine Position
            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
            {
                sp = spawnPoints[forcedIndex];
            }
            else
            {
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            }

            // 2. Add Offset (prevent stacking)
            Vector3 offset = Random.insideUnitSphere * 2.0f;
            offset.y = 0;

            // 3. Pool Spawn
            PoolManager.Instance.Spawn(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }
    }
}