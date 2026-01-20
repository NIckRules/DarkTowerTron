using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public class ShieldHitbox : BaseHitbox
    {
        [Header("Shield Settings")]
        [SerializeField] private float _damageReduction = 0.5f; // 50% damage taken
        [SerializeField] private bool _breakOnHeavyAttack = true;

        // FIX: Override matches new signature
        public override void TakeDamage(DamageInfo info)
        {
            // Shield Logic: 
            // If the shield is "Active" (optional check), reduce damage.

            // Example: Block logic
            info.damageAmount *= _damageReduction;

            // Example: If damage is 0 (fully blocked), we might want to spawn sparks here
            if (info.damageAmount <= 0)
            {
                // Play Block Sound/VFX
                return;
            }

            // Pass modified info to Base (which forwards to MainReceiver)
            base.TakeDamage(info);
        }
    }
}