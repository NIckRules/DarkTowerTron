using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public class BaseHitbox : MonoBehaviour, IDamageable
    {
        [Header("Wiring")]
        [SerializeField] protected DamageReceiver _mainReceiver;

        [Header("Settings")]
        [SerializeField] protected float _damageMultiplier = 1.0f;
        [SerializeField] protected float _staggerMultiplier = 1.0f;
        [SerializeField] protected bool _isCriticalPoint = false;

        protected virtual void Awake()
        {
            // Auto-find logic
            if (_mainReceiver == null)
                _mainReceiver = GetComponentInParent<DamageReceiver>();
        }

        public bool IsDead => _mainReceiver != null && _mainReceiver.IsDead;

        // FIX: Added 'virtual' keyword so children can override it
        public virtual void TakeDamage(DamageInfo info)
        {
            if (_mainReceiver == null) return;

            // Apply Hitbox Modifiers (Headshots, Limbs)
            info.damageAmount *= _damageMultiplier;

            if (_isCriticalPoint)
            {
                info.isCritical = true;
                info.staggerAmount = (int)(info.damageAmount * _staggerMultiplier);
            }

            // Forward to Main Health
            _mainReceiver.TakeDamage(info);
        }

        // FIX: Added 'virtual' keyword
        public virtual void Kill(bool immediate)
        {
            _mainReceiver?.Kill(immediate);
        }
    }
}