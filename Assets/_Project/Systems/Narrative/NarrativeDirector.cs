using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;      // For ServiceLocator
using DarkTowerTron.Systems.Persistence; // For IPersistenceService
using DarkTowerTron.Gameplay.Player;     // For PlayerController
using DarkTowerTron.Core.Debugging;          // For GameLogger

namespace DarkTowerTron.Systems.Narrative
{
    public class NarrativeDirector : MonoBehaviour
    {
        [Header("Data")]
        public NarrativeLibrarySO library;
        [SerializeField] private NarrativeEventChannelSO _narrativeOutput; // Terminal UI
        [SerializeField] private PopupTextEventChannelSO _popupEvent;      // World Space UI

        [Header("Triggers")]
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _waveCombatStartedEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Settings")]
        [Tooltip("Minimum seconds between messages to avoid spam.")]
        public float spamCooldown = 3.0f;

        [Range(0f, 1f)]
        public float worldTextChance = 0.5f;

        private float _lastMessageTime;
        private float _currentCorruption = 0f;

        private void Start()
        {
            // 1. Calculate Corruption from Save Data
            CalculateCorruption();

            // 2. Boot Message
            if (library != null && library.introLines != null && library.introLines.Count > 0)
            {
                // Intro is high priority, no world position
                Publish(library.GetRandomLine(library.introLines), null, 10f);
            }
            else
            {
                GameLogger.LogWarning(LogChannel.System, "[NarrativeDirector] No Library or Intro Lines assigned!", gameObject);
            }
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
            // NEW: Get Persistence via Service Locator
            var persistence = ServiceLocator.Get<IPersistenceService>();

            if (persistence != null && persistence.CurrentData != null)
            {
                var data = persistence.CurrentData;

                // Formula: Each death adds 5% corruption. Each run adds 1%.
                float deathFactor = data.totalDeaths * 0.05f;
                float runFactor = data.totalRuns * 0.01f;

                _currentCorruption = Mathf.Clamp01(deathFactor + runFactor);

                GameLogger.Log(LogChannel.System, $"[Narrative] Corruption Level: {_currentCorruption:P0}", gameObject);
            }
            else
            {
                // Default if no save found yet
                _currentCorruption = 0f;
            }
        }

        /// <summary>
        /// Publishes text to Terminal and optionally to World Space.
        /// </summary>
        private void Publish(string rawText, Vector3? worldPos = null, float priorityBonus = 0f)
        {
            // Rate Limiting (unless priority is high)
            if (Time.time < _lastMessageTime + (spamCooldown - priorityBonus)) return;

            // Apply glitch effects based on corruption
            string finalString = TextCorruptor.Corrupt(rawText, _currentCorruption);

            // 1. Send to Terminal (Always)
            _narrativeOutput?.RaiseEvent(finalString, 3.0f);

            // 2. Send to World (If position provided and RNG passes)
            if (worldPos.HasValue && _popupEvent != null)
            {
                if (Random.value < worldTextChance)
                    _popupEvent.RaiseEvent(worldPos.Value, finalString);
            }

            _lastMessageTime = Time.time;
        }

        [ContextMenu("DEBUG: Test Message")]
        public void DebugTestMessage()
        {
            Publish("System Diagnostic: INTEGRITY_FAIL // [0x00A1]", null);
        }

        // --- HANDLERS ---

        private void OnCombatStart()
        {
            if (library == null) return;
            Publish(library.GetRandomLine(library.introLines), null, 10f); // High priority
        }

        private void OnPlayerHurt()
        {
            if (Random.value > 0.7f) // Don't talk every hit (30% chance)
            {
                if (library == null) return;

                // NEW: Use PlayerController Singleton instead of Global.Player
                Vector3 playerPos = Vector3.zero;
                if (PlayerController.Instance != null)
                    playerPos = PlayerController.Instance.transform.position + Vector3.up * 2f;

                Publish(library.GetRandomLine(library.hurtLines), playerPos);
            }
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (reward && Random.value > 0.8f) // 20% chance on kill
            {
                if (library == null) return;

                // Show over Dead Enemy's position
                Publish(library.GetRandomLine(library.killLines), pos + Vector3.up);
            }
        }

        private void OnPlayerDied()
        {
            // Force message
            if (library == null) return;

            // Higher corruption for death message (glitchier)
            string text = TextCorruptor.Corrupt(library.GetRandomLine(library.deathLines), _currentCorruption + 0.2f);

            _narrativeOutput?.RaiseEvent(text, 5.0f);
        }
    }
}