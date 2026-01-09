using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.UI
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Event Channels")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent;
        [SerializeField] private IntIntEventChannelSO _gritEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;
        [SerializeField] private IntIntEventChannelSO _scoreEvent;

        [Header("Focus (Energy)")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color fullFocusColor = new Color(1f, 0f, 1f);

        [Header("Grit (Health)")]
        public Transform gritContainer;
        public GameObject pipPrefab;
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f);

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
            if (_gritEvent != null) _gritEvent.OnEventRaised += UpdateGrit;
            if (_hullEvent != null) _hullEvent.OnEventRaised += UpdateHull;
            if (_scoreEvent != null) _scoreEvent.OnEventRaised += UpdateScoreUI;
        }

        private void OnDisable()
        {
            if (_focusEvent != null) _focusEvent.OnEventRaised -= UpdateFocus;
            if (_gritEvent != null) _gritEvent.OnEventRaised -= UpdateGrit;
            if (_hullEvent != null) _hullEvent.OnEventRaised -= UpdateHull;
            if (_scoreEvent != null) _scoreEvent.OnEventRaised -= UpdateScoreUI;
        }

        private void Update()
        {
            // CHANGE: Services -> Global
            if (timerText && Global.Score != null)
            {
                float t = Global.Score.GameTime;
                int minutes = Mathf.FloorToInt(t / 60f);
                int seconds = Mathf.FloorToInt(t % 60f);
                timerText.text = $"{minutes:00}:{seconds:00}";
            }
        }

        // --- EVENT HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider) focusSlider.value = current / max;

            if (focusFillImage)
            {
                bool isFull = current >= (max * 0.8f);
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {
            // Kept logs for debugging, remove later if spammy
            GameLogger.Log(LogChannel.UI, $"[HUD] Hull Event: {hasHull}", gameObject);

            if (hullIcon)
            {
                hullIcon.color = hasHull ? hullActiveColor : hullBrokenColor;
            }
            else
            {
                GameLogger.LogError(LogChannel.UI, "[HUDManager] Hull Icon reference is missing!", gameObject);
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
            if (gritContainer == null || pipPrefab == null) return;

            foreach (Transform child in gritContainer) Destroy(child.gameObject);
            _spawnedPips.Clear();

            for (int i = 0; i < max; i++)
            {
                GameObject newPip = Instantiate(pipPrefab, gritContainer);
                Image img = newPip.GetComponent<Image>();
                if (img) _spawnedPips.Add(img);
            }
        }
    }
}