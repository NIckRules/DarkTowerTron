using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels
using DarkTowerTron.Core.Services;    // For Logger

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(ArenaSpawner))]
    public class WaveDirector : MonoBehaviour
    {
        [Header("Wiring")]
        [Tooltip("Listens for enemy deaths to track wave progress.")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Configuration")]
        public List<WaveDefinitionSO> waves;
        public float timeBetweenWaves = 3.0f;

        // Internal State
        private ArenaSpawner _spawner;
        private int _currentWaveIndex = 0;
        private int _essentialEnemiesAlive = 0;
        private int _gruntsAlive = 0;
        private bool _isSpawningMain = false;
        private bool _gameStarted = false;
        private Coroutine _gruntRoutine;

        private void Awake()
        {
            _spawner = GetComponent<ArenaSpawner>();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) 
                _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) 
                _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        // --- PUBLIC API ---

        public void StartGame()
        {
            _gameStarted = true;
            _currentWaveIndex = 0;
            StartCoroutine(StartGameRoutine());
        }

        // --- CORE LOGIC ---

        private IEnumerator StartGameRoutine()
        {
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(RunWave(_currentWaveIndex));
        }

        private IEnumerator RunWave(int index)
        {
            // Stop condition: all waves complete
            if (index >= waves.Count)
            {
                GameLogger.Log(LogChannel.System, "ROOM CLEARED", gameObject);
                
                // Triggers doors opening, etc.
                GameEvents.OnRoomCleared?.Invoke(); 
                yield break;
            }

            WaveDefinitionSO wave = waves[index];
            GameLogger.Log(LogChannel.System, $"STARTING WAVE {index + 1}: {wave.waveName}", gameObject);

            // --- UI ANNOUNCEMENT (Legacy Static Events) ---
            GameEvents.OnWaveAnnounce?.Invoke(index);
            yield return new WaitForSeconds(1.0f);
            
            GameEvents.OnCountdownChange?.Invoke("3");
            yield return new WaitForSeconds(1.0f);
            GameEvents.OnCountdownChange?.Invoke("2");
            yield return new WaitForSeconds(1.0f);
            GameEvents.OnCountdownChange?.Invoke("1");
            yield return new WaitForSeconds(1.0f);
            
            GameEvents.OnCountdownChange?.Invoke("ENGAGE");
            GameEvents.OnWaveCombatStarted?.Invoke();
            yield return new WaitForSeconds(0.5f);
            GameEvents.OnCountdownChange?.Invoke("");
            // -----------------

            // Reset Counters
            _isSpawningMain = true;
            _essentialEnemiesAlive = 0;
            _gruntsAlive = 0;

            // Start Grunt Logic (Infinite Reinforcements)
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
            _gruntRoutine = StartCoroutine(GruntLogic(wave));

            // Spawn Main Force
            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    SpawnEnemy(entry.enemyPrefab, entry.spawnPointIndex);
                    yield return new WaitForSeconds(entry.rate);
                }
            }

            _isSpawningMain = false;
            
            // Check victory in case everything died while we were still spawning
            CheckVictory();
        }

        private IEnumerator GruntLogic(WaveDefinitionSO wave)
        {
            if (wave.maxGrunts <= 0 || wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0)
                yield break;

            // Anchor Logic: Keep spawning ONLY while VIPs are alive (or main force is still spawning)
            while (_essentialEnemiesAlive > 0 || _isSpawningMain)
            {
                if (_gruntsAlive < wave.maxGrunts)
                {
                    GameObject prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
                    SpawnEnemy(prefab, -1);
                }
                yield return new WaitForSeconds(wave.gruntSpawnRate);
            }
        }

        private void SpawnEnemy(GameObject prefab, int forcedIndex)
        {
            if (_spawner == null || prefab == null) return;

            // Spawn via Pool
            GameObject instance = _spawner.SpawnEnemy(prefab, forcedIndex);
            if (instance == null) return;

            // Determine if Essential based on the Instance's Stats
            var motor = instance.GetComponent<DarkTowerTron.Enemy.EnemyMotor>();
            bool countAsEssential = false;

            if (motor != null && motor.stats != null)
            {
                countAsEssential = motor.stats.isEssential;
            }
            else
            {
                // Fallback for safety
                countAsEssential = true;
            }

            if (countAsEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;
        }

        // --- EVENT HANDLERS ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!_gameStarted) return;

            // Logic: Identify who died based on the Stats passed by the event
            if (stats != null && stats.isEssential)
            {
                _essentialEnemiesAlive--;
                GameLogger.Log(LogChannel.System, $"VIP Killed. Remaining: {_essentialEnemiesAlive}", gameObject);

                // Cut reinforcements immediately if VIPs are dead
                if (_essentialEnemiesAlive <= 0)
                {
                    if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
                    GameLogger.Log(LogChannel.System, "VIPs Down. Reinforcements Stopped.", gameObject);
                }
            }
            else
            {
                _gruntsAlive--;
            }

            // Safety clamp
            if (_essentialEnemiesAlive < 0) _essentialEnemiesAlive = 0;
            if (_gruntsAlive < 0) _gruntsAlive = 0;

            CheckVictory();
        }

        private void CheckVictory()
        {
            // VICTORY CONDITION: Room must be totally silent.
            if (_essentialEnemiesAlive <= 0 && _gruntsAlive <= 0 && !_isSpawningMain)
            {
                GameLogger.Log(LogChannel.System, "WAVE CLEARED - SECTOR SECURE", gameObject);

                if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

                GameEvents.OnWaveCleared?.Invoke(); // UI/FX Feedback
                
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