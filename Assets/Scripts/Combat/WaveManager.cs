using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DarkTowerTron.Combat
{
    public class WaveManager : MonoBehaviour
    {
        [System.Serializable]
        public class Wave
        {
            public string waveName = "Wave 1";
            public int chaserCount;
            public int turretCount;
        }

        [Header("Configuration")]
        public List<Transform> spawnPoints;
        public GameObject chaserPrefab;
        public GameObject turretPrefab;
        public float timeBetweenWaves = 2f;

        [Header("Waves")]
        public List<Wave> waves;

        private int currentWaveIndex = 0;
        private bool isWaveActive = false;
        private bool gameFinished = false;

        void Start()
        {
            if (spawnPoints.Count == 0)
            {
                Debug.LogError("No Spawn Points assigned!");
                return;
            }

            // Start the first wave after a short delay
            StartCoroutine(StartNextWave());
        }

        void Update()
        {
            if (gameFinished || !isWaveActive) return;

            // Check if all enemies are dead
            // (Optimization: In a real game, count kills. For prototype, Find is okay.)
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (enemies.Length == 0)
            {
                Debug.Log("<color=green>WAVE CLEARED!</color>");
                isWaveActive = false;
                StartCoroutine(StartNextWave());
            }
        }

        IEnumerator StartNextWave()
        {
            yield return new WaitForSeconds(timeBetweenWaves);

            if (currentWaveIndex >= waves.Count)
            {
                Debug.Log("<color=gold>ALL WAVES COMPLETE! YOU SURVIVED.</color>");
                gameFinished = true;
                yield break;
            }

            Wave wave = waves[currentWaveIndex];
            Debug.Log($"STARTING: {wave.waveName}");

            SpawnEnemies(wave);

            currentWaveIndex++;
            isWaveActive = true;
        }

        void SpawnEnemies(Wave wave)
        {
            // Spawn Chasers
            for (int i = 0; i < wave.chaserCount; i++)
            {
                Transform sp = GetRandomSpawn();
                Instantiate(chaserPrefab, sp.position, Quaternion.identity);
            }

            // Spawn Turrets
            for (int i = 0; i < wave.turretCount; i++)
            {
                Transform sp = GetRandomSpawn();
                Instantiate(turretPrefab, sp.position, Quaternion.identity);
            }
        }

        Transform GetRandomSpawn()
        {
            return spawnPoints[Random.Range(0, spawnPoints.Count)];
        }
    }
}