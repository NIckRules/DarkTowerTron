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

        [Header("System")]
        public TMPro.TextMeshProUGUI waveText;

        private void OnEnable()
        {
            GameEvents.OnFocusChanged += UpdateFocus;
            GameEvents.OnGritChanged += UpdateGrit;
            // Optional: Listen for wave changes if we added that event
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
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
            if (gritPips == null) return;

            for (int i = 0; i < gritPips.Length; i++)
            {
                if (gritPips[i] == null) continue;

                Image pipImg = gritPips[i].GetComponent<Image>();
                if (pipImg)
                {
                    // If currentGrit is 2, pips 0 and 1 are active.
                    pipImg.color = (i < currentGrit) ? activePipColor : inactivePipColor;
                }
            }
        }
    }
}