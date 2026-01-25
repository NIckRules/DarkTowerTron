using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Patterns;

namespace DarkTowerTron.Systems.Waves
{
    public class WaveService : MonoBehaviour, IWaveService
    {
        [Header("Listening (Inputs)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Broadcasting (Outputs)")]
        [SerializeField] private VoidEventChannelSO _waveCompleteEvent; // Optional: For global audio cues
        //[SerializeField] private StringEventChannelSO _announcementEvent; // Optional: HUD Text

        // --- IWaveService State ---
        public bool IsWaveActive { get; private set; }

        // Internal State
        private int _enemiesRemaining = 0;
        private int _essentialEnemiesAlive = 0;
        private int _gruntsAlive = 0;
        private bool _isSpawningMain = false;
        private Coroutine _gruntRoutine;
        private IPoolService _pool;

        private void Awake()
        {
            ServiceLocator.Register<IWaveService>(this);
        }

        private void Start()
        {
            _pool = ServiceLocator.Get<IPoolService>();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IWaveService>(this);
        }

        // --- Implementation ---

        public bool StartWave(WaveDefinitionSO wave, List<Transform> spawnPoints, System.Action onComplete)
        {
            if (IsWaveActive)
            {
                GameLogger.LogWarning(LogChannel.System, "[WaveService] Busy! Cannot start new wave.", gameObject);
                return false;
            }

            if (wave == null) return false;

            StartCoroutine(ProcessWaveRoutine(wave, spawnPoints, onComplete));
            return true;
        }

        public void CancelWave()
        {
            IsWaveActive = false;
            StopAllCoroutines();
        }

        // --- Logic ---

        private IEnumerator ProcessWaveRoutine(WaveDefinitionSO wave, List<Transform> points, System.Action onComplete)
        {
            IsWaveActive = true;
            _enemiesRemaining = 0; // Reset
            _essentialEnemiesAlive = 0;
            _gruntsAlive = 0;

            // 1. Announce Logic (Handled by ArenaController mostly, but if Service does it:)
            // _announcementEvent?.RaiseEvent(wave.waveName);

            // 2. Choose Strategy
            if (wave.type == EncounterType.Reinforcement)
            {
                yield return StartCoroutine(RunReinforcementWave(wave, points));
            }
            else
            {
                yield return StartCoroutine(RunEliminationWave(wave, points));
            }

            // Complete
            GameLogger.Log(LogChannel.System, $"[WaveService] Wave Complete.");
            IsWaveActive = false;

            _waveCompleteEvent?.RaiseEvent();
            onComplete?.Invoke();
        }

        // --- STRATEGY 1: ELIMINATION (Simple) ---
        private IEnumerator RunEliminationWave(WaveDefinitionSO wave, List<Transform> points)
        {
            // Spawn Main
            yield return StartCoroutine(SpawnEntries(wave, points, isEssential: false));

            // Spawn Grunts (Fixed Batch)
            if (wave.maxGrunts > 0 && wave.gruntPrefabs.Length > 0)
            {
                for (int i = 0; i < wave.maxGrunts; i++)
                {
                    SpawnRandomGrunt(wave, points, isEssential: false);
                    yield return new WaitForSeconds(wave.gruntSpawnRate);
                }
            }

            // Wait for Total Clear
            yield return new WaitUntil(() => _enemiesRemaining <= 0);
        }

        // --- STRATEGY 2: REINFORCEMENT (Infinite Grunts) ---
        private IEnumerator RunReinforcementWave(WaveDefinitionSO wave, List<Transform> points)
        {
            // Track VIPs explicitly
            _essentialEnemiesAlive = wave.TotalMainEnemyCount;
            _gruntsAlive = 0;

            // Flag to prevent grunts stopping if VIP spawning is slow
            _isSpawningMain = true;

            // Start Grunt Routine (Runs in parallel)
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
            _gruntRoutine = StartCoroutine(InfiniteGruntLoop(wave, points));

            // Spawn VIPs
            yield return StartCoroutine(SpawnEntries(wave, points, isEssential: true));
            _isSpawningMain = false;

            // Wait for VIPs to die (Grunts don't matter for victory condition)
            yield return new WaitUntil(() => _essentialEnemiesAlive <= 0);

            // Stop Grunts
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

            // Optional: Kill remaining grunts instantly? Or let player mop up?
            // For now, we let player kill them or just end the wave immediately.
            // Let's end immediately (Doors open, player leaves).
        }

        private IEnumerator InfiniteGruntLoop(WaveDefinitionSO wave, List<Transform> points)
        {
            if (wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0) yield break;

            // Keep loop running as long as VIPs are alive OR we are still spawning them
            while (_essentialEnemiesAlive > 0 || _isSpawningMain)
            {
                // Top up grunts to max capacity
                if (_gruntsAlive < wave.maxGrunts)
                {
                    SpawnRandomGrunt(wave, points, isEssential: false);
                }
                yield return new WaitForSeconds(wave.gruntSpawnRate);
            }
        }

        // --- SPAWN HELPERS ---

        private IEnumerator SpawnEntries(WaveDefinitionSO wave, List<Transform> points, bool isEssential)
        {
            if (wave.entries == null) yield break;

            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    SpawnEnemy(entry.enemyPrefab, points, entry.spawnPointIndex, isEssential);
                    yield return new WaitForSeconds(entry.rate);
                }
            }
        }

        private void SpawnRandomGrunt(WaveDefinitionSO wave, List<Transform> points, bool isEssential)
        {
            var prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
            SpawnEnemy(prefab, points, -1, isEssential);
        }

        private void SpawnEnemy(GameObject prefab, List<Transform> points, int indexOverride, bool isEssential)
        {
            if (!prefab) return;

            Vector3 pos = transform.position;
            Quaternion rot = Quaternion.identity;

            if (points != null && points.Count > 0)
            {
                if (indexOverride >= 0 && indexOverride < points.Count)
                {
                    pos = points[indexOverride].position;
                    rot = points[indexOverride].rotation;
                }
                else
                {
                    var t = points[Random.Range(0, points.Count)];
                    pos = t.position;
                    rot = t.rotation;
                }
            }

            GameObject instance;
            if (_pool != null) instance = _pool.Spawn(prefab, pos, rot);
            else instance = Instantiate(prefab, pos, rot);

            // Optional: Mark them visually as VIPs?
            // if (isEssential) ... add crown icon ...

            // Track
            if (isEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;

            // Legacy Tracker
            _enemiesRemaining++;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (!IsWaveActive) return;

            // Determine Type
            // Note: In "Reinforcement" mode, we passed isEssential=true to the spawner,
            // but here we are checking the ScriptableObject stats.
            // Ideally, the Enemy instance knows if it's essential or not.
            // For now, we assume if stats.isEssential is true, it counts.

            bool isEssential = (stats != null && stats.isEssential);

            if (isEssential) _essentialEnemiesAlive--;
            else _gruntsAlive--;

            _enemiesRemaining--;

            // Clamps
            if (_essentialEnemiesAlive < 0) _essentialEnemiesAlive = 0;
            if (_gruntsAlive < 0) _gruntsAlive = 0;
            if (_enemiesRemaining < 0) _enemiesRemaining = 0;
        }
    }
}