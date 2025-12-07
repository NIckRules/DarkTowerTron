using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    public class GritAndFocus : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;
        public float maxFocus = 100f;
        public float focusDecayRate = 5f;

        [Header("Rewards")]
        public float focusOnKill = 30f; // Configurable in Inspector now

        private int _currentGrit;
        private float _currentFocus;
        private bool _isDead;

        private void Start()
        {
            _currentGrit = maxGrit;
            _currentFocus = maxFocus;
            
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            
            UpdateUI();
        }

        private void OnDestroy() { GameEvents.OnEnemyKilled -= OnEnemyKilled; }

        private void Update()
        {
            if (_isDead) return;

            // Focus Decay Logic
            if (_currentFocus > 0)
            {
                _currentFocus -= focusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                
                GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
            }
        }

        // --- IDamageable Implementation ---
        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            // 1. Apply Logic
            if (_currentGrit > 0)
            {
                _currentGrit--;
                // Feedback
                GameEvents.OnPlayerHit?.Invoke();
                
                // Physics Knockback
                var move = GetComponent<PlayerMovement>();
                if (move) move.ApplyKnockback(info.pushDirection * info.pushForce);
            }
            else
            {
                Die();
            }

            UpdateUI();
            return true;
        }

        public void Kill(bool instant)
        {
            Die();
        }
        // ----------------------------------

        /// <summary>
        /// Checks if the player has enough focus for an action.
        /// </summary>
        public bool HasFocus(float amount)
        {
            return _currentFocus >= amount;
        }

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

        /// <summary>
        /// Generic method to add focus from any source (Blitz, Items, etc.)
        /// </summary>
        public void AddFocus(float amount)
        {
            _currentFocus += amount;
            if (_currentFocus > maxFocus) _currentFocus = maxFocus;
            UpdateUI();
        }

        // Event Listener: Automatic reward when an enemy dies
        private void OnEnemyKilled(Vector3 position)
        {
            // Heal 1 Grit
            if (_currentGrit < maxGrit) _currentGrit++;
            
            // Gain Configurable Focus
            AddFocus(focusOnKill);
            
            UpdateUI();
        }

        private void Die()
        {
            _isDead = true;
            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
        }
    }
}