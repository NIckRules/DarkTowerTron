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
        public static readonly int LAYER_HITBOX = LayerMask.NameToLayer("Hitbox");
        public static readonly int LAYER_WALL = LayerMask.NameToLayer("Wall");
        public static readonly int LAYER_GROUND = LayerMask.NameToLayer("Ground");

        // ========================================================================
        // 🎭 MASKS (Bitmasks - for Physics.Raycast / OverlapSphere)
        // ========================================================================
        
        // 1. Movement: Can I walk here?
        // EXCLUDES 'Hitbox' and 'Enemy'. Enemies should not treat other enemies as static walls.
        // They should overlap and let 'EnemyMotor' separation handle the spacing.
        public static readonly int MASK_PHYSICS_OBSTACLES = LayerMask.GetMask("Default", "Wall", "Ground");

        // 2. Projectiles: What do I hit?
        // INCLUDES 'Hitbox' (Shoot the arm) and 'Enemy' (Shoot the capsule)
        public static readonly int MASK_PROJECTILE_COLLISION = LayerMask.GetMask("Default", "Wall", "Player", "Enemy", "Hitbox");

        // Used by Wall Detection (Pushback)
        public static readonly int MASK_WALLS = LayerMask.GetMask("Default", "Wall");

        // Used by "Safe Ground" checks (Falling into void)
        public static readonly int MASK_GROUND_ONLY = LayerMask.GetMask("Ground");
        
        // 3. Sight/AI: What blocks vision?
        // Usually just Walls and Ground. We don't want an enemy to block another enemy's view of the player.
        public static readonly int MASK_SIGHT_BLOCKING = LayerMask.GetMask("Default", "Wall", "Ground");
    }
}