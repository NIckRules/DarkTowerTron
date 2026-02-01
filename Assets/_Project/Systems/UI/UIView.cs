using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DarkTowerTron.Core.AudioSystem;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIView : MonoBehaviour
    {
        [Header("Configuration")]
        public bool hideOnAwake = true;
        public float animationDuration = 0.5f;

        [Header("Audio (Juice)")]
        [Tooltip("The music theme to play when this screen opens. Leave null to keep playing current music.")]
        public MusicProfileSO viewTheme;
        public AudioClip openSound;
        public AudioClip closeSound;

        [Header("References")]
        [Tooltip("Optional: The first button to select for Gamepad navigation.")]
        public GameObject firstSelected;

        // Internal State
        protected CanvasGroup _canvasGroup;
        protected bool _isOpen;
        protected IAudioService _audioService;

        // --- Lifecycle ---

        protected virtual void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            if (hideOnAwake)
            {
                _isOpen = false;
                _canvasGroup.alpha = 0;
                _canvasGroup.interactable = false;
                _canvasGroup.blocksRaycasts = false;
                gameObject.SetActive(false);
            }
        }

        protected virtual void Start()
        {
            _audioService = ServiceLocator.Get<IAudioService>();
        }

        // --- Public API ---

        public virtual void Show()
        {

            if (_isOpen) return;
            _isOpen = true;
            gameObject.SetActive(true);

            // 1. Audio Hooks
            if (_audioService != null)
            {
                if (openSound) _audioService.PlaySFX(openSound, Vector3.zero, 1f);

                // Smart Music Switching: Only switch if a specific profile is assigned
                if (viewTheme != null)
                {
                    _audioService.PlayMusicProfile(viewTheme);
                }
            }

            // 2. Animation (Fade + Slight Scale Up)
            _canvasGroup.DOKill();
            transform.DOKill();

            _canvasGroup.alpha = 0f;
            transform.localScale = Vector3.one * 0.95f;

            _canvasGroup.DOFade(1f, animationDuration).SetUpdate(true); // Ignore TimeScale!
            transform.DOScale(1f, animationDuration).SetEase(Ease.OutBack).SetUpdate(true);

            // 3. Interaction
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;

            // 4. Navigation
            if (firstSelected)
            {
                // Wait a frame for EventSystem
                StartCoroutine(SelectButtonRoutine());
            }
        }

        public virtual void Hide()
        {
            if (!_isOpen) return;
            _isOpen = false;

            // 1. Audio Hook
            if (_audioService != null && closeSound)
                _audioService.PlaySFX(closeSound, Vector3.zero, 1f);

            // 2. Interaction
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;

            // 3. Animation (Fade Out)
            _canvasGroup.DOKill();
            _canvasGroup.DOFade(0f, animationDuration * 0.5f)
                .SetUpdate(true)
                .OnComplete(() => gameObject.SetActive(false));
        }

        /// <summary>
        /// Hook for the Narrative Director. 
        /// Override this in specific views to make text jitter or images distort.
        /// </summary>
        /// <param name="corruptionAmount">0.0 (Clean) to 1.0 (Total Failure)</param>
        public virtual void ApplyCorruption(float corruptionAmount)
        {
            // Base implementation can be empty, or handle a global material effect
        }

        // --- Helpers ---

        private System.Collections.IEnumerator SelectButtonRoutine()
        {
            yield return null;
            if (UnityEngine.EventSystems.EventSystem.current)
            {
                UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(firstSelected);
            }
        }
    }
}