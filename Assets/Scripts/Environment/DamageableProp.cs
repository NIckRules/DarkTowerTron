using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // For EnemyStatsSO if needed, or just raw stats
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class DamageableProp : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Stats")]
        public float health = 10f; // -1 for Immortal
        public bool isImmortal = false;

        [Header("Stagger Logic")]
        public float maxStagger = 1.0f;
        public float staggerDecay = 1.0f;
        public float staggerDuration = 2.0f;

        [Header("Execution Reward")]
        public bool refillFocus = true;
        public bool healGrit = false;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.cyan;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        // State
        private float _currentStagger;
        public bool IsStaggered { get; private set; }

        private void Start()
        {
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Update()
        {
            // Stagger Decay
            if (!IsStaggered && _currentStagger > 0)
            {
                _currentStagger -= staggerDecay * Time.deltaTime;
                if (_currentStagger < 0) _currentStagger = 0;
            }
        }

        // --- IDamageable ---
        public bool TakeDamage(DamageInfo info)
        {
            // 1. Visual Flash
            Flash();

            // 2. Add Stagger
            if (!IsStaggered)
            {
                _currentStagger += info.staggerAmount;
                if (_currentStagger >= maxStagger)
                {
                    EnterStaggerState();
                }
            }

            // 3. Take Health Damage
            if (!isImmortal)
            {
                // Bonus damage if staggered (Critical Hit)
                float dmg = info.damageAmount * (IsStaggered ? 2f : 1f);

                health -= dmg;

                // Show Numbers
                GameEvents.OnDamageDealt?.Invoke(transform.position, dmg, IsStaggered);

                if (health <= 0)
                {
                    Die();
                }
            }

            return true;
        }

        public void Kill(bool instant)
        {
            Die();
        }

        // --- ICombatTarget ---
        public void OnExecutionHit()
        {
            // What happens when player Teleports here?

            // 1. Rewards
            // We fire the kill event logic manually to trigger Player rewards?
            // Or better: The PlayerExecution script handles the reward logic based on our flags.
            // But we need to define specific behavior here.

            // For now, let's keep it visual. The Logic stays in PlayerExecution for consistency,
            // but we can trigger a reaction here.

            if (isImmortal)
            {
                // Anchor Logic: Reset Stagger immediately so we can shoot it again?
                // Or keep it staggered?
                // Let's bounce the mesh
                transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
                IsStaggered = false; // Reset so you have to shoot it again to chain
                _currentStagger = 0;
                if (meshRenderer) meshRenderer.material.color = normalColor;
            }
            else
            {
                // Boss Hand Logic: Massive Damage
                DamageInfo executionDmg = new DamageInfo { damageAmount = 50f };
                TakeDamage(executionDmg);
            }
        }

        // --- INTERNAL ---
        private void EnterStaggerState()
        {
            IsStaggered = true;
            if (meshRenderer) meshRenderer.material.color = staggerColor;
            GameEvents.OnPopupText?.Invoke(transform.position, "READY"); // "READY" for teleport

            // Auto-recover after duration
            DOVirtual.DelayedCall(staggerDuration, () =>
            {
                IsStaggered = false;
                _currentStagger = 0;
                if (this != null && meshRenderer) meshRenderer.material.color = normalColor;
            });
        }

        private void Flash()
        {
            if (meshRenderer)
            {
                meshRenderer.material.DOColor(flashColor, 0.1f).OnComplete(() =>
                {
                    if (this != null)
                        meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
                });
            }
        }

        private void Die()
        {
            // Explosion VFX
            GameEvents.OnEnemyKilled?.Invoke(transform.position, null, false);

            // Logic: Disable self (for Boss Hands) or Destroy (for Crates)
            gameObject.SetActive(false);
            // Optional: Notify Boss Controller via event
        }
    }
}