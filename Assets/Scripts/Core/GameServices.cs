using UnityEngine;
using DarkTowerTron.Managers;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core
{
    /// <summary>
    /// The Central Registry.
    /// Provides global, high-speed access to core systems without FindObjectOfType.
    /// </summary>
    [DefaultExecutionOrder(-100)] // Ensures this initializes before anything else
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
        [SerializeField] private PerkManager _perkManager; // NEW: Added PerkManager

        // Dynamic Services (Set at runtime)
        public static PlayerController Player { get; private set; }

        // Public Accessors (Safe null checking)
        public static WaveDirector WaveDirector => Instance != null ? Instance._waveDirector : null;
        public static ScoreManager Score => Instance != null ? Instance._scoreManager : null;
        public static PoolManager Pool => Instance != null ? Instance._poolManager : null;
        public static VFXManager VFX => Instance != null ? Instance._vfxManager : null;
        public static AudioManager Audio => Instance != null ? Instance._audioManager : null;
        public static DamageTextManager DamageText => Instance != null ? Instance._damageTextManager : null;
        public static PerkManager Perks => Instance != null ? Instance._perkManager : null; // NEW

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
            Debug.Log("[GameServices] Player Registered.");
        }

        private void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}