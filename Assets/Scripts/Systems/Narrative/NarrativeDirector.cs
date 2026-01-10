using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
// ALIAS
using Global = DarkTowerTron.Global;

namespace DarkTowerTron.Systems.Narrative
{
    public class NarrativeDirector : MonoBehaviour
    {
        [Header("Data")]
        public NarrativeLibrarySO library;
        [SerializeField] private NarrativeEventChannelSO _narrativeOutput; // Terminal
        [SerializeField] private PopupTextEventChannelSO _popupEvent;      // World Space

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
            CalculateCorruption();

            // --- NEW: Boot Message ---
            // Pick a line from the "Intro" list and fire it immediately on start
            // Intro has no world position
            if (library != null && library.introLines != null && library.introLines.Count > 0)
                Publish(library.GetRandomLine(library.introLines), null, 10f);
            else
                Debug.LogWarning("[NarrativeDirector] No Library or Intro Lines assigned!");
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

        /// <summary>
        /// Publishes text to Terminal and optionally to World Space.
        /// </summary>
        private void Publish(string rawText, Vector3? worldPos = null, float priorityBonus = 0f)
        {
            // Rate Limiting (unless priority is high)
            if (Time.time < _lastMessageTime + (spamCooldown - priorityBonus)) return;

            string finalString = TextCorruptor.Corrupt(rawText, _currentCorruption);

            // 1. Send to Terminal (Always)
            _narrativeOutput?.Raise(finalString, 3.0f);

            // 2. Send to World (If position provided and RNG passes)
            if (worldPos.HasValue && _popupEvent != null)
            {
                if (Random.value < worldTextChance)
                    _popupEvent.Raise(worldPos.Value, finalString);
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
            if (Random.value > 0.7f) // Don't talk every hit
            {
                if (library == null) return;

                // Show over Player's head
                Vector3 playerPos = Vector3.zero;
                if (Global.Player != null) playerPos = Global.Player.transform.position + Vector3.up * 2f;

                Publish(library.GetRandomLine(library.hurtLines), playerPos);
            }
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (reward && Random.value > 0.8f)
            {
                if (library == null) return;

                // Show over Dead Enemy's position
                Publish(library.GetRandomLine(library.killLines), pos + Vector3.up);
            }
        }

        private void OnPlayerDied()
        {
            // Force message
            string text = TextCorruptor.Corrupt(library.GetRandomLine(library.deathLines), _currentCorruption + 0.2f);
            _narrativeOutput?.Raise(text, 5.0f);
        }
    }
}