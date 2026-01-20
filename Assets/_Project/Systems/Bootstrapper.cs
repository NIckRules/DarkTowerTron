using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.AudioSystem;
using DarkTowerTron.Systems.Score; // Add this namespace
using DarkTowerTron.Systems.TimeManagement;

namespace DarkTowerTron.Systems
{
    [DefaultExecutionOrder(-100)]
    public class Bootstrapper : MonoBehaviour
    {
        [Header("System Prefabs")]
        [SerializeField] private AudioManager _audioManagerPrefab;
        [SerializeField] private ScoreSystem _scoreSystemPrefab; // 1. Add this field
    
        private static bool _isInitialized = false;

        private void Awake()
        {
            if (_isInitialized)
            {
                Destroy(gameObject);
                return;
            }

            _isInitialized = true;
            DontDestroyOnLoad(gameObject);

            RegisterServices();
        }

        private void RegisterServices()
        {
            ServiceLocator.Reset();

            // 1. Audio
            var audioInstance = Instantiate(_audioManagerPrefab, transform);
            audioInstance.name = "Service_Audio";
            ServiceLocator.Register<IAudioService>(audioInstance);

            // 2. Score (Add this logic)
            var scoreInstance = Instantiate(_scoreSystemPrefab, transform);
            scoreInstance.name = "Service_Score";
            ServiceLocator.Register<IScoreService>(scoreInstance);

            // 3. Time
            var timeService = GetComponentInChildren<TimeService>();
            if (timeService != null)
            {
                ServiceLocator.Register<ITimeService>(timeService);
            }
            else
            {
                Debug.LogWarning("[Bootstrapper] TimeService not found in children. ITimeService will not be registered.");
            }

            Debug.Log("<color=cyan>[Bootstrapper]</color> Services Initialized.");
        }
    }
}