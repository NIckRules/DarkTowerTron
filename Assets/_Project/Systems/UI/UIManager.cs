using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Persistence; // To read corruption
using DarkTowerTron.Core.Debugging; // For GameLogger

namespace DarkTowerTron.Systems.UI
{
    public class UIManager : MonoBehaviour
    {
        [Header("Views")]
        public UIView startView;
        public UIView tutorialView;
        public UIView hudView;
        public UIView pauseView;
        public UIView gameOverView;
        public UIView victoryView;

        // Internal
        private UIView _currentView;
        private IPersistenceService _persistence;

        private void Start()
        {
            _persistence = ServiceLocator.Get<IPersistenceService>();

            // Optional: Force corruption update on all views at start
            float corruption = (_persistence?.CurrentData != null) ? GetCorruptionLevel() : 0f;
            UpdateAllViewsCorruption(corruption);
        }

        // --- Public Control ---

        public void ShowStartMenu() => SwitchView(startView);
        public void ShowTutorial() => SwitchView(tutorialView);
        public void ShowHUD() => SwitchView(hudView);
        public void ShowPause() => SwitchView(pauseView);
        public void ShowGameOver() => SwitchView(gameOverView);
        public void ShowVictory() => SwitchView(victoryView);

        // --- Logic ---

        private void SwitchView(UIView newView)
        {

            if (_currentView == newView) return;

            // 1. Close current
            if (_currentView != null)
            {
                _currentView.Hide();
            }

            // 2. Open new
            if (newView != null)
            {
                newView.Show();
                _currentView = newView;

                // 3. Apply Corruption Context (Narrative consistency)
                float corruption = GetCorruptionLevel();
                newView.ApplyCorruption(corruption);
            }
        }

        private void UpdateAllViewsCorruption(float amount)
        {
            if (startView) startView.ApplyCorruption(amount);
            if (hudView) hudView.ApplyCorruption(amount);
            // ... apply to others if needed ...
        }

        // Simple helper logic (moved from NarrativeDirector logic ideally)
        private float GetCorruptionLevel()
        {
            if (_persistence?.CurrentData == null) return 0f;
            var d = _persistence.CurrentData;
            // Your formula: 5% per death + 1% per run
            float val = (d.totalDeaths * 0.05f) + (d.totalRuns * 0.01f);
            return Mathf.Clamp01(val);
        }
    }
}