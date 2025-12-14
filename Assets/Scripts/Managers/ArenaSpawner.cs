using UnityEngine;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        // CHANGED: Returns GameObject instead of void
        public GameObject SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints.Length == 0 || prefab == null) return null;

            Transform sp;

            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
                sp = spawnPoints[forcedIndex];
            else
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Vector3 offset = Random.insideUnitSphere * 2.0f;
            offset.y = 0;

            // Return the actual instance
            return PoolManager.Instance.Spawn(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }
    }
}