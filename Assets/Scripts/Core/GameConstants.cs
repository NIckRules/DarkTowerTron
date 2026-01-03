using UnityEngine;

namespace DarkTowerTron.Core
{
    public static class GameConstants
    {
        // ========================================================================
        // 🏷️ TAGS
        // ========================================================================
        public const string TAG_PLAYER = "Player";
        public const string TAG_ENEMY = "Enemy";
        public const string TAG_PROJECTILE = "Projectile";
        public const string TAG_UNTAGGED = "Untagged";

        // ========================================================================
        // 🧱 LAYERS (Indices - for gameObject.layer check)
        // ========================================================================
        // Note: These must match your Project Settings -> Tags and Layers
        public static readonly int LAYER_DEFAULT = LayerMask.NameToLayer("Default");
        public static readonly int LAYER_TRANSPARENT_FX = LayerMask.NameToLayer("TransparentFX");
        public static readonly int LAYER_IGNORE_RAYCAST = LayerMask.NameToLayer("Ignore Raycast");
        public static readonly int LAYER_WATER = LayerMask.NameToLayer("Water");
        public static readonly int LAYER_UI = LayerMask.NameToLayer("UI");
        
        // Custom Layers
        public static readonly int LAYER_PLAYER = LayerMask.NameToLayer("Player");
        public static readonly int LAYER_ENEMY = LayerMask.NameToLayer("Enemy");
        public static readonly int LAYER_PROJECTILE = LayerMask.NameToLayer("Projectile");
        public static readonly int LAYER_WALL = LayerMask.NameToLayer("Wall");
        public static readonly int LAYER_GROUND = LayerMask.NameToLayer("Ground");

        // ========================================================================
        // 🎭 MASKS (Bitmasks - for Physics.Raycast / OverlapSphere)
        // ========================================================================
        
        // Used by Player Movement / KinematicMover
        // What stops a character from walking? (Walls + Floor + Default objects)
        public static readonly int MASK_PHYSICS_OBSTACLES = LayerMask.GetMask("Default", "Wall", "Ground");

        // Used by Projectiles / Shooting
        // What stops a bullet? (Walls + Default + Players + Enemies)
        // Note: Ground is usually excluded if bullets fly high, included if they can hit floor.
        // Let's stick to the mask we defined in Session 4.
        public static readonly int MASK_PROJECTILE_COLLISION = LayerMask.GetMask("Default", "Wall", "Player", "Enemy");

        // Used by Wall Detection (Pushback)
        public static readonly int MASK_WALLS = LayerMask.GetMask("Default", "Wall");

        // Used by "Safe Ground" checks (Falling into void)
        public static readonly int MASK_GROUND_ONLY = LayerMask.GetMask("Ground");
        
        // Used by Enemy AI (Line of Sight)
        public static readonly int MASK_SIGHT_BLOCKING = LayerMask.GetMask("Default", "Wall", "Ground");
    }
}