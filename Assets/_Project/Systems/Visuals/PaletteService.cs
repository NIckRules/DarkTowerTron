using System;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    [ExecuteAlways]
    public class PaletteService : MonoBehaviour, IPaletteService
    {
        // Singleton for Editor Mode Preview ONLY
        public static PaletteService EditorInstance { get; private set; }

        public event Action OnPaletteChanged;

        [Header("State")]
        [SerializeField] private PaletteDefinitionSO _activePalette;
        [SerializeField] private string _activeVariant = "";

        // --- IPaletteService Implementation ---
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

        private void Awake()
        {
            // Only register in Runtime
            if (Application.isPlaying)
            {
                ServiceLocator.Register<IPaletteService>(this);
            }
        }

        private void OnEnable()
        {
            // Handle Editor Preview Instance
            if (!Application.isPlaying)
            {
                EditorInstance = this;
            }
        }

        private void OnDisable()
        {
            if (Application.isPlaying)
            {
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
            if (mat == null) return;

            // Universal Render Pipeline / Standard Shader Support
            if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", def.mainColor);
            else if (mat.HasProperty("_Color")) mat.SetColor("_Color", def.mainColor);

            if (mat.HasProperty("_EmissionColor"))
            {
                mat.SetColor("_EmissionColor", def.emissionColor);
                mat.EnableKeyword("_EMISSION");
            }

            if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", def.smoothness);
            if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", def.metallic);
        }
    }
}