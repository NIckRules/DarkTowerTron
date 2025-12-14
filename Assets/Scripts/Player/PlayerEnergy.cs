using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Player
{
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Stats")]
        public float maxFocus = 100f;
        public float decayRate = 5f;

        [Header("Rewards (Defaults)")]
        public float defaultFocusOnKill = 30f;

        private float _currentFocus;
        private bool _isDead;
        private bool _isCombatActive = false;

        private void Start()
        {
            _currentFocus = maxFocus;

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

            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= decayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- FIXED SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Use specific reward if available, otherwise default
            float reward = (stats != null) ? stats.focusReward : defaultFocusOnKill;
            AddFocus(reward);
        }
        // -----------------------

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
            _currentFocus += amount;
            if (_currentFocus > maxFocus) _currentFocus = maxFocus;
            UpdateUI();
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }

        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
        }
    }
}