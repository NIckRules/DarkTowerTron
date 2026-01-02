namespace DarkTowerTron.Core
{
    public enum LogChannel
    {
        General,    // Default
        Player,     // Input, Movement, State
        AI,         // Decisions, State changes, Pathing
        Combat,     // Damage, Projectiles, Hitboxes
        UI,         // Menu navigation, HUD updates
        Physics,    // Collisions, Triggers
        System,     // Wave Manager, Loading, Saving
        VFX         // Particles, Audio
    }
}