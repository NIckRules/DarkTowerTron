using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Player; // To access PlayerController

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("UI References")]
        public GameObject startPanel;
        public GameObject hudPanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel; // NEW SLOT

        [Header("Scene References")]
        public PlayerController player;
        public WaveManager waveManager;

        private bool _isGameRunning = false;

        private void Start()
        {
            // Initial State
            Time.timeScale = 1f; // Ensure time is running

            if (startPanel) startPanel.SetActive(true);
            if (hudPanel) hudPanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);

            // Lock Player Input
            if (player) player.ToggleInput(false);

            // Listen for Death
            GameEvents.OnPlayerDied += TriggerGameOver;
            // LISTEN FOR VICTORY
            GameEvents.OnGameVictory += TriggerVictory;
        }

        private void OnDestroy()
        {
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;
        }

        // --- UI BUTTONS HOOKS ---

        public void BeginGame()
        {

            _isGameRunning = true;

            if (startPanel) startPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(true);

            // Unlock Player
            if (player) player.ToggleInput(true);

            // Start Waves
            if (waveManager) waveManager.StartGame();
        }

        public void RestartGame()
        {
            Time.timeScale = 1f; // Reset time in case it was slowed
            // Reload current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        // --- LOGIC ---

        private void TriggerGameOver()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;

            // Slow motion death effect
            Time.timeScale = 0.2f;

            if (hudPanel) hudPanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(true);

            // Lock Input
            if (player) player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;

            // Slow mo finish
            Time.timeScale = 0.5f; 

            if(hudPanel) hudPanel.SetActive(false);
            if(victoryPanel) victoryPanel.SetActive(true);

            // Lock Input
            if (player) player.ToggleInput(false);
        }
    }
}