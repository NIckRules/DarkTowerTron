using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public class WaveEntry
    {
        public GameObject enemyPrefab;
        public int count = 1;
        public float rate = 1.0f;
        [Tooltip("-1 for Random, 0+ for specific index")]
        public int spawnPointIndex = -1;
    }

    [CreateAssetMenu(fileName = "NewWave", menuName = "DarkTowerTron/Wave Definition")]
    public class WaveDefinitionSO : ScriptableObject
    {
        [Header("Wave Info")]
        public string waveName = "Wave 1";

        [Header("Main Force (Essential)")]
        public List<WaveEntry> entries;

        [Header("Grunt Support (Fodder)")]
        public GameObject[] gruntPrefabs;
        public int maxGrunts = 0;
        public float gruntSpawnRate = 5f;
    }
}