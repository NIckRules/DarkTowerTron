using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class DamageableProp : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Stats")]
        public float health = 10f;
        public bool isImmortal = false;
        public bool volatileStructure = false; // NEW: Stagger hurts Health

        [Header("Stagger Logic")]
        public float maxStagger = 1.0f;
        public float staggerDecay = 1.0f;
        public float staggerDuration = 2.0f;

        [Header("Death Rattle")]
        public GameObject spawnOnDeath;
        public bool destroyOnDeath = true;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.cyan;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        private float _currentStagger;
        public bool IsStaggered { get; private set; }

        private void Start()
        {
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Update()
        {
            if (!IsStaggered && _currentStagger > 0)
            {
                _currentStagger -= staggerDecay * Time.deltaTime;
                if (_currentStagger < 0) _currentStagger = 0;
            }
        }

        // --- IDamageable ---
        public bool TakeDamage(DamageInfo info)
        {
            Flash();

            // 1. Add Stagger (Standard Logic)
            if (!IsStaggered)
            {
                _currentStagger += info.staggerAmount;
                if (_currentStagger >= maxStagger)
                {
                    EnterStaggerState();
                }
            }

            // 2. Take Health Damage
            if (!isImmortal)
            {
                float finalDamage = info.damageAmount;

                // NEW: If Volatile, Stagger Damage counts as Health Damage
                if (volatileStructure)
                {
                    finalDamage += info.staggerAmount;
                }

                // Crit multiplier if already staggered
                if (IsStaggered) finalDamage *= 2f;

                health -= finalDamage;

                // Only show numbers if damage > 0
                if (finalDamage > 0)
                    GameEvents.OnDamageDealt?.Invoke(transform.position, finalDamage, IsStaggered);

                if (health <= 0)
                {
                    Die();
                }
            }

            return true;
        }

        public void Kill(bool instant) => Die();

        // --- ICombatTarget (Glory Kill) ---
        public void OnExecutionHit()
        {
            if (isImmortal)
            {
                // Anchor Logic (Bounce)
                transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
                IsStaggered = false;
                _currentStagger = 0;
                if (meshRenderer) meshRenderer.material.color = normalColor;
            }
            else
            {
                // Boss Hand / Barrel Logic
                if (volatileStructure)
                {
                    // Volatile things explode instantly on execution
                    Die();
                }
                else
                {
                    // Standard props take massive damage
                    DamageInfo executionDmg = new DamageInfo { damageAmount = 50f };
                    TakeDamage(executionDmg);
                }
            }
        }

        // ... (EnterStaggerState, Flash, Die methods remain the same) ...

        private void EnterStaggerState()
        {
            IsStaggered = true;
            if (meshRenderer) meshRenderer.material.color = staggerColor;
            GameEvents.OnPopupText?.Invoke(transform.position, "READY");

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
            if (spawnOnDeath)
            {
                if (Managers.PoolManager.Instance)
                    Managers.PoolManager.Instance.Spawn(spawnOnDeath, transform.position, Quaternion.identity);
                else
                    Instantiate(spawnOnDeath, transform.position, Quaternion.identity);
            }

            // Note: We pass 'false' to reward because blowing up a barrel isn't a "Kill" for stats
            // Unless you want it to be?
            GameEvents.OnEnemyKilled?.Invoke(transform.position, null, false);

            if (destroyOnDeath)
            {
                if (Managers.PoolManager.Instance)
                    Managers.PoolManager.Instance.Despawn(gameObject);
                else
                    gameObject.SetActive(false);
            }
        }
    }
}