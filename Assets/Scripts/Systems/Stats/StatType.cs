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
        // Add more as needed
    }

    public enum AbilityType
    {
        None,
        Dodge_Reflect,
        Dodge_ExplosiveDecoy,
        Melee_Parry,
        Passive_HoverDrive
    }

    public enum ModifierType
    {
        Additive,       // +1 Damage
        Multiplicative  // +10% Speed
    }
}