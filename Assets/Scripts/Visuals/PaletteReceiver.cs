using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Services;      // NEW: Where PaletteManager lives
using DarkTowerTron.Core.Services; // NEW: For ServiceLocator

namespace DarkTowerTron.Visuals
{
    [ExecuteAlways]
    public class PaletteReceiver : MonoBehaviour
    {
        public enum ActorType { Player, Enemy }

        [Header("Configuration")]
        public ActorType actorType = ActorType.Enemy;

        [Header("Override (Optional)")]
        [Tooltip("Leave empty to use Global Default.")]
        public ActorThemeSO themeOverride;

        [Header("Renderer Bindings")]
        public List<Renderer> primaryRenderers;
        public List<Renderer> secondaryRenderers;
        public List<Renderer> tertiaryRenderers;

        private MaterialPropertyBlock _propBlock;

        // --- LIFECYCLE ---

        private void OnEnable()
        {
            if (TryGetManager(out var pm))
                pm.OnPaletteChanged += ApplyTheme;
        }

        private void OnDisable()
        {
            // Safety check prevents errors on quit
            if (TryGetManager(out var pm))
                pm.OnPaletteChanged -= ApplyTheme;
        }

        private void Start()
        {
            ApplyTheme();
        }

        public void ManualRefresh() => ApplyTheme();

        // --- LOGIC ---

        private void ApplyTheme()
        {
            if (_propBlock == null) _propBlock = new MaterialPropertyBlock();

            // 1. CASE A: Use Local Override
            if (themeOverride != null)
            {
                ApplySurfaceToList(primaryRenderers, themeOverride.primary);
                ApplySurfaceToList(secondaryRenderers, themeOverride.secondary);
                ApplySurfaceToList(tertiaryRenderers, themeOverride.tertiary);
                return;
            }

            // 2. CASE B: Use Global Service
            // We use TryGetManager helper to handle both Runtime (Services) and Editor (Instance)
            if (!TryGetManager(out var pm) || pm.activePalette == null) return;

            var global = pm.activePalette;

            if (actorType == ActorType.Player)
            {
                ApplySurfaceToList(primaryRenderers, global.playerPrimary);
                ApplySurfaceToList(secondaryRenderers, global.playerSecondary);
                ApplySurfaceToList(tertiaryRenderers, global.playerTertiary);
            }
            else // Enemy
            {
                ApplySurfaceToList(primaryRenderers, global.enemyPrimary);
                ApplySurfaceToList(secondaryRenderers, global.enemySecondary);
                ApplySurfaceToList(tertiaryRenderers, global.enemyTertiary);
            }
        }

        private void ApplySurfaceToList(List<Renderer> rends, SurfaceDefinition surf)
        {
            foreach (var r in rends)
            {
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Set Color
                if (HasProp(r, "_BaseColor")) _propBlock.SetColor("_BaseColor", surf.mainColor);
                else if (HasProp(r, "_Color")) _propBlock.SetColor("_Color", surf.mainColor);

                // Set Emission
                if (HasProp(r, "_EmissionColor")) 
                    _propBlock.SetColor("_EmissionColor", surf.emissionColor);

                // Set Physics
                if (HasProp(r, "_Smoothness")) _propBlock.SetFloat("_Smoothness", surf.smoothness);
                if (HasProp(r, "_Metallic")) _propBlock.SetFloat("_Metallic", surf.metallic);

                r.SetPropertyBlock(_propBlock);
            }
        }

        /// <summary>
        /// Helper to find the manager safely in both Play Mode and Editor Mode.
        /// </summary>
        private bool TryGetManager(out PaletteManager pm)
        {
            // 1. Runtime: Use Service Locator (Safe, no singleton dependency)
            if (ServiceLocator.TryGet(out pm)) return true;

            // 2. Editor Mode: Use the static Instance (Legacy support for ExecuteAlways)
            if (!Application.isPlaying)
            {
                pm = PaletteManager.Instance;
                return pm != null;
            }

            return false;
        }

        /// <summary>
        /// CRITICAL FIX: Actually checks the material properties.
        /// </summary>
        private bool HasProp(Renderer r, string name)
        {
            if (r.sharedMaterial == null) return false;
            return r.sharedMaterial.HasProperty(name);
        }
    }
}