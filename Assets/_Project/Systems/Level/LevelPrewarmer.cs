using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Systems.Level
{
    public class LevelPrewarmer : MonoBehaviour
    {
        [System.Serializable]
        public struct PoolRequest
        {
            public GameObject prefab;
            public int count;
        }

        [Tooltip("List of objects to instantiate immediately when the level starts to prevent lag later.")]
        public List<PoolRequest> prewarmList;

        private void Start()
        {
            // 1. Get the Pool Service
            var poolService = ServiceLocator.Get<IPoolService>();

            if (poolService == null)
            {
                Debug.LogWarning("[LevelPrewarmer] PoolService not found. Skipping prewarm.");
                return;
            }

            // 2. Execute Requests
            foreach (var req in prewarmList)
            {
                if (req.prefab != null && req.count > 0)
                {
                    poolService.Prewarm(req.prefab, req.count);
                }
            }
        }
    }
}