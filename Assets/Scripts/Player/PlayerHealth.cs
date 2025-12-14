using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;
        public bool startWithHull = true; // Default to having the shield

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        private PlayerMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
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

            // 1. Calculate actual damage (for Grit calculation)
            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            // LOGIC GATE
            if (_currentGrit > 0)
            {
                // PHASE 1: Take Grit Damage
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; // Clamp, don't carry over damage to hull

                GameEvents.OnPlayerHit?.Invoke(); // Standard Ouch
            }
            else if (_hasHull)
            {
                // PHASE 2: Hull Break (Gate)
                // We absorb ALL damage from this single hit, regardless of amount.
                _hasHull = false;

                // Special Feedback for breaking the shield
                Debug.Log("<color=orange>HULL BREACHED!</color>");
                // We can fire OnPlayerHit for shake, or a specific Hull Break event
                GameEvents.OnPlayerHit?.Invoke();
            }
            else
            {
                // PHASE 3: Death
                Kill(false);
            }

            // Apply Physics (Always happens if not dead)
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

            // NOTE: We only heal Grit. Hull is not replenishable (per design).
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats)
        {
            // Only heal if allowed
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
    }
}