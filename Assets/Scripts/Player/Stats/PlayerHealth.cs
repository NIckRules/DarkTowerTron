using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels
using DarkTowerTron.Core.Services;    // For GameLogger
using DarkTowerTron.Player.Movement;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Stats
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerHealth : MonoBehaviour, IDamageable, IAimTarget
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget; // Assign 'CameraTarget' or 'Visuals/Spine'

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _gritEvent;      // Replaces OnGritChanged
        [SerializeField] private BoolEventChannelSO _hullEvent;        // Replaces OnHullStateChanged
        [SerializeField] private VoidEventChannelSO _playerHitEvent;   // Replaces OnPlayerHit
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;  // Replaces OnPlayerDied

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        
        private PlayerMovement _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
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

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;
            if (_dodge != null && _dodge.IsInvulnerable) return false;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0;

                // NEW: Raise Void Event for FX/Camera Shake
                _playerHitEvent?.Raise();
            }
            else if (_hasHull)
            {
                _hasHull = false;
                _playerHitEvent?.Raise();
            }
            else
            {
                Kill(false);
            }

            if (!_isDead && _movement) 
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            UpdateUI();
            return true;
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;
            
            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // Simulate Environment Damage
            TakeDamage(new DamageInfo { damageAmount = 1f, damageType = DamageType.Environment });
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            
            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            _playerDiedEvent?.Raise();
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

            // Case A: Stats exist (Standard Enemy)
            if (stats != null)
            {
                if (stats.healsGrit)
                {
                    HealGrit(stats.gritRewardAmount);
                }
                // If !healsGrit, do nothing. Correct.
            }
            // Case B: No Stats (Debug Enemy / Test Dummy)
            else
            {
                // Fallback: Default behavior for untyped enemies
                HealGrit(1);
            }
        }

        public void ForceUpdateUI() => UpdateUI();

        private void UpdateUI()
        {
            int max = _stats ? _stats.MaxGrit : 2;
            
            // NEW: Raise Typed Events
            _gritEvent?.Raise(_currentGrit, max);
            _hullEvent?.Raise(_hasHull);
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