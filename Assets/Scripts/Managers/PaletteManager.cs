using UnityEngine;
using System;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // For Receiver

namespace DarkTowerTron.Managers
{
    [ExecuteAlways]
    public class PaletteManager : MonoBehaviour
    {
        public static PaletteManager Instance;
        public ColorPaletteSO activePalette;

        // Event for Receivers
        public event Action OnPaletteChanged;

        [Header("Actor Collections")]
        public MaterialCollectionSO playerPrimaryCols;
        public MaterialCollectionSO playerSecondaryCols;
        public MaterialCollectionSO playerTertiaryCols;

        public MaterialCollectionSO enemyPrimaryCols;
        public MaterialCollectionSO enemySecondaryCols;
        public MaterialCollectionSO enemyTertiaryCols;

        [Header("Environment Collections")]
        public MaterialCollectionSO floorCols;
        public MaterialCollectionSO wallCols;
        public MaterialCollectionSO hazardCols;
        public MaterialCollectionSO projectileHostileCols;
        public MaterialCollectionSO projectileFriendlyCols;

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
                // In Editor mode, allow temporary instance
                Instance = this;
            }
        }

        private void Update()
        {
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        public void ApplyPalette()
        {
            if (activePalette == null) return;

            // 1. Player (Global Materials)
            ApplySurface(playerPrimaryCols, activePalette.playerPrimary);
            ApplySurface(playerSecondaryCols, activePalette.playerSecondary);
            ApplySurface(playerTertiaryCols, activePalette.playerTertiary);

            // 2. Enemies (Global Materials)
            ApplySurface(enemyPrimaryCols, activePalette.enemyPrimary);
            ApplySurface(enemySecondaryCols, activePalette.enemySecondary);
            ApplySurface(enemyTertiaryCols, activePalette.enemyTertiary);

            // 3. Environment (Global Materials)
            ApplySurface(floorCols, activePalette.floor);
            ApplySurface(wallCols, activePalette.walls);
            ApplySurface(hazardCols, activePalette.hazards);
            ApplySurface(projectileHostileCols, activePalette.projectileHostile);
            ApplySurface(projectileFriendlyCols, activePalette.projectileFriendly);

            if (Camera.main)
                Camera.main.backgroundColor = activePalette.skyColor;

            // 2. Notify Actors (Local Property Blocks)
            OnPaletteChanged?.Invoke();

            // Force update editor-time receivers
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                var receivers = FindObjectsOfType<PaletteReceiver>();
                foreach (var r in receivers) r.ManualRefresh();
            }
#endif

            Debug.Log($"Palette Applied: {activePalette.name}");
        }

        // ApplySurface helper remains the same...
        private void ApplySurface(MaterialCollectionSO collection, SurfaceDefinition surf)
        {
            if (collection == null || collection.materials == null) return;
            foreach (var mat in collection.materials)
            {
                if (mat == null) continue;
                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", surf.mainColor);
                if (mat.HasProperty("_EmissionColor")) mat.SetColor("_EmissionColor", surf.mainColor);
                if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", surf.smoothness);
                if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", surf.metallic);
            }
        }
    }
}