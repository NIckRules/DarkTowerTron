using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;

        private int _currentGrit;
        private bool _isDead;
        private PlayerMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
        }

        private void Start()
        {
            _currentGrit = maxGrit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        // --- IDamageable Implementation ---
        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            if (_currentGrit > 0)
            {
                _currentGrit--;

                // Feedback
                GameEvents.OnPlayerHit?.Invoke();

                // Physics Knockback
                if (_movement) _movement.ApplyKnockback(info.pushDirection * info.pushForce);
            }
            else
            {
                Kill(false);
            }

            UpdateUI();
            return true;
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }
        // ----------------------------------

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position)
        {
            // Passive Reward: Heal 1 Grit on kill
            HealGrit(1);
        }

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
        }
    }
}