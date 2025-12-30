using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Environment
{
    public class Prop_Explosive : CombatProp
    {
        [Header("Explosive Settings")]
        public GameObject spawnOnDeath; // Hazard Zone
        public bool volatileOnStagger = true; // Stagger damage hurts HP

        public override bool TakeDamage(DamageInfo info)
        {
            // Override to allow Stagger damage to hurt Health (Volatile)
            if (volatileOnStagger)
            {
                // Add stagger amount to damage
                info.damageAmount += info.staggerAmount;
            }
            return base.TakeDamage(info);
        }

        public override void OnExecutionHit()
        {
            // Execution = Instant Explosion
            Die();
        }

        protected override void Die()
        {
            // 1. Spawn Hazard
            if (spawnOnDeath)
            {
                PoolManager.Instance.Spawn(spawnOnDeath, transform.position, Quaternion.identity);
            }

            // 2. VFX
            if (VFXManager.Instance)
            {
                PoolManager.Instance.Spawn(VFXManager.Instance.explosionPrefab, transform.position, Quaternion.identity);
            }

            // 3. Despawn Self
            PoolManager.Instance.Despawn(gameObject);
        }
    }
}