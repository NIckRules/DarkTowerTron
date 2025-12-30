using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public abstract class CombatProp : MonoBehaviour, IDamageable, ICombatTarget, IPoolable
    {
        [Header("Base Stats")]
        public float health = 10f;
        public float maxStagger = 1.0f;
        public float staggerDecay = 1.0f;

        [Header("Base Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.cyan;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        // State
        protected float _currentHealth;
        protected float _currentStagger;
        public bool IsStaggered { get; protected set; }

        private Tween _flashTween;

        protected virtual void Awake()
        {
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
        }

        public virtual void OnSpawn()
        {
            _currentHealth = health;
            _currentStagger = 0;
            IsStaggered = false;
            ResetVisuals();
        }

        public virtual void OnDespawn()
        {
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();
        }

        private void Update()
        {
            if (!IsStaggered && _currentStagger > 0)
            {
                _currentStagger -= staggerDecay * Time.deltaTime;
                if (_currentStagger < 0) _currentStagger = 0;
            }
        }

        // --- IDAMAGEABLE ---
        public virtual bool TakeDamage(DamageInfo info)
        {
            Flash();

            if (!IsStaggered)
            {
                _currentStagger += info.staggerAmount;
                if (_currentStagger >= maxStagger) EnterStaggerState();
            }

            // Crit multiplier if staggered
            float finalDmg = IsStaggered ? info.damageAmount * 2f : info.damageAmount;

            _currentHealth -= finalDmg;

            if (finalDmg > 0)
                GameEvents.OnDamageDealt?.Invoke(transform.position, finalDmg, IsStaggered);

            if (_currentHealth <= 0)
            {
                Die();
            }

            return true;
        }

        public void Kill(bool instant) => Die();

        // --- ABSTRACT METHODS ---
        protected abstract void Die();
        public abstract void OnExecutionHit();

        // --- HELPERS ---
        protected void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "READY");

            if (meshRenderer)
                meshRenderer.material.DOColor(staggerColor, 0.2f);

            DOVirtual.DelayedCall(2.0f, () =>
            {
                IsStaggered = false;
                _currentStagger = 0;
                ResetVisuals();
            }).SetId(gameObject);
        }

        protected void Flash()
        {
            if (!IsStaggered && meshRenderer)
            {
                if (_flashTween != null) _flashTween.Kill();
                meshRenderer.material.DOColor(flashColor, 0.1f)
                    .OnComplete(() => ResetVisuals());
            }
        }

        protected void ResetVisuals()
        {
            if (meshRenderer) meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
        }

        // --- ICOMBATTARGET ---
        // 'transform' property is inherited from MonoBehaviour, so we don't define it here.

        public virtual bool KeepPlayerGrounded => true;
    }
}