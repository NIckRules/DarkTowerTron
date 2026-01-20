using UnityEngine;
using System.Collections.Generic;

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
        [HideInInspector] public string surfaceName; // Legacy
        public SurfaceType surfaceType;
        public SurfaceDefinition definition;
    }

    [System.Serializable]
    public class PaletteVariant
    {
        public string variantName;
        public List<SurfaceOverride> overrides;
    }
}