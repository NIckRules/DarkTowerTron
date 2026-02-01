# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2026-01-25 09:49
- **Files:** 196
- **Total LOC:** 13285
- **Estimated tokens:** 106972

## 📁 Project Tree
```
Assets
  _Project
    Core
      AudioSystem
        AudioService.cs
        IAudioService.cs
        MusicManager.cs
      CircleRenderer.cs
      Data
        ActorThemeSO.cs
        AttackPatternSO.cs
        DebugProfileSO.cs
        EnemyAttackSO.cs
        EnemyStatsSO.cs
        EnemyVisualProfileSO.cs
        FeedbackProfileSO.cs
        MaterialCollectionSO.cs
        PaletteData.cs
        PaletteDefinitionSO.cs
        PaletteVariantConfigSO.cs
        PlayerStatsSO.cs
        SoundDef.cs
        SurfaceType.cs
        UIThemeSO.cs
        WaveDefinitionSO.cs
      Debugging
        GameLogger.cs
        GateDebugger.cs
        LogChannel.cs
      Editor
        Tool
          SmartDuplicator.cs
      Events
        BoolEventChannelSO.cs
        DamageTextEventChannelSO.cs
        EnemyKilledEventChannelSO.cs
        FloatFloatEventChannelSO.cs
        IntEventChannelSO.cs
        IntIntEventChannelSO.cs
        NarrativeEventChannelSO.cs
        PopupTextEventChannelSO.cs
        StringEventChannelSO.cs
        TooltipEventChannelSO.cs
        TransformEventChannelSO.cs
        Vector3EventChannelSO.cs
        VoidEventChannelSO.cs
        VoidEventListener.cs
      Feedback
        CameraShaker.cs
        Command
          CameraShakeCommand.cs
          PlaySoundCommand.cs
          SpawnVFXCommand.cs
          TimeFreezeCommand.cs
        FeedbackCommand.cs
        FeedbackConfigurationSO.cs
      GameConstants.cs
      Input
        InputBuffer.cs
      Patterns
        IPoolService.cs
        IPoolable.cs
        PoolService.cs
      Physics
        IMovementStrategy.cs
        IMover.cs
        KinematicMover.cs
        UnityCharacterMover.cs
      Resources
        DOTweenSettings.asset
        DebugProfile.asset
        [GlobalSystems].prefab
      Services
        BootLoader.cs
        IGameService.cs
        ServiceLocator.cs
      Spinner.cs
      Utiities
        GameEventListener.cs
        LayerAutomator.cs
        Rotator.cs
    Gameplay
      AI
        Behaviours
          AvoidanceBehavior.cs
          FleeBehaviour.cs
          OrbitBehavior.cs
          SeekBehaviour.cs
          VoidAvoidanceBehavior.cs
        Core
          AIData.cs
          ContextSolver.cs
          Detector.cs
          SteeringBehaviour.cs
        Detectors
          ObstacleDetector.cs
          TargetDetector.cs
        Paths
          AutoAssignPatrolPath.cs
          PatrolPath.cs
          Waypoint.cs
        Pluggable
          Actions
            Action_ContextSteering.cs
            Action_FirePattern.cs
            Action_Patrol.cs
            Action_SelfDestruct.cs
            Action_Visual_Prime.cs
          Core
            AIAction.cs
            AIBlackboard.cs
            AIDecision.cs
            AIState.cs
            PluggableAIController.cs
          Decisions
            Decision_InRange.cs
            Decision_LineOfSight.cs
            Decision_TimeElapsed.cs
        Utils
          AIDebugger.cs
          AIDirections.cs
      Cameras
        CameraRig.cs
      Combat
        ContactDamager.cs
        DamageInfo.cs
        DamageReceiver.cs
        DamageType.cs
        FirePointRegistry.cs
        HazardZone.cs
        HitBox
          BaseHitbox.cs
          ShieldHitbox.cs
          StandardHitbox.cs
        IAimTarget.cs
        ICombatTarget.cs
        IDamageable.cs
        IReflectable.cs
        IWeapon.cs
        Modules
          StaggerModule.cs
          VitalityModule.cs
        PatternExecutor.cs
        Projectile.cs
        Strategies
          HomingMovement.cs
          LinearMovement.cs
          SineWaveMovement.cs
      Enemies
        Bosses
          Architect
            ArchitectController.cs
            ArchitectHand.cs
            Data
              ArchitectPatternSO.cs
        EnemyBaseAI.cs
        EnemyController.cs
        EnemyMotors.cs
        Modules
          EnemyPatrolModule.cs
        Visuals
          EnemyVisuals.cs
      Environment
        ArenaGate.cs
        CameraZone.cs
        Editor
          ZoneEditor.cs
        Encounter
          ArenaController.cs
          EncounterTrigger.cs
        ILockable.cs
        LevelEndTrigger.cs
        PlayerStart.cs
        Props
          Prop_Anchor.cs
          Prop_Explosive.cs
        TileInfo.cs
        TileSocket.cs
        VoidKiller.cs
        Zone.cs
      Player
        Combat
          PlayerBeam.cs
          PlayerExecution.cs
          PlayerGun.cs
          PlayerWeaponController.cs
          TargetScanner.cs
          WeaponBase.cs
        Controller
          PlayerController.cs
          PlayerInputHandler.cs
        Movement
          AfterImage.cs
          PlayerDodge.cs
          PlayerMotor.cs
        Stats
          PlayerEnergy.cs
          PlayerHealth.cs
          PlayerLoadout.cs
          PlayerStats.cs
      Visuals
        PaletteReceiver.cs
    Systems
      Bootstrapper.cs
      Debugging
        DebugController.cs
      GameModes
        GameSession.cs
      Level
        LevelPrewarmer.cs
        LevelSystem.cs
      Narrative
        NarrativeDirector.cs
        NarrativeLibrarySO.cs
        TextCorruptor.cs
      Persistence
        Editor
          PersistenceServiceEditor.cs
        IPersistenceService.cs
        PersistenceService.cs
        SaveData.cs
        StatsTracker.cs
      Score
        IScoreService.cs
        ScoreService.cs
      Stats
        ModifiableStat.cs
        PerkDatabaseSO.cs
        PerkSO.cs
        StatEnums.cs
      TimeManagement
        ITimeService.cs
        TimeService.cs
      UI
        ActivePerksPanel.cs
        AnnouncementUI.cs
        CountdownUI.cs
        DamageTextManager.cs
        FloatingText.cs
        HUDManager.cs
        MenuController.cs
        NarrativeUI.cs
        PerkIconUI.cs
        ResultScreen.cs
        TooltipManager.cs
        TooltipTrigger.cs
        UIManager.cs
        UIThemeReceiver.cs
      VFX
        GameFeedbackSystem.cs
        IVFXService.cs
        VFXService.cs
      Visuals
        IPaletteService.cs
        PaletteEnvironmentBridge.cs
        PaletteService.cs
      Waves
        IWaveService.cs
        WaveService.cs
```

## 📄 `Assets\_Project\Core\AudioSystem\AudioService.cs`
- Lines: 129
- Size: 4.1 KB
- Modified: 2026-01-20 17:59

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.AudioSystem
{
    public class AudioService : MonoBehaviour, IAudioService
    {
        [Header("Modules")]
        [SerializeField] private MusicManager _musicManager;
        [SerializeField] private AudioSource _sfxSourcePrefab;

        [Header("Settings")]
        [SerializeField] private int _initialPoolSize = 10;

        private List<AudioSource> _sfxPool;

        private void Awake()
        {
            // 1. Register Service
            ServiceLocator.Register<IAudioService>(this);

            // 2. Init Submodules
            InitializePool();

            if (_musicManager == null)
                _musicManager = GetComponentInChildren<MusicManager>();

            if (_musicManager == null)
                Debug.LogWarning("[AudioService] No MusicManager found in children!");
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IAudioService>(this);
        }

        // --- SFX Logic (Pooling) ---

        private void InitializePool()
        {
            _sfxPool = new List<AudioSource>();
            for (int i = 0; i < _initialPoolSize; i++) CreateNewSource();
        }

        private AudioSource CreateNewSource()
        {
            var source = Instantiate(_sfxSourcePrefab, transform);
            source.gameObject.SetActive(false);
            _sfxPool.Add(source);
            return source;
        }

        private AudioSource GetFreeSource()
        {
            foreach (var s in _sfxPool) if (!s.gameObject.activeInHierarchy) return s;
            return CreateNewSource();
        }

        // --- IAudioService Implementation ---

        // 1. Generic Entry Point
        public void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f)
        {
            if (soundDef == null) return;

            if (soundDef is SoundDef def)
            {
                PlaySFX(def, position);
            }
            else if (soundDef is AudioClip clip)
            {
                PlaySFX(clip, position, volume);
            }
        }

        // 2. SoundDef Logic (Pitch Variation)
        public void PlaySFX(SoundDef sound, Vector3 position)
        {
            if (sound == null) return;
            AudioClip clip = sound.GetClip();
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = sound.volume;
            source.pitch = sound.GetPitch(); // Apply Variation
            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length / source.pitch));
        }

        // 3. Raw Clip Logic
        public void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f)
        {
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = volume;
            source.pitch = 1f;
            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length));
        }

        // 4. Music Forwarding (Facade)
        public void PlayMusic(AudioClip musicClip, float fadeDuration = 1f)
            => _musicManager?.PlayMusic(musicClip, fadeDuration);

        public void StopMusic(float fadeDuration = 1f)
            => _musicManager?.StopMusic(fadeDuration);

        public void SetMusicVolume(float volume)
            => _musicManager?.SetVolume(volume);

        private System.Collections.IEnumerator DisableSourceDelayed(AudioSource source, float delay)
        {
            // Small buffer to ensure clip finishes
            yield return new WaitForSeconds(delay + 0.1f);
            source.gameObject.SetActive(false);
        }
    }
}
```

## 📄 `Assets\_Project\Core\AudioSystem\IAudioService.cs`
- Lines: 18
- Size: 0.6 KB
- Modified: 2026-01-20 14:07

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Data; // For SoundDef

namespace DarkTowerTron.Core.AudioSystem
{
    public interface IAudioService : IGameService
    {
        void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f);

        void PlaySFX(SoundDef sound, Vector3 position);
        void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f);

        void PlayMusic(AudioClip musicClip, float fadeDuration = 1f);
        void StopMusic(float fadeDuration = 1f);
        void SetMusicVolume(float volume);
    }
}
```

## 📄 `Assets\_Project\Core\AudioSystem\MusicManager.cs`
- Lines: 80
- Size: 2.4 KB
- Modified: 2026-01-20 18:00

```csharp
using UnityEngine;
using DG.Tweening; // Ensure you have DOTween installed/referenced
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Core.AudioSystem
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        [Header("Listening")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        private AudioSource _source;
        private float _originalPitch;
        private float _originalVolume = 1f;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void OnEnable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnDeath;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnDeath;
        }

        public void PlayMusic(AudioClip clip, float fadeDuration)
        {
            if (clip == null) return;
            if (_source.clip == clip && _source.isPlaying) return;

            _source.DOKill();

            if (_source.isPlaying)
            {
                // Crossfade
                _source.DOFade(0f, fadeDuration * 0.5f).OnComplete(() =>
                {
                    _source.clip = clip;
                    _source.Play();
                    _source.DOFade(_originalVolume, fadeDuration * 0.5f);
                });
            }
            else
            {
                // Fade In
                _source.clip = clip;
                _source.volume = 0f;
                _source.Play();
                _source.DOFade(_originalVolume, fadeDuration);
            }
        }

        public void StopMusic(float fadeDuration)
        {
            _source.DOKill();
            _source.DOFade(0f, fadeDuration).OnComplete(() => _source.Stop());
        }

        public void SetVolume(float volume)
        {
            _originalVolume = volume;
            _source.DOFade(volume, 0.5f);
        }

        private void OnDeath()
        {
            // Warren Spector / Deus Ex style death pitch shift
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true);
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }
    }
}
```

## 📄 `Assets\_Project\Core\CircleRenderer.cs`
- Lines: 51
- Size: 1.4 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    [RequireComponent(typeof(LineRenderer))]
    public class CircleRenderer : MonoBehaviour
    {
        [Header("Settings")]
        public int segments = 50; // Smoothness
        public float radius = 1.0f;
        public float lineWidth = 0.1f;

        private LineRenderer _line;

        void Awake()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        // Draw immediately in Editor so you can see it
        void OnValidate()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        public void DrawCircle()
        {
            if (_line == null) return;

            _line.useWorldSpace = false; // Move with the parent
            _line.startWidth = lineWidth;
            _line.endWidth = lineWidth;
            _line.positionCount = segments + 1; // +1 to close the loop

            float angleStep = 360f / segments;

            for (int i = 0; i < segments + 1; i++)
            {
                float angle = i * angleStep * Mathf.Deg2Rad;

                // Draw on X/Z plane (Flat on ground)
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;

                _line.SetPosition(i, new Vector3(x, 0, z));
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\ActorThemeSO.cs`
- Lines: 13
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/Actor Theme")]
    public class ActorThemeSO : ScriptableObject
    {
        [Header("3-Tone Palette")]
        public SurfaceDefinition primary;   // Main Body (e.g. Armor)
        public SurfaceDefinition secondary; // Details (e.g. Joints/Frame)
        public SurfaceDefinition tertiary;  // Accents (e.g. Eyes/Core - High Emission)
    }
}
```

## 📄 `Assets\_Project\Core\Data\AttackPatternSO.cs`
- Lines: 37
- Size: 1.3 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    // Define Enum here so it's accessible
    public enum AimType
    {
        TargetPlayer,   // Guardian style (Aim at player)
        ForwardRadial   // Boss style (Shoot straight out from hand)
    }

    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Anatomy")]
        [Tooltip("Must match an ID in the Enemy's FirePointRegistry (e.g. 'Muzzle', 'Eye').")]
        public string firePointID = "Default";

        [Header("Aiming & Visuals")]
        public AimType aimMode = AimType.TargetPlayer;
        public float scaleMultiplier = 1.0f; // Boss bullets are huge
        public float speed = 15f;            // Projectile speed

        [Header("Pattern Shape")]
        public int projectileCount = 1;      // How many bullets per "Trigger"
        [Range(0, 360)] public float spreadAngle = 0f;
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float startDelay = 0.5f;      // Windup time
        public float delayBetweenShots = 0.1f; // Time between individual bullets in a burst/stream

        [Header("Cooldown")]
        public float cooldownAfterBurst = 1.0f; // Enforce pacing
    }
}
```

## 📄 `Assets\_Project\Core\Data\DebugProfileSO.cs`
- Lines: 54
- Size: 1.8 KB
- Modified: 2026-01-18 23:51

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Debugging;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "DebugProfile", menuName = "DarkTowerTron/Debug/Profile")]
    public class DebugProfileSO : ScriptableObject
    {
        [Header("Global Toggle")]
        public bool enableLogging = true;

        [Header("Channels")]
        public bool logPlayer = true;
        public bool logAI = true;
        public bool logCombat = true;
        public bool logUI = true;
        public bool logPhysics = false; // Usually noisy, keep off
        public bool logSystem = true;
        public bool logVFX = false;

        public bool IsChannelActive(LogChannel channel)
        {
            if (!enableLogging) return false;

            switch (channel)
            {
                case LogChannel.Player: return logPlayer;
                case LogChannel.AI: return logAI;
                case LogChannel.Combat: return logCombat;
                case LogChannel.UI: return logUI;
                case LogChannel.Physics: return logPhysics;
                case LogChannel.System: return logSystem;
                case LogChannel.VFX: return logVFX;
                default: return true;
            }
        }

        // Color coding for the console to make reading faster
        public string GetColor(LogChannel channel)
        {
            switch (channel)
            {
                case LogChannel.Player: return "cyan";
                case LogChannel.AI: return "orange";
                case LogChannel.Combat: return "red";
                case LogChannel.UI: return "yellow";
                case LogChannel.Physics: return "green";
                case LogChannel.System: return "white";
                default: return "grey";
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\EnemyAttackSO.cs`
- Lines: 22
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Attack_New", menuName = "DarkTowerTron/Combat/Enemy Attack Profile")]
    public class EnemyAttackSO : ScriptableObject
    {
        [Header("Offensive Stats")]
        public float damage = 10f;
        [Min(0)] public int stagger = 1;

        [Header("Projectile Settings")]
        [Tooltip("Leave empty if this is a melee attack.")]
        public GameObject projectilePrefab;
        public float projectileSpeed = 15f;
        public float lifetime = 5f;

        [Header("Accuracy")]
        [Tooltip("0 = Perfect Aim. Higher = More spread.")]
        public float spreadAngle = 0f;
    }
}
```

## 📄 `Assets\_Project\Core\Data\EnemyStatsSO.cs`
- Lines: 66
- Size: 2.4 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewEnemyStats", menuName = "DarkTowerTron/Enemy Stats")]
    public class EnemyStatsSO : ScriptableObject
    {
        [Header("Wave Logic")]
        public bool isEssential = true;

        [Header("Rewards")]
        public int scoreValue = 100;
        public float focusReward = 30f;
        public bool healsGrit = true;
        [Min(1)] public int gritRewardAmount = 1;

        [Header("Movement")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f; // Fast, for navigation
        public float combatRotationSpeed = 3f; // Slow, for aiming at player
        public float acceleration = 20f;

        [Header("Flight (Set 0 for Ground)")]
        public float rideHeight = 0f;
        public float verticalSmoothTime = 0.5f;

        [Header("Separation (Flocking)")]
        public float separationRadius = 1.5f;
        public float separationForce = 8f;

        [Header("Combat & Stagger")]
        public float maxHealth = 10f; // NEW: Actual HP
        [Min(1)] public int maxStagger = 3; // INT (e.g. 3 hits)
        public float staggerDecay = 1.0f; // Decay speed (1 per second)

        [Header("Defenses")]
        public bool hasFrontalShield = false;
        [Range(0f, 1f)] public float shieldAngle = 0.5f;

        // --- NEW: VALIDATION LOGIC ---
        // This runs automatically whenever you change a value in the Inspector
        private void OnValidate()
        {
            // Prevent negative movement
            moveSpeed = Mathf.Max(0f, moveSpeed);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);
            combatRotationSpeed = Mathf.Max(0.1f, combatRotationSpeed);
            acceleration = Mathf.Max(0.1f, acceleration); // 0 accel = infinite stuck

            // Prevent negative rewards
            scoreValue = Mathf.Max(0, scoreValue);
            focusReward = Mathf.Max(0f, focusReward);
            gritRewardAmount = Mathf.Max(1, gritRewardAmount);

            // Prevent 0 HP zombies
            maxHealth = Mathf.Max(1f, maxHealth);

            // Stagger must be a positive integer and decay shouldn't be zero
            maxStagger = Mathf.Max(1, maxStagger);
            staggerDecay = Mathf.Max(0.01f, staggerDecay);

            // Flocking safety
            separationRadius = Mathf.Max(0.1f, separationRadius);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\EnemyVisualProfileSO.cs`
- Lines: 20
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Visuals_Default", menuName = "DarkTowerTron/Visuals/Enemy Visual Profile")]
    public class EnemyVisualProfileSO : ScriptableObject
    {
        [Header("Impact Feel")]
        [Tooltip("How long the white flash lasts on impact.")]
        public float hitFlashDuration = 0.1f;

        [Header("Status Effects")]
        [Tooltip("Time for one full pulse (Stagger -> Danger -> Stagger).")]
        public float staggerPulseDuration = 0.4f;
        
        [Tooltip("Color to pulse to during stagger (usually Red for danger).")]
        [ColorUsage(true, true)] 
        public Color dangerPulseColor = Color.red; 
    }
}
```

## 📄 `Assets\_Project\Core\Data\FeedbackProfileSO.cs`
- Lines: 18
- Size: 0.5 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Feedback Profile")]
    public class FeedbackProfileSO : ScriptableObject
    {
        [Header("Camera Shake")]
        public float shakeDuration = 0.2f;
        public float shakeStrength = 0.5f;

        [Header("Time Freeze")]
        public float hitStopDuration = 0.1f;

        [Header("Audio")]
        public SoundDef sound; // Reuses your SoundDef system!
    }
}
```

## 📄 `Assets\_Project\Core\Data\MaterialCollectionSO.cs`
- Lines: 12
- Size: 0.4 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/Material Collection")]
    public class MaterialCollectionSO : ScriptableObject
    {
        [Tooltip("All materials in this list will share the same color palette.")]
        public List<Material> materials;
    }
}
```

## 📄 `Assets\_Project\Core\Data\PaletteData.cs`
- Lines: 31
- Size: 0.8 KB
- Modified: 2026-01-18 23:33

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public struct SurfaceDefinition
    {
        [ColorUsage(true, true)] public Color mainColor;
        [Range(0f, 1f)] public float smoothness;
        [Range(0f, 1f)] public float metallic;

        [ColorUsage(true, true)] public Color emissionColor;
        public float emissionIntensity;
    }

    [System.Serializable]
    public struct SurfaceOverride
    {
        [HideInInspector] public string surfaceName; // Legacy
        public SurfaceType surfaceType;
        public SurfaceDefinition definition;
    }

    [System.Serializable]
    public class PaletteVariant
    {
        public string variantName;
        public List<SurfaceOverride> overrides;
    }
}
```

## 📄 `Assets\_Project\Core\Data\PaletteDefinitionSO.cs`
- Lines: 103
- Size: 3.9 KB
- Modified: 2026-01-18 23:38

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewPalette", menuName = "DarkTowerTron/Visuals/Color Palette")]
    public class PaletteDefinitionSO : ScriptableObject
    {
        [Header("Player Theme")]
        public SurfaceDefinition playerPrimary;
        public SurfaceDefinition playerSecondary;
        public SurfaceDefinition playerTertiary;

        [Header("Enemy Theme")]
        public SurfaceDefinition enemyPrimary;
        public SurfaceDefinition enemySecondary;
        public SurfaceDefinition enemyTertiary;

        [Header("Combat & FX")]
        public SurfaceDefinition projectileHostile;
        public SurfaceDefinition projectileFriendly;
        public SurfaceDefinition projectileParryable;
        public SurfaceDefinition beamAttack;
        public SurfaceDefinition blitzReady;
        public SurfaceDefinition blitzCooldown;

        [Header("Feedback")]
        [ColorUsage(true, true)] public Color hitFlashColor = Color.white;
        [ColorUsage(true, true)] public Color staggerColor = Color.yellow;

        [Header("Environment")]
        public SurfaceDefinition floor;
        public SurfaceDefinition walls;
        public SurfaceDefinition hazards;
        public SurfaceDefinition voidZone;
        public SurfaceDefinition anchor;

        [Header("Global Environment")]
        public Color skyColor = Color.black;

        [Range(0f, 0.1f)]
        public float fogDensity = 0.02f;

        [Header("Variants")]
        [Tooltip("Drop PaletteVariantConfigSO assets here (e.g. 'Enraged', 'LowHealth').")]
        public List<PaletteVariantConfigSO> variants;

        // --- LOGIC ---

        public SurfaceDefinition GetSurface(SurfaceType type, string activeVariantName)
        {
            // 1. Check for Active Variant Override
            if (!string.IsNullOrEmpty(activeVariantName) && variants != null)
            {
                // Find the matching Config SO
                var activeConfig = variants.Find(v => v != null && v.variantName == activeVariantName);

                if (activeConfig != null)
                {
                    if (activeConfig.TryGetOverride(type, out var overrideDef))
                    {
                        return overrideDef;
                    }
                }
            }

            // 2. Return Base Surface (Default)
            return GetBaseSurface(type);
        }

        private SurfaceDefinition GetBaseSurface(SurfaceType type)
        {
            switch (type)
            {
                case SurfaceType.None: return new SurfaceDefinition();

                case SurfaceType.PlayerPrimary: return playerPrimary;
                case SurfaceType.PlayerSecondary: return playerSecondary;
                case SurfaceType.PlayerTertiary: return playerTertiary;

                case SurfaceType.EnemyPrimary: return enemyPrimary;
                case SurfaceType.EnemySecondary: return enemySecondary;
                case SurfaceType.EnemyTertiary: return enemyTertiary;

                case SurfaceType.ProjectileHostile: return projectileHostile;
                case SurfaceType.ProjectileFriendly: return projectileFriendly;
                case SurfaceType.BeamAttack: return beamAttack;
                case SurfaceType.BlitzReady: return blitzReady;
                case SurfaceType.BlitzCooldown: return blitzCooldown;

                case SurfaceType.Floor: return floor;
                case SurfaceType.Walls: return walls;
                case SurfaceType.Hazards: return hazards;
                case SurfaceType.VoidZone: return voidZone;
                case SurfaceType.Anchor: return anchor;

                default:
                    // Return a "Error Magenta" or blank definition if not found
                    return new SurfaceDefinition();
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\PaletteVariantConfigSO.cs`
- Lines: 35
- Size: 1.2 KB
- Modified: 2026-01-18 23:38

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewVariantConfig", menuName = "DarkTowerTron/Visuals/Palette Variant Config")]
    public class PaletteVariantConfigSO : ScriptableObject
    {
        [Tooltip("The ID used by code to activate this variant (e.g. 'Enraged', 'Phase2').")]
        public string variantName;

        [Tooltip("List of surfaces to override when this variant is active.")]
        public List<SurfaceOverride> overrides;

        /// <summary>
        /// Helper to find a specific override in this config.
        /// </summary>
        public bool TryGetOverride(SurfaceType type, out SurfaceDefinition definition)
        {
            // Iterate linearly (List is usually small, < 10 items)
            // For very large lists, we would cache this into a Dictionary on Enable.
            foreach (var ov in overrides)
            {
                if (ov.surfaceType == type)
                {
                    definition = ov.definition;
                    return true;
                }
            }

            definition = default;
            return false;
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\PlayerStatsSO.cs`
- Lines: 91
- Size: 3.5 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "PlayerStats_Default", menuName = "DarkTowerTron/Player/Base Stats")]
    public class PlayerStatsSO : ScriptableObject
    {
        [Header("Movement")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        [Header("Physics & Feel")]
        public float gravity = 20f;
        public float wallRepulsionForce = 5f;
        [Tooltip("Time gravity is suspended after a dash/kill")]
        [FormerlySerializedAs("postActionHangTime")]
        public float actionHangTime = 0.2f;

        [Header("Scanner")]
        public float scanRange = 25f;
        public float scanRadius = 2f;

        [Header("Resources")]
        public int maxGrit = 2;
        public float maxFocus = 100f;
        public float focusDecayRate = 5f;       // Moved here
        public float baseFocusOnKill = 30f;     // Moved here (Default reward)

        [Header("Dash / Dodge")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f;

        [Header("Weapon: Gun (Ranged)")]
        public float gunFireRate = 0.15f;
        public float gunDamage = 0f;    // Usually 0 for this game
        [Min(0)] public int gunStagger = 1; // 1 shot = 1 point

        [Header("Weapon: Beam (Melee)")]
        public float beamFireRate = 0.4f;
        public float beamDamage = 10f;
        [Min(0)] public int beamStagger = 1; // 1 hit = 1 point

        // --- Validation ---
        private void OnValidate()
        {
            moveSpeed = Mathf.Max(0f, moveSpeed);
            acceleration = Mathf.Max(0.01f, acceleration);
            deceleration = Mathf.Max(0f, deceleration);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);

            gravity = Mathf.Max(0f, gravity);
            wallRepulsionForce = Mathf.Max(0f, wallRepulsionForce);
            actionHangTime = Mathf.Max(0f, actionHangTime);

            scanRange = Mathf.Max(0f, scanRange);
            scanRadius = Mathf.Max(0f, scanRadius);

            maxGrit = Mathf.Max(1, maxGrit);
            maxFocus = Mathf.Max(0f, maxFocus);
            focusDecayRate = Mathf.Max(0f, focusDecayRate);
            baseFocusOnKill = Mathf.Max(0f, baseFocusOnKill);

            dashCost = Mathf.Max(0f, dashCost);
            dashDistance = Mathf.Max(0f, dashDistance);
            dashCooldown = Mathf.Max(0.001f, dashCooldown);

            gunFireRate = Mathf.Max(0.001f, gunFireRate);
            gunDamage = Mathf.Max(0f, gunDamage);
            gunStagger = Mathf.Max(0, gunStagger);

            beamFireRate = Mathf.Max(0.001f, beamFireRate);
            beamDamage = Mathf.Max(0f, beamDamage);
            beamStagger = Mathf.Max(0, beamStagger);

            overdriveThreshold = Mathf.Clamp(overdriveThreshold, 0f, 100f);
            overdriveSpeedMult = Mathf.Max(0.01f, overdriveSpeedMult);
            overdriveDamageMult = Mathf.Max(0f, overdriveDamageMult);
            overdriveFireRateMult = Mathf.Max(0.01f, overdriveFireRateMult);
        }

        [Header("Overdrive Modifiers")]
        public float overdriveThreshold = 80f;
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f; // Doubles damage
        public float overdriveFireRateMult = 1.5f; // Shoots faster (Multiplier > 1 means faster)
    }
}
```

## 📄 `Assets\_Project\Core\Data\SoundDef.cs`
- Lines: 33
- Size: 1.0 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Audio/Sound Definition")]
    public class SoundDef : ScriptableObject
    {
        [Header("Clips")]
        [Tooltip("Randomly plays one of these clips.")]
        public AudioClip[] clips;

        [Header("Settings")]
        [Range(0f, 1f)] public float volume = 1f;
        [Range(0.1f, 3f)] public float pitch = 1f;

        [Header("Variation")]
        public bool randomizePitch = true;
        [Range(0f, 0.5f)] public float randomPitchRange = 0.1f;

        // Logic to pick a clip
        public AudioClip GetClip()
        {
            if (clips == null || clips.Length == 0) return null;
            return clips[Random.Range(0, clips.Length)];
        }

        public float GetPitch()
        {
            if (!randomizePitch) return pitch;
            return pitch + Random.Range(-randomPitchRange, randomPitchRange);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Data\SurfaceType.cs`
- Lines: 32
- Size: 0.6 KB
- Modified: 2026-01-18 23:32

```csharp
namespace DarkTowerTron.Core.Data
{
    public enum SurfaceType
    {
        None = 0,

        // Player
        PlayerPrimary,
        PlayerSecondary,
        PlayerTertiary,

        // Enemy
        EnemyPrimary,
        EnemySecondary,
        EnemyTertiary,

        // Combat
        ProjectileHostile,
        ProjectileFriendly,
        ProjectileParryable,
        BeamAttack,
        BlitzReady,
        BlitzCooldown,

        // Environment
        Floor,
        Walls,
        Hazards,
        VoidZone,
        Anchor
    }
}
```

## 📄 `Assets\_Project\Core\Data\UIThemeSO.cs`
- Lines: 23
- Size: 0.7 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using TMPro;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/UI Theme")]
    public class UIThemeSO : ScriptableObject
    {
        [Header("Fonts")]
        public TMP_FontAsset mainFont;
        public TMP_FontAsset digitFont;

        [Header("Colors")]
        public Color primaryColor = Color.cyan;   // Titles / Borders
        public Color accentColor = Color.yellow;  // Buttons / Highlights
        public Color dangerColor = Color.red;     // Game Over / Health
        public Color bodyColor = Color.white;     // Normal Text

        [Header("Sprites")]
        public Sprite buttonBackground;
        public Sprite panelBackground;
    }
}
```

## 📄 `Assets\_Project\Core\Data\WaveDefinitionSO.cs`
- Lines: 52
- Size: 1.5 KB
- Modified: 2026-01-24 15:39

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    public enum EncounterType
    {
        Elimination, // Standard: Kill everything spawned.
        Reinforcement // Complex: Grunts respawn until VIPs (Essentials) are dead.
    }

    [CreateAssetMenu(menuName = "DarkTowerTron/Waves/Wave Definition")]
    public class WaveDefinitionSO : ScriptableObject
    {
        [Header("Meta")]
        public string waveName = "Wave 1";
        public EncounterType type = EncounterType.Elimination;

        [Header("Main Force")]
        [Tooltip("The core enemies for this wave. In Reinforcement mode, these are the VIPs.")]
        public List<WaveEntry> entries;

        [Header("Reinforcements (Grunts)")]
        [Tooltip("Infinite spawns if Type = Reinforcement. One-time spawn if Type = Elimination.")]
        public GameObject[] gruntPrefabs;
        public int maxGrunts = 0;
        public float gruntSpawnRate = 3f;

        // Helper Property
        public int TotalMainEnemyCount
        {
            get
            {
                int count = 0;
                if (entries != null)
                {
                    foreach (var e in entries) count += e.count;
                }
                return count;
            }
        }
    }

    [System.Serializable]
    public struct WaveEntry
    {
        public GameObject enemyPrefab;
        public int count;
        public float rate;
        public int spawnPointIndex;
    }
}
```

## 📄 `Assets\_Project\Core\Debugging\GameLogger.cs`
- Lines: 51
- Size: 1.9 KB
- Modified: 2026-01-18 23:52

```csharp
using System.Diagnostics;
using DarkTowerTron.Core.Data;
using UnityEngine;

namespace DarkTowerTron.Core.Debugging
{
    public static class GameLogger
    {
        private static DebugProfileSO _profile;

        // Auto-load the profile from Resources if not set, or assign manually
        private static DebugProfileSO Profile
        {
            get
            {
                if (_profile == null)
                    _profile = Resources.Load<DebugProfileSO>("DebugProfile");
                return _profile;
            }
        }

        // Only compile this code in the Editor or Development Builds
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void Log(LogChannel channel, string message, GameObject context = null)
        {
            if (Profile == null) return;
            if (!Profile.IsChannelActive(channel)) return;

            string color = Profile.GetColor(channel);
            string prefix = $"<color={color}>[{channel}]</color>";
            
            UnityEngine.Debug.Log($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogWarning(LogChannel channel, string message, GameObject context = null)
        {
            // Warnings usually ignore the filter, or you can add a separate filter
            string prefix = $"<color=yellow>[{channel} WARNING]</color>";
            UnityEngine.Debug.LogWarning($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogError(LogChannel channel, string message, GameObject context = null)
        {
            // Errors always show
            string prefix = $"<color=red>[{channel} ERROR]</color>";
            UnityEngine.Debug.LogError($"{prefix} {message}", context);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Debugging\GateDebugger.cs`
- Lines: 39
- Size: 1.1 KB
- Modified: 2026-01-23 15:33

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Environment;

namespace DarkTowerTron.Core.Debugging
{
    [RequireComponent(typeof(ArenaGate))]
    public class GateDebugger : MonoBehaviour
    {
        private ArenaGate _gate;

        private void Awake()
        {
            _gate = GetComponent<ArenaGate>();
        }

        private void OnGUI()
        {
            // Draw a button next to the object in World Space (projected to screen)
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

            // Only draw if visible
            if (screenPos.z > 0)
            {
                // Invert Y for GUI coordinates
                screenPos.y = Screen.height - screenPos.y;

                Rect rect = new Rect(screenPos.x, screenPos.y, 100, 30);

                string btnText = _gate.IsLocked ? "Unlock" : "Lock";

                if (GUI.Button(rect, btnText))
                {
                    if (_gate.IsLocked) _gate.Unlock();
                    else _gate.Lock();
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Debugging\LogChannel.cs`
- Lines: 14
- Size: 0.5 KB
- Modified: 2026-01-18 23:52

```csharp
namespace DarkTowerTron.Core.Debugging
{
    public enum LogChannel
    {
        General,    // Default
        Player,     // Input, Movement, State
        AI,         // Decisions, State changes, Pathing
        Combat,     // Damage, Projectiles, Hitboxes
        UI,         // Menu navigation, HUD updates
        Physics,    // Collisions, Triggers
        System,     // Wave Manager, Loading, Saving
        VFX         // Particles, Audio
    }
}
```

## 📄 `Assets\_Project\Core\Editor\Tool\SmartDuplicator.cs`
- Lines: 70
- Size: 2.5 KB
- Modified: 2025-12-30 09:50

```csharp
using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace DarkTowerTron.EditorTools
{
    public class SmartDuplicator : Editor
    {
        [MenuItem("Edit/Smart Duplicate %#d")]
        public static void DuplicateWithNaming()
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            if (selectedObjects.Length == 0) return;

            Undo.IncrementCurrentGroup();
            int undoIndex = Undo.GetCurrentGroup();

            System.Collections.Generic.List<GameObject> newSelection = new System.Collections.Generic.List<GameObject>();

            foreach (GameObject original in selectedObjects)
            {
                // FIX: Use standard Instantiate. 
                // In the Editor, this preserves the Prefab connection (Blue Text) automatically.
                GameObject clone = Instantiate(original, original.transform.parent);

                // Register Undo so Ctrl+Z removes the object
                Undo.RegisterCreatedObjectUndo(clone, "Smart Duplicate");

                // Match Transform
                clone.transform.localPosition = original.transform.localPosition;
                clone.transform.localRotation = original.transform.localRotation;
                clone.transform.localScale = original.transform.localScale;

                // Calculate Name
                string newName = IncrementName(original.name);
                clone.name = newName;

                newSelection.Add(clone);
            }

            // Select the new objects
            Selection.objects = newSelection.ToArray();
            Undo.CollapseUndoOperations(undoIndex);
        }

        private static string IncrementName(string originalName)
        {
            // Regex to find a number at the end (e.g. "_01" or " 1")
            Match match = Regex.Match(originalName, @"^(.*?)(\d+)$");

            if (match.Success)
            {
                string prefix = match.Groups[1].Value;
                string numberStr = match.Groups[2].Value;

                if (int.TryParse(numberStr, out int number))
                {
                    number++;
                    // Keep the leading zeros format (01 -> 02)
                    string newNumberStr = number.ToString(new string('0', numberStr.Length));
                    return prefix + newNumberStr;
                }
            }

            // Fallback: If no number found, add "_1"
            return originalName + "_1";
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\BoolEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Bool Event Channel")]
    public class BoolEventChannelSO : ScriptableObject
    {
        public UnityAction<bool> OnEventRaised;

        public void RaiseEvent(bool value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Bool Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\DamageTextEventChannelSO.cs`
- Lines: 21
- Size: 0.7 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Damage Text Channel")]
    public class DamageTextEventChannelSO : ScriptableObject
    {
        // Added 'isStagger' bool to the signature
        public UnityAction<Vector3, float, bool, bool> OnEventRaised;

        public void RaiseEvent(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(pos, amount, isCrit, isStagger);
            else
                GameLogger.LogWarning(LogChannel.UI, $"DamageText Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\EnemyKilledEventChannelSO.cs`
- Lines: 22
- Size: 0.8 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Enemy Killed Channel")]
    public class EnemyKilledEventChannelSO : ScriptableObject
    {
        // The action signature matches your old GameEvents logic
        public UnityAction<Vector3, EnemyStatsSO, bool> OnEventRaised;

        public void RaiseEvent(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(position, stats, rewardPlayer);
            else
                GameLogger.LogWarning(LogChannel.Combat, $"EnemyKilled Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\FloatFloatEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Float Float Event Channel")]
    public class FloatFloatEventChannelSO : ScriptableObject
    {
        public UnityAction<float, float> OnEventRaised;

        public void RaiseEvent(float current, float max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"FloatFloat Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\IntEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Event Channel")]
    public class IntEventChannelSO : ScriptableObject
    {
        public UnityAction<int> OnEventRaised;

        public void RaiseEvent(int value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Int Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\IntIntEventChannelSO.cs`
- Lines: 21
- Size: 0.6 KB
- Modified: 2026-01-19 00:02

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Int Event Channel")]
    public class IntIntEventChannelSO : ScriptableObject
    {
        public UnityAction<int, int> OnEventRaised;

        public void RaiseEvent(int current, int max)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(current, max);
            else
                GameLogger.LogWarning(LogChannel.System, $"IntInt Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\NarrativeEventChannelSO.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-19 00:02

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Narrative Text Channel")]
    public class NarrativeEventChannelSO : ScriptableObject
    {
        // String = Text, Float = Duration
        public UnityAction<string, float> OnEventRaised;

        public void RaiseEvent(string text, float duration = 3f)
        {
            OnEventRaised?.Invoke(text, duration);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\PopupTextEventChannelSO.cs`
- Lines: 14
- Size: 0.4 KB
- Modified: 2026-01-19 00:03

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Popup Text Channel")]
    public class PopupTextEventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3, string> OnEventRaised;

        public void RaiseEvent(Vector3 pos, string message)
            => OnEventRaised?.Invoke(pos, message);
    }
}
```

## 📄 `Assets\_Project\Core\Events\StringEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-19 00:03

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/String Event Channel")]
    public class StringEventChannelSO : ScriptableObject
    {
        public UnityAction<string> OnEventRaised;

        public void RaiseEvent(string value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"String Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\TooltipEventChannelSO.cs`
- Lines: 23
- Size: 0.5 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/UI/Tooltip Channel")]
    public class TooltipEventChannelSO : ScriptableObject
    {
        // Header, Content
        public UnityAction<string, string> OnShow;
        public UnityAction OnHide;

        public void Show(string header, string content)
        {
            OnShow?.Invoke(header, content);
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\TransformEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-19 00:03

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Transform Event Channel")]
    public class TransformEventChannelSO : ScriptableObject
    {
        public UnityAction<Transform> OnEventRaised;

        public void RaiseEvent(Transform value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Transform Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\Vector3EventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-19 00:03

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Vector3 Event Channel")]
    public class Vector3EventChannelSO : ScriptableObject
    {
        public UnityAction<Vector3> OnEventRaised;

        public void RaiseEvent(Vector3 value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
            else
                GameLogger.LogWarning(LogChannel.System, $"Vector3 Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\VoidEventChannelSO.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-19 00:00

```csharp
using DarkTowerTron.Core.Debugging;
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        public UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke();
            else
                GameLogger.LogWarning(LogChannel.System, $"Void Event [{name}] was raised but nothing picked it up.");
        }
    }
}
```

## 📄 `Assets\_Project\Core\Events\VoidEventListener.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    public class VoidEventListener : MonoBehaviour
    {
        [Tooltip("The Event to listen to")]
        public VoidEventChannelSO channel;

        [Tooltip("What to do when the event triggers")]
        public UnityEvent response;

        private void OnEnable()
        {
            if (channel != null) channel.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (channel != null) channel.OnEventRaised -= Respond;
        }

        private void Respond()
        {
            response?.Invoke();
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\CameraShaker.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2026-01-17 14:10

```csharp
using UnityEngine;
using DG.Tweening;

namespace DarkTowerTron.Core.Feedback
{
    public class CameraShaker : MonoBehaviour
    {
        public static CameraShaker Instance;

        private Camera _cam;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            _cam = Camera.main;
        }

        public void Shake(float duration, float strength)
        {
            if (_cam == null) return;

            // Kill previous shakes to prevent glitches
            _cam.transform.DOKill(true);

            // Shake Position (Local so it doesn't break the Rig follow)
            _cam.transform.DOShakePosition(duration, strength, 20, 90, false, true);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\Command\CameraShakeCommand.cs`
- Lines: 20
- Size: 0.6 KB
- Modified: 2026-01-17 14:13

```csharp
using DarkTowerTron.Gameplay.Visuals;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Camera Shake")]
    public class CameraShakeCommand : FeedbackCommand
    {
        public float duration = 0.2f;
        public float strength = 0.5f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (CameraShaker.Instance != null)
            {
                CameraShaker.Instance.Shake(duration, strength);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\Command\PlaySoundCommand.cs`
- Lines: 28
- Size: 1.0 KB
- Modified: 2026-01-18 23:58

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IAudioService (or Systems.Audio depending on where you put the interface)
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Play Sound")]
    public class PlaySoundCommand : FeedbackCommand
    {
        [Tooltip("The sound definition to play.")]
        public SoundDef sound;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // 1. Get Service
            // Note: Ensure IAudioService is in the namespace you are using, usually Core.Patterns or Systems.Audio
            var audioService = ServiceLocator.Get<IAudioService>();

            if (sound != null && audioService != null)
            {
                // 2. Play Sound via Service
                audioService.PlaySound(sound);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\Command\SpawnVFXCommand.cs`
- Lines: 41
- Size: 1.3 KB
- Modified: 2026-01-18 19:02

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Spawn VFX")]
    public class SpawnVFXCommand : FeedbackCommand
    {
        public GameObject prefab;
        public bool attachToParent = false;

        [Tooltip("Offset relative to the position rotation.")]
        public Vector3 offset = Vector3.zero;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // 1. Get Service
            var pool = ServiceLocator.Get<IPoolService>();

            if (prefab == null || pool == null) return;

            // 2. Calculate rotation
            Quaternion rot = Quaternion.identity;
            if (owner != null) rot = owner.transform.rotation;

            // 3. Spawn
            GameObject instance = pool.Spawn(prefab, position + (rot * offset), rot);

            // 4. Logic
            if (attachToParent && owner != null)
            {
                instance.transform.SetParent(owner.transform);
            }

            // 5. Auto-Play Particle if it exists
            var ps = instance.GetComponent<ParticleSystem>();
            if (ps) ps.Play();
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\Command\TimeFreezeCommand.cs`
- Lines: 23
- Size: 0.7 KB
- Modified: 2026-01-18 23:42

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Systems.TimeManagement;  // Access ITimeService

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Time Freeze")]
    public class TimeFreezeCommand : FeedbackCommand
    {
        [Range(0f, 1f)] public float duration = 0.05f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // Look up the service safely
            var timeService = ServiceLocator.Get<ITimeService>();
            
            if (timeService != null)
            {
                timeService.HitStop(duration);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\FeedbackCommand.cs`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    /// <summary>
    /// Base class for a single "Juice" action (e.g., Play Sound, Shake Camera).
    /// </summary>
    public abstract class FeedbackCommand : ScriptableObject
    {
        /// <summary>
        /// Executes the feedback.
        /// </summary>
        /// <param name="owner">The object causing the feedback (e.g. Player, Bullet).</param>
        /// <param name="position">Where the effect happens (e.g. Impact point).</param>
        public abstract void Execute(GameObject owner, Vector3 position);
    }
}
```

## 📄 `Assets\_Project\Core\Feedback\FeedbackConfigurationSO.cs`
- Lines: 32
- Size: 1.0 KB
- Modified: 2026-01-10 16:07

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(fileName = "Feedback_New", menuName = "DarkTowerTron/Feedback/Configuration Package")]
    public class FeedbackConfigurationSO : ScriptableObject
    {
        [Header("Juice List")]
        public List<FeedbackCommand> commands = new List<FeedbackCommand>();

        /// <summary>
        /// Runs every command in the package.
        /// </summary>
        public void Play(GameObject owner, Vector3 position)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i] != null)
                {
                    commands[i].Execute(owner, position);
                }
            }
        }

        // Overload for simple usage (uses owner's position)
        public void Play(GameObject owner)
        {
            if (owner != null) Play(owner, owner.transform.position);
        }
    }
}
```

## 📄 `Assets\_Project\Core\GameConstants.cs`
- Lines: 56
- Size: 3.1 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public static class GameConstants
    {
        // ========================================================================
        // 🏷️ TAGS
        // ========================================================================
        public const string TAG_PLAYER = "Player";
        public const string TAG_ENEMY = "Enemy";
        public const string TAG_PROJECTILE = "Projectile";
        public const string TAG_UNTAGGED = "Untagged";

        // ========================================================================
        // 🧱 LAYERS (Indices - for gameObject.layer check)
        // ========================================================================
        // Note: These must match your Project Settings -> Tags and Layers
        public static readonly int LAYER_DEFAULT = LayerMask.NameToLayer("Default");
        public static readonly int LAYER_TRANSPARENT_FX = LayerMask.NameToLayer("TransparentFX");
        public static readonly int LAYER_IGNORE_RAYCAST = LayerMask.NameToLayer("Ignore Raycast");
        public static readonly int LAYER_WATER = LayerMask.NameToLayer("Water");
        public static readonly int LAYER_UI = LayerMask.NameToLayer("UI");
        
        // Custom Layers
        public static readonly int LAYER_PLAYER = LayerMask.NameToLayer("Player");
        public static readonly int LAYER_ENEMY = LayerMask.NameToLayer("Enemy");
        public static readonly int LAYER_PROJECTILE = LayerMask.NameToLayer("Projectile");
        public static readonly int LAYER_HITBOX = LayerMask.NameToLayer("Hitbox");
        public static readonly int LAYER_WALL = LayerMask.NameToLayer("Wall");
        public static readonly int LAYER_GROUND = LayerMask.NameToLayer("Ground");

        // ========================================================================
        // 🎭 MASKS (Bitmasks - for Physics.Raycast / OverlapSphere)
        // ========================================================================
        
        // 1. Movement: Can I walk here?
        // EXCLUDES 'Hitbox' and 'Enemy'. Enemies should not treat other enemies as static walls.
        // They should overlap and let 'EnemyMotor' separation handle the spacing.
        public static readonly int MASK_PHYSICS_OBSTACLES = LayerMask.GetMask("Default", "Wall", "Ground");

        // 2. Projectiles: What do I hit?
        // INCLUDES 'Hitbox' (Shoot the arm) and 'Enemy' (Shoot the capsule)
        public static readonly int MASK_PROJECTILE_COLLISION = LayerMask.GetMask("Default", "Wall", "Player", "Enemy", "Hitbox");

        // Used by Wall Detection (Pushback)
        public static readonly int MASK_WALLS = LayerMask.GetMask("Default", "Wall");

        // Used by "Safe Ground" checks (Falling into void)
        public static readonly int MASK_GROUND_ONLY = LayerMask.GetMask("Ground");
        
        // 3. Sight/AI: What blocks vision?
        // Usually just Walls and Ground. We don't want an enemy to block another enemy's view of the player.
        public static readonly int MASK_SIGHT_BLOCKING = LayerMask.GetMask("Default", "Wall", "Ground");
    }
}
```

## 📄 `Assets\_Project\Core\Input\InputBuffer.cs`
- Lines: 41
- Size: 1.2 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Input
{
    /// <summary>
    /// queues inputs for a short time to allow "Early" presses to register.
    /// </summary>
    public class InputBuffer
    {
        private float _bufferTime;
        private Dictionary<string, float> _queuedActions = new Dictionary<string, float>();

        public InputBuffer(float bufferTime = 0.15f)
        {
            _bufferTime = bufferTime;
        }

        public void BufferAction(string actionID)
        {
            // Record the timestamp of the press
            _queuedActions[actionID] = Time.time;
        }

        public bool TryConsumeAction(string actionID)
        {
            if (_queuedActions.TryGetValue(actionID, out float timeStamp))
            {
                // Is the press recent enough?
                if (Time.time - timeStamp <= _bufferTime)
                {
                    _queuedActions.Remove(actionID); // Consume it
                    return true;
                }
            }
            return false;
        }

        public void Clear() => _queuedActions.Clear();
    }
}
```

## 📄 `Assets\_Project\Core\Patterns\IPoolable.cs`
- Lines: 8
- Size: 0.1 KB
- Modified: 2026-01-17 10:45

```csharp
namespace DarkTowerTron.Core.Patterns
{
    public interface IPoolable
    {
        void OnSpawn();
        void OnDespawn();
    }
}
```

## 📄 `Assets\_Project\Core\Patterns\IPoolService.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2026-01-18 11:07

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.Patterns
{
    public interface IPoolService : IGameService
    {
        // The essential contract
        T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component;
        GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation);

        void Despawn(GameObject instance, float delay = 0f);

        // Optional: Prewarming
        void Prewarm(GameObject prefab, int count);
    }
}
```

## 📄 `Assets\_Project\Core\Patterns\PoolService.cs`
- Lines: 204
- Size: 7.0 KB
- Modified: 2026-01-20 18:30

```csharp
using System.Collections.Generic;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DarkTowerTron.Core.Patterns
{
    public class PoolService : MonoBehaviour, IPoolService
    {
        // Dictionary mapping Prefab InstanceID -> Queue of inactive objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();

        // Dictionary mapping Spawned Object InstanceID -> Prefab InstanceID (to know where to return it)
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private Transform _poolRoot;

        private void Awake()
        {
            ServiceLocator.Register<IPoolService>(this);
            // Create a clean container so the Hierarchy doesn't get messy
            GameObject rootObj = new GameObject("Pool_Container");
            _poolRoot = rootObj.transform;
            DontDestroyOnLoad(rootObj);
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IPoolService>(this);
            SceneManager.activeSceneChanged -= OnSceneChanged;
        }

        private void OnEnable() => SceneManager.activeSceneChanged += OnSceneChanged;
        private void OnDisable() => SceneManager.activeSceneChanged -= OnSceneChanged;

        private void OnSceneChanged(Scene current, Scene next)
        {
            // Clear tracking lists, but logic dictates we should also clear the physical container
            // if we want a fresh start per scene (usually safer for references).
            ClearPools();
        }

        public void ClearPools()
        {
            _poolDictionary.Clear();
            _spawnedObjectsParentId.Clear();

            // Nuke the physical objects
            foreach (Transform child in _poolRoot)
            {
                Destroy(child.gameObject);
            }

            GameLogger.Log(LogChannel.System, "Pool memory flushed.", gameObject);
        }

        /// <summary>
        /// Call this during Loading Screens to prevent stutter during gameplay.
        /// </summary>
        public void Prewarm(GameObject prefab, int count)
        {
            if (prefab == null) return;

            int poolKey = prefab.GetInstanceID();

            // Initialize the queue if missing
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            for (int i = 0; i < count; i++)
            {
                GameObject obj = CreateNewInstance(prefab, poolKey);
                // Immediately disable and enqueue
                obj.SetActive(false);
                obj.transform.SetParent(_poolRoot);
                _poolDictionary[poolKey].Enqueue(obj);
            }
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            if (prefab == null) return null;

            int poolKey = prefab.GetInstanceID();

            // 1. Ensure Queue Exists
            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objToSpawn = null;

            // 2. Try Dequeue (Find inactive)
            if (_poolDictionary[poolKey].Count > 0)
            {
                objToSpawn = _poolDictionary[poolKey].Dequeue();

                // Validation: Was it destroyed externally?
                while (objToSpawn == null && _poolDictionary[poolKey].Count > 0)
                {
                    objToSpawn = _poolDictionary[poolKey].Dequeue();
                }
            }

            // 3. If missing or null, Create New
            if (objToSpawn == null)
            {
                objToSpawn = CreateNewInstance(prefab, poolKey);
            }

            // 4. Setup
            objToSpawn.transform.SetPositionAndRotation(position, rotation);
            objToSpawn.SetActive(true);

            // NOTE: We don't unparent from _poolRoot. 
            // Keeping them organized under one parent is cleaner for the Hierarchy view,
            // though slightly (negligibly) more expensive for Transform updates.
            // For a solo dev, clean Hierarchy > Micro-optimization.

            // 5. Interface Call
            var poolables = objToSpawn.GetComponentsInChildren<IPoolable>();
            foreach (var p in poolables) p.OnSpawn();

            return objToSpawn;
        }

        public T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component
        {
            if (prefab == null) return null;
            var go = Spawn(prefab.gameObject, position, rotation);
            return go != null ? go.GetComponent<T>() : null;
        }

        public void Despawn(GameObject instance, float delay = 0f)
        {
            if (instance == null) return;

            if (delay > 0f)
            {
                StartCoroutine(DespawnDelayed(instance, delay));
                return;
            }

            DespawnImmediate(instance);
        }

        private IEnumerator DespawnDelayed(GameObject instance, float delay)
        {
            yield return new WaitForSeconds(delay);
            DespawnImmediate(instance);
        }

        private void DespawnImmediate(GameObject obj)
        {
            if (obj == null) return;
            if (!obj.scene.isLoaded) { Destroy(obj); return; }

            int instanceKey = obj.GetInstanceID();

            if (_spawnedObjectsParentId.TryGetValue(instanceKey, out int poolKey))
            {
                // Interface Call
                var poolables = obj.GetComponentsInChildren<IPoolable>();
                foreach (var p in poolables) p.OnDespawn();

                obj.SetActive(false);

                // Reparent to root to keep scene tidy
                if (obj.transform.parent != _poolRoot)
                    obj.transform.SetParent(_poolRoot);

                // Add back to queue
                if (!_poolDictionary.ContainsKey(poolKey))
                    _poolDictionary[poolKey] = new Queue<GameObject>();

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                // Wasn't pooled? Just destroy.
                Destroy(obj);
            }
        }

        // Helper to keep logic DRY
        private GameObject CreateNewInstance(GameObject prefab, int poolKey)
        {
            GameObject obj = Instantiate(prefab, _poolRoot); // Spawn directly in root
            int instanceKey = obj.GetInstanceID();

            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }
            return obj;
        }
    }
}
```

## 📄 `Assets\_Project\Core\Physics\IMovementStrategy.cs`
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-17 10:46

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Physics
{
    public interface IMovementStrategy
    {
        void Initialize(Transform transform, Vector3 direction, float speed);
        void Move(Transform transform, float deltaTime);
    }
}
```

## 📄 `Assets\_Project\Core\Physics\IMover.cs`
- Lines: 18
- Size: 0.4 KB
- Modified: 2026-01-17 10:45

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Physics
{
    public interface IMover
    {
        // Data Access
        Vector3 Velocity { get; }
        bool IsGrounded { get; }

        // Actions
        void Move(Vector3 velocity); // Accepts Velocity (units/sec)
        void Teleport(Vector3 position);

        // Settings (Optional, for syncing)
        void SetEnabled(bool state);
    }
}
```

## 📄 `Assets\_Project\Core\Physics\KinematicMover.cs`
- Lines: 318
- Size: 12.7 KB
- Modified: 2026-01-17 12:19

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Core.Physics
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class KinematicMover : MonoBehaviour, IMover
    {
        [Header("Configuration")]
        [SerializeField] private LayerMask _obstacleMask;
        [SerializeField] private float _skinWidth = 0.015f;
        [SerializeField] private float _maxStepHeight = 0.3f;
        [Range(0f, 90f)][SerializeField] private float _maxSlopeAngle = 45f;
        [SerializeField] private float _groundSnapDistance = 0.3f;

        [Header("Optimization")]
        public bool useCulling = true;
        public float cullingDistance = 40f; // Beyond this, physics stops

        // Events
        public event System.Action<Vector3> OnCollision;
        public event System.Action<float> OnStepClimbed;

        // State
        private CapsuleCollider _capsule;
        private Vector3 _velocity;
        private Vector3 _groundNormal = Vector3.up;
        private bool _isGrounded;
        private Transform _activePlatform;
        private Vector3 _platformLastPos;
        private Quaternion _platformLastRot;

        private Transform _camTransform;

        // Cache
        private RaycastHit[] _hitBuffer = new RaycastHit[8];
        // OPTIMIZATION: HashSet lookup is O(1) - incredibly fast
        private readonly HashSet<Collider> _myColliders = new HashSet<Collider>();
        private readonly HashSet<Collider> _ignoredExternalColliders = new HashSet<Collider>();

        // Properties
        public Vector3 Velocity => _velocity;
        public bool IsGrounded => _isGrounded;
        public Vector3 GroundNormal => _groundNormal;

        private void Awake()
        {
            _capsule = GetComponent<CapsuleCollider>();

            // 1. Auto-Register Self
            // Find ALL colliders in children (Hitboxes, sensors, shield)
            var childCols = GetComponentsInChildren<Collider>(true); // true = include inactive
            foreach (var c in childCols)
            {
                _myColliders.Add(c);

                // Also ignore physical collision between the capsule and children
                // (Redundant if using Layers, but good for safety)
                if (c != _capsule)
                {
                    UnityEngine.Physics.IgnoreCollision(_capsule, c, true);
                }
            }

            if (Camera.main) _camTransform = Camera.main.transform;
            if (_obstacleMask == 0) _obstacleMask = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        public void Move(Vector3 desiredVelocity)
        {
            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            // --- CULLING CHECK ---
            // Fix: Never cull the Player, even if camera is far away
            if (useCulling && _camTransform != null && !gameObject.CompareTag(GameConstants.TAG_PLAYER))
            {
                // SqrMagnitude is faster than Distance
                float distSqr = (transform.position - _camTransform.position).sqrMagnitude;
                if (distSqr > cullingDistance * cullingDistance)
                {
                    // CHEAP MOVEMENT: Just translate, ignore walls
                    transform.Translate(desiredVelocity * dt, Space.World);
                    return; // Skip the expensive stuff below
                }
            }
            // ---------------------

            // 1. Safety & Platforming
            Depenetrate();
            HandlePlatformMovement();
            CheckGround();

            // 2. Resolve Collisions using Desired Velocity * dt
            Vector3 finalMotion = ResolveCollisions(desiredVelocity * dt);

            // 3. Apply Movement
            transform.position += finalMotion;
            HandleGroundSnapping(finalMotion);

            // 4. Update Internal Velocity (so caller knows actual speed)
            _velocity = finalMotion / dt;
        }

        public void Teleport(Vector3 pos) { transform.position = pos; _velocity = Vector3.zero; }
        public void SetEnabled(bool state) => enabled = state;

        // Helper for other scripts to check "Is this me?"
        public bool IsMyCollider(Collider c) => c != null && _myColliders.Contains(c);

        public void IgnoreCollider(Collider col)
        {
            if (col == null) return;
            _ignoredExternalColliders.Add(col);
        }

        // ================= INTERNAL PHYSICS =================

        private Vector3 ResolveCollisions(Vector3 motion)
        {
            Vector3 pos = transform.position;
            Vector3 remaining = motion;
            Vector3 totalMoved = Vector3.zero;

            for (int i = 0; i < 5; i++)
            {
                float dist = remaining.magnitude;
                if (dist < 1e-5f) break;

                // Step Up
                if (_isGrounded && TryStepUp(pos, remaining, out Vector3 stepMotion, out float h))
                {
                    pos += stepMotion;
                    totalMoved += stepMotion;
                    remaining = Vector3.zero;
                    OnStepClimbed?.Invoke(h);
                    break;
                }

                GetCapsulePoints(pos, out Vector3 p1, out Vector3 p2, out float r);
                
                // QueryTriggerInteraction.Ignore: Do not hit Triggers with this sweep
                int count = UnityEngine.Physics.CapsuleCastNonAlloc(
                    p1, p2, r, remaining.normalized, _hitBuffer, dist + _skinWidth, _obstacleMask,
                    QueryTriggerInteraction.Ignore
                );

                RaycastHit closest = default;
                float closestDist = Mathf.Infinity;
                bool hitFound = false;

                for (int j = 0; j < count; j++)
                {
                    // Double safety check (redundant with QueryTriggerInteraction.Ignore, but good to keep)
                    if (_hitBuffer[j].collider.isTrigger) continue;

                    RaycastHit hit = _hitBuffer[j];
                    Collider col = hit.collider;

                    // FAST CHECK:
                    // 1. Is it me? (O(1))
                    // 2. Is it explicitly ignored? (O(1))
                    // 3. Is it a trigger?
                    if (_myColliders.Contains(col) ||
                        _ignoredExternalColliders.Contains(col) ||
                        col.isTrigger)
                    {
                        continue;
                    }

                    if (hit.distance <= 0) continue;

                    if (hit.distance < closestDist)
                    {
                        closestDist = hit.distance;
                        closest = hit;
                        hitFound = true;
                    }
                }

                if (hitFound)
                {
                    float moveDist = Mathf.Max(0, closestDist - _skinWidth);
                    Vector3 move = remaining.normalized * moveDist;
                    pos += move;
                    totalMoved += move;

                    remaining -= remaining.normalized * moveDist;
                    remaining = Vector3.ProjectOnPlane(remaining, closest.normal);

                    OnCollision?.Invoke(closest.normal);
                }
                else
                {
                    totalMoved += remaining;
                    break;
                }
            }
            return totalMoved;
        }

        private void HandlePlatformMovement()
        {
            if (_activePlatform == null) return;
            Vector3 dPos = _activePlatform.position - _platformLastPos;
            Quaternion dRot = _activePlatform.rotation * Quaternion.Inverse(_platformLastRot);

            transform.position += dPos;
            Vector3 local = transform.position - _activePlatform.position;
            transform.position = _activePlatform.position + (dRot * local);
            transform.rotation = dRot * transform.rotation;

            _platformLastPos = _activePlatform.position;
            _platformLastRot = _activePlatform.rotation;
        }

        private void CheckGround()
        {
            GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
            if (UnityEngine.Physics.SphereCast(p2 + Vector3.up * 0.1f, r * 0.95f, Vector3.down, out RaycastHit hit, _skinWidth + 0.2f, _obstacleMask))
            {
                float angle = Vector3.Angle(hit.normal, Vector3.up);
                if (angle <= _maxSlopeAngle || angle < 85f)
                {
                    _isGrounded = true;
                    _groundNormal = hit.normal;
                    if (angle <= _maxSlopeAngle && hit.transform != _activePlatform)
                    {
                        _activePlatform = hit.transform;
                        _platformLastPos = _activePlatform.position;
                        _platformLastRot = _activePlatform.rotation;
                    }
                    return;
                }
            }
            _isGrounded = false;
            _groundNormal = Vector3.up;
            _activePlatform = null;
        }

        private void HandleGroundSnapping(Vector3 appliedMotion)
        {
            if (_isGrounded && appliedMotion.y <= 0)
            {
                GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
                if (UnityEngine.Physics.SphereCast(p2 + Vector3.up * 0.1f, r * 0.95f, Vector3.down, out RaycastHit hit, _groundSnapDistance, _obstacleMask))
                {
                    if (Vector3.Angle(hit.normal, Vector3.up) <= _maxSlopeAngle)
                    {
                        transform.position += Vector3.down * (hit.distance - 0.1f);
                        _isGrounded = true;
                        _groundNormal = hit.normal;
                    }
                }
            }
        }

        private bool TryStepUp(Vector3 pos, Vector3 motion, out Vector3 stepMotion, out float height)
        {
            stepMotion = Vector3.zero; height = 0;
            Vector3 horz = new Vector3(motion.x, 0, motion.z);
            if (horz.sqrMagnitude < 0.001f) return false;

            GetCapsulePoints(pos, out Vector3 p1, out Vector3 p2, out float r);
            float dist = horz.magnitude + _skinWidth;

            for (float h = _maxStepHeight; h >= 0.05f; h -= 0.05f)
            {
                Vector3 up = Vector3.up * h;
                if (UnityEngine.Physics.CheckCapsule(p1 + up, p2 + up, r * 0.99f, _obstacleMask)) continue;
                if (!UnityEngine.Physics.CapsuleCast(p1 + up, p2 + up, r * 0.99f, horz.normalized, dist, _obstacleMask))
                {
                    if (UnityEngine.Physics.Raycast(pos + up + horz.normalized * 0.1f, Vector3.down, out RaycastHit hit, h + 0.1f, _obstacleMask))
                    {
                        float actualH = hit.point.y - pos.y;
                        if (actualH <= _maxStepHeight && actualH > 0.01f)
                        {
                            stepMotion = (Vector3.up * actualH) + horz;
                            height = actualH;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Depenetrate()
        {
            GetCapsulePoints(transform.position, out Vector3 p1, out Vector3 p2, out float r);
            Collider[] buffer = new Collider[5];
            int c = UnityEngine.Physics.OverlapCapsuleNonAlloc(p1, p2, r, buffer, _obstacleMask);
            for (int i = 0; i < c; i++)
            {
                var col = buffer[i];
                // Ignore self AND ignored colliders
                if (_myColliders.Contains(col) || _ignoredExternalColliders.Contains(col)) continue;
                
                // CRITICAL FIX: Do not push out of Triggers!
                if (col.isTrigger) continue;

                if (UnityEngine.Physics.ComputePenetration(_capsule, transform.position, transform.rotation, col, col.transform.position, col.transform.rotation, out Vector3 dir, out float d))
                {
                    transform.position += dir * (d + _skinWidth);
                }
            }
        }

        private void GetCapsulePoints(Vector3 pos, out Vector3 p1, out Vector3 p2, out float r)
        {
            r = _capsule.radius;
            float h = Mathf.Max(0, _capsule.height * 0.5f - r);
            p1 = pos + _capsule.center + Vector3.up * h;
            p2 = pos + _capsule.center - Vector3.up * h;
        }
    }
}
```

## 📄 `Assets\_Project\Core\Physics\UnityCharacterMover.cs`
- Lines: 54
- Size: 1.6 KB
- Modified: 2026-01-17 12:19

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Physics
{
    [RequireComponent(typeof(CharacterController))]
    public class UnityCharacterMover : MonoBehaviour, IMover
    {
        private CharacterController _cc;

        // We calculate velocity manually because _cc.velocity is sometimes 
        // strictly based on movement, not external forces we want to track.
        public Vector3 Velocity { get; private set; }

        public bool IsGrounded => _cc.isGrounded;

        private void Awake()
        {
            _cc = GetComponent<CharacterController>();
        }

        public void Move(Vector3 velocity)
        {
            if (!_cc.enabled) return;

            float dt = Time.deltaTime;

            // 1. Apply Movement
            // CC.Move takes Displacement (Velocity * Time)
            _cc.Move(velocity * dt);

            // 2. Update Public Velocity
            // We store what was passed in, so other scripts (Animation/Sound) know how fast we intend to go
            Velocity = velocity;
        }

        public void Teleport(Vector3 position)
        {
            // Critical: CC overrides transform.position. 
            // You must disable it, move, then re-enable.
            bool wasEnabled = _cc.enabled;
            _cc.enabled = false;
            transform.position = position;
            _cc.enabled = wasEnabled;

            Velocity = Vector3.zero;
        }

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            if (_cc) _cc.enabled = state;
        }
    }
}
```

## 📄 `Assets\_Project\Core\Resources\[GlobalSystems].prefab`
- Lines: 569
- Size: 16.7 KB
- Modified: 2026-01-23 16:10

```prefab
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &1216672480534377754
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5776826995582308357}
  - component: {fileID: 3105815947437139258}
  m_Layer: 0
  m_Name: VFX
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5776826995582308357
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1216672480534377754}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &3105815947437139258
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1216672480534377754}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3de3d7dd814a41f4a81234b4ce9471f2, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &1578779068022696046
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 140574863369501576}
  - component: {fileID: 4170320843107285051}
  - component: {fileID: 4492476289993959322}
  m_Layer: 0
  m_Name: Music
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &140574863369501576
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1578779068022696046}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 2465950592390206493}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!82 &4170320843107285051
AudioSource:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1578779068022696046}
  m_Enabled: 1
  serializedVersion: 4
  OutputAudioMixerGroup: {fileID: 0}
  m_audioClip: {fileID: 0}
  m_PlayOnAwake: 0
  m_Volume: 1
  m_Pitch: 1
  Loop: 1
  Mute: 0
  Spatialize: 0
  SpatializePostEffects: 0
  Priority: 128
  DopplerLevel: 1
  MinDistance: 1
  MaxDistance: 500
  Pan2D: 1
  rolloffMode: 0
  BypassEffects: 0
  BypassListenerEffects: 0
  BypassReverbZones: 0
  rolloffCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    - serializedVersion: 3
      time: 1
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  panLevelCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  spreadCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 0
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
  reverbZoneMixCustomCurve:
    serializedVersion: 2
    m_Curve:
    - serializedVersion: 3
      time: 0
      value: 1
      inSlope: 0
      outSlope: 0
      tangentMode: 0
      weightedMode: 0
      inWeight: 0.33333334
      outWeight: 0.33333334
    m_PreInfinity: 2
    m_PostInfinity: 2
    m_RotationOrder: 4
--- !u!114 &4492476289993959322
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1578779068022696046}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 4bf97d9429aec5a41a949b95cec52d49, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _playerDiedEvent: {fileID: 11400000, guid: 28f8343a43fb4c7409fe54eacd72f1b1, type: 2}
--- !u!1 &1718035396501018832
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 6090341322086187189}
  - component: {fileID: 4407297048153549117}
  m_Layer: 0
  m_Name: Time
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &6090341322086187189
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1718035396501018832}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &4407297048153549117
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1718035396501018832}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: c2b6fa7f536e6bb41a024c7d6f7ddf08, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &4845145680785771420
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2465950592390206493}
  - component: {fileID: 960002426804599491}
  m_Layer: 0
  m_Name: Audio
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2465950592390206493
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4845145680785771420}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 140574863369501576}
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &960002426804599491
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4845145680785771420}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: f471a2104ae0ce94d84389473bf4bde3, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _musicManager: {fileID: 4492476289993959322}
  _sfxSourcePrefab: {fileID: 7902143403008404995, guid: f1ebba580b32b854886cd135decd0c63,
    type: 3}
  _initialPoolSize: 15
--- !u!1 &4964897886332769746
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 5950281305360802942}
  - component: {fileID: 5610336787606338233}
  m_Layer: 0
  m_Name: Pooling
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &5950281305360802942
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4964897886332769746}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &5610336787606338233
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 4964897886332769746}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 190d45981e89be5489c907223169c19e, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &5375986766938793572
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 2457187509913300185}
  - component: {fileID: 1357856659845079561}
  m_Layer: 0
  m_Name: Score
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &2457187509913300185
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5375986766938793572}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &1357856659845079561
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5375986766938793572}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 74a66a13e0bf03e4f91463fe0d018c09, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _enemyKilledEvent: {fileID: 11400000, guid: 424885e98a1badb49b0880fe04ceb33f, type: 2}
  _playerHitEvent: {fileID: 11400000, guid: 337b2d3cfc7ca4c4e9ed8875aad7e3a4, type: 2}
  _uiScoreEvent: {fileID: 11400000, guid: d8d2ebedf91e7e64bbdfa2f55221931c, type: 2}
  _baseScorePerKill: 100
  _maxMultiplier: 5
--- !u!1 &5698319253934527030
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 4384998581259256161}
  - component: {fileID: 7843336747748332572}
  m_Layer: 0
  m_Name: Visuals
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &4384998581259256161
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5698319253934527030}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &7843336747748332572
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5698319253934527030}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 755a2b9295b7e3f45aa66bc9b9d52ae5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _activePalette: {fileID: 11400000, guid: 253c73382724c81448699d784b933b68, type: 2}
  _activeVariant: 
  bindings:
  - type: 1
    collection: {fileID: 11400000, guid: 4a48fecfa6f40d546a691de1b3a319e8, type: 2}
  - type: 2
    collection: {fileID: 11400000, guid: 42b58d063cd4d28498b6832812f62242, type: 2}
  - type: 3
    collection: {fileID: 11400000, guid: 316488ef898c4da408965571ac1534e7, type: 2}
  - type: 4
    collection: {fileID: 11400000, guid: a5ab19fb2b2b2d74497a9c5d67f872d5, type: 2}
  - type: 5
    collection: {fileID: 11400000, guid: 6aeec2b6cfc6b5b45b4f4aea63ea700a, type: 2}
  - type: 6
    collection: {fileID: 11400000, guid: 395003987dc20114f91713ff6dd2225a, type: 2}
  - type: 7
    collection: {fileID: 11400000, guid: 50797cad22d679541aeb978a850a9ebb, type: 2}
  - type: 8
    collection: {fileID: 11400000, guid: edd3949e88bdbbe47a37dd1187d1ee5e, type: 2}
  - type: 9
    collection: {fileID: 11400000, guid: 8d0a448949d8c084c90c2c2643faf490, type: 2}
  - type: 10
    collection: {fileID: 11400000, guid: 9e6783eb5a8a1794bb6278716baca0a7, type: 2}
  - type: 11
    collection: {fileID: 11400000, guid: 316488ef898c4da408965571ac1534e7, type: 2}
  - type: 12
    collection: {fileID: 11400000, guid: 316488ef898c4da408965571ac1534e7, type: 2}
  - type: 13
    collection: {fileID: 11400000, guid: e64a29004f9ed6d4994b85261337aacb, type: 2}
  - type: 14
    collection: {fileID: 11400000, guid: 8342502258de9bb48b87f0298e3e2ff2, type: 2}
  - type: 15
    collection: {fileID: 11400000, guid: d6e557455fd9a074cbc5863e7c3da0fd, type: 2}
  - type: 16
    collection: {fileID: 11400000, guid: 8256fedb61135554fa3671d5141d34cb, type: 2}
  - type: 3
    collection: {fileID: 11400000, guid: 316488ef898c4da408965571ac1534e7, type: 2}
  refreshNow: 0
--- !u!1 &5712068496228848853
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7569884233303024154}
  - component: {fileID: 665392077893796447}
  m_Layer: 0
  m_Name: '[GlobalSystems]'
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7569884233303024154
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5712068496228848853}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children:
  - {fileID: 2465950592390206493}
  - {fileID: 2457187509913300185}
  - {fileID: 7142749702975940037}
  - {fileID: 5950281305360802942}
  - {fileID: 5776826995582308357}
  - {fileID: 6090341322086187189}
  - {fileID: 4384998581259256161}
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &665392077893796447
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 5712068496228848853}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 0f8d21da57cdcf4449ccd57a5edc2039, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
--- !u!1 &8536581568476607431
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 7142749702975940037}
  - component: {fileID: 8870849308565105949}
  - component: {fileID: 2837505859601881071}
  m_Layer: 0
  m_Name: Persistence
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &7142749702975940037
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8536581568476607431}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 7569884233303024154}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &8870849308565105949
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8536581568476607431}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: e6b4cb555ab838e46a597e2053e4b911, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _currentSlotIndex: 0
--- !u!114 &2837505859601881071
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 8536581568476607431}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 41b539b3c236c2b40adfaa83ee2ea200, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  _enemyKilledEvent: {fileID: 11400000, guid: 424885e98a1badb49b0880fe04ceb33f, type: 2}
  _playerDiedEvent: {fileID: 11400000, guid: 28f8343a43fb4c7409fe54eacd72f1b1, type: 2}
  _damageEvent: {fileID: 11400000, guid: 62100c1f9efa3034d86dce2d21dbf5f9, type: 2}
```

## 📄 `Assets\_Project\Core\Resources\DebugProfile.asset`
- Lines: 23
- Size: 0.5 KB
- Modified: 2026-01-24 11:30

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 3c42e7888c0b9114397613c118f9c21e, type: 3}
  m_Name: DebugProfile
  m_EditorClassIdentifier: 
  enableLogging: 1
  logPlayer: 0
  logAI: 0
  logCombat: 0
  logUI: 0
  logPhysics: 0
  logSystem: 1
  logVFX: 0
```

## 📄 `Assets\_Project\Core\Resources\DOTweenSettings.asset`
- Lines: 55
- Size: 1.3 KB
- Modified: 2025-11-22 14:36

```asset
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 16995157, guid: a811bde74b26b53498b4f6d872b09b6d, type: 3}
  m_Name: DOTweenSettings
  m_EditorClassIdentifier: 
  useSafeMode: 1
  safeModeOptions:
    logBehaviour: 2
    nestedTweenFailureBehaviour: 0
  timeScale: 1
  unscaledTimeScale: 1
  useSmoothDeltaTime: 0
  maxSmoothUnscaledTime: 0.15
  rewindCallbackMode: 0
  showUnityEditorReport: 0
  logBehaviour: 0
  drawGizmos: 1
  defaultRecyclable: 0
  defaultAutoPlay: 3
  defaultUpdateType: 0
  defaultTimeScaleIndependent: 0
  defaultEaseType: 6
  defaultEaseOvershootOrAmplitude: 1.70158
  defaultEasePeriod: 0
  defaultAutoKill: 1
  defaultLoopType: 0
  debugMode: 0
  debugStoreTargetId: 1
  showPreviewPanel: 1
  storeSettingsLocation: 0
  modules:
    showPanel: 0
    audioEnabled: 1
    physicsEnabled: 1
    physics2DEnabled: 1
    spriteEnabled: 1
    uiEnabled: 1
    textMeshProEnabled: 0
    tk2DEnabled: 0
    deAudioEnabled: 0
    deUnityExtendedEnabled: 0
    epoOutlineEnabled: 0
  createASMDEF: 0
  showPlayingTweens: 0
  showPausedTweens: 0
```

## 📄 `Assets\_Project\Core\Services\BootLoader.cs`
- Lines: 37
- Size: 1.4 KB
- Modified: 2026-01-20 18:27

```csharp
using UnityEngine;
using DarkTowerTron.Systems;

namespace DarkTowerTron.Core.Services
{
    public static class Bootloader
    {
        // --- CONFIGURATION ---
        // The path relative to ANY "Resources" folder in your project.
        // If file is at: Assets/_Project/Core/Resources/[GlobalSystems].prefab
        // Then set this to: "[GlobalSystems]"
        private const string SYSTEM_PREFAB_PATH = "[GlobalSystems]";

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Execute()
        {
            // 1. Safety Check: Don't spawn if a Bootstrapper already exists
            if (Object.FindObjectOfType<Bootstrapper>() != null) return;

            // 2. Load the Prefab
            var prefab = Resources.Load<GameObject>(SYSTEM_PREFAB_PATH);

            if (prefab == null)
            {
                // Helpful Debugging for Path Issues
                Debug.LogError($"[Bootloader] CRITICAL: Could not find prefab at path 'Resources/{SYSTEM_PREFAB_PATH}'.\n" +
                               "1. Ensure a folder named 'Resources' exists.\n" +
                               $"2. Ensure the file is named '{SYSTEM_PREFAB_PATH}' (check brackets/spelling).\n");
                return;
            }

            // 3. Spawn
            var instance = Object.Instantiate(prefab);
            instance.name = "[GlobalSystems]"; // Name in Hierarchy
        }
    }
}
```

## 📄 `Assets\_Project\Core\Services\IGameService.cs`
- Lines: 10
- Size: 0.3 KB
- Modified: 2026-01-18 10:40

```csharp
namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// Base contract for all global game services.
    /// </summary>
    public interface IGameService 
    { 
        // Future-proofing: We can add void Initialize(); here later.
    }
}
```

## 📄 `Assets\_Project\Core\Services\ServiceLocator.cs`
- Lines: 62
- Size: 2.0 KB
- Modified: 2026-01-18 23:46

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, IGameService> _services = new Dictionary<Type, IGameService>();

        public static void Register<T>(T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                Debug.LogWarning($"[ServiceLocator] Service {type.Name} is already registered. Overwriting.");
                _services[type] = service;
            }
            else
            {
                _services.Add(type, service);
            }
        }

        public static void Unregister<T>(T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                _services.Remove(type);
            }
        }

        // Added this alias to fix the error in PaletteService
        public static void Deregister<T>(T service) where T : IGameService => Unregister<T>(service);

        public static T Get<T>() where T : IGameService
        {
            var type = typeof(T);
            if (!_services.TryGetValue(type, out var service))
            {
                throw new Exception($"[ServiceLocator] Service {type.Name} not found! Is it registered in the Bootstrapper?");
            }
            return (T)service;
        }

        // --- NEW: Fixes 'does not contain definition for TryGet' ---
        public static bool TryGet<T>(out T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var s))
            {
                service = (T)s;
                return true;
            }
            service = default;
            return false;
        }

        public static void Reset() => _services.Clear();
    }
}
```

## 📄 `Assets\_Project\Core\Spinner.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public class Spinner : MonoBehaviour
    {
        public Vector3 axis = new Vector3(0, 1, 0);
        public float speed = 50f;

        void Update()
        {
            transform.Rotate(axis, speed * Time.deltaTime);
        }
    }
}
```

## 📄 `Assets\_Project\Core\Utiities\GameEventListener.cs`
- Lines: 34
- Size: 0.9 KB
- Modified: 2026-01-23 15:12

```csharp
using UnityEngine;
using UnityEngine.Events;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Core
{
    /// <summary>
    /// Connects a Global Event (SO) to a Local Component (UnityEvent).
    /// Put this on the Gate GameObject.
    /// </summary>
    public class GameEventListener : MonoBehaviour
    {
        [Header("Trigger")]
        [SerializeField] private VoidEventChannelSO _eventToListenFor;

        [Header("Response")]
        public UnityEvent OnEventRaised;

        private void OnEnable()
        {
            if (_eventToListenFor) _eventToListenFor.OnEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (_eventToListenFor) _eventToListenFor.OnEventRaised -= Respond;
        }

        private void Respond()
        {
            OnEventRaised?.Invoke();
        }
    }
}
```

## 📄 `Assets\_Project\Core\Utiities\LayerAutomator.cs`
- Lines: 76
- Size: 2.2 KB
- Modified: 2026-01-17 10:27

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    [ExecuteAlways] // Runs in Editor Mode
    public class LayerAutomator : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("The layer for the Root object (Movement Capsule).")]
        public string rootLayerName = "Enemy";

        [Tooltip("The layer for all child objects (Visuals/Hitboxes).")]
        public string childLayerName = "Hitbox";

        [Tooltip("If true, updates happens automatically when you change something.")]
        public bool autoUpdate = true;

        private void Update()
        {
            // Don't run in the actual game, only in Editor
            if (Application.isPlaying) return;

            if (autoUpdate)
            {
                EnforceLayers();
            }
        }

        [ContextMenu("Force Fix Layers Now")]
        public void EnforceLayers()
        {
            int rootLayer = LayerMask.NameToLayer(rootLayerName);
            int childLayer = LayerMask.NameToLayer(childLayerName);

            // Safety Check: Do layers exist?
            if (rootLayer == -1 || childLayer == -1) return;

            // 1. Fix Root
            if (gameObject.layer != rootLayer)
            {
                gameObject.layer = rootLayer;
            }

            // 2. Fix Children
            foreach (Transform child in transform)
            {
                SetLayerRecursive(child, childLayer);
            }
        }

        private void SetLayerRecursive(Transform t, int layer)
        {
            // Optional: Don't overwrite Triggers if you want them on a specific layer?
            // For now, Hitbox layer is usually fine for triggers too if configured right.

            if (t.gameObject.layer != layer)
            {
                t.gameObject.layer = layer;
            }

            foreach (Transform child in t)
            {
                SetLayerRecursive(child, layer);
            }
        }

        private void Awake()
        {
            // Self-Destruct in Play Mode to save memory
            if (Application.isPlaying)
            {
                Destroy(this);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Core\Utiities\Rotator.cs`
- Lines: 45
- Size: 1.3 KB
- Modified: 2026-01-17 10:27

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public class Rotator : MonoBehaviour
    {
        public enum RotateDirection
        {
            Clockwise = 1,
            CounterClockwise = -1
        }

        [Header("Settings")]
        public Vector3 axis = Vector3.up;
        public float speed = 100f;

        [Tooltip("Direction of rotation relative to the axis.")]
        public RotateDirection direction = RotateDirection.Clockwise;

        public bool localSpace = true;

        private void Update()
        {
            if (speed == 0) return;

            // Math: Speed * Direction (1 or -1) * DeltaTime
            float finalStep = speed * (int)direction * Time.deltaTime;

            if (localSpace)
                transform.Rotate(axis, finalStep, Space.Self);
            else
                transform.Rotate(axis, finalStep, Space.World);
        }

        // API for AI/Events to change direction at runtime
        public void SetDirection(RotateDirection newDir) => direction = newDir;

        public void ToggleDirection()
        {
            direction = direction == RotateDirection.Clockwise ?
                        RotateDirection.CounterClockwise :
                        RotateDirection.Clockwise;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Behaviours\AvoidanceBehavior.cs`
- Lines: 45
- Size: 1.6 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(fileName = "Beh_Avoidance", menuName = "DarkTowerTron/AI/Behaviors/Obstacle Avoidance")]
    public class AvoidanceBehavior : SteeringBehavior
    {
        public float avoidanceRadius = 2f;
        public float dangerWeight = 1f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // 1. Safety Check: Use data from the agent
            if (aiData.ownerCollider == null) return;

            // 2. Logic
            if (aiData.obstacles == null || aiData.obstacles.Count == 0) return;

            foreach (Collider obstacle in aiData.obstacles)
            {
                // FIX: Access the collider via aiData
                Vector3 closestPoint = aiData.ownerCollider.ClosestPoint(aiData.transform.position);

                Vector3 dirToObstacle = closestPoint - aiData.transform.position;
                dirToObstacle.y = 0;

                float distance = dirToObstacle.magnitude;

                if (distance > avoidanceRadius) continue;

                Vector3 dirNormalized = dirToObstacle.normalized;

                for (int i = 0; i < AIDirections.EightDirections.Count; i++)
                {
                    float dot = Vector3.Dot(dirNormalized, AIDirections.EightDirections[i]);
                    if (dot > 0.6f)
                    {
                        float weight = dangerWeight * (1 - (distance / avoidanceRadius));
                        if (weight > danger[i]) danger[i] = weight;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Behaviours\FleeBehaviour.cs`
- Lines: 52
- Size: 1.9 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(fileName = "Beh_Flee", menuName = "DarkTowerTron/AI/Behaviors/Flee")]
    public class FleeBehavior : SteeringBehavior
    {
        [Tooltip("Enemy will only flee if target is closer than this distance.")]
        public float fleeDistance = 10f;

        [Tooltip("Strength of the flee desire (0 to 1).")]
        public float weight = 1.0f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate vector TO the target
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Keep it flat

            float distanceSqr = vectorToTarget.sqrMagnitude;

            // 2. Distance Check (Optimization)
            // If we are far enough away, we don't need to flee.
            if (distanceSqr > fleeDistance * fleeDistance) return;

            // 3. Calculate "Away" Direction
            Vector3 dirAway = -vectorToTarget.normalized;

            // 4. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: How well does this compass direction align with "Away"?
                float dot = Vector3.Dot(dirAway, AIDirections.EightDirections[i]);

                // We only care about directions that actually take us away (> 0)
                if (dot > 0)
                {
                    float value = dot * weight;

                    // If this behavior suggests a stronger interest than existing ones, override it
                    if (value > interest[i])
                    {
                        interest[i] = value;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Behaviours\OrbitBehavior.cs`
- Lines: 55
- Size: 2.1 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(fileName = "Beh_Orbit", menuName = "DarkTowerTron/AI/Behaviors/Orbit")]
    public class OrbitBehavior : SteeringBehavior
    {
        [Header("Orbit Settings")]
        public float idealDistance = 7f;
        public float distanceCorrectionStrength = 0.5f; // How hard we push back/in
        public bool clockwise = true;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            if (aiData.currentTarget == null) return;

            // 1. Calculate Vectors
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Flatten
            float distance = vectorToTarget.magnitude;
            Vector3 dirToTarget = vectorToTarget.normalized;

            // 2. Calculate Tangent (The Orbit Direction)
            // Cross product of Up(0,1,0) and Forward gives Right
            Vector3 tangent = Vector3.Cross(Vector3.up, dirToTarget).normalized;
            if (!clockwise) tangent = -tangent;

            // 3. Calculate Correction (Push In or Pull Out)
            Vector3 correction = Vector3.zero;

            // Allow a "dead zone" of 1 unit where we just orbit purely
            if (distance > idealDistance + 1f)
            {
                correction = dirToTarget * distanceCorrectionStrength; // Move closer
            }
            else if (distance < idealDistance - 1f)
            {
                correction = -dirToTarget * distanceCorrectionStrength; // Back away
            }

            // 4. Combine
            Vector3 finalDir = (tangent + correction).normalized;

            // 5. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                float dot = Vector3.Dot(finalDir, AIDirections.EightDirections[i]);
                if (dot > 0 && dot > interest[i])
                {
                    interest[i] = dot;
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Behaviours\SeekBehaviour.cs`
- Lines: 39
- Size: 1.4 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(fileName = "Beh_Seek", menuName = "DarkTowerTron/AI/Behaviors/Seek")]
    public class SeekBehavior : SteeringBehavior
    {
        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate direction to target
            Vector3 directionToTarget = (aiData.currentTarget.position - aiData.transform.position);
            directionToTarget.y = 0; // Flatten (keep on ground plane)

            // Normalize
            directionToTarget.Normalize();

            // 2. Compare against our 8 compass directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: 1.0 = Perfect Alignment, 0.0 = 90 deg, -1.0 = Opposite
                float dot = Vector3.Dot(directionToTarget, AIDirections.EightDirections[i]);

                // We only care if the direction brings us closer (>0)
                if (dot > 0)
                {
                    // Apply interest
                    // We use the dot value directly (0 to 1) as the weight
                    if (dot > interest[i])
                    {
                        interest[i] = dot;
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Behaviours\VoidAvoidanceBehavior.cs`
- Lines: 41
- Size: 1.8 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Core; // For GameConstants

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(fileName = "Beh_VoidAvoidance", menuName = "DarkTowerTron/AI/Behaviors/Void Avoidance")]
    public class VoidAvoidanceBehavior : SteeringBehavior
    {
        [Header("Settings")]
        public float lookAheadDistance = 2f;
        public float voidDangerWeight = 1f; // 1.0 means "Absolutely Not"

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Loop through all 8 generic directions (N, NE, E, SE, S, SW, W, NW)
            for (int i = 0; i < AIDirections.EightDirections.Count; i++)
            {
                Vector3 direction = AIDirections.EightDirections[i];

                // 1. Calculate where this direction takes us
                // We use the AI's current position + direction * distance
                // Note: AIDirections are usually local or world? Context steering usually uses World Space directions relative to the agent.
                // Assuming AIDirections are unit vectors.

                Vector3 checkPos = aiData.transform.position + (direction * lookAheadDistance);

                // 2. Check for Ground
                // Lift origin up slightly to ensure we cast downwards cleanly
                Vector3 rayOrigin = checkPos + Vector3.up * 2.0f;

                // 3. The Logic: If we DO NOT hit ground, it is DANGEROUS
                if (!UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, 10f, GameConstants.MASK_GROUND_ONLY))
                {
                    // VOID DETECTED!
                    // Set danger for this specific direction slot
                    danger[i] = voidDangerWeight;
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Core\AIData.cs`
- Lines: 25
- Size: 0.7 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.AI
{
    public class AIData : MonoBehaviour
    {
        [Header("Targets")]
        public Transform currentTarget;

        [Header("Dynamic Info (Read Only)")]
        public List<Transform> targets = new List<Transform>();
        public List<Collider> obstacles = new List<Collider>();

        // NEW: Cache the owner's collider here
        public Collider ownerCollider;

        private void Awake()
        {
            ownerCollider = GetComponent<Collider>();
        }

        public int GetTargetsCount() => targets != null ? targets.Count : 0;
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Core\ContextSolver.cs`
- Lines: 81
- Size: 2.6 KB
- Modified: 2026-01-17 13:47

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [RequireComponent(typeof(AIData))]
    public class ContextSolver : MonoBehaviour
    {
        [Header("Settings")]
        public List<SteeringBehavior> behaviors;
        public List<Detector> detectors;

        [Header("Debug")]
        public bool showGizmos = true;

        private float[] _interestMap = new float[8];
        private float[] _dangerMap = new float[8];
        private AIData _aiData;
        private Collider _ownerCollider;

        private void Awake()
        {
            _aiData = GetComponent<AIData>();
            // Get the AI's own collider (usually on the root)
            _ownerCollider = GetComponent<Collider>();
        }

        public Vector3 GetDirectionToMove()
        {
            // SAFETY CHECK: If we are called before Awake or missing component
            if (_aiData == null) return transform.forward;

            // 1. Reset Maps
            System.Array.Clear(_interestMap, 0, 8);
            System.Array.Clear(_dangerMap, 0, 8);

            // 2. Run Detectors
            foreach (var detector in detectors)
            {
                // Extra safety check in case a detector slot is null in Inspector
                if (detector != null) detector.Detect(_aiData);
            }

            // 3. Run Behaviors
            foreach (var behavior in behaviors)
            {
                if (behavior != null) behavior.GetSteering(_interestMap, _dangerMap, _aiData);
            }

            // 4. Process Maps
            for (int i = 0; i < 8; i++)
            {
                if (_dangerMap[i] > 0)
                {
                    _interestMap[i] = Mathf.Clamp01(_interestMap[i] - _dangerMap[i]);
                }
            }

            // 5. Average
            Vector3 outputDirection = Vector3.zero;
            for (int i = 0; i < 8; i++)
            {
                outputDirection += AIDirections.EightDirections[i] * _interestMap[i];
            }

            return outputDirection.normalized;
        }

        private void OnDrawGizmos()
        {
            // STRICT SAFETY CHECKS FOR EDITOR GIZMOS
            if (!showGizmos) return;
            if (!Application.isPlaying) return; // Only draw when logic is actually running
            if (_aiData == null) return;        // Don't draw if not initialized

            Gizmos.color = Color.yellow;
            // This call was causing the crash because it ran when _aiData was null
            Gizmos.DrawRay(transform.position, GetDirectionToMove() * 2);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Core\Detector.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class Detector : MonoBehaviour
    {
        public abstract void Detect(AIData aiData);
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Core\SteeringBehaviour.cs`
- Lines: 12
- Size: 0.3 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class SteeringBehavior : ScriptableObject
    {
        // REMOVED: protected Collider ownerCollider;
        // REMOVED: public virtual void Initialize(...)

        public abstract void GetSteering(float[] interest, float[] danger, AIData aiData);
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Detectors\ObstacleDetector.cs`
- Lines: 39
- Size: 1.1 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public class ObstacleDetector : Detector
    {
        [Header("Settings")]
        public float detectionRadius = 2f;
        public LayerMask obstacleMask;
        public bool showGizmos = true;

        // Optimization: Recycle this array to avoid Garbage Collection
        private Collider[] _colliders = new Collider[10];

        public override void Detect(AIData aiData)
        {
            // Clear previous data
            aiData.obstacles.Clear();

            // Find physics objects
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRadius, _colliders, obstacleMask);

            for (int i = 0; i < count; i++)
            {
                // Add to the data packet
                aiData.obstacles.Add(_colliders[i]);
            }
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, detectionRadius);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Detectors\TargetDetector.cs`
- Lines: 46
- Size: 1.4 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public class TargetDetector : Detector
    {
        [Header("Settings")]
        public float detectionRange = 20f;
        public LayerMask targetLayer; // Set to 'Player' and 'AfterImage'
        public bool showGizmos = false;

        private Collider[] _colliders = new Collider[5];

        public override void Detect(AIData aiData)
        {
            // 1. Find potential targets
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRange, _colliders, targetLayer);

            // 2. Logic: Pick the closest one
            float closestDist = float.MaxValue;
            Transform bestTarget = null;

            for (int i = 0; i < count; i++)
            {
                float dist = Vector3.SqrMagnitude(_colliders[i].transform.position - transform.position);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    bestTarget = _colliders[i].transform;
                }
            }

            // 3. Output
            aiData.currentTarget = bestTarget;
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.magenta;
                Gizmos.DrawWireSphere(transform.position, detectionRange);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Paths\AutoAssignPatrolPath.cs`
- Lines: 77
- Size: 2.4 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
{
    [RequireComponent(typeof(EnemyPatrolModule))]
    public class AutoAssignPatrolPath : MonoBehaviour
    {
        public bool autoFindNearest = true;
        public PatrolPath explicitPath;

        private void Start()
        {
            if (gameObject.scene.name == null) return;
            var patrolModule = GetComponent<EnemyPatrolModule>();

            if (explicitPath != null)
            {
                SetPath(patrolModule, explicitPath);
            }
            else if (autoFindNearest)
            {
                StartCoroutine(FindAndAssignPathRoutine(patrolModule));
            }
        }

        private IEnumerator FindAndAssignPathRoutine(EnemyPatrolModule module)
        {
            yield return null;
            PatrolPath nearest = FindNearestPath();
            if (nearest != null) SetPath(module, nearest);
        }

        private void SetPath(EnemyPatrolModule module, PatrolPath path)
        {
            if (module != null)
            {
                module.patrolPath = path;
                module.currentWaypointIndex = GetClosestWaypointIndex(path);
            }
        }

        private PatrolPath FindNearestPath()
        {
            var allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath best = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float d = Vector3.Distance(transform.position, path.waypoints[0].transform.position);
                    if (d < closestDist) { closestDist = d; best = path; }
                }
            }
            return best;
        }

        private int GetClosestWaypointIndex(PatrolPath path)
        {
            int bestIndex = 0;
            float closestDist = float.MaxValue;

            for (int i = 0; i < path.waypoints.Count; i++)
            {
                if (path.waypoints[i] == null) continue;
                float d = Vector3.Distance(transform.position, path.waypoints[i].transform.position);
                if (d < closestDist) { closestDist = d; bestIndex = i; }
            }
            return bestIndex;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Paths\PatrolPath.cs`
- Lines: 28
- Size: 0.9 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.AI
{
    public class PatrolPath : MonoBehaviour
    {
        public List<Waypoint> waypoints;
        public bool loop = true;

        private void OnDrawGizmos()
        {
            if (waypoints == null || waypoints.Count < 2) return;

            Gizmos.color = Color.cyan;
            for (int i = 0; i < waypoints.Count - 1; i++)
            {
                if (waypoints[i] && waypoints[i + 1])
                    Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
            }

            if (loop && waypoints[0] && waypoints[waypoints.Count - 1])
            {
                Gizmos.DrawLine(waypoints[waypoints.Count - 1].transform.position, waypoints[0].transform.position);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Paths\Waypoint.cs`
- Lines: 26
- Size: 0.6 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor; // <--- WRAP THIS
#endif

namespace DarkTowerTron.Gameplay.AI
{
    public class Waypoint : MonoBehaviour
    {
        public float waitTime = 0f;
        public AIState overrideState;
        public float overrideDuration = 5f;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, 0.5f);

            // --- WRAP THE LABEL LOGIC ---
#if UNITY_EDITOR
            Handles.Label(transform.position + Vector3.up, name);
#endif
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Actions\Action_ContextSteering.cs`
- Lines: 39
- Size: 1.6 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Actions/Move via Context Steering")]
    public class Action_ContextSteering : AIAction
    {
        [Header("Movement Profile")]
        public float speedMultiplier = 1.0f;

        [Header("Behaviors to Apply")]
        // We configure the specific steering behaviors HERE in the asset
        public List<SteeringBehavior> behaviors;

        public override void Act(PluggableAIController controller)
        {
            // 1. Inject Behaviors into the Solver
            // Optimization Note: Doing this every frame is wasteful if the list doesn't change.
            // A better way is to do this in "OnEnter State", but for simplicity/robustness:
            controller.blackboard.ContextSolver.behaviors = behaviors;

            // 2. Get Direction
            Vector3 dir = controller.blackboard.ContextSolver.GetDirectionToMove();

            // 3. Move via IMover interface
            // (Assuming EnemyStats logic is handled inside the IMover or passed here. 
            // For now, let's assume the controller's Motor handles the base speed from StatsSO)
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // 4. Face Movement
            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, targetRot, 10f * Time.deltaTime);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Actions\Action_FirePattern.cs`
- Lines: 34
- Size: 1.1 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Core.Data; // For EnemyAttackSO & AttackPatternSO
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Fire Pattern")]
    public class Action_FirePattern : AIAction
    {
        [Header("The Shape")]
        public AttackPatternSO pattern;

        [Header("The Payload")]
        public EnemyAttackSO attackStats; // <--- REPLACES 'projectilePrefab'

        public override void Act(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return;

            // 1. Face the Target
            if (controller.blackboard.Mover is EnemyMotor motor)
            {
                motor.FaceCombatTarget(controller.blackboard.Target.position);
            }

            // 2. Fire
            if (controller.blackboard.Weapon != null)
            {
                // Pass BOTH config objects to the weapon
                controller.blackboard.Weapon.Fire(pattern, attackStats, controller.blackboard.Target);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Actions\Action_Patrol.cs`
- Lines: 51
- Size: 1.8 KB
- Modified: 2026-01-17 14:32

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Actions/Move/Patrol")]
    public class Action_Patrol : AIAction
    {
        public float waypointTolerance = 1.0f;
        public float speedMultiplier = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            var patrol = controller.GetComponent<EnemyPatrolModule>();
            if (patrol == null || patrol.patrolPath == null) return;

            Transform targetPoint = patrol.GetCurrentWaypointTarget();
            if (targetPoint == null) return;

            // 1. Calculate Flat Distance
            Vector3 flatPos = controller.transform.position; flatPos.y = 0;
            Vector3 flatTarget = targetPoint.position; flatTarget.y = 0;
            if (Vector3.Distance(flatPos, flatTarget) < waypointTolerance)
            {
                patrol.AdvanceWaypoint();

                Transform nextPoint = patrol.GetCurrentWaypointTarget();
                if (nextPoint != null) MoveTowards(controller, nextPoint.position);
            }
            else
            {
                // 3. Keep Moving
                MoveTowards(controller, targetPoint.position);
            }
        }

        private void MoveTowards(PluggableAIController controller, Vector3 targetPos)
        {
            Vector3 dir = (targetPos - controller.transform.position).normalized;
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // Store in blackboard for Debugger visualization
            controller.blackboard.MoveDirection = dir;

            if (controller.blackboard.Mover is DarkTowerTron.Gameplay.Enemies.EnemyMotor motor)
            {
                motor.FaceTarget(targetPos);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Actions\Action_SelfDestruct.cs`
- Lines: 51
- Size: 1.9 KB
- Modified: 2026-01-17 14:32

```csharp
using UnityEngine;
using DarkTowerTron.Core; // For DamageInfo/GameConstants
using DarkTowerTron.Core.Feedback; // For Juice
using DarkTowerTron.Gameplay.Combat;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Actions/Combat/Self Destruct")]
    public class Action_SelfDestruct : AIAction
    {
        [Header("Explosion Stats")]
        public float radius = 2.0f;
        public float damage = 10f;
        public float knockback = 20f;

        [Header("Juice")]
        public FeedbackConfigurationSO explosionFeedback;

        public override void Act(PluggableAIController controller)
        {
            // 1. Play Feedback (Sound/VFX)
            if (explosionFeedback)
                explosionFeedback.Play(null, controller.transform.position);

            // 2. Find Targets
            // We use OverlapSphere to hit player OR other enemies (if friendly fire)
            int mask = LayerMask.GetMask("Player"); // Or use GameConstants
            Collider[] hits = UnityEngine.Physics.OverlapSphere(controller.transform.position, radius, mask);

            foreach (var hit in hits)
            {
                IDamageable target = hit.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = (hit.transform.position - controller.transform.position).normalized,
                        pushForce = knockback,
                        source = controller.gameObject,
                        damageType = DamageType.Explosion
                    };
                    target.TakeDamage(info);
                }
            }

            // 3. Die (No Reward, because it exploded itself)
            controller.blackboard.Controller.SelfDestruct();
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Actions\Action_Visual_Prime.cs`
- Lines: 24
- Size: 0.8 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DG.Tweening; // For the shake

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Actions/Visuals/Prime Effect")]
    public class Action_Visual_Prime : AIAction
    {
        public float shakeDuration = 0.5f;
        public float shakeStrength = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            // 1. Visual Color Flash (Using the System we built in Phase 2)
            if (controller.blackboard.Controller.Visuals != null)
            {
                controller.blackboard.Controller.Visuals.StartPrimingEffect();
            }

            // 2. Physical Shake
            controller.transform.DOShakeScale(shakeDuration, shakeStrength, 20, 90);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Core\AIAction.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class AIAction : ScriptableObject
    {
        public abstract void Act(PluggableAIController controller);
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Core\AIBlackboard.cs`
- Lines: 26
- Size: 0.8 KB
- Modified: 2026-01-17 14:08

```csharp
using UnityEngine;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
{
    [System.Serializable]
    public class AIBlackboard
    {
        [Header("Runtime Data")]
        public Transform Target;
        public Vector3 MoveDirection;
        public float StateTimeElapsed;

        // Component Cache (The "Universal" Body)
        public IMover Mover;
        public ContextSolver ContextSolver;
        public DamageReceiver Health;
        public EnemyController Controller;
        public PatternExecutor Weapon; // Optional but common enough to keep

        // REMOVED: public PatrolPath patrolPath;
        // REMOVED: public int currentWaypointIndex;
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Core\AIDecision.cs`
- Lines: 9
- Size: 0.2 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public abstract class AIDecision : ScriptableObject
    {
        public abstract bool Decide(PluggableAIController controller);
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Core\AIState.cs`
- Lines: 76
- Size: 2.3 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Pluggable/State")]
    public class AIState : ScriptableObject
    {
        [Header("Run Once (On Enter)")]
        public List<AIAction> onEnterActions;

        [Header("Run Every Frame")]
        public List<AIAction> actions;
        public List<Transition> transitions;

        public void EnterState(PluggableAIController controller)
        {
            if (onEnterActions == null || onEnterActions.Count == 0) return;

            for (int i = 0; i < onEnterActions.Count; i++)
            {
                var action = onEnterActions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        public void UpdateState(PluggableAIController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(PluggableAIController controller)
        {
            if (actions == null || actions.Count == 0) return;

            for (int i = 0; i < actions.Count; i++)
            {
                var action = actions[i];
                if (action == null) continue;
                action.Act(controller);
            }
        }

        private void CheckTransitions(PluggableAIController controller)
        {
            if (transitions == null || transitions.Count == 0) return;

            for (int i = 0; i < transitions.Count; i++)
            {
                var transition = transitions[i];
                if (transition.decision == null) continue;

                bool decisionSucceeded = transition.decision.Decide(controller);

                if (decisionSucceeded)
                {
                    controller.TransitionToState(transition.trueState);
                }
                else
                {
                    controller.TransitionToState(transition.falseState);
                }
            }
        }
    }

    [System.Serializable]
    public struct Transition
    {
        public AIDecision decision;
        public AIState trueState;
        public AIState falseState; // Usually "RemainState"
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Core\PluggableAIController.cs`
- Lines: 123
- Size: 3.8 KB
- Modified: 2026-01-18 23:57

```csharp
using UnityEngine;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Gameplay.Player; // ADDED: Needed for PlayerController

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Gameplay.AI
{
    [RequireComponent(typeof(IMover))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(EnemyController))]
    public class PluggableAIController : MonoBehaviour
    {
        [Header("Configuration")]
        public AIState currentState;
        public AIState remainState;

        [Header("Setup")]
        public PatternExecutor specificWeapon;

        [Header("Debug")]
        public bool aiActive = true;
        public AIBlackboard blackboard;

        private void Awake()
        {
            blackboard ??= new AIBlackboard();

            var motor = GetComponent<EnemyMotor>();
            if (motor != null)
            {
                blackboard.Mover = motor;
            }
            else
            {
                var mover = GetComponent<IMover>();
                blackboard.Mover = mover;
                Debug.LogWarning($"[AI Setup] {name} is using fallback mover '{mover.GetType().Name}'.", gameObject);
            }

            blackboard.ContextSolver = GetComponent<ContextSolver>();
            blackboard.Health = GetComponent<DamageReceiver>();
            blackboard.Controller = GetComponent<EnemyController>();

            if (specificWeapon != null)
            {
                blackboard.Weapon = specificWeapon;
            }
            else
            {
                blackboard.Weapon = GetComponent<PatternExecutor>();
                if (blackboard.Weapon == null)
                {
                    blackboard.Weapon = gameObject.AddComponent<PatternExecutor>();
                }
            }
        }

        private void Start()
        {
            // FIX: Replaced GameServices.Player with PlayerController.Instance
            if (PlayerController.Instance != null)
                blackboard.Target = PlayerController.Instance.transform;

            if (blackboard.ContextSolver != null)
            {
                var aiData = GetComponent<AIData>();
                if (aiData) aiData.currentTarget = blackboard.Target;
            }

            if (currentState != null)
            {
                blackboard.StateTimeElapsed = 0f;
                currentState.EnterState(this);
            }
        }

        private void Update()
        {
            if (!aiActive || blackboard.Controller.IsStaggered) return;

            blackboard.StateTimeElapsed += Time.deltaTime;
            if (currentState != null)
            {
                currentState.UpdateState(this);
            }
        }

        public void TransitionToState(AIState nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
                blackboard.StateTimeElapsed = 0f;

                if (currentState != null && currentState.onEnterActions != null)
                {
                    for (int i = 0; i < currentState.onEnterActions.Count; i++)
                    {
                        var action = currentState.onEnterActions[i];
                        if (action == null) continue;
                        action.Act(this);
                    }
                }
            }
        }

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (currentState != null)
            {
                Gizmos.color = Color.green;
                Handles.Label(transform.position + Vector3.up * 2.5f, $"State: {currentState.name}");
            }
        }
#endif
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Decisions\Decision_InRange.cs`
- Lines: 29
- Size: 0.9 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Decisions/In Range")]
    public class Decision_InRange : AIDecision
    {
        public float range = 1.5f;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            // 1. Get Positions
            Vector3 myPos = controller.transform.position;
            Vector3 targetPos = controller.blackboard.Target.position;

            // 2. Flatten Y (Ignore Height)
            // This turns the check from a Sphere into a Cylinder (Infinite height)
            myPos.y = 0;
            targetPos.y = 0;

            // 3. Compare Squared Distance (Optimization)
            float distSqr = (myPos - targetPos).sqrMagnitude;

            return distSqr < (range * range);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Decisions\Decision_LineOfSight.cs`
- Lines: 32
- Size: 1.0 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Core; // GameConstants

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Decisions/Line Of Sight")]
    public class Decision_LineOfSight : AIDecision
    {
        public float range = 15f;
        public LayerMask blockLayer;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            Vector3 eyePos = controller.transform.position + Vector3.up * 1.0f;
            Vector3 targetPos = controller.blackboard.Target.position + Vector3.up * 1.0f;
            Vector3 dir = targetPos - eyePos;
            float dist = dir.magnitude;

            if (dist > range) return false;

            // Check if wall is in between
            if (UnityEngine.Physics.Raycast(eyePos, dir, dist, blockLayer))
            {
                return false; // Hit a wall
            }

            return true; // Clear shot
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Pluggable\Decisions\Decision_TimeElapsed.cs`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    [CreateAssetMenu(menuName = "AI/Decisions/Time Elapsed")]
    public class Decision_TimeElapsed : AIDecision
    {
        public float duration = 2.0f;

        public override bool Decide(PluggableAIController controller)
        {
            return controller.blackboard.StateTimeElapsed >= duration;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Utils\AIDebugger.cs`
- Lines: 77
- Size: 2.8 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
{
    [ExecuteAlways]
    public class AIDebugger : MonoBehaviour
    {
        [Header("Settings")]
        public bool showGizmos = true;
        public float lineScale = 2.0f;

        [Header("References")]
        public PluggableAIController controller;
        public EnemyMotor motor;

        private void OnEnable()
        {
            if (controller == null) controller = GetComponent<PluggableAIController>();
            if (motor == null) motor = GetComponent<EnemyMotor>();
        }

        private void OnDrawGizmos()
        {
            if (!showGizmos || Application.isPlaying == false) return;

            Vector3 pos = transform.position + Vector3.up * 1.0f; // Lift up to see better

            // 1. Draw ACTUAL Velocity (Green) - Where we are actually going
            if (motor != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawRay(pos, motor.Velocity.normalized * lineScale);
                // Draw arrow head
                Vector3 velTip = pos + motor.Velocity.normalized * lineScale;
                Gizmos.DrawSphere(velTip, 0.1f);
            }

            // 2. Draw LOGIC Intent (Yellow) - Where the Blackboard says we should go
            if (controller != null && controller.blackboard != null)
            {
                // Note: You need to ensure your Actions actually write to 'MoveDirection' in Blackboard
                // Currently Action_Patrol calculates it locally. We should fix that.
                /* 
                Gizmos.color = Color.yellow;
                Gizmos.DrawRay(pos, controller.blackboard.MoveDirection * lineScale * 0.8f);
                */
            }

            // 3. Draw TARGET Line (Red)
            if (controller != null && controller.blackboard != null)
            {
                // Target Entity
                if (controller.blackboard.Target != null)
                {
                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(pos, controller.blackboard.Target.position);
                }
                // Patrol Target
                else
                {
                    var patrol = controller.GetComponent<EnemyPatrolModule>();
                    if (patrol != null)
                    {
                        Transform wp = patrol.GetCurrentWaypointTarget();
                        if (wp != null)
                        {
                            Gizmos.color = new Color(1, 0.5f, 0); // Orange
                            Gizmos.DrawLine(pos, wp.position);
                            Gizmos.DrawWireSphere(wp.position, 0.5f);
                        }
                    }
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\AI\Utils\AIDirections.cs`
- Lines: 20
- Size: 0.7 KB
- Modified: 2026-01-17 13:47

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Gameplay.AI
{
    public static class AIDirections
    {
        public static List<Vector3> EightDirections = new List<Vector3>
        {
            new Vector3(0,0,1).normalized,   // 0: North
            new Vector3(1,0,1).normalized,   // 1: NorthEast
            new Vector3(1,0,0).normalized,   // 2: East
            new Vector3(1,0,-1).normalized,  // 3: SouthEast
            new Vector3(0,0,-1).normalized,  // 4: South
            new Vector3(-1,0,-1).normalized, // 5: SouthWest
            new Vector3(-1,0,0).normalized,  // 6: West
            new Vector3(-1,0,1).normalized   // 7: NorthWest
        };
    }
}
```

## 📄 `Assets\_Project\Gameplay\Cameras\CameraRig.cs`
- Lines: 138
- Size: 4.8 KB
- Modified: 2026-01-18 12:57

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Player; // Access to PlayerController

namespace DarkTowerTron.Gameplay.Cameras
{
    [DefaultExecutionOrder(-10)] // Initialize before Triggers
    public class CameraRig : MonoBehaviour
    {
        public static CameraRig Instance { get; private set; }

        [Header("Targeting")]
        [SerializeField] private Transform _target;
        [SerializeField] private bool _autoFindPlayer = true;

        [Header("Default Settings")]
        [SerializeField] private float _defaultPitch = 45f;
        [SerializeField] private float _defaultDistance = 25f;
        
        [Header("Motion Settings")]
        [SerializeField] private float _smoothTime = 0.1f;
        [SerializeField] private float _rotationSmoothSpeed = 2f;

        // Internal State
        private float _targetPitch;
        private float _targetDistance;

        // Locking State (for 2.5D sections)
        private bool _lockX = false;
        private bool _lockZ = false;
        private Vector3 _lockPosition = Vector3.zero;

        // Velocity for SmoothDamp
        private Vector3 _currentVelocity;

        private void Awake()
        {
            // Singleton Registration
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;

            ResetToDefault();
        }

        private void Start()
        {
            if (_target == null && _autoFindPlayer)
            {
                if (PlayerController.Instance != null)
                {
                    _target = PlayerController.Instance.transform;
                }
            }
        }

        private void LateUpdate()
        {
            if (_target == null) return;

            HandleCameraMovement();
        }

        public void ResetToDefault()
        {
            _targetPitch = _defaultPitch;
            _targetDistance = _defaultDistance;
            _lockX = false;
            _lockZ = false;
        }

        /// <summary>
        /// Called by CameraZones to override angle/distance or lock axes.
        /// Pass -1 to keep existing pitch/distance.
        /// </summary>
        public void OverrideCamera(float newPitch, float newDist, bool lockX, bool lockZ, Vector3 lockPos)
        {
            if (newPitch > 0) _targetPitch = newPitch;
            if (newDist > 0) _targetDistance = newDist;

            _lockX = lockX;
            _lockZ = lockZ;
            _lockPosition = lockPos;
        }

        private void HandleCameraMovement()
        {
            // 1. Determine Base Follow Position (Target or Locked Axis)
            Vector3 followPos = _target.position;

            if (_lockX) followPos.x = _lockPosition.x;
            if (_lockZ) followPos.z = _lockPosition.z;

            // 2. Calculate Desired Offset based on Target Pitch/Distance
            // Note: We intentionally don't lerp the Pitch/Distance variables themselves to avoid "Double Smoothing".
            // We calculate the *ideal* destination and let SmoothDamp handle the smoothing.
            
            float rad = _targetPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance;
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);
            
            Vector3 desiredPosition = followPos + new Vector3(0, yOffset, zOffset);

            // 3. Move Position (Smooth)
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref _currentVelocity, _smoothTime);

            // 4. Rotate (Smooth)
            // We always look at the followPos (or slightly ahead/offset if desired)
            // Or strictly adhere to the pitch:
            Quaternion targetRotation = Quaternion.Euler(_targetPitch, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * _rotationSmoothSpeed);
        }
        
        /// <summary>
        /// Instant snap to target (useful for respawns).
        /// </summary>
        public void SnapToTarget()
        {
            if (_target == null) return;
            
            // Force logic once without smoothing
            Vector3 followPos = _target.position;
            if (_lockX) followPos.x = _lockPosition.x;
            if (_lockZ) followPos.z = _lockPosition.z;

            float rad = _targetPitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * _targetDistance;
            float zOffset = -(Mathf.Cos(rad) * _targetDistance);

            transform.position = followPos + new Vector3(0, yOffset, zOffset);
            transform.rotation = Quaternion.Euler(_targetPitch, 0, 0);
            
            _currentVelocity = Vector3.zero;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\ContactDamager.cs`
- Lines: 41
- Size: 1.2 KB
- Modified: 2026-01-20 08:29

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Gameplay.Combat
{
    public class ContactDamager : MonoBehaviour
    {
        [SerializeField] private float _damage = 10f;
        [SerializeField] private DamageType _damageType = DamageType.Melee;
        [SerializeField] private bool _destroyOnImpact = false;

        private void OnTriggerEnter(Collider other)
        {
            // 1. Find Target
            IDamageable target = other.GetComponent<IDamageable>();
            if (target == null) return;

            // 2. Safety Check (since TakeDamage relies on void now)
            if (target.IsDead) return;

            // 3. Create Info
            DamageInfo info = new DamageInfo
            {
                damageAmount = _damage,
                source = gameObject,
                damageType = _damageType,
                pushDirection = transform.forward,
                pushForce = 5f
            };

            // 4. Apply Damage (No longer returns bool)
            target.TakeDamage(info);

            // 5. Cleanup
            if (_destroyOnImpact)
            {
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\DamageInfo.cs`
- Lines: 40
- Size: 1.1 KB
- Modified: 2026-01-20 08:01

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{

    [System.Serializable]
    public struct DamageInfo
    {
        // Primary stats
        public float damageAmount;
        public int staggerAmount;

        // Physics / Knockback
        public Vector3 pushDirection;
        public float pushForce;

        // Context
        public GameObject source;
        public bool isRedirected;
        public DamageType damageType;
        public bool isCritical; // Fixed CS1061 in BaseHitbox

        /// <summary>
        /// Helper constructor for simple damage events
        /// </summary>
        public DamageInfo(float amount, GameObject source = null, DamageType type = DamageType.Generic)
        {
            this.damageAmount = amount;
            this.source = source;
            this.damageType = type;

            // Defaults
            this.staggerAmount = 0;
            this.pushDirection = Vector3.zero;
            this.pushForce = 0;
            this.isRedirected = false;
            this.isCritical = false;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\DamageReceiver.cs`
- Lines: 215
- Size: 6.7 KB
- Modified: 2026-01-20 08:34

```csharp
using UnityEngine;
using System;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Patterns; // For IPoolable

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Gameplay.Combat
{
    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IAimTarget, IPoolable, ICombatTarget
    {
        // --- EVENTS ---
        // Restored for compatibility with ArchitectHand / Props
        public event Action<DamageInfo> OnHitProcessed;
        public event Action<DamageInfo> OnTakeDamage;
        public event Action<EnemyStatsSO, bool> OnDeathProcessed;

        // New event from refactor (kept for future use)
        public event Action OnDeath;

        [Header("Debug")]
        public static bool EnableDebugGizmos = false;

        [Header("Configuration")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget;
        [SerializeField] private float _magnetismRadius = 0.75f;

        [Header("Execution Settings")]
        // Restored for EnemyController
        [SerializeField] private bool _keepPlayerGrounded = true;

        [Header("Feedback")]
        [SerializeField] private FeedbackConfigurationSO _hitFeedback;
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

        // Dependencies
        protected VitalityModule _vitality;
        protected StaggerModule _stagger;
        protected EnemyStatsSO _stats;

        // --- PROPERTIES ---
        public float CurrentHealth => _vitality != null ? _vitality.CurrentHealth : 0f;
        public float MaxHealth => _vitality != null ? _vitality.MaxHealth : 0f;

        // IDamageable Implementation
        public bool IsDead => _vitality != null && _vitality.IsDead;

        public bool IsStaggered => _stagger != null && _stagger.IsStaggered;

        // ICombatTarget Implementation
        public bool KeepPlayerGrounded => _keepPlayerGrounded;

        // Module Accessors
        public VitalityModule Vitality => _vitality;
        public StaggerModule Stagger => _stagger;

        // --- LIFECYCLE ---

        protected virtual void Awake()
        {
            _vitality = GetComponent<VitalityModule>();
            _stagger = GetComponent<StaggerModule>();

            if (_vitality) _vitality.OnDeath += HandleVitalityDeath;
        }

        protected virtual void OnDestroy()
        {
            if (_vitality) _vitality.OnDeath -= HandleVitalityDeath;
        }

        public void Initialize(EnemyStatsSO stats)
        {
            _stats = stats;
            float hp = 10f;
            int stg = 1;
            float decay = 1f;

            if (useOverrides)
            {
                hp = _overrideHealth;
                stg = _overrideStagger;
            }
            else if (stats != null)
            {
                hp = stats.maxHealth;
                stg = stats.maxStagger;
                decay = stats.staggerDecay;
            }

            _vitality?.Initialize(hp);
            _stagger?.Initialize(stg, decay);
        }

        public void OnSpawn()
        {
            // Reset state for pooling
            if (_stagger) _stagger.ResetStagger();
            if (_vitality) _vitality.Initialize(MaxHealth > 0 ? MaxHealth : 10);
        }

        public void OnDespawn()
        {
            if (_stagger) _stagger.ResetStagger();
        }

        // --- LOGIC PIPELINE ---

        public void TakeDamage(DamageInfo info)
        {
            if (IsDead) return;

            // 1. Logic
            if (IsStaggered)
            {
                // Logic: Staggered enemies take lethal damage or start execution
                if (info.damageAmount > 0)
                {
                    Kill(true);
                }
            }
            else
            {
                // Logic: Apply normal damage and stagger
                _stagger.AddStagger(info.staggerAmount);
                _vitality.TakeDamage(info.damageAmount);
            }

            // 2. Feedback
            if (_hitFeedback != null) _hitFeedback.Play(gameObject, transform.position);

            // 3. Events
            OnHitProcessed?.Invoke(info);
            OnTakeDamage?.Invoke(info);
        }

        public void Kill(bool rewardPlayer)
        {
            if (IsDead) return;

            if (_deathFeedback != null)
                _deathFeedback.Play(gameObject, transform.position);

            OnDeath?.Invoke();
            OnDeathProcessed?.Invoke(_stats, rewardPlayer);

            // Force Vitality death
            _vitality.TakeDamage(99999f);
        }

        // Helper Overload for simple float calls
        public void TakeDamage(float amount)
        {
            // FIX: Using correct arguments for DamageInfo struct
            // (amount, source, type)
            TakeDamage(new DamageInfo(amount, null, DamageType.Generic));
        }

        private void HandleVitalityDeath()
        {
            // Triggered when HP hits 0 naturally
            OnDeathProcessed?.Invoke(_stats, true);
            OnDeath?.Invoke();
        }

        // --- ICombatTarget Implementation ---
        public void OnExecutionHit() => Kill(true);

        // --- IAimTarget Implementation ---
        public Vector3 AimPoint
        {
            get
            {
                if (_aimTarget == null) return transform.position + Vector3.up * 1.0f;
                return _aimTarget.position;
            }
        }

        public float TargetRadius => _magnetismRadius;

        // --- DEBUG ---
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (!EnableDebugGizmos || !Application.isPlaying || _vitality == null) return;

            GUIStyle style = new GUIStyle();
            style.normal.textColor = Color.white;
            style.fontSize = 20;
            style.alignment = TextAnchor.MiddleCenter;
            style.fontStyle = FontStyle.Bold;

            float hp = CurrentHealth;
            float maxHp = MaxHealth;
            string hpColor = (hp < maxHp * 0.3f) ? "red" : "green";
            string label = $"<color={hpColor}>HP: {hp:F0}/{maxHp:F0}</color>";

            if (IsStaggered) label += "\n<color=yellow>[STAGGERED]</color>";

            Handles.Label(transform.position + Vector3.up * 2.5f, label, style);
        }
#endif
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\DamageType.cs`
- Lines: 16
- Size: 0.3 KB
- Modified: 2026-01-20 08:36

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public enum DamageType
    {
        Generic,
        Projectile,
        Melee,
        //Physical,
        //Energy,
        Explosion,
        Environment,
        Void
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\FirePointRegistry.cs`
- Lines: 61
- Size: 1.8 KB
- Modified: 2026-01-17 11:42

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.Combat
{
    public class FirePointRegistry : MonoBehaviour
    {
        [System.Serializable]
        public struct NamedPoint
        {
            public string id;
            public Transform point;
        }

        [Header("Configuration")]
        [Tooltip("If empty, auto-collects children starting with 'FirePoint_'.")]
        public List<NamedPoint> points = new List<NamedPoint>();

        private Dictionary<string, Transform> _lookup = new Dictionary<string, Transform>();

        private void Awake()
        {
            // 1. Load Manual Assignments
            foreach (var p in points)
            {
                if (!string.IsNullOrEmpty(p.id) && p.point != null)
                    _lookup[p.id] = p.point;
            }

            // 2. Auto-Discovery (Naming Convention: "FirePoint_Muzzle")
            var children = GetComponentsInChildren<Transform>(true);
            foreach (var t in children)
            {
                if (t.name.StartsWith("FirePoint_"))
                {
                    string id = t.name.Replace("FirePoint_", ""); // "Muzzle"
                    if (!_lookup.ContainsKey(id))
                    {
                        _lookup.Add(id, t);
                    }
                }
            }

            // 3. Fallback "Default"
            if (!_lookup.ContainsKey("Default"))
            {
                _lookup["Default"] = transform;
            }
        }

        public Transform GetPoint(string id)
        {
            if (string.IsNullOrEmpty(id)) id = "Default";

            if (_lookup.TryGetValue(id, out Transform t)) return t;

            // Graceful failure
            return _lookup["Default"];
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\HazardZone.cs`
- Lines: 91
- Size: 3.0 KB
- Modified: 2026-01-17 11:42

```csharp
using DarkTowerTron.Core;
using DG.Tweening;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public class HazardZone : MonoBehaviour
    {
        [Header("Settings")]
        public float duration = 3.0f;
        public float damage = 1f;
        public float knockbackForce = 15f;
        public LayerMask targetLayer; // Player

        [Header("Visuals")]
        public Transform visualRing; // Assign a cylinder/sprite

        // Tween references so we can safely kill them if the zone is stopped early
        private Tween _scaleTween;
        private Tween _fadeTween;
        private Tween _delayedCallTween;
        private Coroutine _destroyCoroutine;

        private void Start()
        {
            Transform target = visualRing != null ? visualRing : transform;

            // 1. Expand Visuals (Juice)
            target.localScale = Vector3.zero;
            _scaleTween = target.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);

            // 2. Schedule Destruction
            // Fade out shortly before destroying
            _delayedCallTween = DOVirtual.DelayedCall(Mathf.Max(0f, duration - 0.5f), FadeOut);
            _destroyCoroutine = StartCoroutine(AutoDestroyCoroutine());
        }

        private void OnDisable()
        {
            _scaleTween?.Kill();
            _fadeTween?.Kill();
            _delayedCallTween?.Kill();

            if (_destroyCoroutine != null)
            {
                try { StopCoroutine(_destroyCoroutine); } catch { }
                _destroyCoroutine = null;
            }
        }

        private System.Collections.IEnumerator AutoDestroyCoroutine()
        {
            yield return new WaitForSeconds(duration);
            Destroy(gameObject);
        }

        private void FadeOut()
        {
            Transform target = visualRing != null ? visualRing : transform;
            _fadeTween = target.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check Layer
            if ((targetLayer.value & (1 << other.gameObject.layer)) != 0)
            {
                IDamageable target = other.GetComponentInParent<IDamageable>();
                if (target != null)
                {
                    // Calculate push direction (Away from center of zone)
                    Vector3 dir = (other.transform.position - transform.position).normalized;
                    dir.y = 0;

                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = dir,
                        pushForce = knockbackForce,
                        source = gameObject
                        ,
                        // NEW: Environment
                        damageType = DamageType.Environment
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\HitBox\BaseHitbox.cs`
- Lines: 48
- Size: 1.5 KB
- Modified: 2026-01-20 08:34

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public class BaseHitbox : MonoBehaviour, IDamageable
    {
        [Header("Wiring")]
        [SerializeField] protected DamageReceiver _mainReceiver;

        [Header("Settings")]
        [SerializeField] protected float _damageMultiplier = 1.0f;
        [SerializeField] protected float _staggerMultiplier = 1.0f;
        [SerializeField] protected bool _isCriticalPoint = false;

        protected virtual void Awake()
        {
            // Auto-find logic
            if (_mainReceiver == null)
                _mainReceiver = GetComponentInParent<DamageReceiver>();
        }

        public bool IsDead => _mainReceiver != null && _mainReceiver.IsDead;

        // FIX: Added 'virtual' keyword so children can override it
        public virtual void TakeDamage(DamageInfo info)
        {
            if (_mainReceiver == null) return;

            // Apply Hitbox Modifiers (Headshots, Limbs)
            info.damageAmount *= _damageMultiplier;

            if (_isCriticalPoint)
            {
                info.isCritical = true;
                info.staggerAmount = (int)(info.damageAmount * _staggerMultiplier);
            }

            // Forward to Main Health
            _mainReceiver.TakeDamage(info);
        }

        // FIX: Added 'virtual' keyword
        public virtual void Kill(bool immediate)
        {
            _mainReceiver?.Kill(immediate);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\HitBox\ShieldHitbox.cs`
- Lines: 31
- Size: 1.0 KB
- Modified: 2026-01-20 08:07

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public class ShieldHitbox : BaseHitbox
    {
        [Header("Shield Settings")]
        [SerializeField] private float _damageReduction = 0.5f; // 50% damage taken
        [SerializeField] private bool _breakOnHeavyAttack = true;

        // FIX: Override matches new signature
        public override void TakeDamage(DamageInfo info)
        {
            // Shield Logic: 
            // If the shield is "Active" (optional check), reduce damage.

            // Example: Block logic
            info.damageAmount *= _damageReduction;

            // Example: If damage is 0 (fully blocked), we might want to spawn sparks here
            if (info.damageAmount <= 0)
            {
                // Play Block Sound/VFX
                return;
            }

            // Pass modified info to Base (which forwards to MainReceiver)
            base.TakeDamage(info);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\HitBox\StandardHitbox.cs`
- Lines: 15
- Size: 0.4 KB
- Modified: 2026-01-19 00:19

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    // A simple pass-through hitbox, essentially the same as BaseHitbox 
    // but kept if you have specific logic in your project.
    public class StandardHitbox : BaseHitbox
    {
        public override void TakeDamage(DamageInfo info)
        {
            // Just call base behavior
            base.TakeDamage(info);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\IAimTarget.cs`
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-19 00:15

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public interface IAimTarget
    {
        Vector3 AimPoint { get; }
        float TargetRadius { get; }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\ICombatTarget.cs`
- Lines: 15
- Size: 0.3 KB
- Modified: 2026-01-17 11:37

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public interface ICombatTarget
    {
        Transform transform { get; }
        bool IsStaggered { get; }

        // NEW: Tells the Execution script if it should snap Y to ground
        bool KeepPlayerGrounded { get; }

        void OnExecutionHit();
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\IDamageable.cs`
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-19 00:15

```csharp
namespace DarkTowerTron.Gameplay.Combat
{
    public interface IDamageable
    {
        void TakeDamage(DamageInfo info); // Void return type is standard for Event-Driven
        void Kill(bool immediate);
        bool IsDead { get; }
    }

}
```

## 📄 `Assets\_Project\Gameplay\Combat\IReflectable.cs`
- Lines: 10
- Size: 0.3 KB
- Modified: 2026-01-17 14:25

```csharp
using UnityEngine;
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null);
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\IWeapon.cs`
- Lines: 7
- Size: 0.1 KB
- Modified: 2026-01-17 11:37

```csharp
namespace DarkTowerTron.Gameplay.Combat
{
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Modules\StaggerModule.cs`
- Lines: 79
- Size: 2.2 KB
- Modified: 2026-01-17 11:37

```csharp
using UnityEngine;
using System;
using DG.Tweening;

namespace DarkTowerTron.Gameplay.Combat
{
    public class StaggerModule : MonoBehaviour
    {
        public event Action OnStaggerBreak;
        public event Action OnStaggerRecover;

        public float CurrentStagger { get; private set; }
        public float MaxStagger { get; private set; }
        public bool IsStaggered { get; private set; }

        private float _decayRate;
        private float _lastHitTime;
        private Tween _recoveryTween;

        public void Initialize(float maxStagger, float decayRate)
        {
            MaxStagger = maxStagger;
            _decayRate = decayRate;
            ResetStagger();
        }

        public void ResetStagger()
        {
            IsStaggered = false;
            CurrentStagger = 0;
            if (_recoveryTween != null) _recoveryTween.Kill();
        }

        private void Update()
        {
            // Passive Decay logic
            if (!IsStaggered && CurrentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f) // Wait 1s before decaying
                {
                    CurrentStagger -= _decayRate * Time.deltaTime;
                    if (CurrentStagger < 0) CurrentStagger = 0;
                }
            }
        }

        public void AddStagger(float amount)
        {
            if (IsStaggered) return; // Already broken

            _lastHitTime = Time.time;
            CurrentStagger += amount;

            if (CurrentStagger >= MaxStagger)
            {
                BreakStagger();
            }
        }

        private void BreakStagger()
        {
            IsStaggered = true;
            OnStaggerBreak?.Invoke();

            // Auto-Recover after 2.0s
            // We use DOTween delay for consistency with visuals
            if (_recoveryTween != null) _recoveryTween.Kill();
            _recoveryTween = DOVirtual.DelayedCall(2.0f, Recover).SetId(gameObject);
        }

        private void Recover()
        {
            if (this == null) return;
            IsStaggered = false;
            CurrentStagger = 0;
            OnStaggerRecover?.Invoke();
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Modules\VitalityModule.cs`
- Lines: 58
- Size: 1.5 KB
- Modified: 2026-01-17 11:37

```csharp
using UnityEngine;
using System;

namespace DarkTowerTron.Gameplay.Combat
{
    public class VitalityModule : MonoBehaviour
    {
        public event Action<float, float> OnHealthChanged; // Current, Max
        public event Action OnDeath;

        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public bool IsDead { get; private set; }

        public void Initialize(float maxHealth)
        {
            MaxHealth = maxHealth;
            // Safety check
            if (MaxHealth <= 0) MaxHealth = 1f;
            
            Revive();
        }

        public void Revive()
        {
            CurrentHealth = MaxHealth;
            IsDead = false;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        public void TakeDamage(float amount)
        {
            if (IsDead) return;

            CurrentHealth -= amount;
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);

            if (CurrentHealth <= 0)
            {
                Die();
            }
        }

        public void Heal(float amount)
        {
            if (IsDead) return;
            CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);
            OnHealthChanged?.Invoke(CurrentHealth, MaxHealth);
        }

        private void Die()
        {
            IsDead = true;
            CurrentHealth = 0;
            OnDeath?.Invoke();
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\PatternExecutor.cs`
- Lines: 146
- Size: 5.0 KB
- Modified: 2026-01-18 19:26

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Gameplay.Combat
{
    [RequireComponent(typeof(FirePointRegistry))]
    public class PatternExecutor : MonoBehaviour
    {
        private FirePointRegistry _registry;
        private bool _isFiring;

        // Cached Service
        private IPoolService _poolService;

        // Exposed for AI Decision making
        public bool IsFiring => _isFiring;

        private void Awake()
        {
            _registry = GetComponent<FirePointRegistry>();
        }

        private void Start()
        {
            _poolService = ServiceLocator.Get<IPoolService>();
        }

        public bool Fire(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            if (_isFiring) return false; // Busy
            if (pattern == null || stats == null || stats.projectilePrefab == null) return false;

            StartCoroutine(ExecuteRoutine(pattern, stats, target));
            return true;
        }

        public void StopFiring()
        {
            StopAllCoroutines();
            _isFiring = false;
        }

        private IEnumerator ExecuteRoutine(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            _isFiring = true;

            // 1. Resolve Fire Point
            Transform firePoint = _registry.GetPoint(pattern.firePointID);

            // Safety check if registry failed
            if (firePoint == null) firePoint = transform;

            // 2. Resolve Smart Aim Target (Optimization: Check once per burst)
            IAimTarget aimTarget = null;
            if (target != null)
            {
                aimTarget = target.GetComponent<IAimTarget>();
                if (aimTarget == null) aimTarget = target.GetComponentInChildren<IAimTarget>();
            }

            // 3. Windup
            if (pattern.startDelay > 0)
                yield return new WaitForSeconds(pattern.startDelay);

            // 4. Burst Loop
            float spinOffset = 0f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                // Dynamic Aim Calculation per shot (Tracks moving player)
                Vector3 aimDir = firePoint.forward;

                if (pattern.aimMode == AimType.TargetPlayer && target != null)
                {
                    Vector3 targetPos;

                    // --- SMART AIM LOGIC ---
                    if (aimTarget != null)
                    {
                        targetPos = aimTarget.AimPoint;
                    }
                    else
                    {
                        // Fallback: Guess center mass
                        targetPos = target.position + Vector3.up;
                    }
                    // -----------------------

                    aimDir = (targetPos - firePoint.position).normalized;
                }

                // Apply Spin
                if (pattern.spinDuringFire)
                {
                    spinOffset += pattern.spinSpeed * pattern.delayBetweenShots; // Increment spin
                    aimDir = Quaternion.Euler(0, spinOffset, 0) * aimDir;
                }

                // Apply Spread (Random noise)
                float totalSpread = pattern.spreadAngle + stats.spreadAngle;
                if (totalSpread > 0)
                {
                    float noise = Random.Range(-totalSpread / 2f, totalSpread / 2f);
                    aimDir = Quaternion.Euler(0, noise, 0) * aimDir;
                }

                SpawnProjectile(pattern, stats, firePoint.position, aimDir);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }

            // 5. Cooldown
            if (pattern.cooldownAfterBurst > 0)
                yield return new WaitForSeconds(pattern.cooldownAfterBurst);

            _isFiring = false;
        }

        private void SpawnProjectile(AttackPatternSO pattern, EnemyAttackSO stats, Vector3 pos, Vector3 dir)
        {
            if (_poolService == null) return;

            GameObject p = _poolService.Spawn(stats.projectilePrefab, pos, Quaternion.LookRotation(dir));
            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);

                proj.damage = stats.damage;
                proj.stagger = stats.stagger;

                // Prefer stats as the source of truth for ballistics; fallback to pattern if needed.
                proj.speed = stats.projectileSpeed > 0 ? stats.projectileSpeed : pattern.speed;
                if (stats.lifetime > 0) proj.lifetime = stats.lifetime;

                proj.SetSource(gameObject); // Ignore self
                proj.Initialize(dir);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Projectile.cs`
- Lines: 328
- Size: 10.5 KB
- Modified: 2026-01-20 08:23

```csharp
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Patterns; // For IPoolable
using DarkTowerTron.Core.Services; // For ServiceLocator and IPoolService
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public enum ProjectileWeight { Light, Heavy, Unstoppable }

    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Classification")]
        public ProjectileWeight weight = ProjectileWeight.Light;

        [Header("Ballistics")]
        public float speed = 25f;
        public float lifetime = 5f;
        public bool isHostile = true;

        [Header("Damage")]
        public float damage = 10f;
        public int stagger = 1;

        public DamageType damageType = DamageType.Projectile;

        [Header("Juice")]
        public FeedbackConfigurationSO spawnFeedback;
        public FeedbackConfigurationSO impactFeedback;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Material friendlyMaterial;
        public Material hostileMaterial;
        public Material parryableMaterial;

        [Header("Parry Logic")]
        public float parrySpeedMultiplier = 2.0f;
        public FeedbackConfigurationSO parryFeedback;

        private Vector3 _direction;
        private GameObject _source;
        private IMovementStrategy _movementStrategy;

        private bool _isInitialized = false;
        private bool _isRedirected = false;
        private float _lifeTimer;
        private bool _wasDeflectedThisFrame = false;
        private List<Collider> _ignoredColliders = new List<Collider>();

        private float _baseSpeed;
        private float _baseLifetime;

        private void Awake()
        {
            _baseSpeed = speed;
            _baseLifetime = lifetime;
        }

        public void OnSpawn()
        {
            speed = _baseSpeed;
            lifetime = _baseLifetime;

            if (TryGetComponent(out Rigidbody rb))
            {
                if (!rb.isKinematic)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    rb.Sleep();
                }
            }

            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.emitting = false;
                trail.Clear();
            }

            if (spawnFeedback != null) spawnFeedback.Play(gameObject, transform.position);
        }

        public void OnDespawn()
        {
            ResetIgnoredColliders();

            _isInitialized = false;
            _movementStrategy = null;
            _source = null;
            isHostile = true;

            speed = _baseSpeed;
            lifetime = _baseLifetime;
        }

        public bool TryParry(Vector3 deflectDirection, GameObject newOwner)
        {
            if (weight == ProjectileWeight.Unstoppable) return false;

            SetSource(newOwner);
            isHostile = false;
            _isRedirected = true;

            speed = _baseSpeed * parrySpeedMultiplier;
            _direction = deflectDirection.normalized;

            UpdateVisuals();
            if (parryFeedback != null) parryFeedback.Play(gameObject, transform.position);

            if (_movementStrategy == null) SetStrategy(new LinearMovement());
            _movementStrategy.Initialize(transform, _direction, speed);

            _lifeTimer = lifetime;

            return true;
        }

        public void Initialize(Vector3 dir)
        {
            if (_movementStrategy == null) SetStrategy(new LinearMovement());

            _direction = dir.normalized;
            _movementStrategy.Initialize(transform, _direction, speed);

            _isInitialized = true;
            _lifeTimer = lifetime;
            _isRedirected = false;

            UpdateVisuals();

            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.Clear();
                trail.emitting = true;
            }
        }

        public void SetStrategy(IMovementStrategy strategy) => _movementStrategy = strategy;

        public void SetSource(GameObject source)
        {
            _source = source;
            ResetIgnoredColliders();

            if (_source != null)
            {
                Collider myCol = GetComponent<Collider>();
                Collider[] sourceCols = _source.GetComponentsInChildren<Collider>();

                foreach (Collider c in sourceCols)
                {
                    if (!c.isTrigger)
                    {
                        UnityEngine.Physics.IgnoreCollision(myCol, c, true);
                        _ignoredColliders.Add(c);
                    }
                }
            }
        }

        public void ResetHostility(bool startHostile)
        {
            isHostile = startHostile;
            UpdateVisuals();
        }

        private void ResetIgnoredColliders()
        {
            Collider myCol = GetComponent<Collider>();
            if (myCol == null) return;

            foreach (Collider c in _ignoredColliders)
            {
                if (c != null) UnityEngine.Physics.IgnoreCollision(myCol, c, false);
            }
            _ignoredColliders.Clear();
        }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false;
            float dt = Time.deltaTime;

            Vector3 oldPos = transform.position;

            if (_movementStrategy == null) _movementStrategy = new LinearMovement();
            _movementStrategy.Move(transform, dt);

            Vector3 newPos = transform.position;
            Vector3 travelVec = newPos - oldPos;
            float moveDistance = travelVec.magnitude;

            if (moveDistance > 0)
            {
                int mask = GameConstants.MASK_PROJECTILE_COLLISION;

                if (UnityEngine.Physics.Raycast(oldPos, travelVec.normalized, out RaycastHit hit, moveDistance, mask, QueryTriggerInteraction.Collide))
                {
                    if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform)))
                    {
                        return;
                    }

                    transform.position = hit.point;
                    HandleCollision(hit.collider);
                }
            }

            _lifeTimer -= dt;
            if (_lifeTimer <= 0) Despawn();
        }

        private void HandleCollision(Collider other)
        {
            IDamageable target = other.GetComponent<IDamageable>();
            if (target == null) target = other.GetComponentInParent<IDamageable>();

            if (other.isTrigger && target == null) return;

            if (other.gameObject.layer == GameConstants.LAYER_WALL || other.gameObject.layer == GameConstants.LAYER_DEFAULT)
            {
                if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                Despawn();
                return;
            }

            if (target != null)
            {
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = this.damage,
                    staggerAmount = this.stagger,
                    pushDirection = transform.forward,
                    pushForce = 5f,
                    source = gameObject,
                    isRedirected = this._isRedirected,
                    damageType = this.damageType,
                    isCritical = false
                };

                target.TakeDamage(info);

                if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                if (!_wasDeflectedThisFrame) Despawn();
            }
        }

        public void DeflectByEnemy(Vector3 surfaceNormal, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true;
            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            _source = null;
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = false;
            _isRedirected = true;
            _direction = newDirection.normalized;
            _source = newOwner;
            speed *= 1.5f;
            _lifeTimer = 3.0f;
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        private void ApplyStrategy(IMovementStrategy strategy)
        {
            SetStrategy(strategy);
            _movementStrategy.Initialize(transform, _direction, speed);
        }

        private void UpdateVisuals()
        {
            if (meshRenderer == null) return;

            if (!isHostile)
            {
                meshRenderer.sharedMaterial = friendlyMaterial;
                return;
            }

            if (weight == ProjectileWeight.Heavy && parryableMaterial != null)
            {
                meshRenderer.sharedMaterial = parryableMaterial;
            }
            else
            {
                meshRenderer.sharedMaterial = hostileMaterial;
            }
        }

        // FIX 2: Replaced Global.Pool with ServiceLocator
        private void Despawn()
        {
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Despawn at {transform.position}", gameObject);

            // Attempt to get the PoolService
            var pool = ServiceLocator.Get<IPoolService>();

            if (pool != null)
            {
                pool.Despawn(gameObject);
            }
            else
            {
                // Fallback for isolated testing/missing services
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Strategies\HomingMovement.cs`
- Lines: 46
- Size: 1.5 KB
- Modified: 2026-01-17 14:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public class HomingMovement : IMovementStrategy
    {
        private Transform _target;
        private float _turnSpeed;
        private float _speed;
        private Vector3 _currentDirection;

        public HomingMovement(Transform target, float turnSpeed)
        {
            _target = target;
            _turnSpeed = turnSpeed;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _currentDirection = direction.normalized;
            transform.rotation = Quaternion.LookRotation(_currentDirection);
        }

        public void Move(Transform transform, float deltaTime)
        {
            if (_target != null)
            {
                Vector3 dirToTarget = (_target.position - transform.position).normalized;
                
                // Rotate towards target
                _currentDirection = Vector3.RotateTowards(
                    _currentDirection, 
                    dirToTarget, 
                    _turnSpeed * Mathf.Deg2Rad * deltaTime, 
                    0.0f
                );
            }

            transform.rotation = Quaternion.LookRotation(_currentDirection);
            transform.Translate(_currentDirection * _speed * deltaTime, Space.World);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Strategies\LinearMovement.cs`
- Lines: 24
- Size: 0.7 KB
- Modified: 2026-01-17 14:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public class LinearMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _direction;

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _direction = direction.normalized;
            transform.rotation = Quaternion.LookRotation(_direction);
        }

        public void Move(Transform transform, float deltaTime)
        {
            transform.Translate(_direction * _speed * deltaTime, Space.World);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Combat\Strategies\SineWaveMovement.cs`
- Lines: 55
- Size: 2.0 KB
- Modified: 2026-01-17 14:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public class SineWaveMovement : IMovementStrategy
    {
        private float _speed;
        private Vector3 _forward;
        private Vector3 _right;
        private float _frequency = 5f;
        private float _amplitude = 2f;
        private float _timeAlive;

        // You could pass config in a Constructor if you weren't using simple interfaces
        // For now, hardcoded or set via property setters
        public SineWaveMovement(float freq, float amp)
        {
            _frequency = freq;
            _amplitude = amp;
        }

        public void Initialize(Transform transform, Vector3 direction, float speed)
        {
            _speed = speed;
            _forward = direction.normalized;
            _right = Vector3.Cross(_forward, Vector3.up); // Calculate "Right" relative to bullet
            _timeAlive = 0f;
            
            transform.rotation = Quaternion.LookRotation(_forward);
        }

        public void Move(Transform transform, float deltaTime)
        {
            _timeAlive += deltaTime;

            // 1. Move Forward
            Vector3 forwardMove = _forward * _speed * deltaTime;

            // 2. Calculate Sine Offset (Mathf.Sin)
            // We apply velocity to the "Right" based on the derivative of Sine, 
            // OR simpler: just offset position (which interacts weirdly with Physics Raycasts).
            
            // Better approach for Raycast-based projectiles: 
            // Calculate current velocity vector and move along it.
            
            // For simplicity in this demo: We will just mutate direction slightly
            float wave = Mathf.Cos(_timeAlive * _frequency) * _amplitude;
            Vector3 finalMove = forwardMove + (_right * wave * deltaTime);

            transform.Translate(finalMove, Space.World);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\Bosses\Architect\ArchitectController.cs`
- Lines: 97
- Size: 3.1 KB
- Modified: 2026-01-20 08:07

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Combat; // Access to DamageInfo and DamageReceiver

namespace DarkTowerTron.Gameplay.Enemies.Bosses
{
    // REFACTOR: Removed IDamageable interface. This class now LISTENS to damage, instead of BEING damageable.
    [RequireComponent(typeof(DamageReceiver))]
    public class ArchitectController : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private DamageReceiver _damageReceiver;
        // [SerializeField] private RotatorRig _rotator; // Example of other components

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _onBossEngaged;
        [SerializeField] private VoidEventChannelSO _onBossDefeated;
        [SerializeField] private VoidEventChannelSO _onPhaseChange;

        [Header("Settings")]
        [SerializeField] private float _phase2Threshold = 0.5f; // 50% HP

        private bool _isPhase2 = false;

        private void Awake()
        {
            if (_damageReceiver == null)
                _damageReceiver = GetComponent<DamageReceiver>();
        }

        private void Start()
        {
            // --- THE "AA" PATTERN: SUBSCRIBE TO COMPONENTS ---
            if (_damageReceiver != null)
            {
                _damageReceiver.OnTakeDamage += HandleDamageReceived;
                _damageReceiver.OnDeath += HandleDeath;
            }

            // Engage logic (could be triggered by a trigger volume elsewhere)
            if (_onBossEngaged != null) _onBossEngaged.RaiseEvent();
        }

        private void OnDestroy()
        {
            // Always unsubscribe to prevent memory leaks
            if (_damageReceiver != null)
            {
                _damageReceiver.OnTakeDamage -= HandleDamageReceived;
                _damageReceiver.OnDeath -= HandleDeath;
            }
        }

        // --- EVENT HANDLERS ---

        private void HandleDamageReceived(DamageInfo info)
        {
            // Logic: Check for Phase Transition
            if (!_isPhase2 && _damageReceiver.CurrentHealth <= (_damageReceiver.MaxHealth * _phase2Threshold))
            {
                TriggerPhase2();
            }

            // Example: Boss flinch logic could go here
            // if (info.damageAmount > 50) PlayStaggerAnimation();
        }

        private void HandleDeath()
        {
            // Logic: Boss Died
            Defeat();
        }

        // --- BOSS BEHAVIOR ---

        private void TriggerPhase2()
        {
            _isPhase2 = true;
            Debug.Log("[Architect] Entering Phase 2!");

            if (_onPhaseChange != null) _onPhaseChange.RaiseEvent();

            // Add Logic: Increase rotation speed, enable new weapons, etc.
        }

        private void Defeat()
        {
            Debug.Log("[Architect] Defeated!");

            if (_onBossDefeated != null) _onBossDefeated.RaiseEvent();

            // Disable behaviors, play cinematic death, etc.
            enabled = false;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\Bosses\Architect\ArchitectHand.cs`
- Lines: 186
- Size: 5.8 KB
- Modified: 2026-01-18 16:04

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Systems;
using DG.Tweening;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Gameplay.Enemies
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class ArchitectHand : MonoBehaviour
    {
        [Header("Visual Components")]
        public Transform visualRoot;    // The object that slides In/Out
        public Transform meshPivot;     // The object that rotates 90 degrees
        public GameObject wallObject;   // The Laser Hazard (Child)
        public Transform firePoint;     // Where bullets spawn

        [Header("Combat Configuration")]
        public GameObject projectilePrefab;
        public GameObject deathExplosionEffect; 

        [Header("Animation")]
        public float slideDuration = 1.0f;
        public float rotateDuration = 0.5f;

        // Dependencies
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;
        private bool _isDead = false;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            if (wallObject) wallObject.SetActive(false);
        }

        private void Start()
        {
            // Initialize DamageReceiver (No Stats SO needed, uses Inspector overrides)
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnDeathProcessed += HandleDeath;
            _receiver.OnHitProcessed += HandleHit;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnDeathProcessed -= HandleDeath;
            _receiver.OnHitProcessed -= HandleHit;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        public bool IsAlive() => !_isDead;

        // --- HANDLERS ---

        private void HandleHit(DamageInfo info)
        {
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            if (_isDead) return;
            Die();
        }

        // --- MOVEMENT ---

        public void MoveToDistance(float localZ)
        {
            if (_isDead) return;
            visualRoot.DOLocalMoveZ(localZ, slideDuration).SetEase(Ease.InOutQuad);
        }

        // --- COMBAT ACTIONS ---

        public void PrepareWall(bool willBeActive)
        {
            if (_isDead || meshPivot == null) return;

            // Rotate 90 on Z for Vertical (Wall Mode), 0 for Flat (Gun Mode)
            float targetZ = willBeActive ? 90f : 0f;

            meshPivot.DOLocalRotate(new Vector3(0, 0, targetZ), rotateDuration)
                .SetEase(Ease.OutBack);
        }

        public void SetWall(bool active)
        {
            if (_isDead) active = false;
            if (wallObject) wallObject.SetActive(active);
        }

        public void Shoot(Vector3 targetPos, bool useForward, float scale)
        {
            if (_isDead || !projectilePrefab) return;

            // Service Access
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool == null) return;

            Vector3 dir;
            if (useForward)
                dir = firePoint.forward; // Spiral / Radial aim
            else
                dir = (targetPos - firePoint.position).normalized; // Tracking aim

            // Spawn from Pool
            GameObject p = pool.Spawn(projectilePrefab, firePoint.position, Quaternion.LookRotation(dir));
            p.transform.localScale = Vector3.one * scale;

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = 15f;
                // CRITICAL: Set Source so the bullet ignores the HandCollider immediately
                proj.SetSource(gameObject);
                proj.Initialize(dir);
            }
        }

        // --- STATE MANAGEMENT ---

        private void Die()
        {
            _isDead = true;
            SetWall(false);

            // 1. VFX
            var pool = ServiceLocator.Get<IPoolService>();
            if (deathExplosionEffect && pool != null)
            {
                pool.Spawn(deathExplosionEffect, transform.position, Quaternion.identity);
            }

            // 2. Visual Shutdown (Shrink)
            if (meshPivot) meshPivot.DOKill();
            visualRoot.DOKill();
            visualRoot.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);

            // 3. Disable Collider
            var col = GetComponent<Collider>();
            if (col) col.enabled = false;
        }

        public void Revive()
        {
            _isDead = false;

            _receiver.Vitality.Revive();
            _receiver.Stagger.ResetStagger();
            _visuals.ResetVisuals();

            var col = GetComponent<Collider>();
            if (col) col.enabled = true;

            gameObject.SetActive(true);
            visualRoot.localScale = Vector3.zero;
            visualRoot.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);

            if (meshPivot) meshPivot.localRotation = Quaternion.identity;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\Bosses\Architect\Data\ArchitectPatternSO.cs`
- Lines: 29
- Size: 0.9 KB
- Modified: 2026-01-17 11:37

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Combat;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Bosses/Architect Pattern")]
    public class ArchitectPatternSO : ScriptableObject
    {
        [Header("Phase Timings")]
        public float startDelay = 1.0f;
        public float activeDuration = 6.0f;

        [Header("Configuration")]
        public float rotationSpeed = 15f;

        [Header("Hands Configuration (Size 4)")]
        [Tooltip("True = Move Outer, False = Move Inner")]
        public bool[] extendHands;

        [Tooltip("True = Laser Wall ON")]
        public bool[] activateWalls;

        [Tooltip("True = Fire Projectiles")]
        public bool[] activeGuns; // NEW: Specific firing control

        [Header("Shooting")]
        public AttackPatternSO shootingPattern;
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\EnemyBaseAI.cs`
- Lines: 203
- Size: 7.3 KB
- Modified: 2026-01-19 00:07

```csharp
using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService, IPoolable
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Player; // Access PlayerController

namespace DarkTowerTron.Gameplay.Enemies
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(EnemyController))]
    public abstract class EnemyBaseAI : MonoBehaviour, IPoolable
    {
        [Header("AI Event Wiring")]
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent;
        [SerializeField] private TransformEventChannelSO _decoySpawnedEvent;
        [SerializeField] private VoidEventChannelSO _decoyExpiredEvent;

        protected EnemyMotor _motor;
        protected EnemyController _controller;
        protected Transform _player;
        protected Transform _currentTarget;
        
        // Cached Service
        protected IPoolService _poolService;

        // Spawn state gate (prevents AI ticking during spawn animation)
        protected bool _isSpawning = false;

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
        }

        protected virtual void Start()
        {
            // 1. Locate Services
            _poolService = ServiceLocator.Get<IPoolService>();

            // 2. Locate Player
            if (PlayerController.Instance != null)
            {
                _player = PlayerController.Instance.transform;
                _currentTarget = _player;
            }

            // 3. Subscribe to Decoy Logic
            if (_decoySpawnedEvent != null) _decoySpawnedEvent.OnEventRaised += OnDecoySpawned;
            if (_decoyExpiredEvent != null) _decoyExpiredEvent.OnEventRaised += OnDecoyExpired;
        }

        public virtual void OnSpawn()
        {
            _isSpawning = true;
            transform.localScale = Vector3.zero;

            _enemySpawnedEvent?.RaiseEvent(transform.position);

            transform.DOScale(Vector3.one, 0.8f)
                .SetEase(Ease.OutBack)
                .OnComplete(() => _isSpawning = false);
        }

        public virtual void OnDespawn()
        {
            transform.DOKill();
            _isSpawning = false;
        }

        protected virtual void OnDestroy()
        {
            if (_decoySpawnedEvent != null) _decoySpawnedEvent.OnEventRaised -= OnDecoySpawned;
            if (_decoyExpiredEvent != null) _decoyExpiredEvent.OnEventRaised -= OnDecoyExpired;
        }

        private void Update()
        {
            // Block logic if spawning
            if (_isSpawning) return;

            // Player might die or be destroyed, re-check occasionally or just handle null
            if (_player == null) return; 
            if (_currentTarget == null) _currentTarget = _player;
            if (_controller.IsStaggered) return;

            RunAI();
        }

        protected abstract void RunAI();

        // --- HELPER METHODS ---

        /// <summary>
        /// Centralized logic to spawn, reset, and fire a hostile projectile.
        /// </summary>
        protected void FireProjectile(GameObject prefab, Vector3 position, Quaternion rotation, Vector3 direction, float speed)
        {
            if (prefab == null || _poolService == null) return;

            GameObject p = _poolService.Spawn(prefab, position, rotation);
            
            Projectile proj = p.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.ResetHostility(true);
                proj.speed = speed;
                proj.SetSource(gameObject);
                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Smart Firing Logic: Calculates vector to Target's Center of Mass.
        /// </summary>
        protected void FireAtTarget(GameObject prefab, Transform firePointOrigin, float speed, float accuracyError = 0f)
        {
            if (prefab == null || _currentTarget == null || _poolService == null) return;

            // 1. Determine Origin
            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            // 2. Determine Destination (AimPoint)
            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();

            if (aimTarget != null)
                targetPos = aimTarget.AimPoint;
            else
                targetPos = _currentTarget.position + Vector3.up * 1.0f;

            // 3. Calculate Vector
            Vector3 direction = (targetPos - origin).normalized;

            // 4. Apply Inaccuracy
            if (accuracyError > 0f)
            {
                direction = ApplySpread(direction, accuracyError);
            }

            // 5. Spawn & Init
            GameObject p = _poolService.Spawn(prefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = speed;
                proj.SetSource(gameObject); // Important: Ignore self
                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Fires using a specific Attack Profile (Single Source of Truth).
        /// </summary>
        protected void FireAtTarget(EnemyAttackSO attackProfile, Transform firePointOrigin)
        {
            if (attackProfile == null || attackProfile.projectilePrefab == null || _currentTarget == null || _poolService == null) return;

            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();
            if (aimTarget != null) targetPos = aimTarget.AimPoint;
            else targetPos = _currentTarget.position + Vector3.up * 1.0f;

            Vector3 direction = (targetPos - origin).normalized;

            if (attackProfile.spreadAngle > 0f)
            {
                direction = ApplySpread(direction, attackProfile.spreadAngle);
            }

            GameObject p = _poolService.Spawn(attackProfile.projectilePrefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                // Inject Stats from SO
                proj.damage = attackProfile.damage;
                proj.stagger = attackProfile.stagger;
                proj.speed = attackProfile.projectileSpeed;
                proj.lifetime = attackProfile.lifetime;

                proj.ResetHostility(true);
                proj.SetSource(gameObject);
                proj.Initialize(direction);
            }
        }

        private Vector3 ApplySpread(Vector3 dir, float angle)
        {
            return Quaternion.Euler(Random.Range(-angle, angle), Random.Range(-angle, angle), 0f) * dir;
        }

        // --- EVENTS ---
        private void OnDecoySpawned(Transform decoy) { _currentTarget = decoy; }
        private void OnDecoyExpired() { if (_player != null) _currentTarget = _player; }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\EnemyController.cs`
- Lines: 164
- Size: 5.3 KB
- Modified: 2026-01-20 14:17

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Patterns; 
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Gameplay.Enemies
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        // --- Dependencies ---
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyVisuals _visuals;
        private EnemyStatsSO _stats;

        // --- Event Wiring ---
        [Header("Broadcasting")]
        [Tooltip("Notifies ScoreManager and WaveDirector when this enemy dies.")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Visual Feedback")]
        [Tooltip("Spawns floating damage numbers.")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;

        [Tooltip("Spawns status text (e.g. STAGGER).")]
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Audio")]
        public AudioClip staggerClip;

        // --- Public Accessors ---
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;
        public EnemyVisuals Visuals => _visuals;

        // --- Lifecycle ---

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;

            // Self-Initialization safety check (if placed in scene manually)
            if (_receiver != null && _stats != null && _receiver.CurrentHealth <= 0)
            {
                _receiver.Initialize(_stats);
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Reset Modules
            _receiver.Initialize(_stats);
            _visuals.ResetVisuals();
        }

        public void OnDespawn()
        {
            _visuals.ResetVisuals();
        }

        private void OnEnable()
        {
            if (_receiver == null) return;

            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover += HandleStaggerExit;
            }
        }

        private void OnDisable()
        {
            if (_receiver == null) return;

            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
            }
        }

        // --- Handlers ---

        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // Visuals
            if (!IsStaggered) _visuals.PlayHitFlash();

            bool isCrit = IsStaggered;

            // Logic: Distinguish Health Damage vs Stagger Damage
            if (info.damageAmount > 0)
            {
                _damageEvent?.RaiseEvent(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                _damageEvent?.RaiseEvent(transform.position, info.staggerAmount, false, true);
            }
        }

        private void HandleStaggerEnter()
        {
            _popupEvent?.RaiseEvent(transform.position, "STAGGER");

            // Audio via Service Locator
            var audio = ServiceLocator.Get<IAudioService>();
            if (audio != null && staggerClip)
                audio.PlaySound(staggerClip, transform.position, 1f);

            _visuals.StartStaggerEffect();
        }

        private void HandleStaggerExit()
        {
            _visuals.StopStaggerEffect();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            // Notify Game Logic (Wave Director / Score)
            _enemyKilledEvent?.RaiseEvent(transform.position, stats, reward);

            // Despawn
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool != null) 
                pool.Despawn(gameObject);
            else 
                Destroy(gameObject);
        }

        // --- Interface Implementation ---
        public void TakeDamage(DamageInfo info) => _receiver.TakeDamage(info);
        public void Kill(bool instant) => _receiver.Kill(true);
        public void SelfDestruct() => _receiver.Kill(false);
        public void OnExecutionHit() => _receiver.Kill(true);
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
        public bool IsDead => _receiver.IsDead;
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\EnemyMotors.cs`
- Lines: 227
- Size: 8.1 KB
- Modified: 2026-01-18 23:52

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Patterns;
using DarkTowerTron.Core.Physics;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Enemies
{
    // We implement IMover so the PluggableAIController can talk to us directly.
    public class EnemyMotor : MonoBehaviour, IPoolable, IMover
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        // The underlying Physics Engine (KinematicMover or UnityCharacterMover)
        private IMover _physicsMover;

        // Internal State
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed; // For smooth hovering
        private Collider[] _neighbors = new Collider[10]; // For separation

        // --- IMover Interface Properties (Pass-Through) ---
        public Vector3 Velocity => _physicsMover != null ? _physicsMover.Velocity : Vector3.zero;
        public bool IsGrounded => _physicsMover != null && _physicsMover.IsGrounded;

        private void Awake()
        {
            // 1. Find the REAL physics mover attached to this object.
            // Since EnemyMotor acts as a wrapper, we need to find the "Other" IMover.
            var allMovers = GetComponents<IMover>();
            foreach (var m in allMovers)
            {
                // Cast to interface to compare references
                if (m != (IMover)this)
                {

                    GameLogger.Log(LogChannel.AI, "[EnemyMotor] Found Physics Mover: " + m.GetType().Name, this.gameObject);

                    _physicsMover = m;
                    break;
                }
            }

            // 2. Fallback Safety: If no physics mover exists, add the default KinematicMover.
            if (_physicsMover == null)
            {
                _physicsMover = gameObject.AddComponent<KinematicMover>();
            }

            if (allyLayer == 0) allyLayer = 1 << GameConstants.LAYER_ENEMY;
        }

        // --- IPoolable Implementation ---

        public void OnSpawn()
        {
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Forward the spawn event to the physics engine if it supports it
            if (_physicsMover is IPoolable p) p.OnSpawn();
        }

        public void OnDespawn()
        {
            _currentVelocity = Vector3.zero;
            if (_physicsMover is IPoolable p) p.OnDespawn();
        }

        // --- IMover Implementation (The Logic) ---

        public void Teleport(Vector3 pos) => _physicsMover?.Teleport(pos);

        public void SetEnabled(bool state)
        {
            this.enabled = state;
            // Optionally enable/disable the physics mover too, 
            // though usually we want physics to run even if AI logic is paused.
        }

        /// <summary>
        /// Receives a Direction (usually Magnitude 1) from the AI.
        /// Applies Speed, Acceleration, Hovering, and Separation.
        /// </summary>
        public void Move(Vector3 inputVector)
        {

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Called with Input: " + inputVector.ToString("F2"), this.gameObject);

            if (stats == null || _physicsMover == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            GameLogger.Log(LogChannel.AI, "[EnemyMotor] Move Input: " + inputVector.ToString("F2"), this.gameObject);

            // 1. Apply Speed Stats
            // The AI sends a direction. We make it a Velocity based on stats.
            Vector3 targetVel = inputVector.normalized * stats.moveSpeed;

            // 2. Separation Logic (Don't stack on top of other enemies)
            if (stats.moveSpeed > 0.1f)
            {
                targetVel += CalculateSeparation();
            }

            // 3. Inertia (Acceleration)
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 4. Knockback Decay
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. Vertical Logic (Hover vs Gravity)
            if (stats.rideHeight > 0)
            {
                // --- HOVER LOGIC ---
                float groundY = -999f;
                Vector3 rayOrigin = transform.position + Vector3.up * 1.0f;

                // Cast down to find floor/obstacles
                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 20f, GameConstants.MASK_PHYSICS_OBSTACLES))
                {
                    groundY = hit.point.y;
                }
                else
                {
                    // No ground? Maintain current relative height
                    groundY = transform.position.y - stats.rideHeight;
                }

                float targetY = groundY + stats.rideHeight;
                float currentY = transform.position.y;

                // Smoothly interpolate height
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // Convert position change back to velocity for the Mover
                finalVelocity.y = (newY - currentY) / dt;
            }
            else
            {
                // --- GRAVITY LOGIC ---
                if (!_physicsMover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard Gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick to ground
                }
            }

            // 6. Final Execution
            _physicsMover.Move(finalVelocity);
        }

        // --- Helper Methods ---

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                // Prevent division by zero
                if (dist < 0.01f) direction = Random.insideUnitSphere;

                // Stronger push the closer they are
                pushVector += direction.normalized / (dist + 0.1f);
            }

            return pushVector * stats.separationForce;
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }

        public void FaceTarget(Vector3 targetPos)
        {
            // Ignore Y axis for rotation
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.rotationSpeed * Time.deltaTime);
            }
        }

        public void FaceCombatTarget(Vector3 targetPos)
        {
            // Ignore Y axis
            Vector3 dir = targetPos - transform.position;
            dir.y = 0;

            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion rot = Quaternion.LookRotation(dir);
                // Use COMBAT rotation speed (slower/smoother) instead of navigation speed
                transform.rotation = Quaternion.Slerp(transform.rotation, rot, stats.combatRotationSpeed * Time.deltaTime);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\Modules\EnemyPatrolModule.cs`
- Lines: 30
- Size: 0.9 KB
- Modified: 2026-01-17 13:47

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.AI;

namespace DarkTowerTron.Gameplay.Enemies
{
    public class EnemyPatrolModule : MonoBehaviour
    {
        [Header("Runtime Data")]
        public PatrolPath patrolPath;
        public int currentWaypointIndex;

        // Helper to get the current target transform safely
        public Transform GetCurrentWaypointTarget()
        {
            if (patrolPath == null || patrolPath.waypoints.Count == 0) return null;

            // Safety wrap
            if (currentWaypointIndex >= patrolPath.waypoints.Count) currentWaypointIndex = 0;

            var wp = patrolPath.waypoints[currentWaypointIndex];
            return wp != null ? wp.transform : null;
        }

        public void AdvanceWaypoint()
        {
            if (patrolPath == null) return;
            currentWaypointIndex = (currentWaypointIndex + 1) % patrolPath.waypoints.Count;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Enemies\Visuals\EnemyVisuals.cs`
- Lines: 223
- Size: 7.2 KB
- Modified: 2026-01-18 23:52

```csharp
using UnityEngine;
using DG.Tweening;
using System.Collections;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Visuals; // Access IPaletteService

namespace DarkTowerTron.Gameplay.Enemies
{
    public class EnemyVisuals : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("Leave EMPTY to use the Global Palette.")]
        public PaletteDefinitionSO paletteOverride;

        [Tooltip("Defines timing and animation curves. Required.")]
        public EnemyVisualProfileSO profile;

        [Header("References")]
        [Tooltip("Assign all mesh parts here. If empty, auto-finds in children.")]
        [SerializeField] private Renderer[] _renderers;

        // Internal
        private MaterialPropertyBlock _propBlock;
        private static readonly int BaseColorID = Shader.PropertyToID("_BaseColor");
        private static readonly int EmissionColorID = Shader.PropertyToID("_EmissionColor");

        // State
        private Color[] _baseColors; // Snapshot of original colors per renderer
        private Color _staggerColor;
        private Color _hitColor;
        private Tween _flashTween;

        private void Awake()
        {
            // Auto-find if not assigned
            if (_renderers == null || _renderers.Length == 0)
                _renderers = GetComponentsInChildren<Renderer>();

            if (_renderers.Length == 0)
            {
                GameLogger.LogWarning(LogChannel.AI, $"[EnemyVisuals] No Renderers found on {name}", gameObject);
            }

            _baseColors = new Color[_renderers.Length];
            _propBlock = new MaterialPropertyBlock();
        }

        private void Start()
        {
            if (profile == null)
            {
                GameLogger.LogError(LogChannel.AI, $"[EnemyVisuals] Profile missing on {gameObject.name}.", gameObject);
                enabled = false;
                return;
            }

            // We wait one frame to ensure PaletteReceiver has finished applying the theme colors.
            StartCoroutine(InitializeColorsNextFrame());
        }

        private IEnumerator InitializeColorsNextFrame()
        {
            yield return null; 
            InitializeColors();
        }

        public void InitializeColors()
        {
            // 1. Resolve Palette Settings
            PaletteDefinitionSO activePalette = paletteOverride;
            
            // Try to get Global Palette if override is missing
            if (activePalette == null)
            {
                try 
                {
                    var service = ServiceLocator.Get<IPaletteService>();
                    if (service != null) activePalette = service.ActivePalette;
                }
                catch { /* Service might not exist in test scenes */ }
            }

            if (activePalette != null)
            {
                _staggerColor = activePalette.staggerColor;
                _hitColor = activePalette.hitFlashColor;
            }
            else
            {
                // Fallback Defaults
                _staggerColor = Color.yellow;
                _hitColor = Color.white;
            }

            // 2. Snapshot current state (The colors set by PaletteReceiver)
            for (int i = 0; i < _renderers.Length; i++)
            {
                Renderer r = _renderers[i];
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Prioritize PropertyBlock color (set by Receiver), then Material color
                if (!_propBlock.isEmpty && _propBlock.GetColor(BaseColorID) != Color.clear)
                {
                    _baseColors[i] = _propBlock.GetColor(BaseColorID);
                }
                else if (r.sharedMaterial != null && r.sharedMaterial.HasProperty(BaseColorID))
                {
                    _baseColors[i] = r.sharedMaterial.GetColor(BaseColorID);
                }
                else
                {
                    _baseColors[i] = Color.white;
                }
            }
        }

        // --- VISUAL FX METHODS ---

        public void PlayHitFlash()
        {
            if (profile == null) return;
            KillTween();

            // Flash all parts to pure White (or HitColor)
            SetAllColors(_hitColor);

            _flashTween = DOVirtual.DelayedCall(profile.hitFlashDuration, ResetVisuals);
        }

        public void StartStaggerEffect()
        {
            if (profile == null) return;
            KillTween();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, profile.staggerPulseDuration / 2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    Color c = Color.Lerp(_staggerColor, profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopStaggerEffect() => ResetVisuals();

        public void StartPrimingEffect()
        {
            if (profile == null) return;
            KillTween();

            float lerpVal = 0f;
            _flashTween = DOTween.To(() => lerpVal, x => lerpVal = x, 1f, 0.1f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    // Pulse between Base Color[0] and Danger Color
                    Color baseC = GetBaseColorSafe(0);
                    Color c = Color.Lerp(baseC, profile.dangerPulseColor, lerpVal);
                    SetAllColors(c);
                });
        }

        public void StopPrimingEffect() => ResetVisuals();

        public void ResetVisuals()
        {
            KillTween();

            // Restore individual base colors
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], _baseColors[i]);
            }
        }

        // --- HELPERS ---

        private void KillTween()
        {
            if (_flashTween != null && _flashTween.IsActive()) _flashTween.Kill();
        }

        private void SetAllColors(Color c)
        {
            for (int i = 0; i < _renderers.Length; i++)
            {
                ApplyColorToRenderer(_renderers[i], c);
            }
        }

        private void ApplyColorToRenderer(Renderer r, Color c)
        {
            if (r == null) return;
            
            r.GetPropertyBlock(_propBlock);
            _propBlock.SetColor(BaseColorID, c);
            
            // Optional: Also boost emission for the flash effect?
            // _propBlock.SetColor(EmissionColorID, c * 1.5f); 
            
            r.SetPropertyBlock(_propBlock);
        }

        private Color GetBaseColorSafe(int index)
        {
            if (_baseColors != null && index < _baseColors.Length)
                return _baseColors[index];
            return Color.white;
        }

        private void OnDestroy()
        {
            KillTween();
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\ArenaGate.cs`
- Lines: 100
- Size: 3.2 KB
- Modified: 2026-01-23 16:08

```csharp
using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Gameplay.Environment
{
    public class ArenaGate : MonoBehaviour, ILockable
    {
        private enum GateState { Open, Closed }

        [Header("References")]
        [Tooltip("Assign the object that should slide (e.g. Wall_Pivot). Do NOT assign the Root.")]
        [SerializeField] private Transform _movingPart;

        [Header("Configuration")]
        [SerializeField] private Vector3 _openLocalPos;
        [SerializeField] private Vector3 _closedLocalPos;
        [SerializeField] private float _speed = 5f;
        [SerializeField] private GateState _startState = GateState.Open;

        private bool _isLocked;
        private Coroutine _moveRoutine;

        public bool IsLocked => _isLocked;

        private void Start()
        {
            // Safety Check
            if (_movingPart == null)
            {
                Debug.LogError($"[ArenaGate] '{name}' is missing the '_movingPart' reference! Assign the visual child.", gameObject);
                return;
            }

            // Snap to initial state
            if (_startState == GateState.Open)
            {
                _movingPart.localPosition = _openLocalPos;
                _isLocked = false;
            }
            else
            {
                _movingPart.localPosition = _closedLocalPos;
                _isLocked = true;
            }
        }

        public void Lock() => Close();
        public void Unlock() => Open();

        [ContextMenu("Open Gate")]
        public void Open()
        {
            if (!_isLocked || _movingPart == null) return;
            _isLocked = false;

            if (_moveRoutine != null) StopCoroutine(_moveRoutine);
            _moveRoutine = StartCoroutine(MoveToTarget(_openLocalPos));
        }

        [ContextMenu("Close Gate")]
        public void Close()
        {
            if (_isLocked || _movingPart == null) return;
            _isLocked = true;

            if (_moveRoutine != null) StopCoroutine(_moveRoutine);
            _moveRoutine = StartCoroutine(MoveToTarget(_closedLocalPos));
        }

        private IEnumerator MoveToTarget(Vector3 targetLocalPos)
        {
            while (Vector3.Distance(_movingPart.localPosition, targetLocalPos) > 0.01f)
            {
                _movingPart.localPosition = Vector3.MoveTowards(
                    _movingPart.localPosition,
                    targetLocalPos,
                    _speed * Time.deltaTime
                );
                yield return null;
            }
            _movingPart.localPosition = targetLocalPos;
        }

        // --- Editor Helpers ---

        [ContextMenu("Capture Open Position")]
        private void CaptureOpen()
        {
            if (_movingPart) _openLocalPos = _movingPart.localPosition;
            else Debug.LogWarning("Assign _movingPart first!");
        }

        [ContextMenu("Capture Closed Position")]
        private void CaptureClosed()
        {
            if (_movingPart) _closedLocalPos = _movingPart.localPosition;
            else Debug.LogWarning("Assign _movingPart first!");
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\CameraZone.cs`
- Lines: 51
- Size: 1.7 KB
- Modified: 2026-01-18 13:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Gameplay.Cameras; // Access the Rig

namespace DarkTowerTron.Gameplay.Environment
{
    public class CameraZone : MonoBehaviour
    {
        [Header("Camera Overrides")]
        [Tooltip("-1 to keep default")]
        public float targetPitch = 30f; // Lower angle = more "forward" view
        public float targetDistance = 20f; // Zoom in slightly?

        [Header("Axis Locking")]
        public bool lockX = false;
        public bool lockZ = false; // Check this for Side-Scrolling (Left/Right movement only)

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                // NEW: Direct Static Access (O(1) speed)
                var rig = CameraRig.Instance;
                
                if (rig != null)
                {
                    // Pass the center of THIS trigger as the lock position
                    rig.OverrideCamera(targetPitch, targetDistance, lockX, lockZ, transform.position);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                var rig = CameraRig.Instance;
                if (rig != null) rig.ResetToDefault();
            }
        }

        // Visualize the Zone
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 1, 0.2f);
            Gizmos.DrawCube(transform.position, transform.localScale);
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Editor\ZoneEditor.cs`
- Lines: 159
- Size: 5.3 KB
- Modified: 2026-01-17 11:56

```csharp
using UnityEngine;
using UnityEditor;
using DarkTowerTron.Gameplay.Environment;
using System.Collections.Generic;

[CustomEditor(typeof(Zone))]
public class ZoneEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Zone zone = (Zone)target;

        GUILayout.Space(20);
        GUILayout.Label("Level Tools", EditorStyles.boldLabel);

        if (GUILayout.Button("Snap Tiles to Grid"))
        {
            zone.SnapTiles();
        }

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Bake Walls (Stable)"))
        {
            BakeWalls(zone);
        }

        if (GUILayout.Button("Clear Walls"))
        {
            ClearWalls(zone);
        }

        GUILayout.EndHorizontal();
    }

    private void BakeWalls(Zone zone)
    {
        ClearWalls(zone);

        if (zone.wallPrefabs == null || zone.wallPrefabs.Count == 0)
        {
            Debug.LogError("[Zone] No Wall Prefabs assigned!");
            return;
        }

        GameObject wallPrefab = zone.wallPrefabs[0];
        TileInfo[] tiles = zone.GetComponentsInChildren<TileInfo>();
        List<GameObject> createdWalls = new List<GameObject>();
        int globalWallCount = 0;

        // --- STEP 1: BUILD THE MAP ---
        Dictionary<Vector2Int, TileInfo> tileMap = new Dictionary<Vector2Int, TileInfo>();
        float gridSize = zone.tileSize;

        foreach (var tile in tiles)
        {
            Vector2Int coord = GetGridCoordinate(tile.transform.position, gridSize);

            if (!tileMap.ContainsKey(coord))
            {
                tileMap.Add(coord, tile);
            }
            else
            {
                Debug.LogWarning($"[Zone] Overlapping tiles at {coord}. Check {tile.name}");
            }
        }

        // --- STEP 2: ITERATE SOCKETS ---
        foreach (var tile in tiles)
        {
            if (tile.sockets == null) continue;

            Vector2Int myCoord = GetGridCoordinate(tile.transform.position, gridSize);
            string tileID = $"T[{myCoord.x},{myCoord.y}]";

            foreach (var socket in tile.sockets)
            {
                if (socket == null) continue;
                if (socket.type == SocketType.Connector) continue;

                // --- THE FIX: ROBUST DIRECTION CALCULATION ---
                // Instead of using socket.forward (which changes if you rotate visuals),
                // we calculate the vector from Tile Center to Socket Position.
                // This ALWAYS points towards the neighbor.

                Vector3 dirVector = socket.transform.position - tile.transform.position;

                // Determine direction based on largest axis
                Vector2Int direction = Vector2Int.zero;
                if (Mathf.Abs(dirVector.z) > Mathf.Abs(dirVector.x))
                    direction = new Vector2Int(0, (dirVector.z > 0) ? 1 : -1); // North/South
                else
                    direction = new Vector2Int((dirVector.x > 0) ? 1 : -1, 0); // East/West

                // (Optional) Diagonal check for Triangle tiles
                // If both components are significant (e.g. > 1.0m), treat as diagonal
                if (Mathf.Abs(dirVector.x) > 1.5f && Mathf.Abs(dirVector.z) > 1.5f)
                {
                    direction = new Vector2Int(
                        (dirVector.x > 0) ? 1 : -1,
                        (dirVector.z > 0) ? 1 : -1
                    );
                }

                Vector2Int neighborCoord = myCoord + direction;

                // --- STEP 3: CHECK NEIGHBOR ---
                bool hasNeighbor = tileMap.ContainsKey(neighborCoord);

                if (!hasNeighbor)
                {
                    // Spawn Wall
                    GameObject newWall = (GameObject)PrefabUtility.InstantiatePrefab(wallPrefab, zone.transform);

                    // Uses the Socket's exact transform (so your visual rotation is preserved!)
                    newWall.transform.position = socket.transform.position;
                    newWall.transform.rotation = socket.transform.rotation;

                    // Naming
                    string socketID = socket.name.Replace("Socket_", "");
                    globalWallCount++;
                    newWall.name = $"Wall_{tileID}_{socketID}_{globalWallCount:000}";

                    createdWalls.Add(newWall);
                    socket.isOccupied = true;
                }
                else
                {
                    socket.isOccupied = false;
                }
            }
        }

        Debug.Log($"<color=green>[Zone]</color> Baked {createdWalls.Count} walls using Center-to-Socket logic.");
    }

    private Vector2Int GetGridCoordinate(Vector3 pos, float size)
    {
        return new Vector2Int(
            Mathf.RoundToInt(pos.x / size),
            Mathf.RoundToInt(pos.z / size)
        );
    }

    private void ClearWalls(Zone zone)
    {
        for (int i = zone.transform.childCount - 1; i >= 0; i--)
        {
            Transform child = zone.transform.GetChild(i);
            if (child.name.StartsWith("Wall_"))
            {
                Undo.DestroyObjectImmediate(child.gameObject);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Encounter\ArenaController.cs`
- Lines: 131
- Size: 4.3 KB
- Modified: 2026-01-24 15:25

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Events; // Needed for UI Events
using DarkTowerTron.Systems.Waves;

namespace DarkTowerTron.Gameplay.Environment
{
    public class ArenaController : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private List<WaveDefinitionSO> _waves;
        [SerializeField] private List<Transform> _spawnPoints;

        // NEW: Granular Control
        [SerializeField] private bool _useCountdown = true;
        [SerializeField] private float _countdownDuration = 3f;
        [SerializeField] private float _delayBetweenWaves = 2f;

        [Header("Gates")]
        [SerializeField] private List<ArenaGate> _gates;

        [Header("UI Broadcasting")]
        // Moved from Service to here
        [SerializeField] private StringEventChannelSO _announcementEvent;
        [SerializeField] private StringEventChannelSO _countdownEvent;

        // Dependencies
        private IWaveService _waveService;
        private Queue<WaveDefinitionSO> _waveQueue;
        private bool _isActive = false;

        private void Start()
        {
            _waveService = ServiceLocator.Get<IWaveService>();
            ToggleGates(false);
        }

        public void BeginEncounter()
        {
            if (_isActive) return;
            _isActive = true;

            ToggleGates(true);
            _waveQueue = new Queue<WaveDefinitionSO>(_waves);

            // Start the sequence
            StartCoroutine(RunWaveRoutine());
        }

        private IEnumerator RunWaveRoutine()
        {
            // Check if we have waves left
            if (_waveQueue.Count > 0)
            {
                var nextWave = _waveQueue.Dequeue();

                // 1. Announce Title
                if (_announcementEvent != null)
                    _announcementEvent.RaiseEvent(nextWave.waveName);

                // 2. Optional Countdown
                if (_useCountdown && _countdownEvent != null)
                {
                    float timer = _countdownDuration;
                    while (timer > 0)
                    {
                        // CeilToInt gives us "3", "2", "1" nice and clean
                        _countdownEvent.RaiseEvent(Mathf.CeilToInt(timer).ToString());
                        yield return new WaitForSeconds(1f);
                        timer -= 1f;
                    }
                    _countdownEvent.RaiseEvent(""); // Clear
                }

                // 3. Execute Wave via Service
                // Note: We cannot use the callback 'RunNextWave' directly inside Coroutine flow easily.
                // Instead, we wait for a flag or signal. 
                // A cleaner way for Coroutines is to wrap the Service call in a YieldInstruction 
                // but since our Service uses a callback, let's adapt.

                bool waveRunning = true;
                bool success = _waveService.StartWave(nextWave, _spawnPoints, onComplete: () => { waveRunning = false; });

                if (!success)
                {
                    Debug.LogError("[ArenaController] Service rejected wave!");
                    FinishEncounter();
                    yield break;
                }

                // 4. Wait for Wave Completion
                yield return new WaitUntil(() => !waveRunning);

                // 5. Inter-Wave Delay
                if (_waveQueue.Count > 0)
                {
                    yield return new WaitForSeconds(_delayBetweenWaves);
                    StartCoroutine(RunWaveRoutine()); // Loop
                }
                else
                {
                    FinishEncounter();
                }
            }
            else
            {
                FinishEncounter();
            }
        }

        private void FinishEncounter()
        {
            ToggleGates(false);
            _isActive = false;
        }

        private void ToggleGates(bool close)
        {
            foreach (var gate in _gates)
            {
                if (gate != null)
                {
                    if (close) gate.Close(); else gate.Open();
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Encounter\EncounterTrigger.cs`
- Lines: 38
- Size: 1.1 KB
- Modified: 2026-01-24 15:09

```csharp
using UnityEngine;
using DarkTowerTron.Core; // For GameConstants

namespace DarkTowerTron.Gameplay.Environment
{
    [RequireComponent(typeof(BoxCollider))]
    public class EncounterTrigger : MonoBehaviour
    {
        [Header("Target")]
        [Tooltip("The controller that manages this room's logic.")]
        [SerializeField] private ArenaController _controller;

        [Header("Settings")]
        [SerializeField] private bool _oneShot = true;

        private bool _hasTriggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_hasTriggered && _oneShot) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                if (_controller != null)
                {
                    _hasTriggered = true;
                    _controller.BeginEncounter();

                    if (_oneShot) GetComponent<Collider>().enabled = false;
                }
                else
                {
                    Debug.LogError($"[EncounterTrigger] No ArenaController assigned on {gameObject.name}!");
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\ILockable.cs`
- Lines: 13
- Size: 0.3 KB
- Modified: 2026-01-23 15:10

```csharp
namespace DarkTowerTron.Gameplay.Environment
{
    /// <summary>
    /// Contract for anything that can block or allow passage 
    /// (Gates, Forcefields, Bridges, Doors).
    /// </summary>
    public interface ILockable
    {
        void Lock();   // Close/Block
        void Unlock(); // Open/Allow
        bool IsLocked { get; }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\LevelEndTrigger.cs`
- Lines: 37
- Size: 1.1 KB
- Modified: 2026-01-19 00:07

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Events;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Environment
{
    public class LevelEndTrigger : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                GameLogger.Log(LogChannel.System, "LEVEL COMPLETE", gameObject);

                // Trigger Victory Logic
                _gameVictoryEvent?.RaiseEvent();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 0, 0.3f); // Semi-transparent Green
            Gizmos.DrawCube(transform.position, transform.localScale);
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\PlayerStart.cs`
- Lines: 65
- Size: 2.2 KB
- Modified: 2026-01-17 11:56

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Gameplay.Environment
{
    public class PlayerStart : MonoBehaviour
    {
        [Tooltip("Unique ID for this spawn point (e.g., 'Start', 'Arena2', 'Boss')")]
        public string spawnID = "Start";

        [Header("Visuals")]
        public Color gizmoColor = Color.green;

        // --- THE REGISTRY ---
        private static readonly Dictionary<string, Transform> _registry = new Dictionary<string, Transform>();

        private void OnEnable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (!_registry.ContainsKey(spawnID))
            {
                _registry.Add(spawnID, transform);
            }
            else if (_registry[spawnID] != transform)
            {
                Debug.LogWarning($"[PlayerStart] Duplicate spawnID '{spawnID}' found on '{name}'. Keeping first registration.", gameObject);
            }
        }

        private void OnDisable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (_registry.TryGetValue(spawnID, out Transform registered) && registered == transform)
            {
                _registry.Remove(spawnID);
            }
        }

        public static Transform GetSpawnPoint(string id)
        {
            if (!string.IsNullOrWhiteSpace(id) && _registry.TryGetValue(id, out Transform t)) return t;

            // Fallback: Try "Start" if the requested one is missing
            if (id != "Start" && _registry.TryGetValue("Start", out Transform def)) return def;

            return null;
        }
        // --------------------

        private void OnDrawGizmos()
        {
            Gizmos.color = gizmoColor;
            // Draw a capsule to represent the player
            Gizmos.DrawWireSphere(transform.position + Vector3.up * 0.5f, 0.5f);
            Gizmos.DrawLine(transform.position, transform.position + transform.forward * 2f);

            // Draw label in Scene View
#if UNITY_EDITOR
            UnityEditor.Handles.Label(transform.position + Vector3.up * 2f, $"Spawn: {spawnID}");
#endif
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Props\Prop_Anchor.cs`
- Lines: 118
- Size: 4.1 KB
- Modified: 2026-01-17 14:25

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Gameplay.Combat; // For DamageReceiver
using DarkTowerTron.Core.Data;
using DarkTowerTron.Gameplay.Enemies; // For EnemyVisuals
using DG.Tweening;
using UnityEngine.Scripting.APIUpdating;

namespace DarkTowerTron.Gameplay.Environment
{
    [MovedFrom(true, "DarkTowerTron.Environment", "Assembly-CSharp", "Prop_Anchor")]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Anchor : MonoBehaviour
    {
        [Header("Anchor Settings")]
        public float respawnTime = 5.0f;
        public GameObject visualRoot; // Assign the mesh object
        public Collider mainCollider;

        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();

            if (visualRoot == null && transform.childCount > 0) visualRoot = transform.GetChild(0).gameObject;
            if (mainCollider == null) mainCollider = GetComponent<Collider>();
        }

        private void Start()
        {
            // Trigger the DamageReceiver to read the Inspector Overrides
            // We pass 'null' for stats because we are using overrides
            if (_receiver != null) _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed += HandleDeath;
                _receiver.OnHitProcessed += HandleHit;

                // Wire up Stagger Visuals
                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
                }
            }
        }

        private void OnDisable()
        {
            if (_receiver != null)
            {
                _receiver.OnDeathProcessed -= HandleDeath;
                _receiver.OnHitProcessed -= HandleHit;

                if (_receiver.Stagger != null && _visuals != null)
                {
                    _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                    _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
                }
            }
        }

        private void HandleHit(DarkTowerTron.Gameplay.Combat.DamageInfo info)
        {
            // Trigger the Flash via the Visuals component
            if (_receiver != null && _visuals != null && !_receiver.IsStaggered)
            {
                _visuals.PlayHitFlash();
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            // The PlayerExecution just triggered Kill().
            // Instead of destroying the object, we "Disable" it temporarily.
            StartCoroutine(RespawnRoutine());
        }

        private IEnumerator RespawnRoutine()
        {
            // 1. Hide
            if (visualRoot) visualRoot.SetActive(false);
            if (mainCollider) mainCollider.enabled = false;

            // 2. Wait
            yield return new WaitForSeconds(respawnTime);

            // 3. Reset Health
            // We need to revive the Vitality/Stagger modules manually
            if (_receiver != null)
            {
                if (_receiver.Vitality != null) _receiver.Vitality.Revive();
                if (_receiver.Stagger != null) _receiver.Stagger.ResetStagger();
            }

            if (_visuals != null) _visuals.ResetVisuals();

            // 4. Show (with Pop-in animation)
            if (visualRoot)
            {
                visualRoot.SetActive(true);
                visualRoot.transform.DOKill();
                visualRoot.transform.localScale = Vector3.zero;
                visualRoot.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
            }

            if (mainCollider) mainCollider.enabled = true;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Props\Prop_Explosive.cs`
- Lines: 123
- Size: 3.9 KB
- Modified: 2026-01-19 00:07

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Core.Patterns; // For IPoolService

namespace DarkTowerTron.Gameplay.Environment
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Explosive : MonoBehaviour
    {
        [Header("Explosive Settings")]
        public GameObject hazardZonePrefab;
        public GameObject explosionPrefab; // New: Explicit reference, removed Global.VFX dependency

        [Tooltip("If true, Stagger Damage from weapons is applied directly to Health.")]
        public bool volatileOnStagger = true;

        [Header("Visual Feedback")]
        [SerializeField] private DamageTextEventChannelSO _damageTextEvent;

        // References
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        private void HandleHit(DamageInfo info)
        {
            // 1. Visual Flash
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();

            // 2. Damage Numbers
            bool isCrit = _receiver.IsStaggered;

            if (info.damageAmount > 0)
            {
                // Show Health Damage
                _damageTextEvent?.RaiseEvent(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                // Show Stagger Damage
                _damageTextEvent?.RaiseEvent(transform.position, info.staggerAmount, false, true);
            }

            // 3. Volatile Logic
            // If this prop is volatile, Stagger actually hurts it
            if (volatileOnStagger && info.staggerAmount > 0)
            {
                _receiver.Vitality.TakeDamage(info.staggerAmount);
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            Explode();
        }

        private void Explode()
        {
            // Resolve Pool Service
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool == null)
            {
                // Fallback: Just destroy if no pool exists (e.g. testing in isolation)
                Destroy(gameObject);
                return;
            }

            Vector3 pos = transform.position;

            // 1. Spawn Hazard (Fire/Acid on ground)
            if (hazardZonePrefab)
                pool.Spawn(hazardZonePrefab, pos, Quaternion.identity);

            // 2. Spawn Explosion Visuals
            
            if (explosionPrefab)
                pool.Spawn(explosionPrefab, pos, Quaternion.identity);

            // 3. Despawn Self
            pool.Despawn(gameObject);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\TileInfo.cs`
- Lines: 46
- Size: 1.4 KB
- Modified: 2026-01-17 11:56

```csharp
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace DarkTowerTron.Gameplay.Environment
{
    public class TileInfo : MonoBehaviour
    {
        [Header("Building Data")]
        public List<TileSocket> sockets = new List<TileSocket>();

        [Header("Debug")]
        public bool showGizmos = true;

        // Defines "Orange" manually
        private Color colorOrange = new Color(1.0f, 0.5f, 0.0f);

        /// <summary>
        /// Generates a short, unique ID based on the tile's local grid position.
        /// Example: A tile at x=10, z=-5 becomes "T[2,-1]"
        /// </summary>
        public string GetGridID(float gridSize)
        {
            int x = Mathf.RoundToInt(transform.localPosition.x / gridSize);
            int z = Mathf.RoundToInt(transform.localPosition.z / gridSize);
            return $"T[{x},{z}]";
        }

        [ContextMenu("Find Sockets in Children")]
        public void FindSockets()
        {
            sockets = GetComponentsInChildren<TileSocket>().ToList();
        }

        private void OnDrawGizmos()
        {
            if (!showGizmos) return;

            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.color = new Color(0, 1, 1, 0.1f);
            Gizmos.DrawWireCube(Vector3.zero, new Vector3(5, 0.1f, 5));

            // (Socket drawing handled by TileSocket gizmos mostly, but we can keep simple lines)
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\TileSocket.cs`
- Lines: 42
- Size: 1.5 KB
- Modified: 2026-01-17 11:56

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Environment
{
    public enum SocketType { Wall, Gate, Connector }

    public class TileSocket : MonoBehaviour
    {
        [Header("Settings")]
        public SocketType type = SocketType.Wall;
        public float wallThickness = 0.5f; // Standard thickness

        [Header("State")]
        public bool isOccupied = false;

        private void OnDrawGizmos()
        {
            // Visual Styles based on Type
            Color color = type switch
            {
                SocketType.Wall => new Color(1f, 0.6f, 0f, 0.8f),   // Orange
                SocketType.Gate => new Color(0f, 1f, 1f, 0.8f),     // Cyan
                SocketType.Connector => new Color(0f, 1f, 0f, 0.8f),// Green
                _ => Color.white
            };

            Gizmos.color = color;
            Gizmos.matrix = transform.localToWorldMatrix;

            // 1. Draw the "Footprint" of the wall that will spawn here
            // If this socket is indented, we draw the box to show where the mesh actually sits
            Gizmos.DrawWireCube(new Vector3(0, 1.25f, 0), new Vector3(5f, 2.5f, wallThickness));

            // 2. Draw the "Forward" direction (Outward)
            Gizmos.DrawLine(Vector3.zero, Vector3.forward * 1.0f);
            Gizmos.DrawSphere(Vector3.forward * 1.0f, 0.15f);

            // 3. Draw a "Snap" diamond at the center
            Gizmos.DrawWireSphere(Vector3.zero, 0.1f);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\VoidKiller.cs`
- Lines: 34
- Size: 1.1 KB
- Modified: 2026-01-17 14:32

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Player; // Access PlayerHealth directly for special void logic
using DarkTowerTron.Gameplay.Combat;

namespace DarkTowerTron.Gameplay.Environment
{
    public class VoidKiller : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            // 1. Check for Player
            PlayerHealth player = other.GetComponentInParent<PlayerHealth>();
            if (player != null)
            {
                player.TakeVoidDamage();
                return;
            }

            // 2. Check for Enemies (Instant Kill)
            IDamageable damageable = other.GetComponentInParent<IDamageable>();
            if (damageable != null)
            {
                damageable.Kill(true);
            }
            else
            {
                // Debris/Bullets
                Destroy(other.gameObject);
                // Note: If object is Pooled, this might break pool logic if not handled.
                // Ideally check for IPoolable, but Destroy is a safe fallback for cleanup.
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Environment\Zone.cs`
- Lines: 86
- Size: 3.3 KB
- Modified: 2026-01-18 15:27

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data; // Access PaletteDefinitionSO

namespace DarkTowerTron.Gameplay.Environment
{
    /// <summary>
    /// Represents a single modular room or arena (Zone).
    /// Holds data about how this zone looks (Palette) and how it connects (Entry/Exit).
    /// </summary>
    public class Zone : MonoBehaviour
    {
        [Header("Zone Identity")]
        [Tooltip("Used for debugging or narrative triggers.")]
        public string zoneID;

        [Tooltip("The visual theme for this zone (Neon, Nier, etc).")]
        public PaletteDefinitionSO palette;

        [Header("Building Settings")]
        [Tooltip("The atomic grid size. Standard is 5 meters.")]
        public float tileSize = 5f;

        [Tooltip("Prefabs to be used by the Wall Baker. Order: 0=Straight, 1=OuterCorner, 2=InnerCorner")]
        public List<GameObject> wallPrefabs = new List<GameObject>();

        [Header("Connections")]
        [SerializeField] private Transform _entryPoint;
        [SerializeField] private Transform _exitPoint;
        [SerializeField] private Bounds _bounds = new Bounds(Vector3.zero, new Vector3(25, 10, 25));

        // Public Accessors
        public Transform EntryPoint => _entryPoint;
        public Transform ExitPoint => _exitPoint;
        public Bounds Bounds => _bounds;

        /// <summary>
        /// Editor Helper: Quickly aligns all child tiles to the grid.
        /// </summary>
        [ContextMenu("Snap Child Tiles")]
        public void SnapTiles()
        {
            // Note: TileInfo needs to be defined in DarkTowerTron.Gameplay.Environment for this to work.
            // If you haven't migrated TileInfo yet, this GetComponent call will act as the compiler check.
            var tileComponents = GetComponentsInChildren<TileInfo>();

            foreach (var tile in tileComponents)
            {
                Transform t = tile.transform;
                
                // Calculate Grid Position
                Vector3 localPos = t.localPosition;
                localPos.x = Mathf.Round(localPos.x / tileSize) * tileSize;
                localPos.z = Mathf.Round(localPos.z / tileSize) * tileSize;
                localPos.y = 0; // Flatten floor

                // Apply
                t.localPosition = localPos;
            }
            
            Debug.Log($"<color=cyan>[Zone]</color> Snapped {tileComponents.Length} tiles to grid.");
        }

        private void OnDrawGizmos()
        {
            // Draw Bounds
            Gizmos.color = new Color(1, 1, 0, 0.3f);
            Gizmos.DrawWireCube(transform.position + _bounds.center, _bounds.size);

            // Draw Connections
            if (_entryPoint != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(_entryPoint.position, 1f);
                Gizmos.DrawLine(_entryPoint.position, _entryPoint.position + _entryPoint.forward * 2);
            }

            if (_exitPoint != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(_exitPoint.position, 1f);
                Gizmos.DrawLine(_exitPoint.position, _exitPoint.position + _exitPoint.forward * 2);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\PlayerBeam.cs`
- Lines: 134
- Size: 4.7 KB
- Modified: 2026-01-18 23:52

```csharp
using System;
using System.Collections.Generic;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Systems.Stats;
using DG.Tweening;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Gameplay.Player
{
    public class PlayerBeam : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 1.0f;
        public float selfRecoil = 15f;
        public GameObject beamVisualPrefab;

        private PlayerMotor _movement;

        protected override void Awake()
        {
            base.Awake();
            _movement = GetComponent<PlayerMotor>();
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            // Use Smart Aim (Magnetism)
            Vector3 fireDir = GetAimDirection();

            // 1. Visuals
            if (beamVisualPrefab)
            {
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);

                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y;
                float compZ = range / parentScale.z;

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 2. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 3. Hit Detection (Projectiles + Enemies, blocked by Walls)
            int mask = GameConstants.MASK_PROJECTILE_COLLISION | (1 << GameConstants.LAYER_PROJECTILE);

            RaycastHit[] hits = UnityEngine.Physics.SphereCastAll(
                firePoint.position,
                beamRadius,
                fireDir,
                range,
                mask,
                QueryTriggerInteraction.Collide
            );

            if (hits == null || hits.Length == 0) return;

            Array.Sort(hits, (a, b) => a.distance.CompareTo(b.distance));

            var damaged = new HashSet<IDamageable>();
            var parried = new HashSet<Projectile>();

            foreach (var hit in hits)
            {
                if (hit.collider == null) continue;

                // Ignore self / child colliders (weapon/player)
                if (hit.collider.transform.IsChildOf(transform)) continue;

                // Stop at walls
                int hitLayer = hit.collider.gameObject.layer;
                if (hitLayer == GameConstants.LAYER_WALL || hitLayer == GameConstants.LAYER_DEFAULT)
                {
                    break;
                }

                // A) Parry hostile projectiles
                Projectile incomingProj = hit.collider.GetComponentInParent<Projectile>();
                if (incomingProj != null)
                {
                    // NEW: Parry is a perk/ability.
                    if (_stats == null || !_stats.HasAbility(AbilityType.Melee_Parry))
                    {
                        continue;
                    }

                    if (incomingProj.isHostile && !parried.Contains(incomingProj))
                    {
                        // Aim-based parry (more deterministic than relying on projectile rotation)
                        Vector3 deflectDir = fireDir;
                        if (incomingProj.TryParry(deflectDir, gameObject))
                        {
                            parried.Add(incomingProj);
                        }
                    }
                    continue;
                }

                // B) Damage enemies in the beam path (avoid double-hits from multiple colliders)
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();
                if (target != null && damaged.Add(target))
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject,
                        damageType = DamageType.Melee
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\PlayerExecution.cs`
- Lines: 146
- Size: 5.1 KB
- Modified: 2026-01-20 14:10

```csharp
using System.Collections;
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Gameplay.Combat; // For ICombatTarget
using DarkTowerTron.Core.Feedback; // For CameraShaker
using DarkTowerTron.Core.AudioSystem; // For IAudioService
using DarkTowerTron.Systems.Score; // For IScoreService

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public int killScoreAmount = 500; // New: explicit score value
        public AudioClip executeClip;

        [Header("Positioning")]
        [Tooltip("How high above the ground to teleport to prevent clipping. 0.1 is usually enough.")]
        public float verticalBuffer = 0.2f;

        // Dependencies
        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMotor _movement;
        private PlayerStats _stats;
        
        // Services
        private IAudioService _audioService;
        private IScoreService _scoreService;

        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMotor>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // Locate Services
            _audioService = ServiceLocator.Get<IAudioService>();
            _scoreService = ServiceLocator.Get<IScoreService>();
        }

        public void PerformGloryKill()
        {
            if (_isBusy) return;

            // Logic Checks
            if (_scanner == null || _scanner.CurrentTarget == null) return;
            if (!_scanner.CurrentTarget.IsStaggered) return;

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        private IEnumerator ExecutionRoutine(ICombatTarget target)
        {
            _isBusy = true;

            // 1. Calculate Base Position (Horizontal only first)
            Vector3 targetPos = target.transform.position;
            
            // Back up slightly from the target so we don't clip inside them
            Vector3 attackPos = targetPos - (transform.forward * 1.5f);

            // 2. Y-Axis Logic (Safe Ground Snap)
            if (target.KeepPlayerGrounded)
            {
                // Cast from High Up (Enemy Head + 2m) downwards
                Vector3 rayOrigin = targetPos + Vector3.up * 2.0f;
                int groundMask = GameConstants.MASK_GROUND_ONLY; // Ensure GameConstants defines this, or use LayerMask.GetMask("Ground")

                if (Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 10f, groundMask))
                {
                    attackPos.y = hit.point.y + verticalBuffer;
                }
                else
                {
                    // Fallback: Use Player's current height
                    attackPos.y = transform.position.y + verticalBuffer;
                }
            }
            else
            {
                // Air execution (maintain enemy height)
                attackPos.y = targetPos.y;
            }

            // 3. Safe Teleport
            if (_movement)
            {
                _movement.Teleport(attackPos);
                // Suspend gravity during animation
                _movement.SuspendGravity(_stats.ActionHangTime + 0.5f);
            }

            // 4. Trigger Target Reaction (Die)
            target.OnExecutionHit();

            // 5. Audio & Rewards
            if (executeClip && _audioService != null)
                _audioService.PlaySound(executeClip, transform.position, 1f);

            _energy.AddFocus(killRewardFocus);

            if (_scoreService != null)
                _scoreService.AddScore(killScoreAmount, transform.position);

            // 6. Juice (Time Stop & Shake)
            StartCoroutine(HitStopRoutine(0.1f));

            if (CameraShaker.Instance)
                CameraShaker.Instance.Shake(0.2f, 0.5f);

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }

        // Simple local replacement for Global.Time.HitStop
        private IEnumerator HitStopRoutine(float duration)
        {
            if (Time.timeScale == 0) yield break; // Already paused

            float originalScale = Time.timeScale;
            Time.timeScale = 0f;
            
            // We use WaitForSecondsRealtime because timeScale is 0
            yield return new WaitForSecondsRealtime(duration);
            
            Time.timeScale = originalScale;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\PlayerGun.cs`
- Lines: 61
- Size: 1.9 KB
- Modified: 2026-01-18 19:16

```csharp
using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerLoadout))]
    public class PlayerGun : WeaponBase
    {
        [Header("Gun Specifics")]
        public float bulletSpeed = 25f;

        private PlayerLoadout _loadout;

        protected override void Awake()
        {
            base.Awake();
            _loadout = GetComponent<PlayerLoadout>();
        }

        protected override void Fire()
        {
            GameObject prefabToSpawn = _loadout.currentProjectile;

            // 1. Get Pool Service
            var pool = ServiceLocator.Get<IPoolService>();

            if (prefabToSpawn && firePoint && pool != null)
            {
                // Use Smart Aim (Inherited from WeaponBase)
                Vector3 aimDir = GetAimDirection();

                // 2. Spawn via Service
                GameObject p = pool.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));

                var proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;

                    // Stats Injection
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;

                    // CRITICAL: Self-Hit Protection
                    // Ensure the bullet knows the Player fired it so it doesn't collide with the player immediately
                    proj.SetSource(gameObject);

                    proj.Initialize(aimDir);
                }
            }
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.GunRate;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\PlayerWeaponController.cs`
- Lines: 35
- Size: 1.1 KB
- Modified: 2026-01-17 12:25

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    public class PlayerWeaponController : MonoBehaviour
    {
        [Header("Inventory")]
        // We link these in Inspector or Awake
        [SerializeField] private WeaponBase _primaryWeapon;   // Beam
        [SerializeField] private WeaponBase _secondaryWeapon; // Gun

        private void Awake()
        {
            // Auto-link if empty (Backwards compatibility with current prefab setup)
            if (_primaryWeapon == null) _primaryWeapon = GetComponent<PlayerBeam>();
            if (_secondaryWeapon == null) _secondaryWeapon = GetComponent<PlayerGun>();
        }

        public void SetPrimaryFire(bool isFiring)
        {
            if (_primaryWeapon) _primaryWeapon.SetFiring(isFiring);
        }

        public void SetSecondaryFire(bool isFiring)
        {
            if (_secondaryWeapon) _secondaryWeapon.SetFiring(isFiring);
        }

        public void StopAll()
        {
            SetPrimaryFire(false);
            SetSecondaryFire(false);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\TargetScanner.cs`
- Lines: 111
- Size: 3.9 KB
- Modified: 2026-01-17 12:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Gameplay.Combat;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public Transform reticlePrefab; 
        public Vector3 reticleOffset = new Vector3(0, 0.1f, 0);
        
        // NEW: Visual Feedback settings
        public Color lockedColor = Color.cyan;
        public Color executionColor = Color.yellow; // or Red

        public ICombatTarget CurrentTarget { get; private set; }

        private Transform _reticleInstance;
        private LineRenderer _reticleLine; // Assuming we use the LineRenderer reticle
        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            if (reticlePrefab)
            {
                _reticleInstance = Instantiate(reticlePrefab, Vector3.zero, Quaternion.identity);
                _reticleLine = _reticleInstance.GetComponent<LineRenderer>();
                _reticleInstance.gameObject.SetActive(false);
            }
        }

        public void UpdateScanner(Vector3 aimDirection)
        {
            // NEW: Create a tall vertical capsule
            // From: 5 units below feet (catch things down stairs)
            // To: 10 units above feet (catch flying drones)
            Vector3 p1 = transform.position + (Vector3.down * 5f);
            Vector3 p2 = transform.position + (Vector3.up * 10f);
            
            int layerMask = 1 << GameConstants.LAYER_ENEMY;

            // Use Stats for width/range
            float range = _stats ? _stats.ScanRange : 25f;
            float rad = _stats ? _stats.ScanRadius : 2f; // Width of the pole

            // Change SphereCast to CapsuleCast
            if (UnityEngine.Physics.CapsuleCast(p1, p2, rad, aimDirection, out RaycastHit hit, range, layerMask))
            {
                // FIX: Look for Interface instead of EnemyController
                ICombatTarget target = hit.collider.GetComponentInParent<ICombatTarget>();
                
                if (target != null)
                {
                    CurrentTarget = target;
                }
                else
                {
                    CurrentTarget = null;
                }
            }
            else
            {
                CurrentTarget = null;
            }

            UpdateReticle();
        }

        private void UpdateReticle()
        {
            if (_reticleInstance == null) return;

            if (CurrentTarget != null)
            {
                _reticleInstance.gameObject.SetActive(true);
                _reticleInstance.position = CurrentTarget.transform.position + reticleOffset;
                _reticleInstance.Rotate(Vector3.up * 200 * Time.deltaTime);

                // --- NEW: COLOR LOGIC ---
                if (_reticleLine)
                {
                    // If Staggered -> Show Execution Color (Yellow/Red)
                    // If Healthy -> Show Lock Color (Cyan)
                    Color targetColor = CurrentTarget.IsStaggered ? executionColor : lockedColor;
                    
                    // Simple property block or direct material color change
                    _reticleLine.startColor = targetColor;
                    _reticleLine.endColor = targetColor;
                    // Also update material color for emission glow
                    _reticleLine.material.color = targetColor;
                }
            }
            else
            {
                _reticleInstance.gameObject.SetActive(false);
            }
        }
        
        // Gizmos remain same...
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Combat\WeaponBase.cs`
- Lines: 151
- Size: 4.9 KB
- Modified: 2026-01-17 12:25

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Gameplay.Combat;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;

        [Header("Behavior")]
        public bool isAutomatic = true;

        [Header("Game Feel")]
        [Tooltip("Audio, Shake, Flash, etc. happens here.")]
        public FeedbackConfigurationSO fireFeedback;

        [Header("Input")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;

        private bool _hasFiredThisPress = false;
        private RaycastHit[] _aimBuffer = new RaycastHit[10];

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
            if (!state) _hasFiredThisPress = false;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                if (isAutomatic || !_hasFiredThisPress)
                    _bufferTimer = inputBufferTime;
            }

            if (_bufferTimer > 0 && _timer <= 0)
            {
                if (!isAutomatic && _hasFiredThisPress) return;

                Fire();
                PlayFireFeedback();

                _timer = GetCurrentFireRate();
                _bufferTimer = 0;
                _hasFiredThisPress = true;
            }
        }

        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        protected void PlayFireFeedback()
        {
            if (fireFeedback == null) return;

            Vector3 playPos = firePoint != null ? firePoint.position : transform.position;
            fireFeedback.Play(gameObject, playPos);
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            // 1. HARD LOCK
            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                if (_scanner.CurrentTarget is IAimTarget aimTarget)
                    return (aimTarget.AimPoint - firePoint.position).normalized;

                return (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
            }

            Vector3 inputDir = transform.forward;

            // 2. SMART MAGNETISM
            float range = _stats ? _stats.ScanRange : 20f;
            float radius = 1.5f;
            int mask = (1 << GameConstants.LAYER_ENEMY) | GameConstants.MASK_WALLS;

            Vector3 p1 = transform.position + (Vector3.down * 2f);
            Vector3 p2 = transform.position + (Vector3.up * 8f);

            int hitCount = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1, p2, radius, inputDir, _aimBuffer, range, mask
            );

            IAimTarget bestTarget = null;
            float bestScore = -1f;

            for (int i = 0; i < hitCount; i++)
            {
                RaycastHit hit = _aimBuffer[i];
                IAimTarget candidate = hit.collider.GetComponentInParent<IAimTarget>();

                if (candidate == null) continue;

                // A. Wall Check
                Vector3 directionToTarget = candidate.AimPoint - firePoint.position;
                float distToTarget = directionToTarget.magnitude;

                if (UnityEngine.Physics.Raycast(firePoint.position, directionToTarget, distToTarget, GameConstants.MASK_WALLS))
                    continue;

                // B. Priority Scoring
                float angleScore = Vector3.Dot(inputDir, directionToTarget.normalized);

                if (angleScore > bestScore)
                {
                    bestScore = angleScore;
                    bestTarget = candidate;
                }
            }

            if (bestTarget != null)
            {
                return (bestTarget.AimPoint - firePoint.position).normalized;
            }

            // 3. TERRAIN FALLBACK
            Vector3 futurePos = transform.position + (inputDir * 15f);
            if (UnityEngine.Physics.Raycast(futurePos + Vector3.up * 10f, Vector3.down, out RaycastHit groundHit, 20f, GameConstants.MASK_GROUND_ONLY))
            {
                Vector3 aimAtPoint = groundHit.point + (Vector3.up * 1.5f);
                return (aimAtPoint - firePoint.position).normalized;
            }

            return inputDir;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Controller\PlayerController.cs`
- Lines: 96
- Size: 2.9 KB
- Modified: 2026-01-18 23:57

```csharp
using UnityEngine;
using DarkTowerTron.Core;
// using DarkTowerTron.Systems; // Removed unused namespace

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerInputHandler))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerExecution))]
    [RequireComponent(typeof(PlayerWeaponController))]
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance { get; private set; }

        private PlayerInputHandler _input;
        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerExecution _execution;
        private PlayerWeaponController _weapons;
        private TargetScanner _scanner;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;

            _input = GetComponent<PlayerInputHandler>();
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _execution = GetComponent<PlayerExecution>();
            _weapons = GetComponent<PlayerWeaponController>();
            _scanner = GetComponent<TargetScanner>();

            _input.OnDash += PerformDodge;
            _input.OnGloryKill += PerformGloryKill;

            // REMOVED: GameServices.RegisterPlayer(this); 
            // The static Instance above handles access now.
        }

        private void OnDestroy()
        {
            if (_input)
            {
                _input.OnDash -= PerformDodge;
                _input.OnGloryKill -= PerformGloryKill;
            }

            if (Instance == this)
            {
                Instance = null;
            }
        }

        private void Update()
        {
            Vector3 moveDir = new Vector3(_input.MoveInput.x, 0, _input.MoveInput.y).normalized;
            _movement.SetMoveInput(moveDir);

            Vector3 aimDir = _input.LookDirection;
            if (aimDir == Vector3.zero) aimDir = transform.forward;

            _movement.LookAtDirection(aimDir);
            if (_scanner) _scanner.UpdateScanner(aimDir);

            _weapons.SetPrimaryFire(_input.FirePrimary);
            _weapons.SetSecondaryFire(_input.FireSecondary);
        }

        private void PerformDodge()
        {
            if (_dodge) _dodge.PerformDodge();
        }

        private void PerformGloryKill()
        {
            if (_execution) _execution.PerformGloryKill();
        }

        public void ToggleInput(bool state)
        {
            if (_input) _input.ToggleInput(state);
            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                _weapons.StopAll();
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Controller\PlayerInputHandler.cs`
- Lines: 207
- Size: 7.0 KB
- Modified: 2026-01-18 23:52

```csharp
using System;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DarkTowerTron.Gameplay.Player
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [Header("Input Assets")]
        [SerializeField] private InputActionReference _moveAction;
        [SerializeField] private InputActionReference _aimGamepadAction;
        [SerializeField] private InputActionReference _aimMouseAction;
        
        [Header("Actions")]
        [SerializeField] private InputActionReference _firePrimaryAction;   // Beam
        [SerializeField] private InputActionReference _fireSecondaryAction; // Gun
        [SerializeField] private InputActionReference _dashAction;
        [SerializeField] private InputActionReference _gloryKillAction;

        [Header("Settings")]
        public float bufferTime = 0.15f;

        // --- PUBLIC DATA ---
        public Vector2 MoveInput { get; private set; }
        public Vector3 LookDirection { get; private set; } 
        public bool FirePrimary { get; private set; }   
        public bool FireSecondary { get; private set; } 

        // --- EVENTS ---
        public event Action OnDash;
        public event Action OnGloryKill;

        // --- INTERNAL ---
        private InputBuffer _buffer;
        private bool _inputEnabled = true;
        private Camera _cam;

        private void Awake()
        {
            // 1. Dependency Validation
            if (!AreInputsBound())
            {
                GameLogger.LogError(LogChannel.Player,
                    "CRITICAL: Missing Input Action References! Disabling InputHandler to prevent crash.", gameObject);

                enabled = false; // Stop Update() from running
                return;
            }

            // 2. Normal Init
            _cam = Camera.main;
            _buffer = new InputBuffer(bufferTime);
        }

        private void OnEnable()
        {
            EnableActions();
        }

        private void OnDisable()
        {
            DisableActions();
        }

        private void Update()
        {
            // 1. Always Read Continuous Input (Move/Aim)
            // Even if input is "disabled" via gameplay state, we might want to read it 
            // but return zero in the properties.
            if (_inputEnabled)
            {
                ProcessContinuousInputs();
                ProcessBufferedInputs();
            }
            else
            {
                ClearInputs();
            }
        }

        private void ProcessContinuousInputs()
        {
            // 1. Movement
            MoveInput = _moveAction.action.ReadValue<Vector2>();

            // 2. Aiming
            HandleAiming();

            // 3. Weapons (Hold)
            FirePrimary = _firePrimaryAction.action.ReadValue<float>() > 0.5f;
            FireSecondary = _fireSecondaryAction.action.ReadValue<float>() > 0.5f;
        }

        private void ProcessBufferedInputs()
        {
            // Check buffer for queued actions
            if (_buffer.TryConsumeAction("Dash")) OnDash?.Invoke();
            if (_buffer.TryConsumeAction("GloryKill")) OnGloryKill?.Invoke();
        }

        private void HandleAiming()
        {
            // Similar logic to before, but using References
            Vector2 stick = _aimGamepadAction.action.ReadValue<Vector2>();
            if (stick.sqrMagnitude > 0.05f)
            {
                LookDirection = new Vector3(stick.x, 0, stick.y).normalized;
                return; 
            }

            Vector2 mousePos = _aimMouseAction.action.ReadValue<Vector2>();
            Ray ray = _cam.ScreenPointToRay(mousePos);
            Plane ground = new Plane(Vector3.up, Vector3.zero);

            if (ground.Raycast(ray, out float enter))
            {
                Vector3 worldPoint = ray.GetPoint(enter);
                Vector3 dir = (worldPoint - transform.position);
                dir.y = 0;
                
                if (dir.sqrMagnitude > 0.001f) LookDirection = dir.normalized;
            }
        }

        // --- EVENT LISTENERS ---
        // We bind these in Enable/Disable
        private void OnDashPerformed(InputAction.CallbackContext ctx) => _buffer.BufferAction("Dash");
        private void OnKillPerformed(InputAction.CallbackContext ctx) => _buffer.BufferAction("GloryKill");

        private void ClearInputs()
        {
            MoveInput = Vector2.zero;
            FirePrimary = false;
            FireSecondary = false;
            _buffer.Clear();
        }

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (!state) ClearInputs();
        }

        // --- HELPER: BOILERPLATE BINDING ---
        private void EnableActions()
        {
            SetActionState(_moveAction, true);
            SetActionState(_aimGamepadAction, true);
            SetActionState(_aimMouseAction, true);
            SetActionState(_firePrimaryAction, true);
            SetActionState(_fireSecondaryAction, true);

            if (_dashAction != null)
            {
                _dashAction.action.performed += OnDashPerformed;
                _dashAction.action.Enable();
            }
            if (_gloryKillAction != null)
            {
                _gloryKillAction.action.performed += OnKillPerformed;
                _gloryKillAction.action.Enable();
            }
        }

        private void DisableActions()
        {
            SetActionState(_moveAction, false);
            SetActionState(_aimGamepadAction, false);
            SetActionState(_aimMouseAction, false);
            SetActionState(_firePrimaryAction, false);
            SetActionState(_fireSecondaryAction, false);

            if (_dashAction != null)
            {
                _dashAction.action.performed -= OnDashPerformed;
                _dashAction.action.Disable();
            }
            if (_gloryKillAction != null)
            {
                _gloryKillAction.action.performed -= OnKillPerformed;
                _gloryKillAction.action.Disable();
            }
        }

        private void SetActionState(InputActionReference refAction, bool enable)
        {
            if (refAction == null) return;
            if (enable) refAction.action.Enable();
            else refAction.action.Disable();
        }

        private bool AreInputsBound()
        {
            // Check the essential ones.
            // If secondary weapons/abilities are optional, you can leave them out of this check.
            if (_moveAction == null) return false;
            if (_aimGamepadAction == null) return false;
            if (_aimMouseAction == null) return false;
            if (_firePrimaryAction == null) return false;
            // if (_dashAction == null) return false; // Uncomment if Dash is mandatory

            return true;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Movement\AfterImage.cs`
- Lines: 56
- Size: 1.4 KB
- Modified: 2026-01-19 00:23

```csharp
using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Combat; // Required for IDamageable

namespace DarkTowerTron.Gameplay.Player
{
    public class AfterImage : MonoBehaviour, IDamageable
    {
        [Header("Settings")]
        [SerializeField] private float _lifetime = 1f;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _onReturnToPool;

        private float _timer;

        // --- IDamageable Implementation ---

        public bool IsDead => false; // AfterImages don't really "die", they vanish

        public void TakeDamage(DamageInfo info)
        {
            // If an enemy hits the afterimage, we might want to destroy it immediately
            // or play a "poof" sound.
            FinishEffect();
        }

        public void Kill(bool immediate)
        {
            FinishEffect();
        }

        // ----------------------------------

        private void OnEnable()
        {
            _timer = _lifetime;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                FinishEffect();
            }
        }

        private void FinishEffect()
        {
            gameObject.SetActive(false);
            if (_onReturnToPool != null)
                _onReturnToPool.RaiseEvent();
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Movement\PlayerDodge.cs`
- Lines: 193
- Size: 6.3 KB
- Modified: 2026-01-20 14:16

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Systems;
using DarkTowerTron.Systems.Stats;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IAudioService
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerLoadout))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerDodge : MonoBehaviour
    {
        [Header("Audio")]
        public AudioClip dashClip;

        [Header("Visual Indicator")]
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public bool showIndicator = true;

        // State Properties
        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        // Dependencies
        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMotor _movement;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;

        // Service Dependencies
        private IAudioService _audioService;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMotor>();
            _loadout = GetComponent<PlayerLoadout>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // Resolve Services
            _audioService = ServiceLocator.Get<IAudioService>();
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            if (_energy.SpendFocus(_stats.DashCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;
            IsInvulnerable = true;

            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // 1. Gravity Suspension
            _movement.SuspendGravity(_stats.DashDuration + _stats.ActionHangTime);

            // 2. Audio (Service Locator)
            if (_audioService != null && dashClip)
                _audioService.PlaySound(dashClip, transform.position, 1f);

            // 3. Decoy Spawn
            if (_loadout && _loadout.currentDecoy)
                Instantiate(_loadout.currentDecoy, transform.position, transform.rotation);

            // 4. Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f)
                dashDir = _movement.MoveInput.normalized;
            else
                dashDir = transform.forward;

            // 5. Physics Loop
            float speed = _stats.DashDistance / _stats.DashDuration;
            float timer = 0f;

            while (timer < _stats.DashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;

                _mover.Move(dashDir * speed);
                CatchProjectiles();

                yield return null;
            }

            yield return new WaitForSeconds(0.05f);

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            // Reflection Ability Check
            if (_stats == null || !_stats.HasAbility(AbilityType.Dodge_Reflect)) return;

            int layerMask = 1 << GameConstants.LAYER_PROJECTILE;

            // Optimization Note: Consider using Physics.OverlapSphereNonAlloc for zero garbage generation here
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, layerMask);

            foreach (var hit in hits)
            {
                var pScript = hit.GetComponent<Projectile>();
                if (pScript != null && pScript.isHostile)
                {
                    // Weight check (cannot reflect Heavy/Unstoppable)
                    if (pScript.weight == ProjectileWeight.Heavy || pScript.weight == ProjectileWeight.Unstoppable)
                        continue;

                    // Redirect
                    pScript.Redirect(transform.forward, gameObject);

                    // Reward
                    if (_energy) _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (!showIndicator || IsDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;

            // Raycast to find stopping point against walls
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, _stats.DashDistance, GameConstants.MASK_WALLS))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * _stats.DashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            // Visual Feedback (Can we afford it?)
            if (indicatorRenderer && readyMat && notReadyMat)
            {
                bool canAfford = _energy.HasFocus(_stats.DashCost);
                Material targetMat = canAfford ? readyMat : notReadyMat;
                if (indicatorRenderer.sharedMaterial != targetMat)
                {
                    indicatorRenderer.sharedMaterial = targetMat;
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Movement\PlayerMotor.cs`
- Lines: 290
- Size: 9.8 KB
- Modified: 2026-01-18 23:52

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Physics;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    // Intentionally not requiring a specific mover so we can swap implementations.
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerMotor : MonoBehaviour
    {
        [Header("Mover Selection")]
        [Tooltip("If true, attempts to use UnityCharacterMover. If false, uses KinematicMover.")]
        public bool useUnityController = false;

        [Header("Wall Repulsion")]
        public float wallBuffer = 0.6f; // Keep this (Collider size dependency)

        [Header("Safety Net")]
        public float safeGroundTimer = 0.5f; // Time required to be grounded to count as "Safe"
        
        // Read-only property for the Health script to access
        public Vector3 LastSafePosition { get; private set; }

        // Expose input for Blitz
        public Vector3 MoveInput => _inputDir;

        private IMover _mover;
        private Camera _cam;
        private PlayerStats _stats;

        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;
        private float _groundedTimer;
        private float _gravitySuspendTimer = 0f;
        
        // Cache for optimization
        private Collider[] _wallBuffer = new Collider[5];

        private void Awake()
        {
            _cam = Camera.main;
            _stats = GetComponent<PlayerStats>();

            InitializeMover();
        }

        private void Start()
        {
            LastSafePosition = transform.position;
        }

        private void InitializeMover()
        {
            var kMover = GetComponent<KinematicMover>();
            var uMover = GetComponent<UnityCharacterMover>();

            // Disable both initially
            if (kMover) kMover.SetEnabled(false);
            if (uMover) uMover.SetEnabled(false);

            if (useUnityController)
            {
                if (uMover == null) uMover = gameObject.AddComponent<UnityCharacterMover>();
                _mover = uMover;

                // Disable collision on KinematicMover (CapsuleCollider) to avoid double collision
                if (kMover && kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = false;
            }
            else
            {
                if (kMover == null) kMover = gameObject.AddComponent<KinematicMover>();
                _mover = kMover;

                // Re-enable CapsuleCollider
                if (kMover.GetComponent<Collider>())
                    kMover.GetComponent<Collider>().enabled = true;
            }

            _mover?.SetEnabled(true);
            if (_mover != null) GameLogger.Log(LogChannel.Player, $"[PlayerMovement] Using Mover: {_mover.GetType().Name}");
        }

        [ContextMenu("Swap Mover")]
        public void SwapMover()
        {
            useUnityController = !useUnityController;
            InitializeMover();
        }

        public void SetMoveInput(Vector3 dir)
        {
            _inputDir = dir;
        }

        public void LookAtDirection(Vector3 direction)
        {
            direction.y = 0;
            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion targetRot = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, _stats.RotationSpeed * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            // Use UnityEngine.Physics to disambiguate
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, GameConstants.MASK_GROUND_ONLY))
            {
                Vector3 lookDir = hit.point - transform.position;
                LookAtDirection(lookDir);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _externalForce += force;
        }

        private void Update()
        {

            if (_gravitySuspendTimer > 0) _gravitySuspendTimer -= Time.deltaTime;

            HandleVelocity();
            HandleSafeGround();
        }

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target (Inputs)
            Vector3 targetVel = _inputDir * _stats.MoveSpeed;
            Vector3 wallPush = CalculateWallRepulsion();
            targetVel += wallPush;

            // 2. Acceleration
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, _stats.Acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, _stats.Deceleration * dt);
                if (_currentVelocity.magnitude < 0.01f) _currentVelocity = Vector3.zero;
            }

            // 3. External Forces (Recoil/Knockback)
            if (_externalForce.magnitude > 0.1f)
            {
                _externalForce = Vector3.Lerp(_externalForce, Vector3.zero, 5f * dt);
            }
            else
            {
                _externalForce = Vector3.zero;
            }

            // 4. COMBINE (No dt multiplication here!)
            Vector3 finalVelocity = _currentVelocity + _externalForce;

            // --- GRAVITY LOGIC UPDATE ---
            // Only apply gravity if NOT grounded AND NOT suspended
            if (!_mover.IsGrounded && _gravitySuspendTimer <= 0)
            {
                finalVelocity.y -= _stats.Gravity;
            }
            else if (_mover.IsGrounded)
            {
                finalVelocity.y = -2f; // Stick to ground
            }
            else
            {
                // We are in Air + Suspended = Zero Gravity (Hover)
                finalVelocity.y = 0f;
            }
            // ----------------------------

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        // NEW METHOD: Call this when teleporting/respawning
        public void ResetVelocity()
        {
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _inputDir = Vector3.zero; // Optional: Stop input until player presses again
        }

        public void Teleport(Vector3 position)
        {
            // 1. Reset Velocities
            _currentVelocity = Vector3.zero;
            _externalForce = Vector3.zero;
            _gravitySuspendTimer = 0f;

            // 2. Delegate to the Interface (which handles the CC enable/disable safety)
            if (_mover != null)
            {
                _mover.Teleport(position);
            }
            else
            {
                transform.position = position;
            }
        }

        private void HandleSafeGround()
        {
            // STRICT CHECK:
            // 1. Must be physically grounded (Motor check)
            // 2. Must have ground directly beneath center (Raycast check)
            // This prevents saving "The Edge" as a safe spot.
            
            bool isCenterSupported = false;
            
            // Cast from slightly up, downwards. Check GROUND layer only.
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, 2.0f, GameConstants.MASK_GROUND_ONLY))
            {
                isCenterSupported = true;
            }

            if (_mover.IsGrounded && isCenterSupported)
            {
                _groundedTimer += Time.deltaTime;
                if (_groundedTimer > safeGroundTimer)
                {
                    // Save position slightly higher to prevent floor clipping
                    LastSafePosition = transform.position + Vector3.up * 0.2f;
                }
            }
            else
            {
                _groundedTimer = 0f;
            }
        }

        private Vector3 CalculateWallRepulsion()
        {
            Vector3 push = Vector3.zero;

            // CHANGE: Use Constant instead of variable
            int layerMask = GameConstants.MASK_WALLS;

            // Find walls within buffer range
            // We use the player's position + slight up offset (center of mass)
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, _wallBuffer, layerMask);

            for (int i = 0; i < count; i++)
            {
                Collider wall = _wallBuffer[i];

                // Find the closest point on the wall's surface to the player
                Vector3 closestPoint = wall.ClosestPoint(transform.position + Vector3.up);

                // Calculate direction AWAY from wall
                Vector3 dir = (transform.position - closestPoint);
                dir.y = 0; // Keep it flat

                float dist = dir.magnitude;

                // If we are actually inside/touching/near the wall
                if (dist < wallBuffer)
                {
                    // The closer we are, the stronger the push
                    // Normalized push * strength
                    push += dir.normalized * _stats.WallRepulsion;
                }
            }

            return push;
        }

        public void SuspendGravity(float duration)
        {
            _gravitySuspendTimer = duration;

            // CRITICAL: Kill existing downward momentum immediately
            // so we don't carry "falling speed" into the hover.
            if (_externalForce.y < 0) _externalForce.y = 0;
            if (_currentVelocity.y < 0) _currentVelocity.y = 0;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Stats\PlayerEnergy.cs`
- Lines: 115
- Size: 4.2 KB
- Modified: 2026-01-19 00:07

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Access to Event Channels

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Broadcasting")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent; // Replaces OnFocusChanged

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent; // Replaces OnEnemyKilled
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;         // Replaces OnPlayerDied
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;      // Replaces OnWaveCombatStarted
        [SerializeField] private VoidEventChannelSO _waveClearedEvent;        // Replaces OnWaveCleared
        [SerializeField] private VoidEventChannelSO _gameVictoryEvent;        // Replaces OnGameVictory

        private float _currentFocus;
        private bool _isDead;
        private bool _isCombatActive = false; 

        private PlayerStats _stats;

        private void Awake()
        {
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            if (_stats == null) return;
            _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        private void OnEnable()
        {
            // Subscribe to SO Event
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;

            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnPlayerDied;
            if (_combatStartedEvent != null) _combatStartedEvent.OnEventRaised += EnableDecay;
            if (_waveClearedEvent != null) _waveClearedEvent.OnEventRaised += DisableDecay;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised += DisableDecay;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;

            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
            if (_combatStartedEvent != null) _combatStartedEvent.OnEventRaised -= EnableDecay;
            if (_waveClearedEvent != null) _waveClearedEvent.OnEventRaised -= DisableDecay;
            if (_gameVictoryEvent != null) _gameVictoryEvent.OnEventRaised -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            bool shouldBeOverdrive = _currentFocus >= _stats.baseStats.overdriveThreshold;
            _stats.SetOverdrive(shouldBeOverdrive);

            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= _stats.FocusDecayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- PUBLIC API ---
        public bool HasFocus(float amount) => _currentFocus >= amount;

        public bool SpendFocus(float amount)
        {
            if (_currentFocus >= amount)
            {
                _currentFocus -= amount;
                UpdateUI();
                return true;
            }
            return false;
        }

        public void AddFocus(float amount)
        {
            _currentFocus += amount;
            if (_currentFocus > _stats.MaxFocus) _currentFocus = _stats.MaxFocus;
            UpdateUI();
        }

        // --- HANDLERS ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;
            float gain = (stats != null) ? stats.focusReward : _stats.BaseFocusOnKill;
            AddFocus(gain);
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }
        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            // NEW: Raise via Channel
            if (_focusEvent != null) 
                _focusEvent.RaiseEvent(_currentFocus, _stats.MaxFocus);
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Stats\PlayerHealth.cs`
- Lines: 185
- Size: 5.7 KB
- Modified: 2026-01-20 14:13

```csharp
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerDodge))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerHealth : MonoBehaviour, IDamageable, IAimTarget
    {
        [Header("Configuration")]
        public bool startWithHull = true;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget;

        [Header("Juice")]
        [SerializeField] private FeedbackConfigurationSO _damageFeedback;
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

        [Header("Broadcasting")]
        [SerializeField] private IntIntEventChannelSO _gritEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Listening")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;

        // INTERFACE IMPLEMENTATION (Fix for CS0535)
        public bool IsDead => _isDead;

        private PlayerMotor _movement;
        private PlayerDodge _dodge;
        private PlayerStats _stats;

        private void Awake()
        {
            _movement = GetComponent<PlayerMotor>();
            _dodge = GetComponent<PlayerDodge>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            _currentGrit = _stats ? _stats.MaxGrit : 2;
            _hasHull = startWithHull;
            UpdateUI();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        // INTERFACE IMPLEMENTATION (Fix for CS0738)
        // Changed return type from 'bool' to 'void'
        public void TakeDamage(DamageInfo info)
        {
            if (_isDead) return;
            if (_dodge != null && _dodge.IsInvulnerable) return;

            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Taking {dmg} Damage. Grit: {_currentGrit} -> {_currentGrit - dmg}", gameObject);

            if (_currentGrit > 0)
            {
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0;

                _playerHitEvent?.RaiseEvent();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else if (_hasHull)
            {
                _hasHull = false;
                _playerHitEvent?.RaiseEvent();
                _damageFeedback?.Play(gameObject, transform.position);
            }
            else
            {
                Kill(false);
            }

            if (!_isDead && _movement)
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            GameLogger.Log(LogChannel.Player, $"[PlayerHealth] Post-Damage State. Grit: {_currentGrit}, HasHull: {_hasHull}", gameObject);

            UpdateUI();
        }

        public void TakeVoidDamage()
        {
            if (_isDead) return;

            if (_movement)
            {
                _movement.ResetVelocity();
                var motor = GetComponent<KinematicMover>();
                if (motor) motor.Teleport(_movement.LastSafePosition);
                else transform.position = _movement.LastSafePosition;
            }

            // Simulate Environment Damage
            TakeDamage(new DamageInfo { damageAmount = 1f, damageType = DamageType.Environment });
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;

            _deathFeedback?.Play(gameObject, transform.position);

            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();

            GameLogger.Log(LogChannel.Player, "PLAYER DEAD", gameObject);
            _playerDiedEvent?.RaiseEvent();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            int max = _stats ? _stats.MaxGrit : 2;
            _currentGrit = Mathf.Min(_currentGrit + amount, max);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            if (stats != null)
            {
                if (stats.healsGrit)
                {
                    HealGrit(stats.gritRewardAmount);
                }
            }
            else
            {
                HealGrit(1);
            }
        }

        public void ForceUpdateUI() => UpdateUI();

        private void UpdateUI()
        {
            int max = _stats ? _stats.MaxGrit : 2;
            _gritEvent?.RaiseEvent(_currentGrit, max);
            _hullEvent?.RaiseEvent(_hasHull);
        }

        // --- IAimTarget ---
        public Vector3 AimPoint
        {
            get
            {
                if (_aimTarget == null) return transform.position + Vector3.up * 1.2f;
                return _aimTarget.position;
            }
        }
        public float TargetRadius => 0.5f;
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Stats\PlayerLoadout.cs`
- Lines: 37
- Size: 0.9 KB
- Modified: 2026-01-17 12:25

```csharp
using UnityEngine;

namespace DarkTowerTron.Gameplay.Player
{
    public class PlayerLoadout : MonoBehaviour
    {
        [Header("Defaults")]
        public GameObject defaultProjectile;
        public GameObject defaultDecoy;

        [Header("Active Loadout (Debug/Runtime)")]
        public GameObject currentProjectile;
        public GameObject currentDecoy;

        private void Awake()
        {
            // Initialize with defaults on start
            ResetLoadout();
        }

        public void ResetLoadout()
        {
            currentProjectile = defaultProjectile;
            currentDecoy = defaultDecoy;
        }

        public void EquipProjectile(GameObject newPrefab)
        {
            if (newPrefab != null) currentProjectile = newPrefab;
        }

        public void EquipDecoy(GameObject newPrefab)
        {
            if (newPrefab != null) currentDecoy = newPrefab;
        }
    }
}
```

## 📄 `Assets\_Project\Gameplay\Player\Stats\PlayerStats.cs`
- Lines: 173
- Size: 5.7 KB
- Modified: 2026-01-17 12:25

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Systems.Stats; // NEW Namespace

namespace DarkTowerTron.Gameplay.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Configuration")]
        public PlayerStatsSO baseStats; // The Template

        // --- The Dynamic Stats ---
        private Dictionary<StatType, ModifiableStat> _stats = new Dictionary<StatType, ModifiableStat>();
        private HashSet<AbilityType> _unlockedAbilities = new HashSet<AbilityType>();

        // Event for UI (e.g. Health bar needs to grow)
        public event System.Action OnStatsChanged;

        private void Awake()
        {
            InitializeStats();
        }

        private void InitializeStats()
        {
            if (baseStats == null) return;

            // Initialize from SO
            _stats[StatType.MoveSpeed] = new ModifiableStat(baseStats.moveSpeed);
            _stats[StatType.Acceleration] = new ModifiableStat(baseStats.acceleration);
            _stats[StatType.DashCooldown] = new ModifiableStat(baseStats.dashCooldown);
            _stats[StatType.MaxGrit] = new ModifiableStat(baseStats.maxGrit);
            _stats[StatType.GunDamage] = new ModifiableStat(baseStats.gunDamage);
            _stats[StatType.BeamDamage] = new ModifiableStat(baseStats.beamDamage);
            // Add others...
        }

        // --- PUBLIC ACCESSORS (The "Facade") ---
        // Keeps the rest of your code working without changes

        // Scanner
        public float ScanRange => baseStats.scanRange;
        public float ScanRadius => baseStats.scanRadius;

        // Overdrive
        public bool IsOverdrive { get; private set; }

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }

        // --- UPDATED ACCESSORS (With Overdrive Math) ---

        public float MoveSpeed
        {
            get
            {
                float val = GetValue(StatType.MoveSpeed);
                if (IsOverdrive) val *= baseStats.overdriveSpeedMult;
                return val;
            }
        }
        public float Acceleration => GetValue(StatType.Acceleration);
        public float Deceleration => baseStats.deceleration; // Some don't change
        public float RotationSpeed => baseStats.rotationSpeed;
        public float Gravity => baseStats.gravity;
        public float WallRepulsion => baseStats.wallRepulsionForce;
        public float ActionHangTime => baseStats.actionHangTime;

        // Abilities
        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown; // Duration is base; cooldown mods affect frequency
        public float DashCooldown => GetValue(StatType.DashCooldown);

        // Combat
        public float GunDamage
        {
            get
            {
                float val = GetValue(StatType.GunDamage);
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        // Rate is inverted (Lower is Faster)
        public float GunRate
        {
            get
            {
                float val = baseStats.gunFireRate;
                // If Overdrive makes it faster, we DIVIDE the delay
                if (IsOverdrive) val /= baseStats.overdriveFireRateMult;
                return val;
            }
        }
        public int GunStagger => baseStats.gunStagger;

        public float BeamDamage
        {
            get
            {
                float val = GetValue(StatType.BeamDamage);
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        public float BeamRate
        {
            get
            {
                float val = baseStats.beamFireRate;
                if (IsOverdrive) val /= baseStats.overdriveFireRateMult;
                return val;
            }
        }
        public int BeamStagger => baseStats.beamStagger;

        public int MaxGrit => Mathf.RoundToInt(GetValue(StatType.MaxGrit));
        public float MaxFocus => baseStats.maxFocus; // Could mod this
        public float FocusDecayRate => baseStats.focusDecayRate;
        public float BaseFocusOnKill => baseStats.baseFocusOnKill;


        // --- PERK SYSTEM ---

        // Tracks perks applied during the current session/run.
        public List<PerkSO> ActivePerks { get; private set; } = new List<PerkSO>();

        public void ApplyPerk(PerkSO perk)
        {
            if (perk == null) return;

            ActivePerks.Add(perk);

            // 1. Apply Stats
            foreach (var mod in perk.statModifiers)
            {
                if (_stats.TryGetValue(mod.targetStat, out var stat))
                {
                    if (mod.type == ModifierType.Additive) stat.AddModifier(mod.value);
                    else stat.AddMultiplier(mod.value);
                }
            }

            // 2. Unlock Abilities
            foreach (var ability in perk.abilitiesToUnlock)
            {
                _unlockedAbilities.Add(ability);
            }

            OnStatsChanged?.Invoke();
        }

        public bool HasAbility(AbilityType ability)
        {
            return _unlockedAbilities.Contains(ability);
        }

        // Helper
        private float GetValue(StatType type)
        {
            if (_stats.TryGetValue(type, out var stat)) return stat.Value;
            return 0f;
        }

        // Overdrive is handled in accessors above.
    }
}
```

## 📄 `Assets\_Project\Gameplay\Visuals\PaletteReceiver.cs`
- Lines: 124
- Size: 4.2 KB
- Modified: 2026-01-18 23:26

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Visuals;

namespace DarkTowerTron.Gameplay.Visuals
{
    [ExecuteAlways]
    public class PaletteReceiver : MonoBehaviour
    {
        public enum ActorType { Player, Enemy }

        [Header("Configuration")]
        public ActorType actorType = ActorType.Enemy;
        public ActorThemeSO themeOverride;

        [Header("Renderer Bindings")]
        public List<Renderer> primaryRenderers;
        public List<Renderer> secondaryRenderers;
        public List<Renderer> tertiaryRenderers;

        private MaterialPropertyBlock _propBlock;

        private void OnEnable()
        {
            if (TryGetPaletteService(out var service))
            {
                service.OnPaletteChanged += ApplyTheme;
            }
        }

        private void OnDisable()
        {
            if (TryGetPaletteService(out var service))
            {
                service.OnPaletteChanged -= ApplyTheme;
            }
        }

        private void Start() => ApplyTheme();

        public void ManualRefresh() => ApplyTheme();

        private void ApplyTheme()
        {
            if (_propBlock == null) _propBlock = new MaterialPropertyBlock();

            // 1. CASE A: Use Local Override
            if (themeOverride != null)
            {
                ApplySurfaceToList(primaryRenderers, themeOverride.primary);
                ApplySurfaceToList(secondaryRenderers, themeOverride.secondary);
                ApplySurfaceToList(tertiaryRenderers, themeOverride.tertiary);
                return;
            }

            // 2. CASE B: Use Global Service
            if (!TryGetPaletteService(out var service) || service.ActivePalette == null) return;

            var global = service.ActivePalette;

            if (actorType == ActorType.Player)
            {
                ApplySurfaceToList(primaryRenderers, global.playerPrimary);
                ApplySurfaceToList(secondaryRenderers, global.playerSecondary);
                ApplySurfaceToList(tertiaryRenderers, global.playerTertiary);
            }
            else // Enemy
            {
                ApplySurfaceToList(primaryRenderers, global.enemyPrimary);
                ApplySurfaceToList(secondaryRenderers, global.enemySecondary);
                ApplySurfaceToList(tertiaryRenderers, global.enemyTertiary);
            }
        }

        private void ApplySurfaceToList(List<Renderer> rends, SurfaceDefinition surf)
        {
            foreach (var r in rends)
            {
                if (r == null) continue;

                r.GetPropertyBlock(_propBlock);

                // Use the data to populate PropertyBlock
                // Note: We duplicate logic slightly here because PropertyBlocks 
                // use different API than Material.SetColor, but the keys are the same.

                if (HasProp(r, "_BaseColor")) _propBlock.SetColor("_BaseColor", surf.mainColor);
                else if (HasProp(r, "_Color")) _propBlock.SetColor("_Color", surf.mainColor);

                if (HasProp(r, "_EmissionColor")) _propBlock.SetColor("_EmissionColor", surf.emissionColor);

                if (HasProp(r, "_Smoothness")) _propBlock.SetFloat("_Smoothness", surf.smoothness);
                if (HasProp(r, "_Metallic")) _propBlock.SetFloat("_Metallic", surf.metallic);

                r.SetPropertyBlock(_propBlock);
            }
        }

        // Abstraction for Editor vs Runtime retrieval
        private bool TryGetPaletteService(out IPaletteService service)
        {
            // Runtime
            if (ServiceLocator.TryGet(out service)) return true;

            // Editor (Fallback)
            if (!Application.isPlaying)
            {
                service = PaletteService.EditorInstance;
                return service != null;
            }

            service = null;
            return false;
        }

        private bool HasProp(Renderer r, string name)
        {
            if (r.sharedMaterial == null) return false;
            return r.sharedMaterial.HasProperty(name);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Bootstrapper.cs`
- Lines: 28
- Size: 0.7 KB
- Modified: 2026-01-20 18:00

```csharp
using UnityEngine;

namespace DarkTowerTron.Systems
{
    /// <summary>
    /// Attached to the [GlobalSystems] prefab. 
    /// Ensures the GameObject persists between scenes and handles Singleton behavior.
    /// </summary>
    [DefaultExecutionOrder(-100)]
    public class Bootstrapper : MonoBehaviour
    {
        private static bool _exists = false;

        private void Awake()
        {
            if (_exists)
            {
                Destroy(gameObject); // Duplicate detected
                return;
            }

            _exists = true;
            DontDestroyOnLoad(gameObject);

            Debug.Log("<color=cyan>[Bootstrapper]</color> Global Systems Loaded.");
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Debugging\DebugController.cs`
- Lines: 173
- Size: 6.4 KB
- Modified: 2026-01-18 23:52

```csharp
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Core.Patterns; // For IPoolService
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Gameplay.Player; // For PlayerController.Instance
//using DarkTowerTron.Gameplay.Player;
//using DarkTowerTron.Gameplay.Player; // For PlayerLoadout
using DarkTowerTron.Systems.Stats; // For PerkSO
using DarkTowerTron.Systems.GameModes; // For GameSession

namespace DarkTowerTron.Systems.Debugging
{
    public class DebugController : MonoBehaviour
    {
        [Header("Workflow")]
        public bool autoStartGame = false;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _combatStartedEvent;

        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Visualization")]
        public bool showEnemyStats = true;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn;

        [Header("Perk Testing")]
        public PerkSO testPerk1; // Assign Mirror Engine
        public PerkSO testPerk2; // Assign Kinetic Deflector
        public GameObject homingPrefab;
        public GameObject explosiveDecoyPrefab;

        // Cached References
        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private PlayerLoadout _loadout;
        private PlayerStats _stats;
        private IPoolService _poolService;
        private GameSession _session;

        private IEnumerator Start()
        {
            // Wait a frame for Bootstrapper and Scene Init
            yield return null;

            _poolService = ServiceLocator.Get<IPoolService>();
            _session = FindObjectOfType<GameSession>();

            // 1. Auto-Start Logic
            if (autoStartGame && _session != null)
            {
                GameLogger.Log(LogChannel.System, "[DEBUG] Auto-Starting Game...", gameObject);
                _session.BeginGame();
                _combatStartedEvent?.RaiseEvent();
            }

            // 2. Locate Player Logic
            // We use the Singleton Instance we setup earlier
            if (PlayerController.Instance != null)
            {
                var p = PlayerController.Instance;
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
                _loadout = p.GetComponent<PlayerLoadout>();
                _stats = p.GetComponent<PlayerStats>();
            }
        }

        private void Update()
        {
            // Safety check for Input System
            if (Keyboard.current == null) return;

            // Sync debug flag (Ensure DamageReceiver has this static property, or remove this line)
            DamageReceiver.EnableDebugGizmos = showEnemyStats;

            HandleInput();
            ApplyCheats();
        }

        private void HandleInput()
        {
            // [TAB] Toggle Visuals
            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {
                showEnemyStats = !showEnemyStats;
                Debug.Log($"Debug Stats: {showEnemyStats}");
            }

            // [T] Time Control
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                Time.timeScale = (Time.timeScale >= 0.9f) ? 0.1f : 1f;
                GameLogger.Log(LogChannel.System, $"Time Scale: {Time.timeScale}");
            }

            // [K] Kill All Enemies
            if (Keyboard.current.kKey.wasPressedThisFrame)
            {
                var enemies = FindObjectsOfType<EnemyController>();
                foreach (var e in enemies) e.Kill(true);
                GameLogger.Log(LogChannel.Combat, "Nuke Triggered.");
            }

            // [R] Recharge Stats
            if (Keyboard.current.rKey.wasPressedThisFrame && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // [NumPad 1-4] Spawning
            if (Keyboard.current.numpad1Key.wasPressedThisFrame) Spawn(0);
            if (Keyboard.current.numpad2Key.wasPressedThisFrame) Spawn(1);
            if (Keyboard.current.numpad3Key.wasPressedThisFrame) Spawn(2);
            if (Keyboard.current.numpad4Key.wasPressedThisFrame) Spawn(3);

            // [H / J] Perk Testing
            if (Keyboard.current.hKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipProjectile(homingPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Homing Projectile");
            }

            if (Keyboard.current.jKey.wasPressedThisFrame && _loadout)
            {
                _loadout.EquipDecoy(explosiveDecoyPrefab);
                GameLogger.Log(LogChannel.Player, "Equipped Explosive Decoy");
            }

            // [P / O] Apply Perks
            if (Keyboard.current.pKey.wasPressedThisFrame && _stats && testPerk1)
            {
                _stats.ApplyPerk(testPerk1);
                GameLogger.Log(LogChannel.System, $"Applied Perk: {testPerk1.perkName}");
            }

            if (Keyboard.current.oKey.wasPressedThisFrame && _stats && testPerk2)
            {
                _stats.ApplyPerk(testPerk2);
                GameLogger.Log(LogChannel.System, $"Applied Perk: {testPerk2.perkName}");
            }
        }

        private void ApplyCheats()
        {
            if (infiniteFocus && _energy) _energy.AddFocus(100f * Time.deltaTime);
            if (godMode && _health) _health.HealGrit(100); // Constant heal
        }

        private void Spawn(int index)
        {
            if (enemiesToSpawn == null || index < 0 || index >= enemiesToSpawn.Length) return;
            if (_poolService == null) return;

            // Simple random spawn around player (or zero if no player)
            Vector3 center = PlayerController.Instance ? PlayerController.Instance.transform.position : Vector3.zero;
            Vector3 spawnPos = center + Random.insideUnitSphere * 5f;
            spawnPos.y = 0; // Reset height (Motors will handle hovering)

            _poolService.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\GameModes\GameSession.cs`
- Lines: 188
- Size: 5.7 KB
- Modified: 2026-01-18 12:40

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Physics; // For UnityCharacterMover
using DarkTowerTron.Gameplay.Environment; // For PlayerStart
using DarkTowerTron.Gameplay.Player; // For PlayerController
using DarkTowerTron.Systems.UI;

namespace DarkTowerTron.Systems.GameModes
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

            // Access the PlayerStart registry (Core/Environment)
            Transform targetPoint = PlayerStart.GetSpawnPoint(activeSpawnID);
            if (targetPoint == null)
            {
                Debug.LogWarning($"[GameSession] Spawn Point '{activeSpawnID}' not found!");
                return;
            }

            // Robust Teleport Logic
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
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Level\LevelPrewarmer.cs`
- Lines: 41
- Size: 1.2 KB
- Modified: 2026-01-18 15:47

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Systems.Level
{
    public class LevelPrewarmer : MonoBehaviour
    {
        [System.Serializable]
        public struct PoolRequest
        {
            public GameObject prefab;
            public int count;
        }

        [Tooltip("List of objects to instantiate immediately when the level starts to prevent lag later.")]
        public List<PoolRequest> prewarmList;

        private void Start()
        {
            // 1. Get the Pool Service
            var poolService = ServiceLocator.Get<IPoolService>();

            if (poolService == null)
            {
                Debug.LogWarning("[LevelPrewarmer] PoolService not found. Skipping prewarm.");
                return;
            }

            // 2. Execute Requests
            foreach (var req in prewarmList)
            {
                if (req.prefab != null && req.count > 0)
                {
                    poolService.Prewarm(req.prefab, req.count);
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Level\LevelSystem.cs`
- Lines: 52
- Size: 1.3 KB
- Modified: 2026-01-18 23:52

```csharp
using System.Collections.Generic;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Gameplay.Environment;
using UnityEngine;

namespace DarkTowerTron.Systems.Level
{
    [ExecuteInEditMode]
    public class LevelSystem: MonoBehaviour
    {
        [Header("Build Configuration")]
        public List<Zone> rooms;

        [Header("Actions")]
        public bool snapNow = false;

        private void Update()
        {
            if (snapNow)
            {
                snapNow = false;
                SnapRooms();
            }
        }

        public void SnapRooms()
        {
            if (rooms == null || rooms.Count == 0) return;

            Vector3 nextPosition = Vector3.zero;

            foreach (var room in rooms)
            {
                if (room == null) continue;

                room.transform.position = nextPosition;

                if (room.ExitPoint != null)
                {
                    nextPosition = room.ExitPoint.position;
                }
                else
                {
                    nextPosition += new Vector3(0, 0, 50);
                }
            }

            // FIX: Use LogChannel.System instead of string
            GameLogger.Log(LogChannel.System, $"[LevelBuilder] Aligned {rooms.Count} Zones.");
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Narrative\NarrativeDirector.cs`
- Lines: 166
- Size: 6.3 KB
- Modified: 2026-01-19 00:07

```csharp
using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;      // For ServiceLocator
using DarkTowerTron.Systems.Persistence; // For IPersistenceService
using DarkTowerTron.Gameplay.Player;     // For PlayerController
using DarkTowerTron.Core.Debugging;          // For GameLogger

namespace DarkTowerTron.Systems.Narrative
{
    public class NarrativeDirector : MonoBehaviour
    {
        [Header("Data")]
        public NarrativeLibrarySO library;
        [SerializeField] private NarrativeEventChannelSO _narrativeOutput; // Terminal UI
        [SerializeField] private PopupTextEventChannelSO _popupEvent;      // World Space UI

        [Header("Triggers")]
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _waveCombatStartedEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        [Header("Settings")]
        [Tooltip("Minimum seconds between messages to avoid spam.")]
        public float spamCooldown = 3.0f;

        [Range(0f, 1f)]
        public float worldTextChance = 0.5f;

        private float _lastMessageTime;
        private float _currentCorruption = 0f;

        private void Start()
        {
            // 1. Calculate Corruption from Save Data
            CalculateCorruption();

            // 2. Boot Message
            if (library != null && library.introLines != null && library.introLines.Count > 0)
            {
                // Intro is high priority, no world position
                Publish(library.GetRandomLine(library.introLines), null, 10f);
            }
            else
            {
                GameLogger.LogWarning(LogChannel.System, "[NarrativeDirector] No Library or Intro Lines assigned!", gameObject);
            }
        }

        private void OnEnable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised += OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
        }

        private void OnDisable()
        {
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHurt;
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_waveCombatStartedEvent) _waveCombatStartedEvent.OnEventRaised -= OnCombatStart;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
        }

        private void CalculateCorruption()
        {
            // NEW: Get Persistence via Service Locator
            var persistence = ServiceLocator.Get<IPersistenceService>();

            if (persistence != null && persistence.CurrentData != null)
            {
                var data = persistence.CurrentData;

                // Formula: Each death adds 5% corruption. Each run adds 1%.
                float deathFactor = data.totalDeaths * 0.05f;
                float runFactor = data.totalRuns * 0.01f;

                _currentCorruption = Mathf.Clamp01(deathFactor + runFactor);

                GameLogger.Log(LogChannel.System, $"[Narrative] Corruption Level: {_currentCorruption:P0}", gameObject);
            }
            else
            {
                // Default if no save found yet
                _currentCorruption = 0f;
            }
        }

        /// <summary>
        /// Publishes text to Terminal and optionally to World Space.
        /// </summary>
        private void Publish(string rawText, Vector3? worldPos = null, float priorityBonus = 0f)
        {
            // Rate Limiting (unless priority is high)
            if (Time.time < _lastMessageTime + (spamCooldown - priorityBonus)) return;

            // Apply glitch effects based on corruption
            string finalString = TextCorruptor.Corrupt(rawText, _currentCorruption);

            // 1. Send to Terminal (Always)
            _narrativeOutput?.RaiseEvent(finalString, 3.0f);

            // 2. Send to World (If position provided and RNG passes)
            if (worldPos.HasValue && _popupEvent != null)
            {
                if (Random.value < worldTextChance)
                    _popupEvent.RaiseEvent(worldPos.Value, finalString);
            }

            _lastMessageTime = Time.time;
        }

        [ContextMenu("DEBUG: Test Message")]
        public void DebugTestMessage()
        {
            Publish("System Diagnostic: INTEGRITY_FAIL // [0x00A1]", null);
        }

        // --- HANDLERS ---

        private void OnCombatStart()
        {
            if (library == null) return;
            Publish(library.GetRandomLine(library.introLines), null, 10f); // High priority
        }

        private void OnPlayerHurt()
        {
            if (Random.value > 0.7f) // Don't talk every hit (30% chance)
            {
                if (library == null) return;

                // NEW: Use PlayerController Singleton instead of Global.Player
                Vector3 playerPos = Vector3.zero;
                if (PlayerController.Instance != null)
                    playerPos = PlayerController.Instance.transform.position + Vector3.up * 2f;

                Publish(library.GetRandomLine(library.hurtLines), playerPos);
            }
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (reward && Random.value > 0.8f) // 20% chance on kill
            {
                if (library == null) return;

                // Show over Dead Enemy's position
                Publish(library.GetRandomLine(library.killLines), pos + Vector3.up);
            }
        }

        private void OnPlayerDied()
        {
            // Force message
            if (library == null) return;

            // Higher corruption for death message (glitchier)
            string text = TextCorruptor.Corrupt(library.GetRandomLine(library.deathLines), _currentCorruption + 0.2f);

            _narrativeOutput?.RaiseEvent(text, 5.0f);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Narrative\NarrativeLibrarySO.cs`
- Lines: 22
- Size: 0.8 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Narrative
{
    [CreateAssetMenu(fileName = "Narrative_Default", menuName = "DarkTowerTron/Narrative/Library")]
    public class NarrativeLibrarySO : ScriptableObject
    {
        [Header("Contexts")]
        public List<string> introLines;      // Level Start
        public List<string> hurtLines;       // Player Hit
        public List<string> killLines;       // Enemy Killed
        public List<string> deathLines;      // Player Died
        public List<string> victoryLines;    // Level End

        public string GetRandomLine(List<string> source)
        {
            if (source == null || source.Count == 0) return "...";
            return source[Random.Range(0, source.Count)];
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Narrative\TextCorruptor.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2026-01-10 16:07

```csharp
using System.Text;
using UnityEngine;

namespace DarkTowerTron.Systems.Narrative
{
    public static class TextCorruptor
    {
        private static char[] _glitchChars = new char[] { '$', '#', '%', '&', '!', '?', '0', '1', 'X' };

        public static string Corrupt(string input, float corruptionLevel)
        {
            if (string.IsNullOrEmpty(input)) return "";
            if (corruptionLevel <= 0) return input;

            StringBuilder sb = new StringBuilder(input);
            int length = sb.Length;

            // 1. Character Replacement (Light Corruption)
            int charsToReplace = Mathf.FloorToInt(length * corruptionLevel * 0.5f);
            for (int i = 0; i < charsToReplace; i++)
            {
                int index = Random.Range(0, length);
                if (sb[index] == ' ') continue; // Don't replace spaces usually
                sb[index] = _glitchChars[Random.Range(0, _glitchChars.Length)];
            }

            // 2. Redaction (Heavy Corruption)
            // If corruption is > 0.5, block out whole words
            if (corruptionLevel > 0.5f)
            {
                // Simple logic: insert [ERR] randomly
                if (Random.value < corruptionLevel)
                {
                    sb.Append(" [FATAL_ERR]");
                }
            }

            // 3. Zalgo/Hex (Extreme Corruption)
            if (corruptionLevel > 0.8f)
            {
                // Hex dump style
                return $"0x{Random.Range(1000, 9999)} // {sb.ToString()}";
            }

            return sb.ToString();
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Persistence\Editor\PersistenceServiceEditor.cs`
- Lines: 53
- Size: 1.9 KB
- Modified: 2026-01-20 14:26

```csharp
using UnityEngine;
using UnityEditor;

namespace DarkTowerTron.Systems.Persistence
{
    [CustomEditor(typeof(PersistenceService))]
    public class PersistenceServiceEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            // Draw the default Inspector (Script field, Current Slot Index)
            DrawDefaultInspector();

            // Cast the target to the correct type
            PersistenceService manager = (PersistenceService)target; // Renamed variable to match your logic

            GUILayout.Space(10);

            // --- The Magic Button ---
            if (GUILayout.Button("📂 Open Save Folder", GUILayout.Height(30)))
            {
                OpenSaveFolder();
            }

            // --- Debug Controls ---
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Save Now"))
            {
                manager.Save();
            }
            if (GUILayout.Button("Load Now"))
            {
                // We need access to the private field _currentSlotIndex logic via public API 
                // Since _currentSlotIndex is serialized, we can read it, or just reload current.
                // Assuming Load() handles internal state:

                // Hack: If you can't access CurrentSlotIndex property, 
                // you might need to make it public or SerializeField exposes it.
                // Assuming the serialized field is editable in inspector:
                SerializedProperty slotProp = serializedObject.FindProperty("_currentSlotIndex");
                manager.Load(slotProp.intValue);
            }
            GUILayout.EndHorizontal();
        }

        private void OpenSaveFolder()
        {
            string path = Application.persistentDataPath;
            path = path.Replace(@"/", @"\"); // Windows friendly
            EditorUtility.RevealInFinder(path);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Persistence\IPersistenceService.cs`
- Lines: 17
- Size: 0.4 KB
- Modified: 2026-01-18 19:05

```csharp
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Persistence
{
    public interface IPersistenceService : IGameService
    {
        SaveData CurrentData { get; }

        void Save();
        void Load(int slotIndex);
        void DeleteSave();

        // Helper to modify data easily
        void RecordRunStart();
        void RecordDeath();
    }
}
```

## 📄 `Assets\_Project\Systems\Persistence\PersistenceService.cs`
- Lines: 129
- Size: 3.9 KB
- Modified: 2026-01-20 18:30

```csharp
using UnityEngine;
using System.IO;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Services; // Access ServiceLocator

namespace DarkTowerTron.Systems.Persistence
{
    public class PersistenceService : MonoBehaviour, IPersistenceService
    {
        private const string SAVE_FILE_PREFIX = "save_slot_";
        private const string EXTENSION = ".json";

        public SaveData CurrentData { get; private set; }

        // We can expose this if we want a UI to change slots later
        [SerializeField] private int _currentSlotIndex = 0;

        private void Awake()
        {
            ServiceLocator.Register<IPersistenceService>(this);
            Load(_currentSlotIndex);
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IPersistenceService>(this);
            Save();
        }

        private void OnApplicationQuit() => Save();

        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus) Save();
        }

        // --- IPersistenceService Implementation ---

        public void Load(int slotIndex)
        {
            _currentSlotIndex = slotIndex;
            string path = GetPath(slotIndex);

            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    CurrentData = JsonUtility.FromJson<SaveData>(json);
                    GameLogger.Log(LogChannel.System, $"[Persistence] Loaded Slot {slotIndex}", gameObject);
                }
                catch (System.Exception e)
                {
                    GameLogger.LogError(LogChannel.System, $"[Persistence] Slot {slotIndex} corrupted. Resetting. Error: {e.Message}", gameObject);
                    CreateNewSave();
                }
            }
            else
            {
                GameLogger.Log(LogChannel.System, $"[Persistence] Slot {slotIndex} not found. Creating new.", gameObject);
                CreateNewSave();
            }
        }

        public void Save()
        {
            if (CurrentData == null) CurrentData = new SaveData();
            CurrentData.lastPlayedDate = System.DateTime.Now.ToString();

            try
            {
                string path = GetPath(_currentSlotIndex);
                string json = JsonUtility.ToJson(CurrentData, true);
                File.WriteAllText(path, json);

#if UNITY_EDITOR
                // Reduce spam in Editor
                // GameLogger.Log(LogChannel.System, $"Saved to Slot {_currentSlotIndex}", gameObject);
#endif
            }
            catch (System.Exception e)
            {
                GameLogger.LogError(LogChannel.System, $"[Persistence] Failed to save: {e.Message}", gameObject);
            }
        }

        public void DeleteSave()
        {
            string path = GetPath(_currentSlotIndex);
            if (File.Exists(path))
            {
                File.Delete(path);
                GameLogger.Log(LogChannel.System, $"[Persistence] Deleted Slot {_currentSlotIndex}", gameObject);
                CreateNewSave();
            }
        }

        public void RecordRunStart()
        {
            if (CurrentData != null)
            {
                CurrentData.totalRuns++;
                Save();
            }
        }

        public void RecordDeath()
        {
            if (CurrentData != null)
            {
                CurrentData.totalDeaths++;
                Save();
            }
        }

        // --- Helpers ---

        private void CreateNewSave()
        {
            CurrentData = new SaveData();
            Save();
        }

        private string GetPath(int index)
        {
            return Path.Combine(Application.persistentDataPath, $"{SAVE_FILE_PREFIX}{index}{EXTENSION}");
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Persistence\SaveData.cs`
- Lines: 42
- Size: 1.2 KB
- Modified: 2026-01-18 19:07

```csharp
using System;
using System.Collections.Generic; // Added for Lists if needed later

namespace DarkTowerTron.Systems.Persistence
{
    [Serializable]
    public class SaveData
    {
        // --- Header ---
        public string lastPlayedDate;
        public string version = "0.1";

        // --- Narrative Stats (The "Corruption") ---
        public int totalRuns;
        public int totalDeaths;
        public int totalKills;
        public float totalDamageDealt;

        // --- Progression ---
        public int highestWaveReached;
        public bool hasSeenTutorial;

        // --- Inventory / Unlocks (Added for future proofing) ---
        public List<string> unlockedWeapons = new List<string>();

        // --- Settings ---
        public float masterVolume = 1.0f;

        // Constructor
        public SaveData()
        {
            lastPlayedDate = DateTime.Now.ToString();
            totalRuns = 0;
            totalDeaths = 0;
            totalKills = 0;
            totalDamageDealt = 0;
            highestWaveReached = 0;
            hasSeenTutorial = false;
            unlockedWeapons = new List<string>();
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Persistence\StatsTracker.cs`
- Lines: 72
- Size: 2.6 KB
- Modified: 2026-01-18 19:08

```csharp
using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Access ServiceLocator

namespace DarkTowerTron.Systems.Persistence
{
    /// <summary>
    /// Listens to gameplay events and updates the persistent SaveData.
    /// Place this on the same GameObject as PersistenceService in the Bootstrapper.
    /// </summary>
    public class StatsTracker : MonoBehaviour
    {
        [Header("Listening To")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private DamageTextEventChannelSO _damageEvent;

        // Dependency
        private IPersistenceService _persistence;

        private void Start()
        {
            // Resolve dependency via Locator
            _persistence = ServiceLocator.Get<IPersistenceService>();

            if (_persistence == null)
                Debug.LogError("[StatsTracker] Persistence Service not found!");
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised += OnDamageDealt;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised -= OnDamageDealt;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (!reward || _persistence?.CurrentData == null) return;
            _persistence.CurrentData.totalKills++;
        }

        private void OnPlayerDied()
        {
            if (_persistence?.CurrentData == null) return;

            // Use the helper methods or modify directly
            _persistence.RecordDeath();
            // Note: RecordDeath already increments totalDeaths and Saves.

            // If you want to increment Runs on death:
            // _persistence.CurrentData.totalRuns++;
            // _persistence.Save();
        }

        private void OnDamageDealt(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (!isStagger && _persistence?.CurrentData != null)
            {
                _persistence.CurrentData.totalDamageDealt += amount;
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Score\IScoreService.cs`
- Lines: 23
- Size: 0.6 KB
- Modified: 2026-01-20 13:59

```csharp
using System;
using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Score
{
    public interface IScoreService : IGameService
    {
        // State Properties
        int TotalScore { get; }
        int CurrentMultiplier { get; }
        float GameTime { get; } // Fixes CS1061 in ResultScreen/HUD

        // Events
        event Action<int, int> OnScoreChanged;

        // Methods
        void AddScore(int amount);
        void AddScore(int amount, Vector3 position); // Fixes CS1501 in PlayerExecution
        void ResetScore();
        void StopTracking(); // Fixes CS1061 in ResultScreen
    }
}
```

## 📄 `Assets\_Project\Systems\Score\ScoreService.cs`
- Lines: 133
- Size: 3.7 KB
- Modified: 2026-01-20 18:31

```csharp
using System;
using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Debugging;

namespace DarkTowerTron.Systems.Score
{
    public class ScoreService : MonoBehaviour, IScoreService
    {
        [Header("Listening (Inputs)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;

        [Header("Broadcasting (Outputs)")]
        [SerializeField] private IntIntEventChannelSO _uiScoreEvent;

        [Header("Settings")]
        [SerializeField] private int _baseScorePerKill = 100;
        [SerializeField] private int _maxMultiplier = 5;

        // --- IScoreService Implementation ---
        public int TotalScore { get; private set; }
        public int CurrentMultiplier { get; private set; } = 1;
        public float GameTime { get; private set; } // Implemented Timer

        public event Action<int, int> OnScoreChanged;

        // Internal State
        private bool _isTracking = false;

        // --- Lifecycle ---

        private void Awake()
        {
            ServiceLocator.Register<IScoreService>(this);
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IScoreService>(this);
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;

            // Auto-start on scene load
            ResetScore();
            _isTracking = true;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking)
            {
                GameTime += Time.deltaTime;
            }
        }

        // --- Methods ---

        public void AddScore(int amount)
        {
            if (!_isTracking) return;

            TotalScore += amount;
            NotifyChange();
        }

        public void AddScore(int amount, Vector3 position)
        {
            // Simple overload redirection
            AddScore(amount);
        }

        public void ResetScore()
        {
            TotalScore = 0;
            CurrentMultiplier = 1;
            GameTime = 0f;
            _isTracking = true;
            NotifyChange();
        }

        public void StopTracking()
        {
            _isTracking = false;
        }

        // --- Internal Logic ---

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer || !_isTracking) return;

            int scoreValue = (stats != null) ? stats.scoreValue : _baseScorePerKill;

            // Add Score with Multiplier
            AddScore(scoreValue * CurrentMultiplier);

            // Increment Multiplier
            if (CurrentMultiplier < _maxMultiplier)
            {
                CurrentMultiplier++;
                NotifyChange();
            }
        }

        private void OnPlayerHit()
        {
            if (CurrentMultiplier > 1)
            {
                CurrentMultiplier = 1;
                NotifyChange();
            }
        }

        private void NotifyChange()
        {
            OnScoreChanged?.Invoke(TotalScore, CurrentMultiplier);
            _uiScoreEvent?.RaiseEvent(TotalScore, CurrentMultiplier);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Stats\ModifiableStat.cs`
- Lines: 62
- Size: 1.5 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using System;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [Serializable]
    public class ModifiableStat
    {
        [SerializeField] private float _baseValue;
        private float _additiveMod = 0f;
        private float _multiplicativeMod = 1f;

        // Cache the result to avoid math every frame
        private float _cachedValue;
        private bool _isDirty = true;

        public float BaseValue
        {
            get => _baseValue;
            set { _baseValue = value; _isDirty = true; }
        }

        public ModifiableStat(float baseValue)
        {
            _baseValue = baseValue;
        }

        public float Value
        {
            get
            {
                if (_isDirty)
                {
                    _cachedValue = (_baseValue + _additiveMod) * _multiplicativeMod;
                    _isDirty = false;
                }
                return _cachedValue;
            }
        }

        public void AddModifier(float amount)
        {
            _additiveMod += amount;
            _isDirty = true;
        }

        public void AddMultiplier(float amount)
        {
            // E.g. +0.1 (10%) makes mult 1.1
            _multiplicativeMod += amount;
            _isDirty = true;
        }

        public void Reset()
        {
            _additiveMod = 0f;
            _multiplicativeMod = 1f;
            _isDirty = true;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Stats\PerkDatabaseSO.cs`
- Lines: 32
- Size: 1.0 KB
- Modified: 2026-01-10 16:21

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [CreateAssetMenu(fileName = "DB_AllPerks", menuName = "DarkTowerTron/Stats/Perk Database")]
    public class PerkDatabaseSO : ScriptableObject
    {
        public List<PerkSO> commonPerks;
        public List<PerkSO> rarePerks;

        // Helper to get random cards
        public List<PerkSO> GetRandomHand(int count)
        {
            List<PerkSO> hand = new List<PerkSO>();
            List<PerkSO> pool = new List<PerkSO>(commonPerks);

            // Simple logic: Add rares if lucky (50% chance to include rares in the pool)
            if (Random.value > 0.5f) pool.AddRange(rarePerks);

            for (int i = 0; i < count; i++)
            {
                if (pool.Count == 0) break;

                int idx = Random.Range(0, pool.Count);
                hand.Add(pool[idx]);
                pool.RemoveAt(idx); // Prevent duplicates in same hand
            }
            return hand;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Stats\PerkSO.cs`
- Lines: 26
- Size: 0.7 KB
- Modified: 2026-01-10 16:07

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [System.Serializable]
    public struct StatModifier
    {
        public StatType targetStat;
        public ModifierType type;
        public float value;
    }

    [CreateAssetMenu(fileName = "NewPerk", menuName = "DarkTowerTron/Stats/Perk Definition")]
    public class PerkSO : ScriptableObject
    {
        [Header("UI")]
        public string perkName;
        [TextArea] public string description;
        public Sprite icon;

        [Header("Effects")]
        public List<StatModifier> statModifiers;
        public List<AbilityType> abilitiesToUnlock;
    }
}
```

## 📄 `Assets\_Project\Systems\Stats\StatEnums.cs`
- Lines: 28
- Size: 0.6 KB
- Modified: 2026-01-10 16:15

```csharp
namespace DarkTowerTron.Systems.Stats
{
    public enum StatType
    {
        MoveSpeed,
        Acceleration,
        DashCooldown,
        MaxGrit,
        GunDamage,
        BeamDamage,
        // Add more here as needed (e.g., FireRate, Luck)
    }

    public enum AbilityType
    {
        None,
        Dodge_Reflect,         // Mirror Engine
        Melee_Parry,           // Kinetic Deflector
        Dodge_ExplosiveDecoy,  // (Future)
        Passive_HoverDrive     // (Future)
    }

    public enum ModifierType
    {
        Additive,       // +1 Damage
        Multiplicative  // +10% Speed
    }
}
```

## 📄 `Assets\_Project\Systems\TimeManagement\ITimeService.cs`
- Lines: 10
- Size: 0.2 KB
- Modified: 2026-01-18 23:42

```csharp
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.TimeManagement
{
    public interface ITimeService : IGameService
    {
        void HitStop(float duration);
        void SetTimeScale(float scale);
    }
}
```

## 📄 `Assets\_Project\Systems\TimeManagement\TimeService.cs`
- Lines: 36
- Size: 1.1 KB
- Modified: 2026-01-18 23:42

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.TimeManagement
{
    public class TimeService : MonoBehaviour, ITimeService
    {
        private Coroutine _hitStopCoroutine;

        public void SetTimeScale(float scale)
        {
            Time.timeScale = scale;
        }

        public void HitStop(float duration)
        {
            // Prevent HitStop if game is totally paused via Menu
            if (Time.timeScale == 0) return;

            if (_hitStopCoroutine != null) StopCoroutine(_hitStopCoroutine);
            _hitStopCoroutine = StartCoroutine(HitStopRoutine(duration));
        }

        private IEnumerator HitStopRoutine(float duration)
        {
            float originalScale = Time.timeScale;
            Time.timeScale = 0.001f; // Almost zero (better than 0 for some physics calculations)
            
            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = originalScale;
            _hitStopCoroutine = null;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\ActivePerksPanel.cs`
- Lines: 62
- Size: 1.8 KB
- Modified: 2026-01-18 19:15

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Gameplay.Player; // Access PlayerController & PlayerStats

namespace DarkTowerTron.Systems.UI
{
    public class ActivePerksPanel : MonoBehaviour
    {
        public GameObject iconPrefab;
        public Transform container;

        private PlayerStats _cachedStats;

        private void Start()
        {
            // Wait for Player to be registered (Singleton access)
            if (PlayerController.Instance != null)
            {
                _cachedStats = PlayerController.Instance.GetComponent<PlayerStats>();

                if (_cachedStats != null)
                {
                    _cachedStats.OnStatsChanged += RefreshUI;
                    RefreshUI(); // Initial state
                }
            }
        }

        private void OnDestroy()
        {
            // Good practice: Unsubscribe to avoid errors when changing scenes
            if (_cachedStats != null)
            {
                _cachedStats.OnStatsChanged -= RefreshUI;
            }
        }

        private void RefreshUI()
        {
            // Safety Check
            if (_cachedStats == null) return;

            // 1. Clear old icons
            foreach (Transform child in container) Destroy(child.gameObject);

            // 2. Rebuild list
            foreach (var perk in _cachedStats.ActivePerks)
            {
                if (perk == null) continue;

                GameObject obj = Instantiate(iconPrefab, container);

                // Assuming PerkIconUI is a simple script that sets an Image/Text
                var iconUI = obj.GetComponent<PerkIconUI>();
                if (iconUI != null)
                {
                    iconUI.Setup(perk);
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\AnnouncementUI.cs`
- Lines: 44
- Size: 1.2 KB
- Modified: 2026-01-24 11:06

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class AnnouncementUI : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private StringEventChannelSO _announcementEvent;

        [Header("UI")]
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private CanvasGroup _canvasGroup;

        private void Awake()
        {
            if (_canvasGroup) _canvasGroup.alpha = 0;
        }

        private void OnEnable()
        {
            if (_announcementEvent) _announcementEvent.OnEventRaised += ShowAnnouncement;
        }

        private void OnDisable()
        {
            if (_announcementEvent) _announcementEvent.OnEventRaised -= ShowAnnouncement;
        }

        private void ShowAnnouncement(string text)
        {
            if (_text) _text.text = text;

            // Sequence: Fade In -> Wait -> Fade Out
            _canvasGroup.DOKill();
            Sequence seq = DOTween.Sequence();
            seq.Append(_canvasGroup.DOFade(1f, 0.5f));
            seq.AppendInterval(2.5f);
            seq.Append(_canvasGroup.DOFade(0f, 0.5f));
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\CountdownUI.cs`
- Lines: 94
- Size: 3.2 KB
- Modified: 2026-01-24 15:32

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("Listening")]
        [Tooltip("Receives strings like 'Wave 1' or 'BOSS FIGHT'")]
        [SerializeField] private StringEventChannelSO _announceEvent;

        [Tooltip("Receives countdown strings like '3', '2', '1', ''")]
        [SerializeField] private StringEventChannelSO _countdownEvent;

        [Header("UI References")]
        public TextMeshProUGUI waveTitleText;
        public TextMeshProUGUI countdownText;

        [Header("Settings")]
        [SerializeField] private float _titleDuration = 3f; // How long title stays visible

        private void Awake()
        {
            // Reset State
            if (waveTitleText)
            {
                waveTitleText.alpha = 0f;
                waveTitleText.gameObject.SetActive(false);
            }
            if (countdownText)
            {
                countdownText.text = "";
                countdownText.gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            if (_announceEvent != null) _announceEvent.OnEventRaised += ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised += UpdateCountdown;
        }

        private void OnDisable()
        {
            if (_announceEvent != null) _announceEvent.OnEventRaised -= ShowWaveTitle;
            if (_countdownEvent != null) _countdownEvent.OnEventRaised -= UpdateCountdown;
        }

        private void ShowWaveTitle(string titleText)
        {
            if (waveTitleText)
            {
                // Reset State
                waveTitleText.DOKill();
                waveTitleText.gameObject.SetActive(true);
                waveTitleText.text = titleText;

                // Animation Sequence: Pop In -> Wait -> Fade Out
                waveTitleText.transform.localScale = Vector3.zero;
                waveTitleText.alpha = 1f;

                Sequence seq = DOTween.Sequence();
                seq.Append(waveTitleText.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack));
                seq.AppendInterval(_titleDuration);
                seq.Append(waveTitleText.DOFade(0f, 0.5f));
                seq.OnComplete(() => waveTitleText.gameObject.SetActive(false));
            }
        }

        private void UpdateCountdown(string text)
        {
            if (countdownText)
            {
                // Logic: Empty string means "Hide/Done"
                if (string.IsNullOrEmpty(text))
                {
                    countdownText.gameObject.SetActive(false);
                    return;
                }

                // Ensure Active
                countdownText.gameObject.SetActive(true);
                countdownText.text = text;

                // Punch Animation
                countdownText.transform.DOKill(); // Stop previous punch
                countdownText.transform.localScale = Vector3.one;
                countdownText.transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\DamageTextManager.cs`
- Lines: 119
- Size: 4.3 KB
- Modified: 2026-01-18 19:28

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Systems.UI
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Setup")]
        public GameObject textPrefab;

        [Header("Damage Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0);
        public Color healthColor = Color.white;
        public Color critColor = Color.yellow;
        public Color staggerColor = Color.cyan; // Distinct color for Stagger Damage

        [Header("Narrative Settings")]
        public Color narrativeColor = new Color(1f, 0.5f, 0f); // Orange
        [Tooltip("Words to inject via the Popup channel")]
        public List<string> barks = new List<string> { "WHAM!", "CRUNCH!", "ERROR", "VOID" };

        // Dependencies
        private IPoolService _poolService;

        private void Start()
        {
            // Cache the service because damage text happens frequently
            _poolService = ServiceLocator.Get<IPoolService>();
        }

        private void OnEnable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised += ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised += ShowPopup;
        }

        private void OnDisable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised -= ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (textPrefab == null || _poolService == null) return;

            // 1. Determine Appearance
            Color finalColor;
            float finalScale;
            string text;
            bool isDramatic = isCrit;

            if (isStagger)
            {
                finalColor = staggerColor;
                finalScale = 0.8f; // Stagger numbers slightly smaller
                text = amount.ToString("N0"); // e.g. "5"
            }
            else
            {
                finalColor = isCrit ? critColor : healthColor;
                finalScale = isCrit ? 1.5f : 1.0f;
                text = amount.ToString("N0");
            }

            // 2. Spawn & Init
            SpawnText(pos, text, finalColor, finalScale, isDramatic);
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            // If the message is a keyword like "BARK", pick a random narrative word
            if (message == "BARK" && barks.Count > 0)
            {
                message = barks[Random.Range(0, barks.Count)];
                SpawnText(pos, message, narrativeColor, 1.3f, true); // Dramatic!
            }
            else
            {
                // Logic: If the message contains spaces, it's likely a sentence (Narrative).
                // If it's one word (STAGGER, REFLECT), it's combat info.
                bool isNarrative = !string.IsNullOrWhiteSpace(message) && message.Contains(" ");

                Color finalColor = isNarrative ? narrativeColor : critColor;
                float scale = isNarrative ? 0.8f : 1.2f; // Sentences should be smaller to fit

                SpawnText(pos, message, finalColor, scale, true);
            }
        }

        private void SpawnText(Vector3 pos, string text, Color color, float scale, bool dramatic)
        {
            if (textPrefab == null || _poolService == null) return;

            // Spawn via Service
            GameObject obj = _poolService.Spawn(textPrefab, pos + offset, Quaternion.identity);

            var floatingText = obj.GetComponent<FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(text, color, scale, dramatic);

                // Billboarding (Look at main camera)
                if (Camera.main != null)
                {
                    obj.transform.forward = Camera.main.transform.forward;
                }
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\FloatingText.cs`
- Lines: 73
- Size: 2.2 KB
- Modified: 2026-01-18 19:32

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Systems.UI
{
    public class FloatingText : MonoBehaviour
    {
        public TextMeshPro textMesh;
        public float floatDistance = 2f;
        public float duration = 0.8f;
        public Ease motionEase = Ease.OutCubic;

        private void Awake()
        {
            if (textMesh == null) textMesh = GetComponent<TextMeshPro>();
        }

        public void Initialize(string text, Color color, float sizeScale = 1f, bool isDramatic = false)
        {
            // 1. Setup Text
            textMesh.text = text;
            textMesh.color = color;
            textMesh.alpha = 1f;

            // 2. Narrative/Dramatic Polish
            if (isDramatic)
            {
                textMesh.fontStyle = FontStyles.Bold;
                textMesh.outlineWidth = 0.2f;
            }
            else
            {
                textMesh.fontStyle = FontStyles.Normal;
                textMesh.outlineWidth = 0f;
            }

            // 3. Reset Transform
            transform.localScale = Vector3.one * sizeScale;

            // 4. Animate Move Up
            transform.DOMoveY(transform.position.y + floatDistance, duration)
                .SetEase(motionEase);

            // 5. Animate Fade Out
            textMesh.DOFade(0f, duration * 0.5f)
                .SetDelay(duration * 0.5f)
                .OnComplete(Despawn);

            // 6. Juice: Punch Scale
            float punchAmount = isDramatic ? 0.8f : 0.5f;
            transform.DOPunchScale(Vector3.one * punchAmount, 0.2f);
        }

        private void Despawn()
        {
            // Get Pool Service via Locator
            var pool = ServiceLocator.Get<IPoolService>();

            if (pool != null)
            {
                pool.Despawn(gameObject);
            }
            else
            {
                // Fallback if scene is unloading or pool service is missing
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\HUDManager.cs`
- Lines: 147
- Size: 5.0 KB
- Modified: 2026-01-20 18:40

```csharp
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Systems.Score; // For IScoreService

namespace DarkTowerTron.Systems.UI
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Event Channels")]
        [SerializeField] private FloatFloatEventChannelSO _focusEvent;
        [SerializeField] private IntIntEventChannelSO _gritEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;
        [SerializeField] private IntIntEventChannelSO _scoreEvent;

        [Header("Focus (Energy)")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color fullFocusColor = new Color(1f, 0f, 1f);

        [Header("Grit (Health)")]
        public Transform gritContainer;
        public GameObject pipPrefab;
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f);

        [Header("Hull (Shield)")]
        public Image hullIcon;
        public Color hullActiveColor = Color.cyan;
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f);

        [Header("Score & System")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI multiplierText;
        public TextMeshProUGUI timerText;

        // Internal State
        private List<Image> _spawnedPips = new List<Image>();
        private IScoreService _scoreService;

        private void Start()
        {
            // 1. Get Score Service (Guaranteed by GlobalSystems)
            _scoreService = ServiceLocator.Get<IScoreService>();

            // 2. Initial UI Refresh
            if (_scoreService != null)
            {
                UpdateScoreUI(_scoreService.TotalScore, _scoreService.CurrentMultiplier);
            }
        }

        private void OnEnable()
        {
            if (_focusEvent) _focusEvent.OnEventRaised += UpdateFocus;
            if (_gritEvent) _gritEvent.OnEventRaised += UpdateGrit;
            if (_hullEvent) _hullEvent.OnEventRaised += UpdateHull;
            if (_scoreEvent) _scoreEvent.OnEventRaised += UpdateScoreUI;
        }

        private void OnDisable()
        {
            if (_focusEvent) _focusEvent.OnEventRaised -= UpdateFocus;
            if (_gritEvent) _gritEvent.OnEventRaised -= UpdateGrit;
            if (_hullEvent) _hullEvent.OnEventRaised -= UpdateHull;
            if (_scoreEvent) _scoreEvent.OnEventRaised -= UpdateScoreUI;
        }

        private void Update()
        {
            // Poll for Timer (less expensive than event for every second)
            if (timerText && _scoreService != null)
            {
                float t = _scoreService.GameTime;
                int minutes = Mathf.FloorToInt(t / 60f);
                int seconds = Mathf.FloorToInt(t % 60f);

                // Optimization: Only update string if second changed? 
                // For now, per frame is acceptable for HUD text.
                timerText.text = $"{minutes:00}:{seconds:00}";
            }
        }

        // --- HANDLERS ---

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider) focusSlider.value = current / max;

            if (focusFillImage)
            {
                bool isFull = current >= (max * 0.95f);
                focusFillImage.color = isFull ? fullFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit, int maxGrit)
        {
            // Rebuild if max changed
            if (_spawnedPips.Count != maxGrit)
            {
                RebuildGritLayout(maxGrit);
            }

            // Update states
            for (int i = 0; i < _spawnedPips.Count; i++)
            {
                if (_spawnedPips[i] == null) continue;
                _spawnedPips[i].color = (i < currentGrit) ? activePipColor : inactivePipColor;
            }
        }

        private void UpdateHull(bool hasHull)
        {
            if (hullIcon)
            {
                hullIcon.color = hasHull ? hullActiveColor : hullBrokenColor;
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0");
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }

        private void RebuildGritLayout(int max)
        {
            if (gritContainer == null || pipPrefab == null) return;

            foreach (Transform child in gritContainer) Destroy(child.gameObject);
            _spawnedPips.Clear();

            for (int i = 0; i < max; i++)
            {
                GameObject newPip = Instantiate(pipPrefab, gritContainer);
                Image img = newPip.GetComponent<Image>();
                if (img) _spawnedPips.Add(img);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\MenuController.cs`
- Lines: 30
- Size: 0.9 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace DarkTowerTron.Systems.UI
{
    public class MenuController : MonoBehaviour
    {
        [Header("Navigation")]
        public GameObject firstSelectedObject;

        private void OnEnable()
        {
            // Wait one frame to ensure EventSystem is ready
            StartCoroutine(SelectButtonRoutine());
        }

        private System.Collections.IEnumerator SelectButtonRoutine()
        {
            yield return null;

            if (firstSelectedObject && EventSystem.current)
            {
                // Clear selection then set new one to force highlight update
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(firstSelectedObject);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\NarrativeUI.cs`
- Lines: 108
- Size: 3.5 KB
- Modified: 2026-01-20 14:17

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IAudioService
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Systems.UI
{
    public class NarrativeUI : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private NarrativeEventChannelSO _inputChannel;

        [Header("Components")]
        [SerializeField] private TextMeshProUGUI _textMesh;
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private RectTransform _panelRoot;

        [Header("Settings")]
        public float typeSpeed = 0.03f; // Fast terminal speed
        public string prefix = "> SYS_OUT: ";
        public AudioClip typeSound;

        [Header("Glitch Settings")]
        public float shakeStrength = 10f;
        public Color normalColor = Color.white;
        public Color errorColor = Color.red;

        private Tween _fadeTween;
        private Coroutine _displayRoutine;

        // Service Dependencies
        private IAudioService _audioService;

        private void Awake()
        {
            // Initial State: Hidden
            _canvasGroup.alpha = 0;
            _textMesh.text = "";
        }

        private void Start()
        {
            // Locate Services
            _audioService = ServiceLocator.Get<IAudioService>();
        }

        private void OnEnable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised += OnMessageReceived;
        }

        private void OnDisable()
        {
            if (_inputChannel != null)
                _inputChannel.OnEventRaised -= OnMessageReceived;
        }

        private void OnMessageReceived(string message, float duration)
        {
            // 1. Interrupt existing messages
            if (_displayRoutine != null) StopCoroutine(_displayRoutine);
            if (_fadeTween != null) _fadeTween.Kill();
            _panelRoot.DOKill();

            // 2. Start new sequence
            _displayRoutine = StartCoroutine(TypewriterRoutine(message, duration));
        }

        private IEnumerator TypewriterRoutine(string message, float duration)
        {
            // A. Setup
            string fullText = prefix + message;
            _textMesh.text = fullText;
            _textMesh.maxVisibleCharacters = 0; // Hide all chars
            _textMesh.color = message.Contains("FATAL") ? errorColor : normalColor;

            // B. Visual "Boot" (Fade In + Jolt)
            _canvasGroup.alpha = 1;
            _panelRoot.DOPunchAnchorPos(Vector2.right * shakeStrength, 0.2f, 20, 1);

            // C. Typewriter Effect
            int totalChars = fullText.Length;
            for (int i = 0; i <= totalChars; i++)
            {
                _textMesh.maxVisibleCharacters = i;

                // Play sound every few chars to avoid machine-gun audio
                if (i % 3 == 0 && typeSound != null && _audioService != null)
                {
                    _audioService.PlaySound(typeSound, Vector3.zero, 0.2f);
                }

                yield return new WaitForSeconds(typeSpeed);
            }

            // D. Wait (Read time)
            yield return new WaitForSeconds(duration);

            // E. Fade Out
            _fadeTween = _canvasGroup.DOFade(0f, 0.5f);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\PerkIconUI.cs`
- Lines: 41
- Size: 1.0 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;
using UnityEngine.UI;
using DarkTowerTron.Systems.Stats;

namespace DarkTowerTron.Systems.UI
{
    // Make sure to add this requirement so we don't forget the trigger
    [RequireComponent(typeof(TooltipTrigger))]
    public class PerkIconUI : MonoBehaviour
    {
        public Image iconImage;
        private TooltipTrigger _tooltip;

        private void Awake()
        {
            _tooltip = GetComponent<TooltipTrigger>();
        }

        public void Setup(PerkSO perk)
        {
            if (perk == null) return;

            // 1. Icon Setup
            if (perk.icon != null)
            {
                iconImage.sprite = perk.icon;
                iconImage.enabled = true;
            }
            else
            {
                iconImage.color = Color.cyan;
            }

            // 2. Tooltip Injection
            if (_tooltip != null)
            {
                _tooltip.SetText(perk.perkName, perk.description);
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\ResultScreen.cs`
- Lines: 82
- Size: 2.4 KB
- Modified: 2026-01-18 19:30

```csharp
using UnityEngine;
using TMPro;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Systems.Score; // Access IScoreService

namespace DarkTowerTron.Systems.UI
{
    public class ResultScreen : MonoBehaviour
    {
        [Header("UI References")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI timeText;
        public TextMeshProUGUI rankText;

        [Header("Ranking Config")]
        public int rankS_Threshold = 50000;
        public int rankA_Threshold = 25000;
        public int rankB_Threshold = 10000;

        private void OnEnable()
        {
            // 1. Get Service
            var scoreService = ServiceLocator.Get<IScoreService>();

            if (scoreService == null)
            {
                // Fallback for UI testing without services
                if (scoreText) scoreText.text = "0";
                if (timeText) timeText.text = "00:00";
                return;
            }

            // 2. Stop the Timer (Game Over state)
            scoreService.StopTracking();

            // 3. Get Stats from Service
            int finalScore = scoreService.TotalScore;
            float finalTime = scoreService.GameTime;

            // 4. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                int minutes = Mathf.FloorToInt(finalTime / 60f);
                int seconds = Mathf.FloorToInt(finalTime % 60f);
                timeText.text = $"{minutes:00}:{seconds:00}";
            }

            // 5. Calculate Rank
            if (rankText)
            {
                CalculateRank(finalScore);
            }
        }

        private void CalculateRank(int score)
        {
            string rank = "C";
            Color rankColor = Color.grey;

            if (score >= rankS_Threshold)
            {
                rank = "S";
                rankColor = Color.cyan;
            }
            else if (score >= rankA_Threshold)
            {
                rank = "A";
                rankColor = Color.green;
            }
            else if (score >= rankB_Threshold)
            {
                rank = "B";
                rankColor = Color.yellow;
            }

            rankText.text = rank;
            rankText.color = rankColor;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\TooltipManager.cs`
- Lines: 80
- Size: 2.1 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;
using TMPro;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class TooltipManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private TooltipEventChannelSO _tooltipEvent;

        [Header("UI References")]
        public GameObject tooltipObject;
        public TextMeshProUGUI headerText;
        public TextMeshProUGUI contentText;
        public RectTransform rectTransform;

        private void Awake()
        {
            // Start hidden
            tooltipObject.SetActive(false);
        }

        private void OnEnable()
        {
            if (_tooltipEvent)
            {
                _tooltipEvent.OnShow += Show;
                _tooltipEvent.OnHide += Hide;
            }
        }

        private void OnDisable()
        {
            if (_tooltipEvent)
            {
                _tooltipEvent.OnShow -= Show;
                _tooltipEvent.OnHide -= Hide;
            }
        }

        private void Show(string header, string content)
        {
            headerText.text = header;
            contentText.text = content;

            // Toggle header visibility if empty
            headerText.gameObject.SetActive(!string.IsNullOrEmpty(header));

            tooltipObject.SetActive(true);
            UpdatePosition();
        }

        private void Hide()
        {
            tooltipObject.SetActive(false);
        }

        private void Update()
        {
            if (tooltipObject.activeSelf)
            {
                UpdatePosition();
            }
        }

        private void UpdatePosition()
        {
            // Simple mouse follow
            Vector2 mousePos = UnityEngine.Input.mousePosition;

            // Offset so cursor doesn't cover text
            float pivotX = mousePos.x / Screen.width;
            float pivotY = mousePos.y / Screen.height;

            rectTransform.pivot = new Vector2(pivotX, pivotY);
            transform.position = mousePos;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\TooltipTrigger.cs`
- Lines: 34
- Size: 1.0 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;
using UnityEngine.EventSystems; // Required for Pointer interfaces
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Systems.UI
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Wiring")]
        [SerializeField] private TooltipEventChannelSO _tooltipEvent;

        [Header("Content")]
        public string header;
        [TextArea] public string content;

        // Allow other scripts (like PerkIconUI) to set this dynamically
        public void SetText(string newHeader, string newContent)
        {
            header = newHeader;
            content = newContent;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            // Delay could be added here if needed
            _tooltipEvent?.Show(header, content);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _tooltipEvent?.Hide();
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\UIManager.cs`
- Lines: 35
- Size: 1.3 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;

namespace DarkTowerTron.Systems.UI
{
    public class UIManager : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject startPanel;
        public GameObject tutorialPanel;
        public GameObject hudPanel;
        public GameObject pausePanel;
        public GameObject gameOverPanel;
        public GameObject victoryPanel;

        public void ShowStartMenu() => SetPanelActive(startPanel);
        public void ShowTutorial() => SetPanelActive(tutorialPanel);
        public void ShowHUD() => SetPanelActive(hudPanel);
        public void ShowPause() => SetPanelActive(pausePanel);
        public void ShowGameOver() => SetPanelActive(gameOverPanel);
        public void ShowVictory() => SetPanelActive(victoryPanel);

        // Helper to ensure exclusive visibility
        private void SetPanelActive(GameObject activePanel)
        {
            if (startPanel) startPanel.SetActive(false);
            if (tutorialPanel) tutorialPanel.SetActive(false);
            if (hudPanel) hudPanel.SetActive(false);
            if (pausePanel) pausePanel.SetActive(false);
            if (gameOverPanel) gameOverPanel.SetActive(false);
            if (victoryPanel) victoryPanel.SetActive(false);

            if (activePanel) activePanel.SetActive(true);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\UI\UIThemeReceiver.cs`
- Lines: 48
- Size: 1.7 KB
- Modified: 2026-01-17 13:09

```csharp
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Systems.UI
{
    public enum UIElementType { Title, Body, Button, Panel, Digits, Danger }

    public class UIThemeReceiver : MonoBehaviour
    {
        public UIThemeSO theme; // Assign in Inspector or Load from Manager
        public UIElementType type = UIElementType.Body;

        private void OnEnable()
        {
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            if (theme == null) return;

            var text = GetComponent<TextMeshProUGUI>();
            var img = GetComponent<Image>();

            switch (type)
            {
                case UIElementType.Title:
                    if (text) { text.font = theme.mainFont; text.color = theme.primaryColor; }
                    break;
                case UIElementType.Body:
                    if (text) { text.font = theme.mainFont; text.color = theme.bodyColor; }
                    break;
                case UIElementType.Digits:
                    if (text) { text.font = theme.digitFont; text.color = theme.accentColor; }
                    break;
                case UIElementType.Danger:
                    if (text) { text.font = theme.mainFont; text.color = theme.dangerColor; }
                    break;
                case UIElementType.Button:
                    if (img) { img.sprite = theme.buttonBackground; img.color = theme.accentColor; }
                    // Button text is usually handled by a child receiver set to "Body" or "Title"
                    break;
            }
        }
    }
}
```

## 📄 `Assets\_Project\Systems\VFX\GameFeedbackSystem.cs`
- Lines: 86
- Size: 3.3 KB
- Modified: 2026-01-18 23:54

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Systems.VFX
{
    /// <summary>
    /// Listens to high-level game events and triggers audiovisual feedback.
    /// Acts as the bridge between "Gameplay Logic" and "Core Services".
    /// </summary>
    public class GameFeedbackSystem : MonoBehaviour
    {
        [Header("Inputs (Events)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent;

        [Header("Assets (VFX)")]
        [SerializeField] private GameObject _defaultExplosion;
        [SerializeField] private GameObject _spawnVFX;
        [SerializeField] private GameObject _playerHitVFX;

        [Header("Settings")]
        [SerializeField] private LayerMask _groundLayer;

        // Services
        private IVFXService _vfxService;
        private IAudioService _audioService; // Now we can easily add sound too!

        private void Start()
        {
            _vfxService = ServiceLocator.Get<IVFXService>();
            _audioService = ServiceLocator.Get<IAudioService>();

            if (_groundLayer == 0) _groundLayer = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised += OnEnemySpawned;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised -= OnEnemySpawned;
        }

        // --- Logic Handlers ---

        private void OnEnemySpawned(Vector3 pos)
        {
            if (_spawnVFX == null) return;

            // Logic: Ground Snapping (Moved from Service to System)
            Vector3 vfxPos = pos + Vector3.up * 0.1f;
            if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2f, Vector3.down, out RaycastHit hit, 10f, _groundLayer))
            {
                vfxPos = hit.point + Vector3.up * 0.1f;
            }

            _vfxService.SpawnVFX(_spawnVFX, vfxPos, Quaternion.identity);
            // _audioService.PlaySFX("EnemySpawn", vfxPos); // Easy to add later
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool byPlayer)
        {
            // Logic: Determine which explosion to use
            // GameObject explosion = stats.DeathVFX != null ? stats.DeathVFX : _defaultExplosion;

            _vfxService.SpawnVFX(_defaultExplosion, position, Quaternion.identity);
        }

        private void OnPlayerHit()
        {
            // Logic: Find player position (if needed) or just play UI shake
            // _vfxService.SpawnVFX(_playerHitVFX, playerPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\VFX\IVFXService.cs`
- Lines: 17
- Size: 0.6 KB
- Modified: 2026-01-20 14:13

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.VFX
{
    public interface IVFXService : IGameService
    {
        // Spawn with optional duration/delay before despawn
        void Spawn(GameObject prefab, Vector3 position, Quaternion rotation, float duration = 0f);

        // Fire and forget
        void SpawnVFX(GameObject vfxPrefab, Vector3 position, Quaternion rotation);

        // Spawn attached to a moving target (e.g., status effects)
        void SpawnVFX(GameObject vfxPrefab, Transform parent, Vector3 localOffset);
    }
}
```

## 📄 `Assets\_Project\Systems\VFX\VFXService.cs`
- Lines: 72
- Size: 2.2 KB
- Modified: 2026-01-20 18:31

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services; 
using DarkTowerTron.Core.Patterns; 

namespace DarkTowerTron.Systems.VFX
{
    public class VFXService : MonoBehaviour, IVFXService
    {
        private IPoolService _pool;

        private void Awake()
        {
            ServiceLocator.Register<IVFXService>(this);
        }

        private void Start()
        {
            _pool = ServiceLocator.Get<IPoolService>();
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IVFXService>(this);
        }

        // --- IVFXService Implementation ---

        // 1. Signature from Error CS0535
        public void SpawnVFX(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            Spawn(prefab, position, rotation, 0f);
        }

        // 2. Signature from Error CS0535
        public void SpawnVFX(GameObject prefab, Transform parent, Vector3 offset)
        {
            if (prefab == null) return;
            EnsurePool();

            // Calculate world position
            Vector3 pos = (parent != null) ? parent.position + parent.TransformDirection(offset) : offset;
            Quaternion rot = (parent != null) ? parent.rotation : Quaternion.identity;

            GameObject instance = _pool.Spawn(prefab, pos, rot);
            
            // Optional: Parent it if it's meant to stick (like a status effect)
            if (parent != null && instance != null)
            {
                instance.transform.SetParent(parent);
            }
        }

        // 3. The "Spawn" method we fixed previously (Wrapper / Main Logic)
        public void Spawn(GameObject prefab, Vector3 position, Quaternion rotation, float duration = 0f)
        {
            if (prefab == null) return;
            EnsurePool();

            GameObject instance = _pool.Spawn(prefab, position, rotation);

            if (instance != null && duration > 0f)
            {
                _pool.Despawn(instance, duration);
            }
        }

        private void EnsurePool()
        {
            if (_pool == null) _pool = ServiceLocator.Get<IPoolService>();
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Visuals\IPaletteService.cs`
- Lines: 20
- Size: 0.5 KB
- Modified: 2026-01-20 19:04

```csharp
using System;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    public interface IPaletteService : IGameService
    {
        event Action OnPaletteChanged;

        PaletteDefinitionSO ActivePalette { get; }
        string ActiveVariant { get; }

        void SetVariant(string variantName);
        void Refresh();

        // Helper to get a specific surface definition without needing the SO directly
        SurfaceDefinition GetSurface(SurfaceType type);
    }
}
```

## 📄 `Assets\_Project\Systems\Visuals\PaletteEnvironmentBridge.cs`
- Lines: 72
- Size: 2.3 KB
- Modified: 2026-01-18 23:25

```csharp
using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    [RequireComponent(typeof(Camera))]
    public class PaletteEnvironmentBridge : MonoBehaviour
    {
        private Camera _cam;

        private void Awake()
        {
            _cam = GetComponent<Camera>();
        }

        private void OnEnable()
        {
            // Wait for service to be ready
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                paletteService.OnPaletteChanged += UpdateEnvironment;
                // Update immediately if service is already running
                UpdateEnvironment();
            }
            else
            {
                // Retry in Start or via a Global Event if ServiceLocator isn't ready in Awake
                // For this example, we'll assume Service init order is handled or we check in Start
            }
        }

        private void Start()
        {
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                // Ensure we are subscribed
                paletteService.OnPaletteChanged -= UpdateEnvironment;
                paletteService.OnPaletteChanged += UpdateEnvironment;
                UpdateEnvironment();
            }
        }

        private void OnDisable()
        {
            if (ServiceLocator.TryGet(out IPaletteService paletteService))
            {
                paletteService.OnPaletteChanged -= UpdateEnvironment;
            }
        }

        private void UpdateEnvironment()
        {
            if (!ServiceLocator.TryGet(out IPaletteService service)) return;

            var palette = service.ActivePalette;
            if (palette == null) return;

            // 1. Camera Background
            if (_cam != null)
            {
                _cam.clearFlags = CameraClearFlags.SolidColor;
                _cam.backgroundColor = palette.skyColor;
            }

            // 2. Global Fog
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.ExponentialSquared;
            RenderSettings.fogColor = palette.skyColor;
            RenderSettings.fogDensity = palette.fogDensity;
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Visuals\PaletteService.cs`
- Lines: 142
- Size: 4.2 KB
- Modified: 2026-01-20 19:05

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Visuals
{
    [ExecuteAlways]
    public class PaletteService : MonoBehaviour, IPaletteService
    {
        // Singleton for Editor Mode Preview ONLY
        public static PaletteService EditorInstance { get; private set; }

        public event Action OnPaletteChanged;

        [Header("State")]
        [SerializeField] private PaletteDefinitionSO _activePalette;
        [SerializeField] private string _activeVariant = "";

        // --- IPaletteService Implementation ---
        public PaletteDefinitionSO ActivePalette => _activePalette;
        public string ActiveVariant => _activeVariant;

        [Header("Material Bindings")]
        public List<SurfaceBinding> bindings;

        [System.Serializable]
        public struct SurfaceBinding
        {
            public SurfaceType type;
            public MaterialCollectionSO collection;
        }

        [Header("Debug")]
        public bool refreshNow = false;

        private void Awake()
        {
            // Only register in Runtime
            if (Application.isPlaying)
            {
                ServiceLocator.Register<IPaletteService>(this);
            }
        }

        private void OnEnable()
        {
            // Handle Editor Preview Instance
            if (!Application.isPlaying)
            {
                EditorInstance = this;
            }
        }

        private void OnDisable()
        {
            if (Application.isPlaying)
            {
                ServiceLocator.Unregister<IPaletteService>(this);
            }
            else
            {
                if (EditorInstance == this) EditorInstance = null;
            }
        }

        private void Start()
        {
            if (Application.isPlaying) ApplyPalette();
        }

        private void Update()
        {
#if UNITY_EDITOR
            if (refreshNow)
            {
                ApplyPalette();
                refreshNow = false;
            }
#endif
        }

        public void SetVariant(string variantName)
        {
            if (_activeVariant == variantName) return;
            _activeVariant = variantName;
            ApplyPalette();
        }

        public void Refresh() => ApplyPalette();

        public SurfaceDefinition GetSurface(SurfaceType type)
        {
            if (_activePalette == null) return new SurfaceDefinition();
            return _activePalette.GetSurface(type, _activeVariant);
        }

        private void ApplyPalette()
        {
            if (_activePalette == null) return;

            foreach (var binding in bindings)
            {
                if (binding.collection == null) continue;
                SurfaceDefinition def = GetSurface(binding.type);
                ApplyToCollection(binding.collection, def);
            }

            OnPaletteChanged?.Invoke();
        }

        private void ApplyToCollection(MaterialCollectionSO col, SurfaceDefinition def)
        {
            if (col.materials == null) return;

            foreach (Material mat in col.materials)
            {
                if (mat == null) continue;
                ApplyDefinitionToMaterial(mat, def);
            }
        }

        public static void ApplyDefinitionToMaterial(Material mat, SurfaceDefinition def)
        {
            if (mat == null) return;

            // Universal Render Pipeline / Standard Shader Support
            if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", def.mainColor);
            else if (mat.HasProperty("_Color")) mat.SetColor("_Color", def.mainColor);

            if (mat.HasProperty("_EmissionColor"))
            {
                mat.SetColor("_EmissionColor", def.emissionColor);
                mat.EnableKeyword("_EMISSION");
            }

            if (mat.HasProperty("_Smoothness")) mat.SetFloat("_Smoothness", def.smoothness);
            if (mat.HasProperty("_Metallic")) mat.SetFloat("_Metallic", def.metallic);
        }
    }
}
```

## 📄 `Assets\_Project\Systems\Waves\IWaveService.cs`
- Lines: 27
- Size: 0.9 KB
- Modified: 2026-01-20 18:52

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Waves
{
    public interface IWaveService : IGameService
    {
        /// <summary>
        /// Is the service currently processing a wave?
        /// </summary>
        bool IsWaveActive { get; }

        /// <summary>
        /// Starts a specific wave using the provided spawn points.
        /// </summary>
        /// <param name="wave">The wave data to run.</param>
        /// <param name="spawnPoints">List of valid spawn transforms for this encounter.</param>
        /// <param name="onComplete">Callback when all enemies are dead.</param>
        /// <returns>False if service was already busy.</returns>
        bool StartWave(WaveDefinitionSO wave, List<Transform> spawnPoints, Action onComplete);

        void CancelWave();
    }
}
```

## 📄 `Assets\_Project\Systems\Waves\WaveService.cs`
- Lines: 256
- Size: 9.0 KB
- Modified: 2026-01-25 09:23

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Patterns;

namespace DarkTowerTron.Systems.Waves
{
    public class WaveService : MonoBehaviour, IWaveService
    {
        [Header("Listening (Inputs)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Broadcasting (Outputs)")]
        [SerializeField] private VoidEventChannelSO _waveCompleteEvent; // Optional: For global audio cues
        //[SerializeField] private StringEventChannelSO _announcementEvent; // Optional: HUD Text

        // --- IWaveService State ---
        public bool IsWaveActive { get; private set; }

        // Internal State
        private int _enemiesRemaining = 0;
        private int _essentialEnemiesAlive = 0;
        private int _gruntsAlive = 0;
        private bool _isSpawningMain = false;
        private Coroutine _gruntRoutine;
        private IPoolService _pool;

        private void Awake()
        {
            ServiceLocator.Register<IWaveService>(this);
        }

        private void Start()
        {
            _pool = ServiceLocator.Get<IPoolService>();
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IWaveService>(this);
        }

        // --- Implementation ---

        public bool StartWave(WaveDefinitionSO wave, List<Transform> spawnPoints, System.Action onComplete)
        {
            if (IsWaveActive)
            {
                GameLogger.LogWarning(LogChannel.System, "[WaveService] Busy! Cannot start new wave.", gameObject);
                return false;
            }

            if (wave == null) return false;

            StartCoroutine(ProcessWaveRoutine(wave, spawnPoints, onComplete));
            return true;
        }

        public void CancelWave()
        {
            IsWaveActive = false;
            StopAllCoroutines();
        }

        // --- Logic ---

        private IEnumerator ProcessWaveRoutine(WaveDefinitionSO wave, List<Transform> points, System.Action onComplete)
        {
            IsWaveActive = true;
            _enemiesRemaining = 0; // Reset
            _essentialEnemiesAlive = 0;
            _gruntsAlive = 0;

            // 1. Announce Logic (Handled by ArenaController mostly, but if Service does it:)
            // _announcementEvent?.RaiseEvent(wave.waveName);

            // 2. Choose Strategy
            if (wave.type == EncounterType.Reinforcement)
            {
                yield return StartCoroutine(RunReinforcementWave(wave, points));
            }
            else
            {
                yield return StartCoroutine(RunEliminationWave(wave, points));
            }

            // Complete
            GameLogger.Log(LogChannel.System, $"[WaveService] Wave Complete.");
            IsWaveActive = false;

            _waveCompleteEvent?.RaiseEvent();
            onComplete?.Invoke();
        }

        // --- STRATEGY 1: ELIMINATION (Simple) ---
        private IEnumerator RunEliminationWave(WaveDefinitionSO wave, List<Transform> points)
        {
            // Spawn Main
            yield return StartCoroutine(SpawnEntries(wave, points, isEssential: false));

            // Spawn Grunts (Fixed Batch)
            if (wave.maxGrunts > 0 && wave.gruntPrefabs.Length > 0)
            {
                for (int i = 0; i < wave.maxGrunts; i++)
                {
                    SpawnRandomGrunt(wave, points, isEssential: false);
                    yield return new WaitForSeconds(wave.gruntSpawnRate);
                }
            }

            // Wait for Total Clear
            yield return new WaitUntil(() => _enemiesRemaining <= 0);
        }

        // --- STRATEGY 2: REINFORCEMENT (Infinite Grunts) ---
        private IEnumerator RunReinforcementWave(WaveDefinitionSO wave, List<Transform> points)
        {
            // Track VIPs explicitly
            _essentialEnemiesAlive = wave.TotalMainEnemyCount;
            _gruntsAlive = 0;

            // Flag to prevent grunts stopping if VIP spawning is slow
            _isSpawningMain = true;

            // Start Grunt Routine (Runs in parallel)
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
            _gruntRoutine = StartCoroutine(InfiniteGruntLoop(wave, points));

            // Spawn VIPs
            yield return StartCoroutine(SpawnEntries(wave, points, isEssential: true));
            _isSpawningMain = false;

            // Wait for VIPs to die (Grunts don't matter for victory condition)
            yield return new WaitUntil(() => _essentialEnemiesAlive <= 0);

            // Stop Grunts
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

            // Optional: Kill remaining grunts instantly? Or let player mop up?
            // For now, we let player kill them or just end the wave immediately.
            // Let's end immediately (Doors open, player leaves).
        }

        private IEnumerator InfiniteGruntLoop(WaveDefinitionSO wave, List<Transform> points)
        {
            if (wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0) yield break;

            // Keep loop running as long as VIPs are alive OR we are still spawning them
            while (_essentialEnemiesAlive > 0 || _isSpawningMain)
            {
                // Top up grunts to max capacity
                if (_gruntsAlive < wave.maxGrunts)
                {
                    SpawnRandomGrunt(wave, points, isEssential: false);
                }
                yield return new WaitForSeconds(wave.gruntSpawnRate);
            }
        }

        // --- SPAWN HELPERS ---

        private IEnumerator SpawnEntries(WaveDefinitionSO wave, List<Transform> points, bool isEssential)
        {
            if (wave.entries == null) yield break;

            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    SpawnEnemy(entry.enemyPrefab, points, entry.spawnPointIndex, isEssential);
                    yield return new WaitForSeconds(entry.rate);
                }
            }
        }

        private void SpawnRandomGrunt(WaveDefinitionSO wave, List<Transform> points, bool isEssential)
        {
            var prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
            SpawnEnemy(prefab, points, -1, isEssential);
        }

        private void SpawnEnemy(GameObject prefab, List<Transform> points, int indexOverride, bool isEssential)
        {
            if (!prefab) return;

            Vector3 pos = transform.position;
            Quaternion rot = Quaternion.identity;

            if (points != null && points.Count > 0)
            {
                if (indexOverride >= 0 && indexOverride < points.Count)
                {
                    pos = points[indexOverride].position;
                    rot = points[indexOverride].rotation;
                }
                else
                {
                    var t = points[Random.Range(0, points.Count)];
                    pos = t.position;
                    rot = t.rotation;
                }
            }

            GameObject instance;
            if (_pool != null) instance = _pool.Spawn(prefab, pos, rot);
            else instance = Instantiate(prefab, pos, rot);

            // Optional: Mark them visually as VIPs?
            // if (isEssential) ... add crown icon ...

            // Track
            if (isEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;

            // Legacy Tracker
            _enemiesRemaining++;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (!IsWaveActive) return;

            // Determine Type
            // Note: In "Reinforcement" mode, we passed isEssential=true to the spawner,
            // but here we are checking the ScriptableObject stats.
            // Ideally, the Enemy instance knows if it's essential or not.
            // For now, we assume if stats.isEssential is true, it counts.

            bool isEssential = (stats != null && stats.isEssential);

            if (isEssential) _essentialEnemiesAlive--;
            else _gruntsAlive--;

            _enemiesRemaining--;

            // Clamps
            if (_essentialEnemiesAlive < 0) _essentialEnemiesAlive = 0;
            if (_gruntsAlive < 0) _gruntsAlive = 0;
            if (_enemiesRemaining < 0) _enemiesRemaining = 0;
        }
    }
}
```
