using UnityEngine;
using TMPro;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.UI
{
    public class TooltipManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private TooltipEventChannelSO _tooltipEvent;

        [Header("UI References")]
        public GameObject tooltipObject;
        public TextMeshProUGUI headerText;
        public TextMeshProUGUI contentText;
        public RectTransform rectTransform;

        private void Awake()
        {
            // Start hidden
            tooltipObject.SetActive(false);
        }

        private void OnEnable()
        {
            if (_tooltipEvent)
            {
                _tooltipEvent.OnShow += Show;
                _tooltipEvent.OnHide += Hide;
            }
        }

        private void OnDisable()
        {
            if (_tooltipEvent)
            {
                _tooltipEvent.OnShow -= Show;
                _tooltipEvent.OnHide -= Hide;
            }
        }

        private void Show(string header, string content)
        {
            headerText.text = header;
            contentText.text = content;

            // Toggle header visibility if empty
            headerText.gameObject.SetActive(!string.IsNullOrEmpty(header));

            tooltipObject.SetActive(true);
            UpdatePosition();
        }

        private void Hide()
        {
            tooltipObject.SetActive(false);
        }

        private void Update()
        {
            if (tooltipObject.activeSelf)
            {
                UpdatePosition();
            }
        }

        private void UpdatePosition()
        {
            // Simple mouse follow
            Vector2 mousePos = UnityEngine.Input.mousePosition;

            // Offset so cursor doesn't cover text
            float pivotX = mousePos.x / Screen.width;
            float pivotY = mousePos.y / Screen.height;

            rectTransform.pivot = new Vector2(pivotX, pivotY);
            transform.position = mousePos;
        }
    }
}