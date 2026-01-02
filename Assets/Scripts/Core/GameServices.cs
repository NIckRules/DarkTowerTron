using UnityEngine;
using DarkTowerTron.Managers;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core
{
    [DefaultExecutionOrder(-100)] // Init before everything else
    public class GameServices : MonoBehaviour
    {
        public static GameServices Instance { get; private set; }

        [Header("System Services")]
        [SerializeField] private WaveDirector _waveDirector;
        [SerializeField] private ScoreManager _scoreManager;
        [SerializeField] private PoolManager _poolManager;
        [SerializeField] private VFXManager _vfxManager;
        [SerializeField] private AudioManager _audioManager;
        [SerializeField] private DamageTextManager _damageTextManager;

        // Dynamic Services (Set at runtime)
        public static PlayerController Player { get; private set; }

        // Public Accessors
        public static WaveDirector WaveDirector => Instance != null ? Instance._waveDirector : null;
        public static ScoreManager Score => Instance != null ? Instance._scoreManager : null;
        public static PoolManager Pool => Instance != null ? Instance._poolManager : null;
        public static VFXManager VFX => Instance != null ? Instance._vfxManager : null;
        public static AudioManager Audio => Instance != null ? Instance._audioManager : null;
        public static DamageTextManager DamageText => Instance != null ? Instance._damageTextManager : null;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }

        public static void RegisterPlayer(PlayerController player)
        {
            Player = player;
            GameLogger.Log(LogChannel.System, "[GameServices] Player Registered.", player != null ? player.gameObject : null);
        }

        private void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}