using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    public enum EncounterType
    {
        Elimination, // Standard: Kill everything spawned.
        Reinforcement // Complex: Grunts respawn until VIPs (Essentials) are dead.
    }

    [CreateAssetMenu(menuName = "DarkTowerTron/Waves/Wave Definition")]
    public class WaveDefinitionSO : ScriptableObject
    {
        [Header("Meta")]
        public string waveName = "Wave 1";
        public EncounterType type = EncounterType.Elimination;

        [Header("Main Force")]
        [Tooltip("The core enemies for this wave. In Reinforcement mode, these are the VIPs.")]
        public List<WaveEntry> entries;

        [Header("Reinforcements (Grunts)")]
        [Tooltip("Infinite spawns if Type = Reinforcement. One-time spawn if Type = Elimination.")]
        public GameObject[] gruntPrefabs;
        public int maxGrunts = 0;
        public float gruntSpawnRate = 3f;

        // Helper Property
        public int TotalMainEnemyCount
        {
            get
            {
                int count = 0;
                if (entries != null)
                {
                    foreach (var e in entries) count += e.count;
                }
                return count;
            }
        }
    }

    [System.Serializable]
    public struct WaveEntry
    {
        public GameObject enemyPrefab;
        public int count;
        public float rate;
        public int spawnPointIndex;
    }
}