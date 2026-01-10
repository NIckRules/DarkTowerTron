using UnityEngine;
using System.Collections.Generic;
using System;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public struct SurfaceDefinition
    {
        [ColorUsage(true, true)] public Color mainColor;
        [Range(0f, 1f)] public float smoothness;
        [Range(0f, 1f)] public float metallic;
        
        [ColorUsage(true, true)] public Color emissionColor;
        public float emissionIntensity;
    }

    [System.Serializable]
    public struct SurfaceOverride
    {
        // Legacy (string-based) surface name. Kept for migration/backward compatibility.
        [HideInInspector] public string surfaceName; // e.g., "EnemyTertiary"

        public SurfaceType surfaceType;
        public SurfaceDefinition definition;
    }

    [System.Serializable]
    public class PaletteVariant
    {
        public string variantName; // e.g., "Enraged"
        public List<SurfaceOverride> overrides;
    }

    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class ColorPaletteSO : ScriptableObject
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
        public float fogDensity = 0.02f; // Default "Atmosphere"

        [Header("Variants")]
        public List<PaletteVariant> variants;

        // --- LOGIC ---

        /// <summary>
        /// Returns the base definition, or an override if the active variant has one.
        /// </summary>
        public SurfaceDefinition GetSurface(SurfaceType type, string activeVariantName)
        {
            // 1. Check Variant Override
            if (!string.IsNullOrEmpty(activeVariantName) && variants != null)
            {
                PaletteVariant activeVariant = variants.Find(v => v.variantName == activeVariantName);
                if (activeVariant != null && activeVariant.overrides != null)
                {
                    // Find specific override
                    int index = activeVariant.overrides.FindIndex(o => o.surfaceType == type);
                    if (index >= 0) return activeVariant.overrides[index].definition;

                    // Backward compatibility: if the asset still uses legacy strings,
                    // resolve them on the fly.
                    index = activeVariant.overrides.FindIndex(o =>
                        o.surfaceType == SurfaceType.None &&
                        TryParseSurfaceType(o.surfaceName, out var parsed) &&
                        parsed == type);
                    if (index >= 0) return activeVariant.overrides[index].definition;
                }
            }

            // 2. Return Base
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
                    return new SurfaceDefinition();
            }
        }

        private static bool TryParseSurfaceType(string surfaceName, out SurfaceType type)
        {
            if (string.IsNullOrWhiteSpace(surfaceName))
            {
                type = SurfaceType.None;
                return false;
            }

            return Enum.TryParse(surfaceName.Trim(), true, out type) && type != SurfaceType.None;
        }

        private void OnValidate()
        {
            // Migrate legacy string overrides into enum values.
            if (variants == null) return;

            for (int variantIndex = 0; variantIndex < variants.Count; variantIndex++)
            {
                PaletteVariant variant = variants[variantIndex];
                if (variant == null || variant.overrides == null) continue;

                bool changed = false;
                for (int overrideIndex = 0; overrideIndex < variant.overrides.Count; overrideIndex++)
                {
                    SurfaceOverride ov = variant.overrides[overrideIndex];
                    if (ov.surfaceType == SurfaceType.None && TryParseSurfaceType(ov.surfaceName, out var parsed))
                    {
                        ov.surfaceType = parsed;
                        variant.overrides[overrideIndex] = ov;
                        changed = true;
                    }
                }

                if (changed)
                {
                    variants[variantIndex] = variant;
                }
            }
        }
    }
}