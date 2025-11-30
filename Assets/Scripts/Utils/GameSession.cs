using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DarkTowerTron.Player; // To access Player scripts
using DarkTowerTron.Combat; // To access WaveManager

namespace DarkTowerTron.Utils
{
    public class GameSession : MonoBehaviour
    {
        [Header("UI Panels")]
        public GameObject startPanel;
        public GameObject hudPanel;
        public GameObject gameOverPanel;

        [Header("Game References")]
        public GameObject player;
        public WaveManager waveManager;

        private bool isGameRunning = false;

        void Start()
        {
            // 1. Setup Initial State
            Time.timeScale = 0; // Pause everything immediately
            startPanel.SetActive(true);
            hudPanel.SetActive(false);
            gameOverPanel.SetActive(false);

            // Disable Player Input so they don't click through the menu
            TogglePlayerControl(false);
        }

        // Hook this to the START BUTTON
        public void BeginGame()
        {
            isGameRunning = true;
            Time.timeScale = 1; // Unpause

            startPanel.SetActive(false);
            hudPanel.SetActive(true);

            TogglePlayerControl(true);

            // Start the waves
            if (waveManager) waveManager.enabled = true;
        }

        // Hook this to Player OnDeath event
        public void TriggerGameOver()
        {
            if (!isGameRunning) return;
            isGameRunning = false;

            Debug.Log("GAME OVER TRIGGERED");

            // 1. Slow down time (Death Effect) or Stop it
            Time.timeScale = 0.1f; // Slow motion death

            // 2. Show UI
            hudPanel.SetActive(false);
            gameOverPanel.SetActive(true);

            // 3. Disable controls
            TogglePlayerControl(false);
        }

        // Hook this to RESTART BUTTON
        public void RestartGame()
        {
            Time.timeScale = 1; // Reset time
            // Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        void TogglePlayerControl(bool state)
        {
            if (player == null) return;

            // We disable the scripts, not the object (so the camera doesn't break)
            var movement = player.GetComponent<PlayerMovement>();
            var attack = player.GetComponent<PlayerAttack>();
            var blitz = player.GetComponent<Blitz>();

            if (movement) movement.enabled = state;
            if (attack) attack.enabled = state;
            if (blitz) blitz.enabled = state;
        }
    }
}