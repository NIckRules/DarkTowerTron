using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    // A simple pass-through hitbox, essentially the same as BaseHitbox 
    // but kept if you have specific logic in your project.
    public class StandardHitbox : BaseHitbox
    {
        public override void TakeDamage(DamageInfo info)
        {
            // Just call base behavior
            base.TakeDamage(info);
        }
    }
}