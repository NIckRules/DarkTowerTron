using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public class StandardHitbox : BaseHitbox
    {
        public float damageMultiplier = 1.0f; 

        public override bool TakeDamage(DamageInfo info)
        {
            info.damageAmount *= damageMultiplier;
            return base.TakeDamage(info);
        }
    }
}