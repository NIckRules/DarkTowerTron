using UnityEngine;
using System.Collections;
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

        [Header("Anchor Logic")]
        public bool respawns = false; // Set True for Traversal Anchors
        public float respawnTime = 3.0f;

        // Components to hide
        private Collider _col;
        private Renderer _rend;

        private float _currentStagger;
        public bool IsStaggered { get; private set; }

        private void Start()
        {
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Awake()
        {
            _col = GetComponent<Collider>();
            _rend = meshRenderer ? meshRenderer : GetComponent<Renderer>();
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
                if (respawns)
                {
                    StartCoroutine(RespawnRoutine());
                }
                else
                {
                    // Standard Bounce
                    transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
                    ResetStagger();
                }
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

        private IEnumerator RespawnRoutine()
        {
            // 1. Disable Interactions
            if (_col) _col.enabled = false;
            if (_rend) _rend.enabled = false;

            // Reset Stagger state internally
            ResetStagger();

            // 2. Wait
            yield return new WaitForSeconds(respawnTime);

            // 3. Re-Enable
            if (_rend)
            {
                _rend.enabled = true;
                // Juice: Scale up from 0
                transform.localScale = Vector3.zero;
                transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
            }
            if (_col) _col.enabled = true;
        }

        private void ResetStagger()
        {
            IsStaggered = false;
            _currentStagger = 0;
            if (meshRenderer) meshRenderer.material.color = normalColor;
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