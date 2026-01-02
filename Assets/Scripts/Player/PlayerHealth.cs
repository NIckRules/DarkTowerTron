using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerStats))] // NEW DEPENDENCY
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        // State
        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        
        // Dependencies
        private PlayerMovement _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats; // NEW

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // FIX: Read Max Grit from Data, not Inspector
            if (_stats != null && _stats.baseStats != null)
            {
                _currentGrit = _stats.baseStats.maxGrit;
                GameLogger.Log(LogChannel.Player, $"Health Initialized. Max Grit: {_currentGrit}", gameObject);
            }
            else
            {
                _currentGrit = 2; // Fallback
                GameLogger.LogError(LogChannel.Player, "Missing PlayerStatsSO! Defaulting to 2 Grit.", gameObject);
            }

            _hasHull = startWithHull;
            
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            if (_dodge != null && _dodge.IsInvulnerable) 
            {
                GameLogger.Log(LogChannel.Combat, "Damage Dodged (Invulnerable)", gameObject);
                return false;
            }

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; 
                
                GameLogger.Log(LogChannel.Combat, $"Player Hit! Grit: {_currentGrit}", gameObject);
                GameEvents.OnPlayerHit?.Invoke(); 
            }
            else if (_hasHull)
            {
                _hasHull = false;
                
                GameLogger.Log(LogChannel.Combat, "HULL BREACHED!", gameObject);
                GameEvents.OnPlayerHit?.Invoke(); 
                GameEvents.OnHullStateChanged?.Invoke(false); 
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

            GameLogger.Log(LogChannel.Physics, "Fell into Void. Respawning.", gameObject);

            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            DamageInfo info = new DamageInfo
            {
                damageAmount = 1f,
                pushDirection = Vector3.zero,
                pushForce = 0f,
                source = null,
                damageType = DamageType.Environment
            };
            
            TakeDamage(info); 
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            
            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            
            int max = _stats ? _stats.baseStats.maxGrit : 2;
            _currentGrit = Mathf.Min(_currentGrit + amount, max);
            
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            if (stats != null)
            {
                if (stats.healsGrit) HealGrit(stats.gritRewardAmount);
            }
            else
            {
                HealGrit(1);
            }
        }

        public void ForceUpdateUI()
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            int max = _stats ? _stats.baseStats.maxGrit : 2;
            GameEvents.OnGritChanged?.Invoke(_currentGrit, max);
            GameEvents.OnHullStateChanged?.Invoke(_hasHull);
        }
    }
}