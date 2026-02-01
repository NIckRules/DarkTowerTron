using UnityEngine;
using TMPro;

namespace DarkTowerTron.Systems.UI
{
    public class MainMenuPanel : UIView
    {
        [Header("Corruption Targets")]
        public TextMeshProUGUI titleText;
        public float maxJitterAmount = 10f;

        private float _currentCorruption = 0f;
        private Vector3 _originalTitlePos;

        protected override void Awake()
        {
            base.Awake();
            if (titleText) _originalTitlePos = titleText.rectTransform.anchoredPosition;
        }

        private void Update()
        {
            // Example: Visual Corruption Effect
            // Only run this logic if the menu is actually open and corruption > 0
            if (_isOpen && _currentCorruption > 0.1f && titleText)
            {
                // Jitter the title text based on corruption level
                float jitter = _currentCorruption * maxJitterAmount;
                Vector3 offset = new Vector3(Random.Range(-jitter, jitter), Random.Range(-jitter, jitter), 0);
                titleText.rectTransform.anchoredPosition = _originalTitlePos + offset;
            }
        }

        // Override the hook from UIView
        public override void ApplyCorruption(float corruptionAmount)
        {
            _currentCorruption = corruptionAmount;

            // Example: Change text content at high corruption
            if (titleText && corruptionAmount > 0.8f)
            {
                titleText.text = "D//RK TOWER_NULL";
                titleText.color = Color.red;
            }
        }
    }
}