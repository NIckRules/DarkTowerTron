using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance;

        [Header("Score Settings")]
        public int baseScorePerKill = 100;
        public int gloryKillBonus = 500;
        
        [Header("Multiplier Settings")]
        public int currentMultiplier = 1;
        public int maxMultiplier = 5;

        // State Properties
        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Awake()
        {
            if (Instance == null) 
            {
                Instance = this;
            }
            else 
            {
                Destroy(gameObject);
                return;
            }
        }

        private void Start()
        {
            // Subscribe to game events
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerHit += OnPlayerHit;
            
            // Start tracking immediately (or hook this to GameSession.BeginGame if you prefer)
            _isTracking = true; 
            
            // Initialize UI
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerHit -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking)
            {
                GameTime += Time.deltaTime;
                // We don't fire an event for time every frame to save performance.
                // The HUDManager reads 'ScoreManager.Instance.GameTime' directly in its Update().
            }
        }

        // --- PUBLIC API ---

        public void StopTracking()
        {
            _isTracking = false;
        }

        public void AddScore(int amount)
        {
            TotalScore += amount;
            UpdateUI();
        }

        /// <summary>
        /// Called by Blitz.cs when a Glory Kill is executed.
        /// </summary>
        public void TriggerGloryKillBonus()
        {
            int bonus = gloryKillBonus * currentMultiplier;
            Debug.Log($"<color=yellow>GLORY KILL! +{bonus}</color>");
            AddScore(bonus);
        }

        // --- EVENT HANDLERS ---

        private void OnEnemyKilled(Vector3 pos)
        {
            // Standard Kill Score
            AddScore(baseScorePerKill * currentMultiplier);

            // Increase Multiplier
            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI(); // Refresh UI to show new multiplier
            }
        }

        private void OnPlayerHit()
        {
            // Penalty: Reset Multiplier
            if (currentMultiplier > 1)
            {
                currentMultiplier = 1;
                UpdateUI();
            }
        }

        // --- UI UPDATER ---

        private void UpdateUI()
        {
            // Notify the HUD via the Event System
            GameEvents.OnScoreChanged?.Invoke(TotalScore, currentMultiplier);
        }
    }
}