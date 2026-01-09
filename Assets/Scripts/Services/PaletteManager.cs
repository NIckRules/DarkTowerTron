using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Services;
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Services
{
    [ExecuteAlways]
    public class PaletteManager : MonoBehaviour
    {
        public static PaletteManager Instance;

        // --- NEW: Restore the Event ---
        public event Action OnPaletteChanged;

        [Header("Active Configuration")]
        public ColorPaletteSO activePalette;
        public string activeVariant = "";

        [Header("Material Bindings")]
        public List<SurfaceBinding> bindings;

        [System.Serializable]
        public struct SurfaceBinding
        {
            // Legacy (string-based) surface name. Kept for migration/backward compatibility.
            [HideInInspector] public string surfaceName;

            [FormerlySerializedAs("surfaceType")]
            public SurfaceType type;
            public MaterialCollectionSO collection;
        }

        [Header("Debug")]
        public bool refreshNow = false;

        private void Awake()
        {
            if (Application.isPlaying)
            {
                if (Instance == null) Instance = this;
                else Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        private void Update()
        {
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
        }

        public void SetVariant(string variantName)
        {
            activeVariant = variantName;
            ApplyPalette();
        }

        public void ApplyPalette()
        {
            if (activePalette == null) return;

            // 1. Apply Surfaces
            foreach (var binding in bindings)
            {

                GameLogger.Log(LogChannel.VFX, $"Applying Surface: {binding.type} to Collection: {binding.collection?.name}", gameObject);

                if (binding.collection == null) continue;

                // Pass the Enum
                SurfaceDefinition def = activePalette.GetSurface(binding.type, activeVariant);
                ApplyToCollection(binding.collection, def);
            }

            // 2. Apply Globals
            if (Camera.main != null)
            {
                // URP: This sets the "Background Type" to Solid Color
                Camera.main.clearFlags = CameraClearFlags.SolidColor;
                Camera.main.backgroundColor = activePalette.skyColor;
            }

            // 3. Apply Fog (The Infinite Void)
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.ExponentialSquared; // Best for "Void" look
            RenderSettings.fogColor = activePalette.skyColor;
            RenderSettings.fogDensity = activePalette.fogDensity;

            // 4. Notify Listeners (PaletteReceiver)
            OnPaletteChanged?.Invoke(); // <--- RESTORED

            GameLogger.Log(LogChannel.VFX, $"Palette Applied: {activePalette.name} [{activeVariant}]", gameObject);
        }

        private void ApplyToCollection(MaterialCollectionSO col, SurfaceDefinition def)
        {
            if (col.materials == null) return;

            foreach (Material mat in col.materials)
            {
                if (mat == null) continue;

                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", def.mainColor);
                else if (mat.HasProperty("_Color")) mat.SetColor("_Color", def.mainColor);

                if (mat.HasProperty("_EmissionColor"))
                {
                    mat.SetColor("_EmissionColor", def.emissionColor);
                    mat.EnableKeyword("_EMISSION");
                }
                else if (mat.HasProperty("_GlowColor"))
                {
                    Color hdrGlow = def.emissionColor * Mathf.LinearToGammaSpace(def.emissionIntensity > 0 ? def.emissionIntensity : 1f);
                    mat.SetColor("_GlowColor", hdrGlow);
                }

                if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", def.smoothness);
                if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", def.metallic);
            }
        }
    }
}