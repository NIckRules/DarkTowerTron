using UnityEngine;
using DG.Tweening;
using System.Collections;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Visuals; // Access IPaletteService

namespace DarkTowerTron.Gameplay.Enemies
{
    public class EnemyVisuals : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Leave EMPTY to use the Global Palette.")]
        public PaletteDefinitionSO paletteOverride;

        [Tooltip("Defines timing and animation curves. Required.")]
        public EnemyVisualProfileSO profile;

        [Header("References")]
        [Tooltip("Assign all mesh parts here. If empty, auto-finds in children.")]
        [SerializeField] private Renderer[] _renderers;

        // Internal
        private MaterialPropertyBlock _propBlock;
        private static readonly int BaseColorID = Shader.PropertyToID("_BaseColor");
        private static readonly int EmissionColorID = Shader.PropertyToID("_EmissionColor");

        // State
        private Color[] _baseColors; // Snapshot of original colors per renderer
        private Color _staggerColor;
        private Color _hitColor;
        private Tween _flashTween;

        private void Awake()
        {
            // Auto-find if not assigned
            if (_renderers == null || _renderers.Length == 0)
                _renderers = GetComponentsInChildren<Renderer>();

            if (_renderers.Length == 0)
            {
                GameLogger.LogWarning(LogChannel.AI, $"[EnemyVisuals] No Renderers found on {name}", gameObject);
            }

            _baseColors = new Color[_renderers.Length];
            _propBlock = new MaterialPropertyBlock();
        }

        private void Start()
        {
            if (profile == null)
            {
                GameLogger.LogError(LogChannel.AI, $"[EnemyVisuals] Profile missing on {gameObject.name}.", gameObject);
                enabled = false;
                return;
            }

            // We wait one frame to ensure PaletteReceiver has finished applying the theme colors.
            StartCoroutine(InitializeColorsNextFrame());
        }

        private IEnumerator InitializeColorsNextFrame()
        {
            yield return null; 
            InitializeColors();
        }

        public void InitializeColors()
        {
            // 1. Resolve Palette Settings
            PaletteDefinitionSO activePalette = paletteOverride;
            
            // Try to get Global Palette if override is missing
            if (activePalette == null)
            {
                try 
                {
                    var service = ServiceLocator.Get<IPaletteService>();
                    if (service != null) activePalette = service.ActivePalette;
                }
                catch { /* Service might not exist in test scenes */ }
            }

            if (activePalette != null)
            {
                _staggerColor = activePalette.staggerColor;
                _hitColor = activePalette.hitFlashColor;
            }
            else
            {
                // Fallback Defaults
                _staggerColor = Color.yellow;
                _hitColor = Color.white;
            }

            // 2. Snapshot current state (The colors set by PaletteReceiver)
            for (int i = 0; i < _renderers.Length; i++)
            {
                Renderer r = _renderers[i];
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Prioritize PropertyBlock color (set by Receiver), then Material color
                if (!_propBlock.isEmpty && _propBlock.GetColor(BaseColorID) != Color.clear)
                {
                    _baseColors[i] = _propBlock.GetColor(BaseColorID);
                }
                else if (r.sharedMaterial != null && r.sharedMaterial.HasProperty(BaseColorID))
                {
                    _baseColors[i] = r.sharedMaterial.GetColor(BaseColorID);
                }
                else
                {
                    _baseColors[i] = Color.white;
                }
            }
        }

        // --- VISUAL FX METHODS ---

        public void PlayHitFlash()
        {
            if (profile == null) return;
            KillTween();

            // Flash all parts to pure White (or HitColor)
            SetAllColors(_hitColor);

            _flashTween = DOVirtual.DelayedCall(profile.hitFlashDuration, ResetVisuals);
        }

        public void StartStaggerEffect()
        {
            if (profile == null) return;
            KillTween();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, profile.staggerPulseDuration / 2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopStaggerEffect() => ResetVisuals();

        public void StartPrimingEffect()
        {
            if (profile == null) return;
            KillTween();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, 0.1f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    // Pulse between Base Color[0] and Danger Color
                    Color baseC = GetBaseColorSafe(0);
                    Color c = Color.Lerp(baseC, profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopPrimingEffect() => ResetVisuals();

        public void ResetVisuals()
        {
            KillTween();

            // Restore individual base colors
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], _baseColors[i]);
            }
        }

        // --- HELPERS ---

        private void KillTween()
        {
            if (_flashTween != null && _flashTween.IsActive()) _flashTween.Kill();
        }

        private void SetAllColors(Color c)
        {
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], c);
            }
        }

        private void ApplyColorToRenderer(Renderer r, Color c)
        {
            if (r == null) return;
            
            r.GetPropertyBlock(_propBlock);
            _propBlock.SetColor(BaseColorID, c);
            
            // Optional: Also boost emission for the flash effect?
            // _propBlock.SetColor(EmissionColorID, c * 1.5f); 
            
            r.SetPropertyBlock(_propBlock);
        }

        private Color GetBaseColorSafe(int index)
        {
            if (_baseColors != null && index < _baseColors.Length)
                return _baseColors[index];
            return Color.white;
        }

        private void OnDestroy()
        {
            KillTween();
        }
    }
}