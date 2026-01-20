namespace DarkTowerTron.Gameplay.Combat
{
    public interface IDamageable
    {
        void TakeDamage(DamageInfo info); // Void return type is standard for Event-Driven
        void Kill(bool immediate);
        bool IsDead { get; }
    }

}