using UnityEngine;

namespace DarkTowerTron.Managers
{
    public class UIManager : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject pausePanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;

        public void ShowStartMenu() => SetPanelActive(startPanel);
        public void ShowTutorial() => SetPanelActive(tutorialPanel);
        public void ShowHUD() => SetPanelActive(hudPanel);
        public void ShowPause() => SetPanelActive(pausePanel);
        public void ShowGameOver() => SetPanelActive(gameOverPanel);
        public void ShowVictory() => SetPanelActive(victoryPanel);

        // Helper to ensure exclusive visibility
        private void SetPanelActive(GameObject activePanel)
        {
            if (startPanel) startPanel.SetActive(false);
            if (tutorialPanel) tutorialPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(false);
            if (pausePanel) pausePanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}