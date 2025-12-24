namespace DarkTowerTron.Core
{
    public interface IDamageable
    {
        bool TakeDamage(DamageInfo info);
        void Kill(bool instant);
    }
}