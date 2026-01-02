using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent; // Replaces OnFocusChanged

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled

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
            if (_stats == null) return;
            _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        private void OnEnable()
        {
            // Subscribe to SO Event
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;

            // Subscribe to remaining Static Events (Phase 2 migration)
            GameEvents.OnPlayerDied += OnPlayerDied;
            GameEvents.OnWaveCombatStarted += EnableDecay;
            GameEvents.OnWaveCleared += DisableDecay;
            GameEvents.OnGameVictory += DisableDecay;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;

            GameEvents.OnPlayerDied -= OnPlayerDied;
            GameEvents.OnWaveCombatStarted -= EnableDecay;
            GameEvents.OnWaveCleared -= DisableDecay;
            GameEvents.OnGameVictory -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= _stats.FocusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- PUBLIC API ---
        public bool HasFocus(float amount) => _currentFocus >= amount;

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
            if (_currentFocus > _stats.MaxFocus) _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        // --- HANDLERS ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;
            float gain = (stats != null) ? stats.focusReward : _stats.BaseFocusOnKill;
            AddFocus(gain);
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }
        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            // NEW: Raise via Channel
            if (_focusEvent != null) 
                _focusEvent.Raise(_currentFocus, _stats.MaxFocus);
        }
    }
}