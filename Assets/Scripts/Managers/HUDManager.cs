using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro; // TextMeshPro
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Event Channels")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent; // Was GameEvents.OnFocusChanged
        [SerializeField] private IntIntEventChannelSO _gritEvent;      // Was GameEvents.OnGritChanged
        [SerializeField] private BoolEventChannelSO _hullEvent;        // Was GameEvents.OnHullStateChanged
        [SerializeField] private IntIntEventChannelSO _scoreEvent;     // Was GameEvents.OnScoreChanged

        [Header("Focus (Energy)")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color fullFocusColor = new Color(1f, 0f, 1f); // Purple/Pink for Overdrive

        [Header("Grit (Health)")]
        public Transform gritContainer; // Assign a HorizontalLayoutGroup object here
        public GameObject pipPrefab;    // Prefab with just an Image component
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f); // Faded

        [Header("Hull (Shield)")]
        public Image hullIcon;
        public Color hullActiveColor = Color.cyan;
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f);

        [Header("Score & System")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI multiplierText;
        public TextMeshProUGUI timerText;

        // Internal State
        private List<Image> _spawnedPips = new List<Image>();

        private void OnEnable()
        {
            if (_focusEvent != null) _focusEvent.OnEventRaised += UpdateFocus;
            else GameEvents.OnFocusChanged += UpdateFocus;

            if (_gritEvent != null) _gritEvent.OnEventRaised += UpdateGrit;
            else GameEvents.OnGritChanged += UpdateGrit;

            if (_hullEvent != null) _hullEvent.OnEventRaised += UpdateHull;
            else GameEvents.OnHullStateChanged += UpdateHull;

            if (_scoreEvent != null) _scoreEvent.OnEventRaised += UpdateScoreUI;
            else GameEvents.OnScoreChanged += UpdateScoreUI;
        }

        private void OnDisable()
        {
            if (_focusEvent != null) _focusEvent.OnEventRaised -= UpdateFocus;
            else GameEvents.OnFocusChanged -= UpdateFocus;

            if (_gritEvent != null) _gritEvent.OnEventRaised -= UpdateGrit;
            else GameEvents.OnGritChanged -= UpdateGrit;

            if (_hullEvent != null) _hullEvent.OnEventRaised -= UpdateHull;
            else GameEvents.OnHullStateChanged -= UpdateHull;

            if (_scoreEvent != null) _scoreEvent.OnEventRaised -= UpdateScoreUI;
            else GameEvents.OnScoreChanged -= UpdateScoreUI;
        }

        private void Update()
        {
            // Update Timer every frame directly from Manager (no event needed)
            if (timerText && Services.Score != null)
            {
                float t = Services.Score.GameTime;
                string minutes = Mathf.Floor(t / 60).ToString("00");
                string seconds = (t % 60).ToString("00");
                timerText.text = $"{minutes}:{seconds}";
            }
        }

        // --- EVENT HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider)
            {
                // Ensure slider is 0-1
                focusSlider.value = current / max;
            }

            if (focusFillImage)
            {
                // Visual feedback for Overdrive (Full Bar)
                bool isFull = current >= (max * 0.8f); // 80% threshold
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {

            // 1. Check if we need to rebuild the layout
            // (Happens on Start or if Max HP changes via Upgrade)
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            // 2. Update Colors
            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;

                // Example: Grit 2. 
                // i=0 (<2) -> Active. 
                // i=1 (<2) -> Active. 
                // i=2 (>=2) -> Inactive.
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {

            GameLogger.Log(DarkTowerTron.Core.LogChannel.UI, $"[HUD] Hull Event Received! State: {hasHull}", gameObject);

            if (hullIcon)
            {
                GameLogger.Log(LogChannel.UI, $"[HUDManager] Updating Hull Icon. Has Hull: {hasHull}", gameObject);

                Color targetColor = hasHull ? hullActiveColor : hullBrokenColor;
                hullIcon.color = targetColor;
            }else{
                GameLogger.Log(LogChannel.UI, $"[HUDManager] Hull Icon reference is missing!", gameObject);
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0");
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }

        // --- HELPERS ---

        private void RebuildGritLayout(int max)
        {

            GameLogger.Log(LogChannel.UI, $"[HUDManager] Rebuilding Grit Layout for Max Grit: {max}", gameObject);

            if (gritContainer == null || pipPrefab == null) return;

            // Clear existing
            foreach (Transform child in gritContainer)
            {
                Destroy(child.gameObject);
            }
            _spawnedPips.Clear();

            // Spawn new
            for (int i = 0; i < max; i++)
            {

                GameLogger.Log(LogChannel.UI, $"[HUDManager] Spawning Grit Pip {i + 1}/{max}", gameObject);

                GameObject newPip = Instantiate(pipPrefab, gritContainer);
                Image img = newPip.GetComponent<Image>();
                if (img)
                {
                    GameLogger.Log(LogChannel.UI, $"[HUDManager] Successfully spawned pip and added to list.", newPip);
                    _spawnedPips.Add(img);
                }
            }
        }
    }
}