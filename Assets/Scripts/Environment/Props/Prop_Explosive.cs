using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services;
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
                Services.Pool?.Spawn(spawnOnDeath, transform.position, Quaternion.identity);
            }

            // 2. VFX
            if (Services.VFX != null)
            {
                Services.Pool?.Spawn(Services.VFX.explosionPrefab, transform.position, Quaternion.identity);
            }

            // 3. Despawn Self
            Services.Pool?.Despawn(gameObject);
        }
    }
}