using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Services;
// Alias
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Managers
{
    public class LevelPrewarmer : MonoBehaviour
    {
        [System.Serializable]
        public struct PoolRequest
        {
            public GameObject prefab;
            public int count;
        }

        public List<PoolRequest> prewarmList;

        private void Start()
        {
            // Wait one frame for Services to be ready (if not using Execution Order)
            if (Global.Pool != null)
            {
                foreach (var req in prewarmList)
                {
                    Global.Pool.Prewarm(req.prefab, req.count);
                }
            }
        }
    }
}