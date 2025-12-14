using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

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

        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        private void Start()
        {
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerHit += OnPlayerHit;
            _isTracking = true;
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerHit -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking) GameTime += Time.deltaTime;
        }

        // --- FIXED METHOD SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats)
        {
            // Determine score from Stats asset, or use default if missing
            int scoreValue = (stats != null) ? stats.scoreValue : baseScorePerKill;

            // Apply Multiplier
            AddScore(scoreValue * currentMultiplier);

            // Increase Multiplier
            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI();
            }
        }
        // -----------------------------

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
            Debug.Log($"<color=yellow>GLORY KILL! +{bonus}</color>");
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            GameEvents.OnScoreChanged?.Invoke(TotalScore, currentMultiplier);
        }
    }
}