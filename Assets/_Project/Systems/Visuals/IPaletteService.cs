using System;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    public interface IPaletteService : IGameService
    {
        event Action OnPaletteChanged;

        PaletteDefinitionSO ActivePalette { get; }
        string ActiveVariant { get; }

        void SetVariant(string variantName);
        void Refresh();

        // Helper to get a specific surface definition without needing the SO directly
        SurfaceDefinition GetSurface(SurfaceType type);
    }
}