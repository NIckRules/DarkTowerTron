using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems;
using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Enemy.Visuals
{
    public class EnemyVisuals : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Leave EMPTY to use the Global Palette.")]
        [FormerlySerializedAs("palette")]
        public ColorPaletteSO paletteOverride;

        [Tooltip("Defines timing and animation curves. Required.")]
        public EnemyVisualProfileSO profile;

        [Header("References")]
        [Tooltip("Assign all mesh parts here. If empty, auto-finds in children.")]
        [SerializeField] private Renderer[] _renderers;

        // Internal
        private MaterialPropertyBlock _propBlock;
        private int _colorPropID;
        private int _emissionPropID;

        // State
        private Color[] _baseColors; // Snapshot of original colors per renderer
        private Color _staggerColor;
        private Color _hitColor;
        private Tween _flashTween;

        private void Awake()
        {
            // Auto-find if not assigned (Convenience)
            if (_renderers == null || _renderers.Length == 0)
                _renderers = GetComponentsInChildren<Renderer>();

            // Validate
            if (_renderers.Length == 0)
            {
                // Warn but don't crash, logic will just loop 0 times
                GameLogger.LogWarning(LogChannel.AI, $"[EnemyVisuals] No Renderers found on {name}", gameObject);
            }

            _baseColors = new Color[_renderers.Length];
            _propBlock = new MaterialPropertyBlock();

            _colorPropID = Shader.PropertyToID("_BaseColor");
            _emissionPropID = Shader.PropertyToID("_EmissionColor");
        }

        private void Start()
        {
            if (profile == null)
            {
                GameLogger.LogError(LogChannel.AI, $"[EnemyVisuals] Profile missing on {gameObject.name}. Animations will fail.", gameObject);
                enabled = false;
                return;
            }

            // Wait one frame to ensure PaletteReceiver has run (Execution Order usually handles this, but safety first)
            StartCoroutine(InitializeColorsNextFrame());
        }

        private IEnumerator InitializeColorsNextFrame()
        {
            yield return null;
            InitializeColors();
        }

        public void InitializeColors()
        {
            // 1. Resolve Colors from Palette/Managers
            ColorPaletteSO activePalette = paletteOverride;
            if (activePalette == null)
            {
                if (ServiceLocator.TryGet<PaletteManager>(out var manager)) activePalette = manager.activePalette;
                else if (PaletteManager.Instance != null) activePalette = PaletteManager.Instance.activePalette;
            }

            if (activePalette != null)
            {
                _staggerColor = activePalette.staggerColor;
                _hitColor = activePalette.hitFlashColor;
            }
            else
            {
                _staggerColor = Color.yellow;
                _hitColor = Color.white;
            }

            // 2. Snapshot current state
            // If PaletteReceiver ran, MPB has the palette color. If not, Material has the default.
            for (int i = 0; i < _renderers.Length; i++)
            {
                Renderer r = _renderers[i];
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Read current color
                if (!_propBlock.isEmpty && _propBlock.GetColor(_colorPropID) != Color.clear)
                {
                    _baseColors[i] = _propBlock.GetColor(_colorPropID);
                }
                else if (r.sharedMaterial != null && r.sharedMaterial.HasProperty(_colorPropID))
                {
                    _baseColors[i] = r.sharedMaterial.GetColor(_colorPropID);
                }
                else
                {
                    _baseColors[i] = Color.white;
                }
            }

            // 3. FORCE APPLY (The Fix)
            // Even if we just read it, re-applying it ensures the MPB is assigned to the renderer
            // and the state is consistent.
            ResetVisuals();
        }

        // --- VISUAL FX METHODS ---

        public void PlayHitFlash()
        {
            if (profile == null) return;
            if (_flashTween != null && _flashTween.IsActive()) _flashTween.Kill();

            // Flash all parts to pure White
            SetAllColors(_hitColor);

            _flashTween = DOVirtual.DelayedCall(profile.hitFlashDuration, ResetVisuals);
        }

        public void StartStaggerEffect()
        {
            if (profile == null) return;
            if (_flashTween != null) _flashTween.Kill();

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
            if (_flashTween != null) _flashTween.Kill();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, 0.1f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(GetBaseColorSafe(0), profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopPrimingEffect() => ResetVisuals();

        public void ResetVisuals()
        {
            if (_flashTween != null) _flashTween.Kill();

            // Restore individual colors
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], _baseColors[i]);
            }
        }

        // --- HELPERS ---

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
            _propBlock.SetColor(_colorPropID, c);
            _propBlock.SetColor(_emissionPropID, c);
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
            if (_flashTween != null) _flashTween.Kill();
        }
    }
}