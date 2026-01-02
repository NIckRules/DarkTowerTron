using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public abstract class BaseHitbox : MonoBehaviour, IDamageable
    {
        // CHANGED: Now references the new Orchestrator
        [SerializeField] protected DamageReceiver _receiver;

        protected virtual void Awake()
        {
            // Auto-link
            if (_receiver == null) _receiver = GetComponentInParent<DamageReceiver>();
        }

        public virtual bool TakeDamage(DamageInfo info)
        {
            // If no receiver, we still accept the hit but do nothing (Prop logic)
            if (_receiver != null) 
            {
                return _receiver.TakeDamage(info);
            }
            return true;
        }

        public virtual void Kill(bool instant)
        {
            if (_receiver) _receiver.Kill(instant);
        }
    }
}