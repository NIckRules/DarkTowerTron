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
        public GameObject pausePanel;

        [Header("Scene References")]
        public PlayerController player;
        
        // CHANGED: Was WaveManager, now WaveDirector
        public WaveDirector waveDirector; 

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;

        private void Awake()
        {
            _controls = new GameControls();
            _controls.Gameplay.Pause.performed += ctx => TogglePause();
        }

        private void OnEnable() => _controls.Enable();
        private void OnDisable() => _controls.Disable();

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
            // Existing unsubscriptions
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;

            // CRITICAL: Wipe static listeners
            GameEvents.Cleanup();
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            SetPanelActive(hudPanel);

            if (player) player.ToggleInput(true);
            
            // UPDATED CALL
            if (waveDirector) waveDirector.StartGame();
        }

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                pausePanel.SetActive(true);
                if (player) player.ToggleInput(false);
            }
            else
            {
                Time.timeScale = 1f;
                pausePanel.SetActive(false);
                if (player) player.ToggleInput(true);
            }
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
            if(startPanel) startPanel.SetActive(false);
            if(tutorialPanel) tutorialPanel.SetActive(false);
            if(hudPanel) hudPanel.SetActive(false);
            if(gameOverPanel) gameOverPanel.SetActive(false);
            if(victoryPanel) victoryPanel.SetActive(false);
            if(pausePanel) pausePanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}