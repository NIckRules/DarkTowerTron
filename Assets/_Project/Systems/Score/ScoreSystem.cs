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
        // Keep these! It decouples the system. 
        // The system reacts to the world events.
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;

        [Header("Broadcasting (Outputs)")]
        // Optional: Keep this if you have UI prefabs relying strictly on SOs.
        // If not, prefer the C# event below.
        [SerializeField] private IntIntEventChannelSO _uiScoreEvent;

        [Header("Settings")]
        [SerializeField] private int _baseScorePerKill = 100;
        [SerializeField] private int _gloryKillBonus = 500;
        [SerializeField] private int _maxMultiplier = 5;

        // --- IScoreService State ---
        public int TotalScore { get; private set; }
        public int CurrentMultiplier { get; private set; } = 1;
        public event Action<int, int> OnScoreChanged;

        // Internal State
        private bool _isTracking = false;

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;

            _isTracking = true;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
        }

        // --- IScoreService Implementation ---

        public void AddScore(int amount)
        {
            if (!_isTracking) return;

            TotalScore += amount;
            NotifyChange();
        }

        public void ResetScore()
        {
            TotalScore = 0;
            CurrentMultiplier = 1;
            NotifyChange();
        }

        // --- Internal Logic (From Old Manager) ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer || !_isTracking) return;

            int scoreValue = (stats != null) ? stats.scoreValue : _baseScorePerKill;

            // Logic: Add score based on current multiplier
            AddScore(scoreValue * CurrentMultiplier);

            // Logic: Increase Multiplier
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
                // Optional: Play a "Combo Broken" sound via IAudioService here
                NotifyChange();
            }
        }

        private void NotifyChange()
        {
            // 1. Notify Code Listeners (The new way)
            OnScoreChanged?.Invoke(TotalScore, CurrentMultiplier);

            // 2. Notify Asset Listeners (The old/hybrid way)
            _uiScoreEvent?.RaiseEvent(TotalScore, CurrentMultiplier);
        }
    }
}