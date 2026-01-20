using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewVariantConfig", menuName = "DarkTowerTron/Visuals/Palette Variant Config")]
    public class PaletteVariantConfigSO : ScriptableObject
    {
        [Tooltip("The ID used by code to activate this variant (e.g. 'Enraged', 'Phase2').")]
        public string variantName;

        [Tooltip("List of surfaces to override when this variant is active.")]
        public List<SurfaceOverride> overrides;

        /// <summary>
        /// Helper to find a specific override in this config.
        /// </summary>
        public bool TryGetOverride(SurfaceType type, out SurfaceDefinition definition)
        {
            // Iterate linearly (List is usually small, < 10 items)
            // For very large lists, we would cache this into a Dictionary on Enable.
            foreach (var ov in overrides)
            {
                if (ov.surfaceType == type)
                {
                    definition = ov.definition;
                    return true;
                }
            }

            definition = default;
            return false;
        }
    }
}