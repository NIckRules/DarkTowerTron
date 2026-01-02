using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        // NO INSPECTOR VARIABLES! All data comes from PlayerStats.

        private float _currentFocus;
        private bool _isDead;
        private bool _isCombatActive = false; 

        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            if (_stats == null)
            {
                GameLogger.LogError(LogChannel.Player, "PlayerEnergy missing PlayerStats component!", gameObject);
                return;
            }

            // Init
            _currentFocus = _stats.MaxFocus;
            GameLogger.Log(LogChannel.Player, $"Energy Initialized. Max: {_stats.MaxFocus}", gameObject);

            // Subscriptions
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerDied += OnPlayerDied;
            
            GameEvents.OnWaveCombatStarted += EnableDecay;
            GameEvents.OnWaveCleared += DisableDecay;
            GameEvents.OnGameVictory += DisableDecay;
            
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerDied -= OnPlayerDied;
            
            GameEvents.OnWaveCombatStarted -= EnableDecay;
            GameEvents.OnWaveCleared -= DisableDecay;
            GameEvents.OnGameVictory -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            // Check Overdrive Threshold via Stats
            // (We assume the threshold is static in SO for now)
            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            // Decay Logic
            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= _stats.FocusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                
                UpdateUI();
            }
        }

        // --- PUBLIC API ---

        public bool HasFocus(float amount)
        {
            return _currentFocus >= amount;
        }

        public bool SpendFocus(float amount)
        {
            if (_currentFocus >= amount)
            {
                _currentFocus -= amount;
                UpdateUI();
                return true;
            }
            return false;
        }

        public void AddFocus(float amount)
        {
            float max = _stats.MaxFocus;
            _currentFocus += amount;
            if (_currentFocus > max) _currentFocus = max;
            UpdateUI();
        }

        // --- EVENT HANDLERS ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Use enemy specific reward, or fallback to player base stat
            float gain = (stats != null) ? stats.focusReward : _stats.BaseFocusOnKill;
            
            GameLogger.Log(LogChannel.Player, $"Enemy Killed. +{gain} Focus.", gameObject);
            AddFocus(gain);
        }

        private void EnableDecay() 
        { 
            _isCombatActive = true;
            GameLogger.Log(LogChannel.System, "Combat Started. Focus Decay ON.");
        }

        private void DisableDecay() 
        { 
            _isCombatActive = false; 
            GameLogger.Log(LogChannel.System, "Combat Ended. Focus Decay OFF.");
        }

        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, _stats.MaxFocus);
        }
    }
}