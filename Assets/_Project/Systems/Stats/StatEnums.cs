namespace DarkTowerTron.Systems.Stats
{
    public enum StatType
    {
        MoveSpeed,
        Acceleration,
        DashCooldown,
        MaxGrit,
        GunDamage,
        BeamDamage,
        // Add more here as needed (e.g., FireRate, Luck)
    }

    public enum AbilityType
    {
        None,
        Dodge_Reflect,         // Mirror Engine
        Melee_Parry,           // Kinetic Deflector
        Dodge_ExplosiveDecoy,  // (Future)
        Passive_HoverDrive     // (Future)
    }

    public enum ModifierType
    {
        Additive,       // +1 Damage
        Multiplicative  // +10% Speed
    }
}