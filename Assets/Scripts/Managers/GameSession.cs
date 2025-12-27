using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Player;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("UI Panels")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject pausePanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;

        [Header("Scene References")]
        public PlayerController player;
        public WaveDirector waveDirector; // Renamed from WaveManager

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;

        private void Awake()
        {
            _controls = new GameControls();

            // Bind Pause Action (ESC / Start)
            _controls.Gameplay.Pause.performed += ctx => TogglePause();
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

        private void Start()
        {
            // Pause everything immediately on load
            Time.timeScale = 0f;

            // Show Main Menu
            SetPanelActive(startPanel);

            // Lock Player
            if (player) player.ToggleInput(false);

            // Subscribe to Global Events
            GameEvents.OnPlayerDied += TriggerGameOver;
            GameEvents.OnGameVictory += TriggerVictory;
        }

        private void OnDestroy()
        {
            // Unsubscribe Local
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;

            // CRITICAL: Clean up static events so they don't linger between scene loads
            GameEvents.Cleanup();
        }

        // --- PUBLIC UI FUNCTIONS (Linked to Buttons) ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;

            // Unpause Physics/Logic
            Time.timeScale = 1f;

            // Switch UI
            SetPanelActive(hudPanel);

            // Wake up Player
            if (player)
            {
                player.ToggleInput(true);

                // CRITICAL FIX: Now that HUD is active, force PlayerHealth 
                // to resend the initial HP values so the UI updates.
                var health = player.GetComponent<PlayerHealth>();
                if (health) health.ForceUpdateUI();

                // Also sync energy if needed
                var energy = player.GetComponent<PlayerEnergy>();
                // (Assuming you might add ForceUpdate to Energy later, but Health is the priority)
            }

            // Start the Level Logic
            if (waveDirector) waveDirector.StartGame();
        }

        public void OpenTutorial()
        {
            SetPanelActive(tutorialPanel);
        }

        public void BackToMenu()
        {
            SetPanelActive(startPanel);
        }

        public void RestartGame()
        {
            Time.timeScale = 1f; // Reset time so the next scene loads cleanly
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            Debug.Log("EXITING SYSTEM...");
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        public void TogglePause()
        {
            // Can't pause if in menu or dead
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                // PAUSE STATE
                Time.timeScale = 0f;
                pausePanel.SetActive(true);
                // Optional: Hide HUD while paused
                // hudPanel.SetActive(false); 

                // Disable input so clicking menus doesn't shoot guns
                if (player) player.ToggleInput(false);
            }
            else
            {
                // RESUME STATE
                Time.timeScale = 1f;
                pausePanel.SetActive(false);
                // hudPanel.SetActive(true);

                if (player) player.ToggleInput(true);
            }
        }

        // --- INTERNAL LOGIC ---

        private void TriggerGameOver()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;

            // Slow Motion Death
            Time.timeScale = 0.2f;

            SetPanelActive(gameOverPanel);

            if (player) player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;

            // Slow Motion Victory
            Time.timeScale = 0.5f;

            SetPanelActive(victoryPanel);

            if (player) player.ToggleInput(false);
        }

        // Helper to ensure only one panel is visible at a time
        private void SetPanelActive(GameObject activePanel)
        {
            if (startPanel) startPanel.SetActive(false);
            if (tutorialPanel) tutorialPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);
            if (pausePanel) pausePanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}