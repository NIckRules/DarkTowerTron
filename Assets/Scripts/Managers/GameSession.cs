using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Environment;
using DarkTowerTron.Physics;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DarkTowerTron.Managers
{
    public class GameSession : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        [Header("Manager References")]
        public UIManager uiManager;

        [Header("Debug")]
        public string activeSpawnID = "Start";

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;

        private void Awake()
        {
            GameServices.RegisterSession(this);
            _controls = new GameControls();
            _controls.Gameplay.Pause.performed += ctx => TogglePause();
        }

        private void OnEnable()
        {
            _controls.Enable();
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += TriggerGameOver;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised += TriggerVictory;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= TriggerGameOver;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised -= TriggerVictory;
            _controls.Disable();
        }

        private void Start()
        {
            Time.timeScale = 0f;

            // Use UIManager
            if (uiManager) uiManager.ShowStartMenu();

            // Locate Player via Service
            MovePlayerToStart();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            Time.timeScale = 1f;

            if (uiManager) uiManager.ShowHUD();

            if (GameServices.Player)
            {
                GameServices.Player.ToggleInput(true);

                // Refresh UI
                var health = GameServices.Player.GetComponent<PlayerHealth>();
                if (health) health.ForceUpdateUI();
            }

            if (GameServices.WaveDirector) GameServices.WaveDirector.StartGame();
        }

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                if (uiManager) uiManager.ShowPause();
                if (GameServices.Player) GameServices.Player.ToggleInput(false);
            }
            else
            {
                Time.timeScale = 1f;
                if (uiManager) uiManager.ShowHUD();
                if (GameServices.Player) GameServices.Player.ToggleInput(true);
            }
        }

        public void OpenTutorial()
        {
            if (uiManager) uiManager.ShowTutorial();
        }

        public void BackToMenu()
        {
            if (uiManager) uiManager.ShowStartMenu();
        }

        public void RestartGame()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void QuitGame()
        {
            GameLogger.Log(LogChannel.System, "EXITING...", gameObject);
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
            if (uiManager) uiManager.ShowGameOver();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.5f;
            if (uiManager) uiManager.ShowVictory();
            if (GameServices.Player) GameServices.Player.ToggleInput(false);
        }

        private void MovePlayerToStart()
        {
            if (GameServices.Player == null) return;

            // FIX: Query the Registry
            Transform targetPoint = PlayerStart.GetSpawnPoint(activeSpawnID);
            if (targetPoint == null)
            {
                Debug.LogWarning($"[GameSession] Spawn Point '{activeSpawnID}' not found!");
                return;
            }

            // Move Logic
            var uMover = GameServices.Player.GetComponent<UnityCharacterMover>();
            if (uMover != null)
            {
                uMover.Teleport(targetPoint.position);
            }
            else
            {
                // Back-compat: some setups may still use the custom mover
                var kMover = GameServices.Player.GetComponent<KinematicMover>();
                if (kMover != null) kMover.Teleport(targetPoint.position);
                else GameServices.Player.transform.position = targetPoint.position;
            }

            GameServices.Player.transform.rotation = targetPoint.rotation;
        }
    }
}