using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Gameplay.Combat
{
    public class ContactDamager : MonoBehaviour
    {
        [SerializeField] private float _damage = 10f;
        [SerializeField] private DamageType _damageType = DamageType.Melee;
        [SerializeField] private bool _destroyOnImpact = false;

        private void OnTriggerEnter(Collider other)
        {
            // 1. Find Target
            IDamageable target = other.GetComponent<IDamageable>();
            if (target == null) return;

            // 2. Safety Check (since TakeDamage relies on void now)
            if (target.IsDead) return;

            // 3. Create Info
            DamageInfo info = new DamageInfo
            {
                damageAmount = _damage,
                source = gameObject,
                damageType = _damageType,
                pushDirection = transform.forward,
                pushForce = 5f
            };

            // 4. Apply Damage (No longer returns bool)
            target.TakeDamage(info);

            // 5. Cleanup
            if (_destroyOnImpact)
            {
                Destroy(gameObject);
            }
        }
    }
}