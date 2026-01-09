using DarkTowerTron.Core;
using UnityEngine;

namespace DarkTowerTron.Combat
{
    public abstract class BaseHitbox : MonoBehaviour, IDamageable
    {
        // CHANGED: Use Interface, not concrete class
        protected IDamageable _damageableParent;

        protected virtual void Awake()
        {
            // Auto-link: Look for ANY damageable component in parents
            // BUT ensure we don't grab ourselves!
            if (_damageableParent != null) return;

            var damageables = GetComponentsInParent<IDamageable>();
            for (int i = 0; i < damageables.Length; i++)
            {
                var d = damageables[i];
                if (d == null) continue;

                // Skip self (this hitbox also implements IDamageable)
                if (ReferenceEquals(d, this)) continue;

                _damageableParent = d;
                break;
            }
        }

        public virtual bool TakeDamage(DamageInfo info)
        {
            // Forward damage to the main health component
            if (_damageableParent != null)
                return _damageableParent.TakeDamage(info);
            return true;
        }

        public virtual void Kill(bool instant)
        {
            if (_damageableParent != null) _damageableParent.Kill(instant);
        }
    }
}