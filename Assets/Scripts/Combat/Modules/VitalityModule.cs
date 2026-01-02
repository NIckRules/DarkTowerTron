using UnityEngine;
using System;

namespace DarkTowerTron.Combat
{
    public class VitalityModule : MonoBehaviour
    {
        public event Action<float, float> OnHealthChanged; // Current, Max
        public event Action OnDeath;

        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public bool IsDead { get; private set; }

        public void Initialize(float maxHealth)
        {
            MaxHealth = maxHealth;
            // Safety check
            if (MaxHealth <= 0) MaxHealth = 1f;
            
            Revive();
        }

        public void Revive()
        {
            CurrentHealth = MaxHealth;
            IsDead = false;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void TakeDamage(float amount)
        {
            if (IsDead) return;

            CurrentHealth -= amount;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);

            if (CurrentHealth <= 0)
            {
                Die();
            }
        }

        public void Heal(float amount)
        {
            if (IsDead) return;
            CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        private void Die()
        {
            IsDead = true;
            CurrentHealth = 0;
            OnDeath?.Invoke();
        }
    }
}