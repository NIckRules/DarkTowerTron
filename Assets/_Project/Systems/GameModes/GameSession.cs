using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Physics; // For UnityCharacterMover
using DarkTowerTron.Gameplay.Environment; // For PlayerStart
using DarkTowerTron.Gameplay.Player; // For PlayerController
using DarkTowerTron.Systems.UI;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Systems.GameModes
{
    public class GameSession : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        [Header("Manager References")]
        public UIManager uiManager;

        [Header("Music")]
        [SerializeField] private MusicProfileSO _mainCombatTheme;
        // NEW: Fallback music profile if the zone has none
        [SerializeField] private MusicProfileSO _defaultMusicTheme;

        [Header("Debug")]
        public string activeSpawnID = "Start";

        private bool _isGameRunning = false;
        private bool _isPaused = false;
        private GameControls _controls;
        
        // Cache the player locally
        private PlayerController _player;

        private void Awake()
        {
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
            // Instant access, O(1) performance
            _player = PlayerController.Instance;

            // Safety fallback: if execution order is unusual, recover gracefully.
            if (_player == null)
            {
                _player = FindObjectOfType<PlayerController>();
                if (_player == null)
                    Debug.LogWarning("[GameSession] PlayerController.Instance is null (player not yet initialized or missing in scene).");
            }

            Time.timeScale = 0f;

            if (uiManager) uiManager.ShowStartMenu();

            MovePlayerToStart();

            // --- AUDIO TRIGGER ---
            var audio = ServiceLocator.Get<IAudioService>();
            if (audio != null && _mainCombatTheme != null)
            {
                audio.PlayMusicProfile(_mainCombatTheme);
            }
            
            // Lock input until game begins
            if (_player) _player.ToggleInput(false);
        }

        // --- PUBLIC UI FUNCTIONS ---

        public void BeginGame()
        {
            _isGameRunning = true;
            _isPaused = false;
            Time.timeScale = 1f;

            if (uiManager) uiManager.ShowHUD();

            if (_player)
            {
                _player.ToggleInput(true);

                // Refresh UI (Optional, if UI doesn't auto-hook)
                var health = _player.GetComponent<PlayerHealth>();
                if (health) health.ForceUpdateUI();
            }
            
            // Note: We no longer call WaveService.StartGame(). 
            // The WaveTriggers in the level will handle spawning when the player enters.
        }

        public void TogglePause()
        {
            if (!_isGameRunning) return;

            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0f;
                if (uiManager) uiManager.ShowPause();
                if (_player) _player.ToggleInput(false);
            }
            else
            {
                Time.timeScale = 1f;
                if (uiManager) uiManager.ShowHUD();
                if (_player) _player.ToggleInput(true);
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
            Debug.Log("EXITING...");
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
            if (_player) _player.ToggleInput(false);
        }

        private void TriggerVictory()
        {
            if (!_isGameRunning) return;
            _isGameRunning = false;
            Time.timeScale = 0.5f;
            if (uiManager) uiManager.ShowVictory();
            if (_player) _player.ToggleInput(false);
        }

        private void MovePlayerToStart()
        {
            if (_player == null) return;

            // 1. Find Spawn Point
            Transform targetPoint = PlayerStart.GetSpawnPoint(activeSpawnID);
            if (targetPoint == null)
            {
                Debug.LogWarning($"[GameSession] Spawn Point '{activeSpawnID}' not found!");
                return;
            }

            // 2. Teleport Player
            var mover = _player.GetComponent<UnityCharacterMover>();
            if (mover != null)
            {
                mover.Teleport(targetPoint.position);
            }
            else
            {
                _player.transform.position = targetPoint.position;
            }
            _player.transform.rotation = targetPoint.rotation;

            // --- 3. NEW: Resolve Music Context ---
            // Check if this spawn point belongs to a specific Zone
            Zone parentZone = targetPoint.GetComponentInParent<Zone>();
            var audio = ServiceLocator.Get<IAudioService>();
            if (audio != null)
            {
                if (parentZone != null && parentZone.zoneMusicProfile != null)
                {
                    // Zone has specific profile? Play it.
                    audio.PlayMusicProfile(parentZone.zoneMusicProfile);
                }
                else if (_defaultMusicTheme != null)
                {
                    // No Zone / No Profile? Play Default.
                    audio.PlayMusicProfile(_defaultMusicTheme);
                }
            }
        }
    }
}