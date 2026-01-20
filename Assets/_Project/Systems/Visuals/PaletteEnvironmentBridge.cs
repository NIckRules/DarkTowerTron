using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    [RequireComponent(typeof(Camera))]
    public class PaletteEnvironmentBridge : MonoBehaviour
    {
        private Camera _cam;

        private void Awake()
        {
            _cam = GetComponent<Camera>();
        }

        private void OnEnable()
        {
            // Wait for service to be ready
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                paletteService.OnPaletteChanged += UpdateEnvironment;
                // Update immediately if service is already running
                UpdateEnvironment();
            }
            else
            {
                // Retry in Start or via a Global Event if ServiceLocator isn't ready in Awake
                // For this example, we'll assume Service init order is handled or we check in Start
            }
        }

        private void Start()
        {
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                // Ensure we are subscribed
                paletteService.OnPaletteChanged -= UpdateEnvironment;
                paletteService.OnPaletteChanged += UpdateEnvironment;
                UpdateEnvironment();
            }
        }

        private void OnDisable()
        {
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                paletteService.OnPaletteChanged -= UpdateEnvironment;
            }
        }

        private void UpdateEnvironment()
        {
            if (!ServiceLocator.TryGet(out IPaletteService service)) return;

            var palette = service.ActivePalette;
            if (palette == null) return;

            // 1. Camera Background
            if (_cam != null)
            {
                _cam.clearFlags = CameraClearFlags.SolidColor;
                _cam.backgroundColor = palette.skyColor;
            }

            // 2. Global Fog
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.ExponentialSquared;
            RenderSettings.fogColor = palette.skyColor;
            RenderSettings.fogDensity = palette.fogDensity;
        }
    }
}