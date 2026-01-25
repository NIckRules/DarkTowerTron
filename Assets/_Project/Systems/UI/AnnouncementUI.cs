using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class AnnouncementUI : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private StringEventChannelSO _announcementEvent;

        [Header("UI")]
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private CanvasGroup _canvasGroup;

        private void Awake()
        {
            if (_canvasGroup) _canvasGroup.alpha = 0;
        }

        private void OnEnable()
        {
            if (_announcementEvent) _announcementEvent.OnEventRaised += ShowAnnouncement;
        }

        private void OnDisable()
        {
            if (_announcementEvent) _announcementEvent.OnEventRaised -= ShowAnnouncement;
        }

        private void ShowAnnouncement(string text)
        {
            if (_text) _text.text = text;

            // Sequence: Fade In -> Wait -> Fade Out
            _canvasGroup.DOKill();
            Sequence seq = DOTween.Sequence();
            seq.Append(_canvasGroup.DOFade(1f, 0.5f));
            seq.AppendInterval(2.5f);
            seq.Append(_canvasGroup.DOFade(0f, 0.5f));
        }
    }
}