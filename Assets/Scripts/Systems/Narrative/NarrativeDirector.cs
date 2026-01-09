using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core;

namespace DarkTowerTron.Systems.Narrative
{
    public class NarrativeDirector : MonoBehaviour
    {
        [Header("Data")]
        public NarrativeLibrarySO library;
        [SerializeField] private NarrativeEventChannelSO _narrativeOutput;

        [Header("Triggers")]
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _waveCombatStartedEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Settings")]
        [Tooltip("Minimum seconds between messages to avoid spam.")]
        public float spamCooldown = 3.0f;

        private float _lastMessageTime;
        private float _currentCorruption = 0f;

        private void Start()
        {
            CalculateCorruption();
        }

        private void OnEnable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised += OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
        }

        private void OnDisable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised -= OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
        }

        private void CalculateCorruption()
        {
            // Logic: More Runs + More Deaths = Higher Corruption
            // Example: 10 deaths = 50% corruption
            if (Global.Score != null && Global.Score.gameObject.GetComponent<DarkTowerTron.Systems.Persistence.PersistenceManager>() != null)
            {
                // Accessing Persistence via Global shortcut or FindObject depending on your registration
                // Let's assume you added it to Global in Phase 3. If not, use FindObject for now.
                var data = FindObjectOfType<DarkTowerTron.Systems.Persistence.PersistenceManager>()?.CurrentData;

                if (data != null)
                {
                    // Formula: Each death adds 5% corruption. Each run adds 1%.
                    float deathFactor = data.totalDeaths * 0.05f;
                    float runFactor = data.totalRuns * 0.01f;

                    _currentCorruption = Mathf.Clamp01(deathFactor + runFactor);

                    Debug.Log($"[Narrative] Corruption Level: {_currentCorruption:P0}");
                }
            }
        }

        private void Publish(string rawText, float priorityBonus = 0f)
        {
            // Rate Limiting (unless priority is high)
            if (Time.time < _lastMessageTime + (spamCooldown - priorityBonus)) return;

            string finalString = TextCorruptor.Corrupt(rawText, _currentCorruption);

            _narrativeOutput?.Raise(finalString, 3.0f);
            _lastMessageTime = Time.time;
        }

        // --- HANDLERS ---

        private void OnCombatStart()
        {
            Publish(library.GetRandomLine(library.introLines), 10f); // High priority
        }

        private void OnPlayerHurt()
        {
            if (Random.value > 0.7f) // Don't talk every hit
                Publish(library.GetRandomLine(library.hurtLines));
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (reward && Random.value > 0.8f)
                Publish(library.GetRandomLine(library.killLines));
        }

        private void OnPlayerDied()
        {
            // Force message
            string text = TextCorruptor.Corrupt(library.GetRandomLine(library.deathLines), _currentCorruption + 0.2f);
            _narrativeOutput?.Raise(text, 5.0f);
        }
    }
}