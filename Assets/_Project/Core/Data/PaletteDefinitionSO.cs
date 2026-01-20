using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class PaletteDefinitionSO : ScriptableObject
    {
        [Header("Player Theme")]
        public SurfaceDefinition playerPrimary;
        public SurfaceDefinition playerSecondary;
        public SurfaceDefinition playerTertiary;

        [Header("Enemy Theme")]
        public SurfaceDefinition enemyPrimary;
        public SurfaceDefinition enemySecondary;
        public SurfaceDefinition enemyTertiary;

        [Header("Combat & FX")]
        public SurfaceDefinition projectileHostile;
        public SurfaceDefinition projectileFriendly;
        public SurfaceDefinition projectileParryable;
        public SurfaceDefinition beamAttack;
        public SurfaceDefinition blitzReady;
        public SurfaceDefinition blitzCooldown;

        [Header("Feedback")]
        [ColorUsage(true, true)] public Color hitFlashColor = Color.white;
        [ColorUsage(true, true)] public Color staggerColor = Color.yellow;

        [Header("Environment")]
        public SurfaceDefinition floor;
        public SurfaceDefinition walls;
        public SurfaceDefinition hazards;
        public SurfaceDefinition voidZone;
        public SurfaceDefinition anchor;

        [Header("Global Environment")]
        public Color skyColor = Color.black;

        [Range(0f, 0.1f)]
        public float fogDensity = 0.02f;

        [Header("Variants")]
        [Tooltip("Drop PaletteVariantConfigSO assets here (e.g. 'Enraged', 'LowHealth').")]
        public List<PaletteVariantConfigSO> variants;

        // --- LOGIC ---

        public SurfaceDefinition GetSurface(SurfaceType type, string activeVariantName)
        {
            // 1. Check for Active Variant Override
            if (!string.IsNullOrEmpty(activeVariantName) && variants != null)
            {
                // Find the matching Config SO
                var activeConfig = variants.Find(v => v != null && v.variantName == activeVariantName);

                if (activeConfig != null)
                {
                    if (activeConfig.TryGetOverride(type, out var overrideDef))
                    {
                        return overrideDef;
                    }
                }
            }

            // 2. Return Base Surface (Default)
            return GetBaseSurface(type);
        }

        private SurfaceDefinition GetBaseSurface(SurfaceType type)
        {
            switch (type)
            {
                case SurfaceType.None: return new SurfaceDefinition();

                case SurfaceType.PlayerPrimary: return playerPrimary;
                case SurfaceType.PlayerSecondary: return playerSecondary;
                case SurfaceType.PlayerTertiary: return playerTertiary;

                case SurfaceType.EnemyPrimary: return enemyPrimary;
                case SurfaceType.EnemySecondary: return enemySecondary;
                case SurfaceType.EnemyTertiary: return enemyTertiary;

                case SurfaceType.ProjectileHostile: return projectileHostile;
                case SurfaceType.ProjectileFriendly: return projectileFriendly;
                case SurfaceType.BeamAttack: return beamAttack;
                case SurfaceType.BlitzReady: return blitzReady;
                case SurfaceType.BlitzCooldown: return blitzCooldown;

                case SurfaceType.Floor: return floor;
                case SurfaceType.Walls: return walls;
                case SurfaceType.Hazards: return hazards;
                case SurfaceType.VoidZone: return voidZone;
                case SurfaceType.Anchor: return anchor;

                default:
                    // Return a "Error Magenta" or blank definition if not found
                    return new SurfaceDefinition();
            }
        }
    }
}