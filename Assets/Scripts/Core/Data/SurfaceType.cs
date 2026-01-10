namespace DarkTowerTron.Core.Data
{
    public enum SurfaceType
    {

        None = 0, // <--- ADD THIS. Acts as a "Null" safety.

        // Actors
        PlayerPrimary,
        PlayerSecondary,
        PlayerTertiary,

        EnemyPrimary,
        EnemySecondary,
        EnemyTertiary,

        // Combat
        ProjectileHostile,
        ProjectileFriendly,
        ProjectileParryable,
        BeamAttack,
        BlitzReady,
        BlitzCooldown,

        // Environment
        Floor,
        Walls,
        Hazards,
        VoidZone,
        Anchor,

        // UI/VFX
        UI_Main,
        VFX_General
    }
}