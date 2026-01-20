using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Visuals;

namespace DarkTowerTron.Gameplay.Visuals
{
    [ExecuteAlways]
    public class PaletteReceiver : MonoBehaviour
    {
        public enum ActorType { Player, Enemy }

        [Header("Configuration")]
        public ActorType actorType = ActorType.Enemy;
        public ActorThemeSO themeOverride;

        [Header("Renderer Bindings")]
        public List<Renderer> primaryRenderers;
        public List<Renderer> secondaryRenderers;
        public List<Renderer> tertiaryRenderers;

        private MaterialPropertyBlock _propBlock;

        private void OnEnable()
        {
            if (TryGetPaletteService(out var service))
            {
                service.OnPaletteChanged += ApplyTheme;
            }
        }

        private void OnDisable()
        {
            if (TryGetPaletteService(out var service))
            {
                service.OnPaletteChanged -= ApplyTheme;
            }
        }

        private void Start() => ApplyTheme();

        public void ManualRefresh() => ApplyTheme();

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
            if (!TryGetPaletteService(out var service) || service.ActivePalette == null) return;

            var global = service.ActivePalette;

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

                // Use the data to populate PropertyBlock
                // Note: We duplicate logic slightly here because PropertyBlocks 
                // use different API than Material.SetColor, but the keys are the same.

                if (HasProp(r, "_BaseColor")) _propBlock.SetColor("_BaseColor", surf.mainColor);
                else if (HasProp(r, "_Color")) _propBlock.SetColor("_Color", surf.mainColor);

                if (HasProp(r, "_EmissionColor")) _propBlock.SetColor("_EmissionColor", surf.emissionColor);

                if (HasProp(r, "_Smoothness")) _propBlock.SetFloat("_Smoothness", surf.smoothness);
                if (HasProp(r, "_Metallic")) _propBlock.SetFloat("_Metallic", surf.metallic);

                r.SetPropertyBlock(_propBlock);
            }
        }

        // Abstraction for Editor vs Runtime retrieval
        private bool TryGetPaletteService(out IPaletteService service)
        {
            // Runtime
            if (ServiceLocator.TryGet(out service)) return true;

            // Editor (Fallback)
            if (!Application.isPlaying)
            {
                service = PaletteService.EditorInstance;
                return service != null;
            }

            service = null;
            return false;
        }

        private bool HasProp(Renderer r, string name)
        {
            if (r.sharedMaterial == null) return false;
            return r.sharedMaterial.HasProperty(name);
        }
    }
}