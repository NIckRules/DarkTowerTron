using UnityEngine;
using UnityEngine.UI;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Focus")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color overheatFocusColor = Color.red;

        [Header("Grit (Health)")]
        public GameObject[] gritPips; // Drag your Pip Images here
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f); // Faded

        [Header("Hull / Wound")]
        public Image hullIcon; // Assign the Wound Image
        public Color hullActiveColor = Color.cyan; // Shield is UP
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f); // Shield BROKEN (Red/Transparent)

        [Header("System")]
        public TMPro.TextMeshProUGUI waveText;

        [Header("Score UI")]
        public TMPro.TextMeshProUGUI scoreText;
        public TMPro.TextMeshProUGUI multiplierText;
        public TMPro.TextMeshProUGUI timerText;

        private void Update()
        {
            // Simple Timer Update
            if (timerText && Managers.ScoreManager.Instance)
            {
                float t = Managers.ScoreManager.Instance.GameTime;
                // Format 00:00
                string minutes = Mathf.Floor(t / 60).ToString("00");
                string seconds = (t % 60).ToString("00");
                timerText.text = $"{minutes}:{seconds}";
            }
        }

        private void OnEnable()
        {
            GameEvents.OnFocusChanged += UpdateFocus;
            GameEvents.OnGritChanged += UpdateGrit;
            GameEvents.OnScoreChanged += UpdateScoreUI;
            GameEvents.OnHullStateChanged += UpdateHull;
            // Optional: Listen for wave changes if we added that event
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
            GameEvents.OnScoreChanged -= UpdateScoreUI;
            GameEvents.OnHullStateChanged -= UpdateHull;
        }

        private void UpdateHull(bool hasHull)
        {
            if (!hullIcon) return;

            if (hasHull)
            {
                // Hull is intact
                hullIcon.color = hullActiveColor;
                // Optional: hullIcon.sprite = shieldSprite;
            }
            else
            {
                // Hull is gone (Danger State)
                hullIcon.color = hullBrokenColor;
                // Optional: hullIcon.sprite = brokenSkullSprite;
            }
        }

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider)
            {
                focusSlider.value = current / max;
            }

            // Optional: Change color if full (Overheat warning)
            if (focusFillImage)
            {
                focusFillImage.color = (current >= max) ? overheatFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit)
        {

            Debug.Log($"[DEBUG HUD] Updating Grit UI: {currentGrit}");

            if (gritPips == null) return;

            Debug.Log($"[DEBUG HUD] Grit Pips Length: {gritPips.Length}");

            for (int i = 0; i < gritPips.Length; i++)
            {
                if (gritPips[i] == null) continue;

                Debug.Log($"[DEBUG HUD] Updating Pip {i}");

                Image pipImg = gritPips[i].GetComponent<Image>();
                if (pipImg)
                {

                    Debug.Log($"[DEBUG HUD] Setting Pip {i} Color");

                    // If currentGrit is 2, pips 0 and 1 are active.
                    pipImg.color = (i < currentGrit) ? activePipColor : inactivePipColor;
                }
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0"); // "N0" adds commas (1,000)
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }
    }
}