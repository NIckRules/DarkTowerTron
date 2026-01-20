using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // For IGameService
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Gameplay.Combat;

namespace DarkTowerTron.Systems.Waves
{
    public class WaveService : MonoBehaviour, IGameService
    {
        [Header("Configuration")]
        [SerializeField] private List<WaveDefinitionSO> _waves;
        [SerializeField] private float _timeBetweenWaves = 5f;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _waveCompleteEvent;
        [SerializeField] private VoidEventChannelSO _allWavesCompleteEvent;
        [SerializeField] private StringEventChannelSO _announceTextEvent; // Optional: For HUD announcements

        [Header("Runtime State")]
        private int _currentWaveIndex = 0;
        private bool _isWaveActive = false;
        private int _enemiesRemaining = 0;
        private Coroutine _waveRoutine;

        private void OnEnable()
        {
            ServiceLocator.Register<WaveService>(this);
        }

        private void OnDisable()
        {
            ServiceLocator.Unregister<WaveService>(this);
        }

        public void StartWaveSequence()
        {
            if (_waveRoutine != null) StopCoroutine(_waveRoutine);
            _currentWaveIndex = 0;
            _waveRoutine = StartCoroutine(ProcessWaves());
        }

        private IEnumerator ProcessWaves()
        {
            while (_currentWaveIndex < _waves.Count)
            {
                WaveDefinitionSO currentWave = _waves[_currentWaveIndex];

                // Announce Wave
                Debug.Log($"[WaveService] Starting {currentWave.waveName}");
                if (_announceTextEvent != null)
                    _announceTextEvent.RaiseEvent(currentWave.waveName);

                yield return StartCoroutine(SpawnWave(currentWave));

                // Wait for clear
                yield return new WaitUntil(() => _enemiesRemaining <= 0);

                // Wave Complete
                Debug.Log($"[WaveService] Wave {_currentWaveIndex + 1} Complete!");

                // FIX: Changed .Raise() to .RaiseEvent()
                if (_waveCompleteEvent != null) _waveCompleteEvent.RaiseEvent();

                _currentWaveIndex++;

                if (_currentWaveIndex < _waves.Count)
                {
                    yield return new WaitForSeconds(_timeBetweenWaves);
                }
            }

            // All Waves Complete
            Debug.Log("[WaveService] All Waves Clear!");

            // FIX: Changed .Raise() to .RaiseEvent()
            if (_allWavesCompleteEvent != null) _allWavesCompleteEvent.RaiseEvent();
        }

        private IEnumerator SpawnWave(WaveDefinitionSO wave)
        {
            _isWaveActive = true;

            // Use the property we added to WaveDefinitionSO previously
            _enemiesRemaining = wave.TotalEnemyCount + wave.maxGrunts;

            // 1. Spawn Main Force
            if (wave.entries != null)
            {
                foreach (var entry in wave.entries)
                {
                    for (int i = 0; i < entry.count; i++)
                    {
                        SpawnEnemy(entry.enemyPrefab, entry.spawnPointIndex);
                        yield return new WaitForSeconds(entry.rate);
                    }
                }
            }

            // 2. Spawn Grunts (Optional Logic)
            if (wave.maxGrunts > 0 && wave.gruntPrefabs != null && wave.gruntPrefabs.Length > 0)
            {
                for (int i = 0; i < wave.maxGrunts; i++)
                {
                    GameObject prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
                    SpawnEnemy(prefab, -1);
                    yield return new WaitForSeconds(wave.gruntSpawnRate);
                }
            }
        }

        private void SpawnEnemy(GameObject prefab, int spawnIndex)
        {
            if (prefab == null) return;

            // Logic to find spawn point (simplified for this fix)
            Vector3 spawnPos = Vector3.zero;
            // In a real scenario, query a SpawnPointManager or PlayerStart.GetSpawnPoint(spawnIndex)

            // Instantiate
            GameObject enemy = Instantiate(prefab, spawnPos, Quaternion.identity);

            // Track Death
            // Note: In a production AA system, we'd use an Event Channel (OnEnemyKilled) 
            // instead of GetComponent, but for now we hook directly or expect the enemy to fire an event.
            var health = enemy.GetComponent<DamageReceiver>();
            if (health != null)
            {
                health.OnDeath += HandleEnemyDeath;
            }
        }

        private void HandleEnemyDeath()
        {
            _enemiesRemaining--;
            if (_enemiesRemaining < 0) _enemiesRemaining = 0;
        }
    }
}