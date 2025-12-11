using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Player;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("UI References")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;
        public GameObject pausePanel; // NEW

        [Header("Scene References")]
        public PlayerController player;
        public WaveManager waveManager;

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls; // To read ESC input

        private void Awake()
        {
            _controls = new GameControls();
            // Listen for Pause button
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
            Time.timeScale = 1f;
            SetPanelActive(startPanel);

            if (player) player.ToggleInput(false);

            GameEvents.OnPlayerDied += TriggerGameOver;
            GameEvents.OnGameVictory += TriggerVictory;
        }

        private void OnDestroy()
        {
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;
        }

        // --- PAUSE LOGIC ---

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                // PAUSE
                Time.timeScale = 0f;
                pausePanel.SetActive(true);
                hudPanel.SetActive(false); // <--- Add This (Hide HUD)
                if (player) player.ToggleInput(false);
            }
            else
            {
                // RESUME
                Time.timeScale = 1f;
                pausePanel.SetActive(false);
                hudPanel.SetActive(true); // <--- Add This (Show HUD)
                if (player) player.ToggleInput(true);
            }
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            SetPanelActive(hudPanel);

            if (player) player.ToggleInput(true);
            if (waveManager) waveManager.StartGame();
        }

        public void OpenTutorial() { SetPanelActive(tutorialPanel); }
        public void BackToMenu() { SetPanelActive(startPanel); }

        public void RestartGame()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        // --- INTERNAL ---

        private void TriggerGameOver()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.2f;
            SetPanelActive(gameOverPanel);
            if (player) player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.5f;
            SetPanelActive(victoryPanel);
            if (player) player.ToggleInput(false);
        }

        private void SetPanelActive(GameObject activePanel)
        {
            // Hide all
            if (startPanel) startPanel.SetActive(false);
            if (tutorialPanel) tutorialPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);
            if (pausePanel) pausePanel.SetActive(false);

            // Show one
            if (activePanel) activePanel.SetActive(true);
        }
    }
}