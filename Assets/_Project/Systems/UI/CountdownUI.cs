using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("Listening")]
        [Tooltip("Receives strings like 'Wave 1' or 'BOSS FIGHT'")]
        [SerializeField] private StringEventChannelSO _announceEvent;

        [Tooltip("Receives countdown strings like '3', '2', '1', ''")]
        [SerializeField] private StringEventChannelSO _countdownEvent;

        [Header("UI References")]
        public TextMeshProUGUI waveTitleText;
        public TextMeshProUGUI countdownText;

        [Header("Settings")]
        [SerializeField] private float _titleDuration = 3f; // How long title stays visible

        private void Awake()
        {
            // Reset State
            if (waveTitleText)
            {
                waveTitleText.alpha = 0f;
                waveTitleText.gameObject.SetActive(false);
            }
            if (countdownText)
            {
                countdownText.text = "";
                countdownText.gameObject.SetActive(false);
            }
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

        private void ShowWaveTitle(string titleText)
        {
            if (waveTitleText)
            {
                // Reset State
                waveTitleText.DOKill();
                waveTitleText.gameObject.SetActive(true);
                waveTitleText.text = titleText;

                // Animation Sequence: Pop In -> Wait -> Fade Out
                waveTitleText.transform.localScale = Vector3.zero;
                waveTitleText.alpha = 1f;

                Sequence seq = DOTween.Sequence();
                seq.Append(waveTitleText.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack));
                seq.AppendInterval(_titleDuration);
                seq.Append(waveTitleText.DOFade(0f, 0.5f));
                seq.OnComplete(() => waveTitleText.gameObject.SetActive(false));
            }
        }

        private void UpdateCountdown(string text)
        {
            if (countdownText)
            {
                // Logic: Empty string means "Hide/Done"
                if (string.IsNullOrEmpty(text))
                {
                    countdownText.gameObject.SetActive(false);
                    return;
                }

                // Ensure Active
                countdownText.gameObject.SetActive(true);
                countdownText.text = text;

                // Punch Animation
                countdownText.transform.DOKill(); // Stop previous punch
                countdownText.transform.localScale = Vector3.one;
                countdownText.transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            }
        }
    }
}