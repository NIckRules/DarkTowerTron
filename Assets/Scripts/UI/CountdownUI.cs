using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("Listening")]
        [SerializeField] private IntEventChannelSO _announceEvent;
        [SerializeField] private StringEventChannelSO _countdownEvent;

        [Header("UI References")]
        public TextMeshProUGUI waveTitleText; // "WAVE 1"
        public TextMeshProUGUI countdownText; // "3"

        private void Awake()
        {
            // Hide by default
            if (waveTitleText) waveTitleText.gameObject.SetActive(false);
            if (countdownText) countdownText.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            if (_announceEvent != null) _announceEvent.OnEventRaised += ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised += UpdateCountdown;
        }

        private void OnDisable()
        {
            if (_announceEvent != null) _announceEvent.OnEventRaised -= ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised -= UpdateCountdown;
        }

        private void ShowWaveTitle(int waveIndex)
        {
            if (waveTitleText)
            {
                waveTitleText.text = $"WAVE {waveIndex}";
                waveTitleText.gameObject.SetActive(true);

                // Animation: Scale Up and Fade In
                waveTitleText.transform.localScale = Vector3.zero;
                waveTitleText.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
                waveTitleText.alpha = 1f;
            }
        }

        private void UpdateCountdown(string text)
        {
            if (countdownText)
            {
                // If text is empty, hide everything
                if (string.IsNullOrEmpty(text))
                {
                    countdownText.gameObject.SetActive(false);
                    if (waveTitleText) waveTitleText.DOFade(0, 0.5f); // Fade out title
                    return;
                }

                countdownText.gameObject.SetActive(true);
                countdownText.text = text;

                // Punch Animation for every number
                countdownText.transform.localScale = Vector3.one;
                countdownText.transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            }
        }
    }
}