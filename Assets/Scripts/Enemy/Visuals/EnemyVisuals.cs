using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Services;      // Where PaletteManager lives
using DarkTowerTron.Core.Services; // Where ServiceLocator lives
using UnityEngine.Serialization;

namespace DarkTowerTron.Enemy.Visuals
{
    public class EnemyVisuals : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Leave EMPTY to use the Global Palette. Assign only to force a specific look.")]
        [FormerlySerializedAs("palette")]
        public ColorPaletteSO paletteOverride;
        
        [Tooltip("Defines timing and animation curves. Required.")]
        public EnemyVisualProfileSO profile; 

        [Header("References")]
        [SerializeField] private Renderer _renderer;

        // Internal
        private MaterialPropertyBlock _propBlock;
        private int _colorPropID;
        private int _emissionPropID;

        // State
        private Color _baseColor; 
        private Color _staggerColor;
        private Color _hitColor;
        private Tween _flashTween;

        private void Awake()
        {
            // Auto-find if not assigned in Inspector
            if (_renderer == null) _renderer = GetComponentInChildren<Renderer>();
            
            _propBlock = new MaterialPropertyBlock();
            
            _colorPropID = Shader.PropertyToID("_BaseColor");
            _emissionPropID = Shader.PropertyToID("_EmissionColor");
        }

        private void Start()
        {
            if (profile == null)
            {
                // We use GameLogger if possible, or Debug.LogError
                Debug.LogError($"[EnemyVisuals] Profile missing on {gameObject.name}. Animations will fail.", gameObject);
                enabled = false;
                return;
            }
            
            InitializeColors();
        }

        public void InitializeColors()
        {
            // 1. Determine which Palette to use (Priority Hierarchy)
            ColorPaletteSO activePalette = paletteOverride;

            if (activePalette == null)
            {
                // Try Service Locator (Standard Runtime)
                if (ServiceLocator.TryGet<PaletteManager>(out var manager))
                {
                    activePalette = manager.activePalette;
                }
                // Fallback to Instance (Editor/Test Scenes without Bootloader)
                else if (PaletteManager.Instance != null)
                {
                    activePalette = PaletteManager.Instance.activePalette;
                }
            }

            // 2. Load Colors
            if (activePalette != null)
            {
                _staggerColor = activePalette.staggerColor;
                _hitColor = activePalette.hitFlashColor;
            }
            else
            {
                // Absolute Fallback
                _staggerColor = Color.yellow;
                _hitColor = Color.white;
            }

            // 3. Determine Base Color (Preserve PaletteReceiver overrides)
            if (_renderer)
            {
                _renderer.GetPropertyBlock(_propBlock);
                
                // If MPB is empty/clear, assume Material color. Otherwise trust the MPB (from PaletteReceiver).
                if (_propBlock.isEmpty || _propBlock.GetColor(_colorPropID) == Color.clear)
                {
                    if (_renderer.sharedMaterial != null && _renderer.sharedMaterial.HasProperty(_colorPropID))
                        _baseColor = _renderer.sharedMaterial.GetColor(_colorPropID);
                    else
                        _baseColor = Color.white;
                }
                else
                {
                    _baseColor = _propBlock.GetColor(_colorPropID);
                }
            }
        }

        // --- VISUAL FX METHODS ---

        public void PlayHitFlash()
        {
            if (profile == null) return;
            if (_flashTween != null && _flashTween.IsActive()) _flashTween.Kill();

            SetColor(_hitColor);
            _flashTween = DOVirtual.DelayedCall(profile.hitFlashDuration, () => SetColor(_baseColor));
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
                    SetColor(c);
                });
        }

        public void StopStaggerEffect()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_baseColor); 
        }

        public void StartPrimingEffect()
        {
            if (profile == null) return;
            if (_flashTween != null) _flashTween.Kill();

            float lerpVal = 0f;
            // Fast blink (0.1s loops)
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, 0.1f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_baseColor, profile.dangerPulseColor, lerpVal);
                    SetColor(c);
                });
        }

        public void StopPrimingEffect() => ResetVisuals();

        public void ResetVisuals()
        {
            if (_flashTween != null) _flashTween.Kill();
            SetColor(_baseColor);
        }

        private void SetColor(Color c)
        {
            if (_renderer == null) return;

            _renderer.GetPropertyBlock(_propBlock);
            _propBlock.SetColor(_colorPropID, c);
            _propBlock.SetColor(_emissionPropID, c);
            _renderer.SetPropertyBlock(_propBlock);
        }

        private void OnDestroy()
        {
            if (_flashTween != null) _flashTween.Kill();
        }
    }
}