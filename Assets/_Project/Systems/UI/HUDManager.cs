using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Systems.Score; // For IScoreService

namespace DarkTowerTron.Systems.UI
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
        private IScoreService _scoreService;

        private void Start()
        {
            // 1. Get Score Service (Guaranteed by GlobalSystems)
            _scoreService = ServiceLocator.Get<IScoreService>();

            // 2. Initial UI Refresh
            if (_scoreService != null)
            {
                UpdateScoreUI(_scoreService.TotalScore, _scoreService.CurrentMultiplier);
            }
        }

        private void OnEnable()
        {
            if (_focusEvent) _focusEvent.OnEventRaised += UpdateFocus;
            if (_gritEvent) _gritEvent.OnEventRaised += UpdateGrit;
            if (_hullEvent) _hullEvent.OnEventRaised += UpdateHull;
            if (_scoreEvent) _scoreEvent.OnEventRaised += UpdateScoreUI;
        }

        private void OnDisable()
        {
            if (_focusEvent) _focusEvent.OnEventRaised -= UpdateFocus;
            if (_gritEvent) _gritEvent.OnEventRaised -= UpdateGrit;
            if (_hullEvent) _hullEvent.OnEventRaised -= UpdateHull;
            if (_scoreEvent) _scoreEvent.OnEventRaised -= UpdateScoreUI;
        }

        private void Update()
        {
            // Poll for Timer (less expensive than event for every second)
            if (timerText && _scoreService != null)
            {
                float t = _scoreService.GameTime;
                int minutes = Mathf.FloorToInt(t / 60f);
                int seconds = Mathf.FloorToInt(t % 60f);

                // Optimization: Only update string if second changed? 
                // For now, per frame is acceptable for HUD text.
                timerText.text = $"{minutes:00}:{seconds:00}";
            }
        }

        // --- HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider) focusSlider.value = current / max;

            if (focusFillImage)
            {
                bool isFull = current >= (max * 0.95f);
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {
            // Rebuild if max changed
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            // Update states
            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {
            if (hullIcon)
            {
                hullIcon.color = hasHull ? hullActiveColor : hullBrokenColor;
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0");
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }

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