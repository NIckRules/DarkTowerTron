using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers; // For AudioManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;
        public bool startWithHull = true;

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        private PlayerMovement _movement;
        private PlayerDodge _dodge;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _dodge = GetComponent<PlayerDodge>();
        }

        private void Start()
        {
            _currentGrit = maxGrit;
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

            // Invulnerability Check
            if (_dodge != null && _dodge.IsInvulnerable) return false;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; 
                GameEvents.OnPlayerHit?.Invoke(); 
            }
            else if (_hasHull)
            {
                _hasHull = false;
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

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();
            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
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

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
            GameEvents.OnHullStateChanged?.Invoke(_hasHull);
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;

            Debug.Log("Fell into Void! Respawning...");

            // 1. Teleport & Reset Physics
            if (_movement)
            {
                // Reset Logic (Inertia)
                _movement.ResetVelocity();
                
                // Teleport Logic (Position)
                var motor = GetComponent<DarkTowerTron.Physics.KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // 2. Take Penalty (1 Grit/Hull) via standard damage path
            DamageInfo info = new DamageInfo
            {
                damageAmount = 1f,
                pushDirection = Vector3.zero,
                pushForce = 0f,
                source = null
            };
            
            TakeDamage(info); 
        }
    }
}