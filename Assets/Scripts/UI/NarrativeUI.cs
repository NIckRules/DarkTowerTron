using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core;

namespace DarkTowerTron.UI
{
    public class NarrativeUI : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private NarrativeEventChannelSO _inputChannel;

        [Header("Components")]
        [SerializeField] private TextMeshProUGUI _textMesh;
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private RectTransform _panelRoot;

        [Header("Settings")]
        public float typeSpeed = 0.03f; // Fast terminal speed
        public string prefix = "> SYS_OUT: ";
        public AudioClip typeSound;

        [Header("Glitch Settings")]
        public float shakeStrength = 10f;
        public Color normalColor = Color.white;
        public Color errorColor = Color.red;

        private Tween _fadeTween;
        private Coroutine _displayRoutine;

        private void Awake()
        {
            // Initial State: Hidden
            _canvasGroup.alpha = 0;
            _textMesh.text = "";
        }

        private void OnEnable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised += OnMessageReceived;
        }

        private void OnDisable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised -= OnMessageReceived;
        }

        private void OnMessageReceived(string message, float duration)
        {
            // 1. Interrupt existing messages
            if (_displayRoutine != null) StopCoroutine(_displayRoutine);
            if (_fadeTween != null) _fadeTween.Kill();
            _panelRoot.DOKill();

            // 2. Start new sequence
            _displayRoutine = StartCoroutine(TypewriterRoutine(message, duration));
        }

        private IEnumerator TypewriterRoutine(string message, float duration)
        {
            // A. Setup
            string fullText = prefix + message;
            _textMesh.text = fullText;
            _textMesh.maxVisibleCharacters = 0; // Hide all chars
            _textMesh.color = message.Contains("FATAL") ? errorColor : normalColor;

            // B. Visual "Boot" (Fade In + Jolt)
            _canvasGroup.alpha = 1;
            _panelRoot.DOPunchAnchorPos(Vector2.right * shakeStrength, 0.2f, 20, 1);

            // C. Typewriter Effect
            int totalChars = fullText.Length;
            for (int i = 0; i <= totalChars; i++)
            {
                _textMesh.maxVisibleCharacters = i;

                // Play sound every few chars to avoid machine-gun audio
                if (i % 3 == 0 && typeSound != null && Global.Audio != null)
                {
                    Global.Audio.PlaySound(typeSound, 0.2f, true);
                }

                yield return new WaitForSeconds(typeSpeed);
            }

            // D. Wait (Read time)
            yield return new WaitForSeconds(duration);

            // E. Fade Out
            _fadeTween = _canvasGroup.DOFade(0f, 0.5f);
        }
    }
}