using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services;
using UnityEngine;

namespace DarkTowerTron.Systems.Visuals
{
    [ExecuteAlways]
    public class PaletteService : MonoBehaviour, IPaletteService
    {
        // Singleton for Editor Mode ONLY
        public static PaletteService EditorInstance { get; private set; }

        public event Action OnPaletteChanged;

        [Header("State")]
        [SerializeField] private PaletteDefinitionSO _activePalette;
        [SerializeField] private string _activeVariant = "";

        public PaletteDefinitionSO ActivePalette => _activePalette;
        public string ActiveVariant => _activeVariant;

        [Header("Material Bindings")]
        public List<SurfaceBinding> bindings;

        [System.Serializable]
        public struct SurfaceBinding
        {
            public SurfaceType type;
            public MaterialCollectionSO collection;
        }

        [Header("Debug")]
        public bool refreshNow = false;

        private void OnEnable()
        {
            if (Application.isPlaying)
            {
                ServiceLocator.Register<IPaletteService>(this);
            }
            else
            {
                EditorInstance = this;
            }
        }

        private void OnDisable()
        {
            if (Application.isPlaying)
            {
                // FIX: Used to be Deregister, now Unregister (or the alias handles it)
                ServiceLocator.Unregister<IPaletteService>(this);
            }
            else
            {
                if (EditorInstance == this) EditorInstance = null;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        private void Update()
        {
#if UNITY_EDITOR
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
#endif
        }

        public void SetVariant(string variantName)
        {
            if (_activeVariant == variantName) return;
            _activeVariant = variantName;
            ApplyPalette();
        }

        public void Refresh() => ApplyPalette();

        public SurfaceDefinition GetSurface(SurfaceType type)
        {
            if (_activePalette == null) return new SurfaceDefinition();
            return _activePalette.GetSurface(type, _activeVariant);
        }

        private void ApplyPalette()
        {
            if (_activePalette == null) return;

            // Only log if we have the logger, avoiding circular dependencies in early init
            // GameLogger.Log(LogChannel.VFX, ...); 

            foreach (var binding in bindings)
            {
                if (binding.collection == null) continue;
                SurfaceDefinition def = GetSurface(binding.type);
                ApplyToCollection(binding.collection, def);
            }

            OnPaletteChanged?.Invoke();
        }

        private void ApplyToCollection(MaterialCollectionSO col, SurfaceDefinition def)
        {
            if (col.materials == null) return;

            foreach (Material mat in col.materials)
            {
                if (mat == null) continue;
                ApplyDefinitionToMaterial(mat, def);
            }
        }

        public static void ApplyDefinitionToMaterial(Material mat, SurfaceDefinition def)
        {
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