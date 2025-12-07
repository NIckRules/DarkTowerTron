using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class WaveManager : MonoBehaviour
    {
        [System.Serializable]
        public class WaveEntry
        {
            public GameObject enemyPrefab;
            public int count;
            public float rate = 1.0f;

            [Tooltip("Set to -1 for Random. Set to 0, 1, 2 etc for specific marker.")]
            public int spawnPointIndex = -1; // NEW: Manual Override
        }

        [System.Serializable]
        public class Wave
        {
            public string waveName;
            public List<WaveEntry> entries;
        }

        [Header("Config")]
        public Transform[] spawnPoints;
        public float timeBetweenWaves = 3.0f;
        public List<Wave> waves;

        private int _currentWaveIndex = 0;
        private int _enemiesAlive = 0;
        private bool _isSpawning = false;
        private bool _gameStarted = false;

        private void OnEnable()
        {
            GameEvents.OnEnemyKilled += OnEnemyKilled;
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        public void StartGame()
        {
            _gameStarted = true;
            _currentWaveIndex = 0;
            StartCoroutine(RunWave(_currentWaveIndex));
        }

        private IEnumerator RunWave(int index)
        {
            if (index >= waves.Count)
            {
                Debug.Log("ALL WAVES CLEARED - VICTORY");
                // Optional: GameEvents.OnVictory?.Invoke();
                yield break;
            }

            Wave wave = waves[index];
            Debug.Log($"STARTING WAVE: {wave.waveName}");
            _isSpawning = true;

            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    // Pass the manual index to the spawner
                    SpawnEnemy(entry.enemyPrefab, entry.spawnPointIndex);

                    _enemiesAlive++;
                    yield return new WaitForSeconds(entry.rate);
                }
            }

            _isSpawning = false;
        }

        private void SpawnEnemy(GameObject prefab, int forcedIndex)
        {
            if (spawnPoints.Length == 0 || prefab == null) return;

            Transform sp;

            // 1. Determine Spawn Point
            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
            {
                // Manual Selection
                sp = spawnPoints[forcedIndex];
            }
            else
            {
                // Random Selection (Default behavior)
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            }

            // 2. Apply Offset
            // We keep the offset even for manual points so 2 enemies 
            // spawning at the same spot don't fuse together perfectly.
            Vector3 offset = Random.insideUnitSphere * 2.0f; // Increased to 2.0f for breathing room
            offset.y = 0;

            Instantiate(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }

        private void OnEnemyKilled(Vector3 pos)
        {
            if (!_gameStarted) return;

            _enemiesAlive--;

            if (_enemiesAlive <= 0 && !_isSpawning)
            {
                Debug.Log("WAVE CLEARED");
                GameEvents.OnWaveCleared?.Invoke();

                _currentWaveIndex++;
                StartCoroutine(NextWaveRoutine());
            }
        }

        private IEnumerator NextWaveRoutine()
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            StartCoroutine(RunWave(_currentWaveIndex));
        }
    }
}