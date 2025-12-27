using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public struct SurfaceDefinition
    {
        [ColorUsage(true, true)] public Color mainColor;
        [Range(0f, 1f)] public float smoothness;
        [Range(0f, 1f)] public float metallic;
        
        [ColorUsage(true, true)] public Color emissionColor;
        [Tooltip("How bright is the emission? (Use HDR)")]
        public float emissionIntensity;
    }

    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class ColorPaletteSO : ScriptableObject
    {
        [Header("Player Theme")]
        public SurfaceDefinition playerPrimary;   // Body
        public SurfaceDefinition playerSecondary; // Visor / Details
        public SurfaceDefinition playerTertiary;  // Lights / Engine

        [Header("Enemy Theme")]
        public SurfaceDefinition enemyPrimary;    // Body (Red)
        public SurfaceDefinition enemySecondary;  // Joints (Grey/Dark)
        public SurfaceDefinition enemyTertiary;   // Eyes / Cores (Bright)

        // Keep legacy references for PaletteReceiver defaults
        // We can construct ActorThemeSO at runtime or just reference these values directly
        // For simplicity, PaletteManager will read these specific fields.

        [Header("Combat")]
        public SurfaceDefinition projectileHostile;
        public SurfaceDefinition projectileFriendly;
        [ColorUsage(true, true)] public Color staggerColor = Color.yellow;

        [Header("Environment")]
        public SurfaceDefinition floor;
        public SurfaceDefinition walls;
        public SurfaceDefinition hazards;

        [Header("Global")]
        public Color skyColor = Color.black;
    }
}