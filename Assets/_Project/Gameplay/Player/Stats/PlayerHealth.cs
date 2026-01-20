using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerHealth : MonoBehaviour, IDamageable, IAimTarget
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget;

        [Header("Juice")]
        [SerializeField] private FeedbackConfigurationSO _damageFeedback;
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _gritEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;

        // INTERFACE IMPLEMENTATION (Fix for CS0535)
        public bool IsDead => _isDead;

        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats;

        private void Awake()
        {
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            _currentGrit = _stats ? _stats.MaxGrit : 2;
            _hasHull = startWithHull;
            UpdateUI();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        // INTERFACE IMPLEMENTATION (Fix for CS0738)
        // Changed return type from 'bool' to 'void'
        public void TakeDamage(DamageInfo info)
        {
            if (_isDead) return;
            if (_dodge != null && _dodge.IsInvulnerable) return;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Taking {dmg} Damage. Grit: {_currentGrit} -> {_currentGrit - dmg}", gameObject);

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0;

                _playerHitEvent?.RaiseEvent();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else if (_hasHull)
            {
                _hasHull = false;
                _playerHitEvent?.RaiseEvent();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else
            {
                Kill(false);
            }

            if (!_isDead && _movement)
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Post-Damage State. Grit: {_currentGrit}, HasHull: {_hasHull}", gameObject);

            UpdateUI();
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;

            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // Simulate Environment Damage
            TakeDamage(new DamageInfo { damageAmount = 1f, damageType = DamageType.Environment });
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;

            _deathFeedback?.Play(gameObject, transform.position);

            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();

            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            _playerDiedEvent?.RaiseEvent();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            int max = _stats ? _stats.MaxGrit : 2;
            _currentGrit = Mathf.Min(_currentGrit + amount, max);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            if (stats != null)
            {
                if (stats.healsGrit)
                {
                    HealGrit(stats.gritRewardAmount);
                }
            }
            else
            {
                HealGrit(1);
            }
        }

        public void ForceUpdateUI() => UpdateUI();

        private void UpdateUI()
        {
            int max = _stats ? _stats.MaxGrit : 2;
            _gritEvent?.RaiseEvent(_currentGrit, max);
            _hullEvent?.RaiseEvent(_hasHull);
        }

        // --- IAimTarget ---
        public Vector3 AimPoint
        {
            get
            {
                if (_aimTarget == null) return transform.position + Vector3.up * 1.2f;
                return _aimTarget.position;
            }
        }
        public float TargetRadius => 0.5f;
    }
}