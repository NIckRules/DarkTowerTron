using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels

namespace DarkTowerTron.Services
{
    public class ScoreManager : MonoBehaviour
    {
        // Note: ScoreManager is likely registered in Bootloader or Scene Context via ServiceLocator
        // But internal logic remains MonoBehaviour-based for now.

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _scoreEvent; // Replaces OnScoreChanged

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled
        [SerializeField] private VoidEventChannelSO _playerHitEvent; // Replaces OnPlayerHit

        [Header("Score Settings")]
        public int baseScorePerKill = 100;
        public int gloryKillBonus = 500;
        public int maxMultiplier = 5;

        public int currentMultiplier = 1;
        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Start()
        {
            _isTracking = true;
            UpdateUI();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking) GameTime += Time.deltaTime;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            int scoreValue = (stats != null) ? stats.scoreValue : baseScorePerKill;
            AddScore(scoreValue * currentMultiplier);

            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI();
            }
        }

        private void OnPlayerHit()
        {
            if (currentMultiplier > 1)
            {
                currentMultiplier = 1;
                UpdateUI();
            }
        }

        public void StopTracking() { _isTracking = false; }

        public void AddScore(int amount)
        {
            TotalScore += amount;
            UpdateUI();
        }

        public void TriggerGloryKillBonus()
        {
            int bonus = gloryKillBonus * currentMultiplier;
            GameLogger.Log(LogChannel.Combat, $"GLORY KILL! +{bonus}", gameObject);
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            // NEW: Raise event via Channel
            _scoreEvent?.Raise(TotalScore, currentMultiplier);
        }
    }
}