namespace DarkTowerTron.Core.Data
{
    public enum SurfaceType
    {
        None = 0,

        // Player
        PlayerPrimary,
        PlayerSecondary,
        PlayerTertiary,

        // Enemy
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
        Anchor
    }
}