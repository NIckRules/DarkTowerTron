using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Stats")]
        public float maxFocus = 100f;
        public float decayRate = 5f;

        [Header("Rewards")]
        public float focusOnKill = 30f;

        private float _currentFocus;
        private bool _isDead; // To stop decay on death

        private void Start()
        {
            _currentFocus = maxFocus;

            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerDied += OnPlayerDied;

            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerDied -= OnPlayerDied;
        }

        private void Update()
        {
            if (_isDead) return;

            // Decay Logic
            if (_currentFocus > 0)
            {
                _currentFocus -= decayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;

                UpdateUI();
            }
        }

        // --- API used by Abilities (Blitz) ---
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

        public void AddFocus(float amount)
        {
            _currentFocus += amount;
            if (_currentFocus > maxFocus) _currentFocus = maxFocus;
            UpdateUI();
        }
        // -------------------------------------

        private void OnEnemyKilled(Vector3 pos)
        {
            AddFocus(focusOnKill);
        }

        private void OnPlayerDied()
        {
            _isDead = true;
        }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
        }
    }
}