using System;
using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Debugging;

namespace DarkTowerTron.Systems.Score
{
    public class ScoreSystem : MonoBehaviour, IScoreService
    {
        [Header("Listening (Inputs)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;

        [Header("Broadcasting (Outputs)")]
        [SerializeField] private IntIntEventChannelSO _uiScoreEvent;

        [Header("Settings")]
        [SerializeField] private int _baseScorePerKill = 100;
        [SerializeField] private int _maxMultiplier = 5;

        // --- IScoreService Implementation ---
        public int TotalScore { get; private set; }
        public int CurrentMultiplier { get; private set; } = 1;
        public float GameTime { get; private set; } // Implemented Timer

        public event Action<int, int> OnScoreChanged;

        // Internal State
        private bool _isTracking = false;

        // --- Lifecycle ---

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;

            // Auto-start on scene load
            ResetScore();
            _isTracking = true;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking)
            {
                GameTime += Time.deltaTime;
            }
        }

        // --- Methods ---

        public void AddScore(int amount)
        {
            if (!_isTracking) return;

            TotalScore += amount;
            NotifyChange();
        }

        public void AddScore(int amount, Vector3 position)
        {
            // Simple overload redirection
            AddScore(amount);
        }

        public void ResetScore()
        {
            TotalScore = 0;
            CurrentMultiplier = 1;
            GameTime = 0f;
            _isTracking = true;
            NotifyChange();
        }

        public void StopTracking()
        {
            _isTracking = false;
        }

        // --- Internal Logic ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer || !_isTracking) return;

            int scoreValue = (stats != null) ? stats.scoreValue : _baseScorePerKill;

            // Add Score with Multiplier
            AddScore(scoreValue * CurrentMultiplier);

            // Increment Multiplier
            if (CurrentMultiplier < _maxMultiplier)
            {
                CurrentMultiplier++;
                NotifyChange();
            }
        }

        private void OnPlayerHit()
        {
            if (CurrentMultiplier > 1)
            {
                CurrentMultiplier = 1;
                NotifyChange();
            }
        }

        private void NotifyChange()
        {
            OnScoreChanged?.Invoke(TotalScore, CurrentMultiplier);
            _uiScoreEvent?.RaiseEvent(TotalScore, CurrentMultiplier);
        }
    }
}