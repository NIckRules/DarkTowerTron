# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2025-12-14 12:45
- **Files:** 59
- **Total LOC:** 4869
- **Estimated tokens:** 38043

## 📁 Project Tree
```
Assets
  Scripts
    Combat
      HazardZone.cs
      Projectile.cs
    Core
      CameraRig.cs
      CircleRenderer.cs
      Data
        AttackPatternSO.cs
        EnemyStatsSO.cs
        WaveDefinitionSO.cs
      GameConstants.cs
      GameEvents.cs
      GameTime.cs
      Interfaces.cs
      Spinner.cs
    Enemy
      Agents
        EnemyAgent_Chaser.cs
        EnemyAgent_Guardian.cs
        EnemyAgent_Sentinel.cs
        EnemyAgent_Sniper.cs
      EnemyBaseAI.cs
      EnemyController.cs
      EnemyMotors.cs
      PatrolPath.cs
      States
        Chaser
          ChaserState_Chase.cs
          ChaserState_Primer.cs
        Guardian
          GuardianState_Attack.cs
          GuardianState_Move.cs
        Sentinel
          SentinelState_Combat.cs
          SentinelState_Hunt.cs
        Sniper
          SniperState_Aiming.cs
          SniperState_Firing.cs
          SniperState_Positioning.cs
          SniperState_Teleport.cs
    Managers
      ArenaSpawner.cs
      AudioManager.cs
      DamageTextManager.cs
      DebugController.cs
      FeedbackDirector.cs
      GameFeel.cs
      GameSession.cs
      HUDManager.cs
      MusicManager.cs
      PoolManager.cs
      ScoreManager.cs
      VFXManager.cs
      WaveDirector.cs
    Physics
      KinematicMover.cs
    Player
      AfterImage.cs
      PlayerAttack.cs
      PlayerController.cs
      PlayerDodge.cs
      PlayerEnergy.cs
      PlayerExecution.cs
      PlayerGun.cs
      PlayerHealth.cs
      PlayerMovement.cs
      TargetScanner.cs
      WeaponBase.cs
    UI
      CountdownUI.cs
      FloatingText.cs
      ResultScreen.cs
    Visuals
      CameraShaker.cs
```

## 📄 `Assets\Scripts\Combat\HazardZone.cs`
- Lines: 60
- Size: 1.9 KB
- Modified: 2025-12-14 10:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Combat
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

        private void Start()
        {
            // 1. Expand Visuals (Juice)
            transform.localScale = Vector3.zero;
            transform.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack);

            // 2. Schedule Destruction
            // Fade out before destroying
            DOVirtual.DelayedCall(duration - 0.5f, FadeOut);
            Destroy(gameObject, duration);
        }

        private void FadeOut()
        {
            transform.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBack);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check Layer
            if (((1 << other.gameObject.layer) & targetLayer) != 0)
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
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Combat\Projectile.cs`
- Lines: 129
- Size: 4.1 KB
- Modified: 2025-12-14 12:42

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Ballistics")]
        public float speed = 15f;
        public float lifetime = 5f;
        public bool isHostile = true;
        
        [Header("Safety")]
        public float gracePeriod = 0.05f; // Ignore hits for first 0.05s
        public LayerMask wallLayer;

        [Header("Damage Stats")]
        public float damage = 10f;
        public float stagger = 0f;

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial;

        private Material _originalMaterial;
        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
        private float _graceTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.sharedMaterial;
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
        }

        public void OnSpawn()
        {
            _lifeTimer = lifetime;
        }

        public void OnDespawn()
        {
            CancelInvoke();
            _isInitialized = false;
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;
            _graceTimer = gracePeriod; // RESET TIMER
            _isRedirected = false; 
            
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;
        }

        public void ResetHostility(bool startHostile) { isHostile = startHostile; }

        private void Update()
        {
            if (!_isInitialized) return;
            
            // Countdown Grace Period
            if (_graceTimer > 0) _graceTimer -= Time.deltaTime;

            transform.Translate(_direction * speed * Time.deltaTime, Space.World);

            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0) Despawn();
        }

        private void OnTriggerEnter(Collider other)
        {
            // SAFETY CHECK: If grace period active, ignore everything
            if (_graceTimer > 0) return;

            if (other.isTrigger) return;

            // Wall Check
            if ((wallLayer.value & (1 << other.gameObject.layer)) > 0)
            {
                Despawn();
                return;
            }

            IDamageable target = other.GetComponentInParent<IDamageable>();
            if (target != null)
            {
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = this.damage,
                    staggerAmount = this.stagger,
                    pushDirection = _direction,
                    pushForce = 5f,
                    source = gameObject,
                    isRedirected = this._isRedirected 
                };

                if (target.TakeDamage(info)) Despawn();
            }
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false; 
            _isRedirected = true;
            _direction = newDirection.normalized;
            speed *= 1.5f; 
            if (meshRenderer && friendlyMaterial) meshRenderer.material = friendlyMaterial;
            else if (meshRenderer) meshRenderer.material.color = Color.cyan;
            _lifeTimer = 3.0f; 
        }

        private void Despawn()
        {
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\CameraRig.cs`
- Lines: 36
- Size: 1.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public class CameraRig : MonoBehaviour
    {
        [Header("Target")]
        public Transform target; // Assign the Player

        [Header("Isometric Settings")]
        public float pitch = 45f;   // Angle (e.g., 45 degrees)
        public float distance = 25f; // Zoom
        public float smoothTime = 0.1f; // 0.1 is snappy but smooth. 0 is hard-lock.

        private Vector3 _currentVelocity;

        // Run AFTER PlayerMovement (Update) and KinematicMover (Update)
        private void LateUpdate()
        {
            if (target == null) return;

            // 1. Math: Calculate exact isometric position based on angle/distance
            float rad = pitch * Mathf.Deg2Rad;
            float yOffset = Mathf.Sin(rad) * distance;
            float zOffset = -(Mathf.Cos(rad) * distance);

            Vector3 targetPos = target.position + new Vector3(0, yOffset, zOffset);

            // 2. Smooth Follow
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVelocity, smoothTime);

            // 3. Lock Rotation
            transform.rotation = Quaternion.Euler(pitch, 0, 0);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\CircleRenderer.cs`
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

## 📄 `Assets\Scripts\Core\Data\AttackPatternSO.cs`
- Lines: 23
- Size: 0.8 KB
- Modified: 2025-12-14 11:08

```csharp
using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Pattern Shape")]
        public int projectileCount = 1;
        [Range(0, 360)] public float spreadAngle = 0f; // 0 = Stream, 360 = Nova
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float delayBetweenShots = 0.1f; // Machine gun vs Shotgun
        public float startDelay = 0.5f; // Windup time

        [Header("Projectile Override")]
        public float speed = 15f;
        // Optional: Custom prefab for this specific attack? 
        // For now, we use the Agent's default prefab to keep it simple.
    }
}
```

## 📄 `Assets\Scripts\Core\Data\EnemyStatsSO.cs`
- Lines: 62
- Size: 2.2 KB
- Modified: 2025-12-14 12:15

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
        public float maxStagger = 1.0f;
        public float staggerDecay = 0.5f;

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

            // Prevent divide-by-zero or weird logic in Stagger
            maxStagger = Mathf.Max(0.1f, maxStagger);
            staggerDecay = Mathf.Max(0.1f, staggerDecay);

            // Flocking safety
            separationRadius = Mathf.Max(0.1f, separationRadius);
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Data\WaveDefinitionSO.cs`
- Lines: 30
- Size: 0.8 KB
- Modified: 2025-12-11 13:58

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Core.Data
{
    [System.Serializable]
    public class WaveEntry
    {
        public GameObject enemyPrefab;
        public int count = 1;
        public float rate = 1.0f;
        [Tooltip("-1 for Random, 0+ for specific index")]
        public int spawnPointIndex = -1;
    }

    [CreateAssetMenu(fileName = "NewWave", menuName = "DarkTowerTron/Wave Definition")]
    public class WaveDefinitionSO : ScriptableObject
    {
        [Header("Wave Info")]
        public string waveName = "Wave 1";

        [Header("Main Force (Essential)")]
        public List<WaveEntry> entries;

        [Header("Grunt Support (Fodder)")]
        public GameObject[] gruntPrefabs;
        public int maxGrunts = 0;
        public float gruntSpawnRate = 5f;
    }
}
```

## 📄 `Assets\Scripts\Core\GameConstants.cs`
- Lines: 17
- Size: 0.5 KB
- Modified: 2025-12-11 07:51

```csharp
namespace DarkTowerTron.Core
{
    public static class GameConstants
    {
        // Layers
        public const string LAYER_PLAYER = "Player";
        public const string LAYER_ENEMY = "Enemy";
        public const string LAYER_PROJECTILE = "Projectile";
        public const string LAYER_AFTERIMAGE = "AfterImage";
        public const string LAYER_GROUND = "Ground";
        public const string LAYER_WALL = "Wall";

        // Tags
        public const string TAG_PLAYER = "Player";
        public const string TAG_ENEMY = "Enemy";
    }
}
```

## 📄 `Assets\Scripts\Core\GameEvents.cs`
- Lines: 69
- Size: 2.2 KB
- Modified: 2025-12-14 08:43

```csharp
using System;
using UnityEngine;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Core
{
    public static class GameEvents
    {
        // --- COMBAT ---
        // OLD: public static Action<Vector3> OnEnemyKilled;

        // Updated Signature: Vector3 pos, Stats, bool rewardPlayer
        public static Action<Vector3, EnemyStatsSO, bool> OnEnemyKilled;

        public static Action OnPlayerHit;
        public static Action OnPlayerDied;

        // Feedback
        public static Action<Vector3, float, bool> OnDamageDealt;
        public static Action<Vector3, string> OnPopupText;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

        // NEW: True = Hull Active, False = Hull Broken (Danger)
        public static Action<bool> OnHullStateChanged;

        // System
        public static Action<Vector3> OnEnemySpawned;
        public static Action OnWaveCleared;
        public static Action OnGameVictory;
        public static Action<int> OnWaveAnnounce;
        public static Action<string> OnCountdownChange;
        public static Action OnWaveCombatStarted;

        // AI
        public static Action<Transform> OnDecoySpawned;
        public static Action OnDecoyExpired;

        // UI
        public static Action<int, int> OnScoreChanged;

        /// <summary>
        /// CRITICAL: Call this when loading a scene to prevent memory leaks
        /// and calling functions on destroyed objects.
        /// </summary>
        public static void Cleanup()
        {
            OnEnemyKilled = null;
            OnPlayerHit = null;
            OnPlayerDied = null;
            OnDamageDealt = null;
            OnPopupText = null;
            OnFocusChanged = null;
            OnGritChanged = null;
            OnHullStateChanged = null;
            OnEnemySpawned = null;
            OnWaveCleared = null;
            OnGameVictory = null;
            OnWaveAnnounce = null;
            OnCountdownChange = null;
            OnWaveCombatStarted = null;
            OnDecoySpawned = null;
            OnDecoyExpired = null;
            OnScoreChanged = null;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\GameTime.cs`
- Lines: 35
- Size: 0.8 KB
- Modified: 2025-12-11 14:18

```csharp
using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Core
{
    public class GameTime : MonoBehaviour
    {
        public static GameTime Instance;
        private bool _isFrozen = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void HitStop(float duration)
        {
            if (_isFrozen) return;
            StartCoroutine(DoHitStop(duration));
        }

        private IEnumerator DoHitStop(float duration)
        {
            _isFrozen = true;
            float originalScale = Time.timeScale;

            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);

            Time.timeScale = originalScale;
            _isFrozen = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Core\Interfaces.cs`
- Lines: 37
- Size: 0.8 KB
- Modified: 2025-12-13 14:44

```csharp
using UnityEngine;

namespace DarkTowerTron.Core
{
    public struct DamageInfo
    {
        public float damageAmount;
        public float staggerAmount;
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
    }

    public interface IDamageable
    {
        bool TakeDamage(DamageInfo info);
        void Kill(bool instant);
    }

    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner);
    }

    // NEW: Standardizes input for any weapon (Beam, Gun, Sword)
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }

    public interface IPoolable
    {
        void OnSpawn();
        void OnDespawn();
    }
}
```

## 📄 `Assets\Scripts\Core\Spinner.cs`
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

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Chaser.cs`
- Lines: 133
- Size: 4.1 KB
- Modified: 2025-12-14 10:46

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Chaser;

namespace DarkTowerTron.Enemy.Agents
{
    public enum ChaserMode { Missile, MineLayer }

    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Mode Selection")]
        public ChaserMode mode = ChaserMode.Missile;

        [Header("Settings")]
        public float attackRange = 1.5f; 
        
        [Header("Mine Settings")]
        public GameObject hazardPrefab;
        public float fuseDuration = 0.5f;

        [Header("Missile Settings")]
        public float damage = 1f;
        public float explosionForce = 20f;

        [Header("Steering")]
        public System.Collections.Generic.List<SteeringBehavior> chaseBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public ChaserState_Chase StateChase { get; private set; }
        public ChaserState_Priming StatePriming { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            StateChase = new ChaserState_Chase(this);
            StatePriming = new ChaserState_Priming(this);
        }

        protected override void Start()
        {
            base.Start();
            FSM.Initialize(StateChase);
        }

        protected override void RunAI() { }

        // --- ATTACK LOGIC ---

        public void TriggerAttack()
        {
            if (mode == ChaserMode.Missile)
            {
                // INSTANT BOOM
                DetonateMissile();
            }
            else
            {
                // PRIME MINE (Shake then Boom)
                FSM.ChangeState(StatePriming);
            }
        }

        public void DetonateMissile()
        {
            // Standard damage logic
            if (_currentTarget != null)
            {
                IDamageable targetHealth = _currentTarget.GetComponentInParent<IDamageable>();
                if (targetHealth != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = damage,
                        pushDirection = transform.forward,
                        pushForce = explosionForce,
                        source = gameObject
                    };
                    targetHealth.TakeDamage(info);
                    _controller.SelfDestruct();
                }
                else
                {
                    // Hit Decoy? Reward.
                    if (_currentTarget.name.Contains("AfterImage")) _controller.Kill(true);
                    else _controller.SelfDestruct();
                }
            }
            else
            {
                _controller.SelfDestruct();
            }
        }

        public void DeployMine()
        {
            // Spawn Hazard
            if (hazardPrefab)
            {
                // Spawn at ground level
                Vector3 pos = transform.position;
                pos.y = 0;
                Instantiate(hazardPrefab, pos, Quaternion.identity);
            }
            
            // Die (No Reward, because you didn't kill it, it deployed)
            // Or Reward? Let's say SelfDestruct (No reward).
            _controller.SelfDestruct();
        }

        // ... Gizmos and Getters ...
        public Transform GetTarget() => _currentTarget;
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;
        
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackRange);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Guardian.cs`
- Lines: 152
- Size: 5.0 KB
- Modified: 2025-12-14 11:59

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.States.Guardian;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Guardian : EnemyBaseAI
    {
        [Header("Patrol Config")]
        public float waypointTolerance = 1.5f;
        public List<SteeringBehavior> moveBehaviors;

        [Header("Combat Config")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public List<AttackPatternSO> attackPatterns;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATE DATA --
        public PatrolPath ActivePath { get; private set; }
        public int CurrentWaypointIndex { get; set; } = 0;

        // -- STATES --
        public GuardianState_Move StateMove { get; private set; }
        public GuardianState_Attack StateAttack { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            StateMove = new GuardianState_Move(this);
            StateAttack = new GuardianState_Attack(this);
        }

        protected override void Start()
        {
            base.Start();

            // Auto-find path if not assigned
            if (ActivePath == null)
            {
                ActivePath = FindNearestPath();
            }

            if (ActivePath != null && ActivePath.waypoints.Count > 0)
            {
                FSM.Initialize(StateMove);
            }
            else
            {
                Debug.LogWarning($"{name}: No PatrolPath found! Standing still.");
                FSM.Initialize(StateAttack);
            }
        }

        protected override void RunAI() { }

        public IEnumerator ExecutePattern(AttackPatternSO pattern)
        {
            if (pattern == null || projectilePrefab == null) yield break;

            yield return new WaitForSeconds(pattern.startDelay);

            float angleStep = (pattern.spreadAngle > 0 && pattern.projectileCount > 1)
                ? pattern.spreadAngle / (pattern.projectileCount - 1)
                : 0;

            float startAngle = -pattern.spreadAngle / 2f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                float currentAngle = startAngle + (angleStep * i);

                if (pattern.spinDuringFire)
                    startAngle += pattern.spinSpeed * pattern.delayBetweenShots;

                Quaternion rot = transform.rotation * Quaternion.Euler(0, currentAngle, 0);
                Vector3 fireDir = rot * Vector3.forward;

                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;

                FireProjectile(projectilePrefab, spawnPos, rot, fireDir, pattern.speed);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }
        }

        // --- PATHFINDING HELPERS ---
        private PatrolPath FindNearestPath()
        {
            PatrolPath[] allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath closest = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float dist = Vector3.Distance(transform.position, path.waypoints[0].position);
                    if (dist < closestDist)
                    {
                        closestDist = dist;
                        closest = path;
                    }
                }
            }
            return closest;
        }

        public Transform GetCurrentWaypoint()
        {
            if (ActivePath == null || ActivePath.waypoints.Count == 0) return null;
            return ActivePath.waypoints[CurrentWaypointIndex];
        }

        public void AdvanceWaypoint()
        {
            if (ActivePath == null) return;
            CurrentWaypointIndex++;
            if (CurrentWaypointIndex >= ActivePath.waypoints.Count)
            {
                CurrentWaypointIndex = (ActivePath.loop) ? 0 : ActivePath.waypoints.Count - 1;
            }
        }

        // --- PUBLIC ACCESSORS (Fixes CS1061) ---
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;

        // This was the missing one:
        public Transform GetTarget() => _currentTarget;
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Sentinel.cs`
- Lines: 88
- Size: 3.0 KB
- Modified: 2025-12-14 10:25

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Sentinel; // Sub-namespace for States

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Sentinel : EnemyBaseAI
    {
        [Header("Tactics")]
        public float combatRange = 10f; // Switch to Combat
        public float huntRange = 15f;   // Switch back to Hunt

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireRate = 2.0f;

        [Header("Steering Profiles")]
        // Assigned in Inspector (e.g. Seek, AvoidWalls)
        public List<SteeringBehavior> huntBehaviors;
        // Assigned in Inspector (e.g. Orbit, Flee, AvoidWalls)
        public List<SteeringBehavior> combatBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public SentinelState_Hunt StateHunt { get; private set; }
        public SentinelState_Combat StateCombat { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            // Initialize States
            StateHunt = new SentinelState_Hunt(this);
            StateCombat = new SentinelState_Combat(this);
        }

        protected override void Start()
        {
            base.Start();
            // Start Hunting immediately
            FSM.Initialize(StateHunt);
        }

        protected override void RunAI()
        {
            // Logic is delegated to the FSM component via its own Update loop.
        }

        // --- HELPERS FOR STATES ---

        public void HelperFireProjectile()
        {
            if (projectilePrefab && !_controller.IsStaggered)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;

                // Use BaseAI helper to spawn via Pool
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
            }
        }

        // Expose protected members to States
        public Transform GetTarget() => _currentTarget;
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;

        private void OnDrawGizmosSelected()
        {
            // Visualize the hysteresis ranges
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, combatRange);
            Gizmos.color = new Color(1, 1, 0, 0.3f);
            Gizmos.DrawWireSphere(transform.position, huntRange);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Sniper.cs`
- Lines: 86
- Size: 2.9 KB
- Modified: 2025-12-14 10:23

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.States.Sniper;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Sniper : EnemyBaseAI
    {
        [Header("Tactics")]
        public float panicDistance = 6f;
        public float attackRange = 18f;

        [Tooltip("How far to jump when panicking")]
        public float teleportDistance = 12f; // NEW: Configurable
        public float teleportCooldown = 5f;
        public LayerMask wallLayer;

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public LineRenderer laserSight;
        public float fireRate = 3.0f;
        public float aimDuration = 1.5f;

        [Header("Steering Profiles (Optimization)")]
        // NEW: Pre-allocated lists to prevent Garbage Collection spikes
        public List<SteeringBehavior> positioningBehaviors;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATES --
        public SniperState_Positioning StatePositioning { get; private set; }
        public SniperState_Aiming StateAiming { get; private set; }
        public SniperState_Teleport StateTeleport { get; private set; }
        public SniperState_Firing StateFiring { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);

            // Initialize States
            StatePositioning = new SniperState_Positioning(this);
            StateAiming = new SniperState_Aiming(this);
            StateTeleport = new SniperState_Teleport(this);
            StateFiring = new SniperState_Firing(this);
        }

        protected override void Start()
        {
            base.Start();
            if (laserSight) laserSight.enabled = false;

            FSM.Initialize(StatePositioning);
        }

        protected override void RunAI()
        {
            // Logic delegated to FSM
        }

        // Helpers
        public void HelperFireProjectile(float speed)
        {
            if (projectilePrefab)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, speed);
            }
        }

        public Transform GetTarget() => _currentTarget;
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyBaseAI.cs`
- Lines: 107
- Size: 3.3 KB
- Modified: 2025-12-14 08:33

```csharp
using UnityEngine;
using DG.Tweening; // Logic relies on Tweening
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(EnemyController))]
    public abstract class EnemyBaseAI : MonoBehaviour, IPoolable
    {
        protected EnemyMotor _motor;
        protected EnemyController _controller;
        protected Transform _player;
        protected Transform _currentTarget;

        // Spawn state gate (prevents AI ticking during spawn animation)
        protected bool _isSpawning = false;

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
        }

        // REPLACE old OnEnable with OnSpawn
        public virtual void OnSpawn()
        {
            _isSpawning = true;
            transform.localScale = Vector3.zero;

            GameEvents.OnEnemySpawned?.Invoke(transform.position);

            transform.DOScale(Vector3.one, 0.8f)
                .SetEase(Ease.OutBack)
                .OnComplete(() => _isSpawning = false);

            // Reset any child AI timers here if needed
        }

        public virtual void OnDespawn()
        {
            transform.DOKill(); // Stop scaling tween
            _isSpawning = false;
        }

        protected virtual void Start()
        {
            GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _player = p.transform;
                _currentTarget = _player;
            }

            GameEvents.OnDecoySpawned += OnDecoySpawned;
            GameEvents.OnDecoyExpired += OnDecoyExpired;
        }

        protected virtual void OnDestroy()
        {
            GameEvents.OnDecoySpawned -= OnDecoySpawned;
            GameEvents.OnDecoyExpired -= OnDecoyExpired;
        }

        private void Update()
        {
            // BLOCK LOGIC IF SPAWNING
            if (_isSpawning) return;

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
            if (prefab == null) return;

            // 1. Spawn via Pool
            GameObject p = PoolManager.Instance.Spawn(prefab, position, rotation);

            // 2. Setup Logic
            Projectile proj = p.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.ResetHostility(true); // Enemies always shoot hostile
                proj.speed = speed;
                proj.Initialize(direction);
            }
        }

        // --- EVENTS ---
        private void OnDecoySpawned(Transform decoy) { _currentTarget = decoy; }
        private void OnDecoyExpired() { if (_player != null) _currentTarget = _player; }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyController.cs`
- Lines: 234
- Size: 7.1 KB
- Modified: 2025-12-14 08:44

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable, IPoolable
    {
        private EnemyStatsSO _stats;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Color normalColor = Color.red;
        public Color staggerColor = Color.yellow;
        public Color flashColor = Color.white;

        [Header("Audio")]
        public AudioClip staggerClip;

        private EnemyMotor _motor;
        private float _currentStagger;
        private float _lastHitTime;
        public bool IsStaggered { get; private set; }

        // OPTIMIZATION: Property Block to avoid Material Instancing
        private MaterialPropertyBlock _propBlock;
        private Tween _flashTween;
        private int _colorPropID;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();

            // Setup Property Block
            _propBlock = new MaterialPropertyBlock();
            // URP usually uses "_BaseColor", Built-in uses "_Color"
            _colorPropID = Shader.PropertyToID("_BaseColor");
        }

        // --- IPoolable Implementation ---
        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            ResetState();
        }

        public void OnDespawn()
        {
            // Kill tweens safely
            transform.DOKill();
            if (_flashTween != null) _flashTween.Kill();

            // Reset color immediately so it doesn't spawn flashing next time
            SetColor(normalColor);
        }
        // --------------------------------

        private void Start()
        {
            // Initial color set
            SetColor(normalColor);

            // Fallback for non-pooled usage
            if (_motor != null && _stats == null) _stats = _motor.stats;
        }

        private void ResetState()
        {
            IsStaggered = false;
            _currentStagger = 0;
            SetColor(normalColor);
        }

        private void Update()
        {
            if (_stats == null) return;

            if (!IsStaggered && _currentStagger > 0)
            {
                if (Time.time > _lastHitTime + 1.0f)
                {
                    _currentStagger -= _stats.staggerDecay * Time.deltaTime;
                    if (_currentStagger < 0) _currentStagger = 0;
                }
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_stats == null) return false;

            _lastHitTime = Time.time;

            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            if (_stats.hasFrontalShield && !IsStaggered)
            {
                Vector3 incomingDir = info.pushDirection.normalized;
                float impactAngle = Vector3.Dot(transform.forward, -incomingDir);

                if (impactAngle > _stats.shieldAngle)
                {
                    GameEvents.OnPopupText?.Invoke(transform.position, "BLOCKED");
                    return false;
                }
            }

            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            bool isBigHit = info.isRedirected || IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isBigHit);

            if (IsStaggered)
            {
                if (info.damageAmount > 0) Kill(false);
            }
            else
            {
                AddStagger(info.staggerAmount);
                Flash();
            }

            return true;
        }

        private void AddStagger(float amount)
        {
            _currentStagger += amount;
            if (_currentStagger >= _stats.maxStagger)
            {
                EnterStaggerState();
            }
        }

        private void EnterStaggerState()
        {
            IsStaggered = true;
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (GameFeel.Instance && staggerClip)
                GameFeel.Instance.PlaySound(staggerClip, 1f, true);

            // Start Flashing via Tween that updates PropertyBlock
            if (_flashTween != null) _flashTween.Kill();

            // We tween a dummy value to drive the update loop
            float flashLerp = 0f;
            _flashTween = DOTween.To(() => flashLerp, x => flashLerp = x, 1f, 0.2f)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.Linear)
                .OnUpdate(() =>
                {
                    // Manually Lerp color and apply block
                    Color c = Color.Lerp(staggerColor, Color.red, flashLerp);
                    SetColor(c);
                });

            DOVirtual.DelayedCall(2.0f, ExitStaggerState).SetId(gameObject); // ID for DOKill
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;

            if (_flashTween != null) _flashTween.Kill();
            _currentStagger = 0;
            SetColor(normalColor);
        }

        private void Flash()
        {
            // Simple 1-shot flash
            if (!IsStaggered)
            {
                if (_flashTween != null) _flashTween.Kill();

                SetColor(flashColor);
                _flashTween = DOVirtual.DelayedCall(0.1f, () =>
                {
                    if (!IsStaggered) SetColor(normalColor);
                }).SetId(gameObject);
            }
        }

        private void SetColor(Color c)
        {
            if (meshRenderer)
            {
                meshRenderer.GetPropertyBlock(_propBlock);
                _propBlock.SetColor(_colorPropID, c);
                meshRenderer.SetPropertyBlock(_propBlock);
            }
        }

        // Standard Kill (Player wins)
        public void Kill(bool instant)
        {
            // Pass 'true' for reward
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, true);
            SafeDestroy();
        }

        // Suicide / Hazard Death (Player gets nothing)
        public void SelfDestruct()
        {
            // Pass 'false' for reward
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats, false);
            SafeDestroy();
        }

        private void SafeDestroy()
        {
#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject)
                UnityEditor.Selection.activeGameObject = null;
#endif

            // Use Pool if IPoolable, otherwise Destroy
            if (PoolManager.Instance)
                PoolManager.Instance.Despawn(gameObject);
            else
                Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyMotors.cs`
- Lines: 171
- Size: 5.5 KB
- Modified: 2025-12-14 12:17

```csharp
using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(KinematicMover))]
    public class EnemyMotor : MonoBehaviour, IPoolable
    {
        [Header("Data Profile")]
        public EnemyStatsSO stats;

        [Header("Layers")]
        public LayerMask allyLayer;

        private KinematicMover _mover;
        private Vector3 _currentVelocity;
        private Vector3 _knockbackForce;
        private float _currentVerticalSpeed;
        private Collider[] _neighbors = new Collider[10];

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            if (allyLayer == 0) allyLayer = LayerMask.GetMask(GameConstants.LAYER_ENEMY);
        }

        private void OnEnable()
        {
            // Keep existing behavior even when not spawned via pool
            OnSpawn();
        }

        // --- IPoolable ---
        public void OnSpawn()
        {
            // Reset Physics State
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Reset Position logic
            if (stats != null && stats.rideHeight > 0)
            {
                Vector3 startPos = transform.position;
                startPos.y = 0;
                transform.position = startPos;
            }
        }

        public void OnDespawn()
        {
            // Stop moving immediately so we don't drift while in the pool
            _currentVelocity = Vector3.zero;
        }

        public void Move(Vector3 desiredDirection)
        {
            if (stats == null) return;

            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;
            Vector3 targetVel = desiredDirection * stats.moveSpeed;

            // 1. Separation
            if (stats.moveSpeed > 0.1f)
            {
                Vector3 separationPush = CalculateSeparation();
                targetVel += separationPush;
            }

            // 2. Inertia
            _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, stats.acceleration * dt);

            // 3. Knockback
            if (_knockbackForce.magnitude > 0.1f)
            {
                _knockbackForce = Vector3.Lerp(_knockbackForce, Vector3.zero, 5f * dt);
            }

            // 4. COMBINE
            Vector3 finalVelocity = _currentVelocity + _knockbackForce;

            // 5. VERTICAL LOGIC (Flight vs Gravity)
            if (stats.rideHeight > 0)
            {
                // FLYING: Calculate vertical velocity to reach height
                float currentY = transform.position.y;
                float targetY = stats.rideHeight;
                float newY = Mathf.SmoothDamp(currentY, targetY, ref _currentVerticalSpeed, stats.verticalSmoothTime);

                // Convert distance delta back to velocity for the motor
                float verticalVel = (newY - currentY) / dt;
                finalVelocity.y = verticalVel;
            }
            else
            {
                // WALKING: Apply Gravity if not grounded
                if (!_mover.IsGrounded)
                {
                    finalVelocity.y -= 20f; // Standard gravity
                }
                else
                {
                    finalVelocity.y = -2f; // Stick
                }
            }

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        private Vector3 CalculateSeparation()
        {
            Vector3 pushVector = Vector3.zero;

            // Use stats.separationRadius
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, stats.separationRadius, _neighbors, allyLayer);

            for (int i = 0; i < count; i++)
            {
                var neighbor = _neighbors[i];
                if (neighbor.gameObject == gameObject) continue;

                Vector3 direction = transform.position - neighbor.transform.position;
                float dist = direction.magnitude;

                if (dist < 0.01f) direction = Random.insideUnitSphere;

                pushVector += direction.normalized / (dist + 0.1f);
            }

            // Use stats.separationForce
            return pushVector * stats.separationForce;
        }

        // Standard Face Target (Uses Navigation Speed)
        public void FaceTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.rotationSpeed);
        }

        // Combat Face Target (Uses Slower Combat Speed)
        public void FaceCombatTarget(Vector3 targetPosition)
        {
            if (stats == null) return;
            RotateTowards(targetPosition, stats.combatRotationSpeed);
        }

        // Helper to avoid duplicate code
        private void RotateTowards(Vector3 targetPosition, float speed)
        {
            Vector3 dir = targetPosition - transform.position;
            dir.y = 0; 
            
            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, speed * Time.deltaTime);
            }
        }

        public void ApplyKnockback(Vector3 force)
        {
            force.y = 0;
            _knockbackForce += force;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\PatrolPath.cs`
- Lines: 28
- Size: 0.8 KB
- Modified: 2025-12-14 11:08

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Enemy
{
    public class PatrolPath : MonoBehaviour
    {
        public List<Transform> waypoints;
        public bool loop = true;

        private void OnDrawGizmos()
        {
            if (waypoints == null || waypoints.Count < 2) return;

            Gizmos.color = Color.cyan;
            for (int i = 0; i < waypoints.Count - 1; i++)
            {
                if (waypoints[i] && waypoints[i + 1])
                    Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }

            if (loop && waypoints[0] && waypoints[waypoints.Count - 1])
            {
                Gizmos.DrawLine(waypoints[waypoints.Count - 1].position, waypoints[0].position);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Chaser\ChaserState_Chase.cs`
- Lines: 42
- Size: 1.1 KB
- Modified: 2025-12-14 10:44

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Chase : State
    {
        private EnemyAgent_Chaser _agent;

        public ChaserState_Chase(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _agent.Brain.behaviors = _agent.chaseBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.attackRange)
            {
                // DELEGATE DECISION TO AGENT
                _agent.TriggerAttack();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Chaser\ChaserState_Primer.cs`
- Lines: 63
- Size: 1.9 KB
- Modified: 2025-12-14 10:45

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Chaser
{
    public class ChaserState_Priming : State
    {
        private EnemyAgent_Chaser _agent;
        private float _timer;
        private Tween _shakeTween;

        public ChaserState_Priming(EnemyAgent_Chaser agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.fuseDuration;

            // VISUAL WARNING: Shake the mesh
            // (Assumes Art is a child, so we shake the child or local rotation)
            // A simple scale punch or color flash works too.
            // Let's do a Color Flash + Scale Shake

            if (_agent.GetController().meshRenderer)
            {
                _agent.GetController().meshRenderer.material.DOColor(Color.red, 0.1f).SetLoops(-1, LoopType.Yoyo);
            }
            _agent.transform.DOShakeScale(_agent.fuseDuration, 0.5f, 20, 90);
        }

        public override void LogicUpdate()
        {
            _timer -= Time.deltaTime;

            // Lock rotation to target so it looks aggressive
            if (_agent.GetTarget() != null)
            {
                _agent.GetMotor().FaceTarget(_agent.GetTarget().position);
            }

            if (_timer <= 0)
            {
                _agent.DeployMine(); // CHANGED: Was Detonate()
            }
        }

        public override void Exit()
        {
            // Cleanup tweens if we get stunned/killed during priming
            _agent.transform.DOKill();
            if (_agent.GetController().meshRenderer)
                _agent.GetController().meshRenderer.material.DOKill();
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Guardian\GuardianState_Attack.cs`
- Lines: 62
- Size: 1.9 KB
- Modified: 2025-12-14 12:18

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Core.Data;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Attack : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Attack(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Stop Moving
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>(); 
            
            // 2. Start Shooting Routine
            _agent.StartCoroutine(AttackRoutine());
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            // Keep facing player while shooting (Slowly!)
            Transform combatTarget = _agent.GetTarget();
            if (combatTarget != null)
            {
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
        }

        private System.Collections.IEnumerator AttackRoutine()
        {
            // Debug check
            if (_agent.attackPatterns == null || _agent.attackPatterns.Count == 0)
            {
                Debug.LogWarning("Guardian has no Attack Patterns assigned!");
            }
            else
            {
                // Pick random pattern
                AttackPatternSO pattern = _agent.attackPatterns[Random.Range(0, _agent.attackPatterns.Count)];
                
                // Execute and Wait for it to finish
                yield return _agent.ExecutePattern(pattern);
            }
            
            // Cooldown after firing
            yield return new WaitForSeconds(1.5f);

            // Go back to moving
            _stateMachine.ChangeState(_agent.StateMove);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Guardian\GuardianState_Move.cs`
- Lines: 75
- Size: 2.5 KB
- Modified: 2025-12-14 12:17

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.AI.Core; // For AIData
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Guardian
{
    public class GuardianState_Move : State
    {
        private EnemyAgent_Guardian _agent;

        public GuardianState_Move(EnemyAgent_Guardian agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // 1. Set Steering to "Move Profile"
            _agent.Brain.behaviors = _agent.moveBehaviors;

            // 2. Tell the Brain to Seek the Waypoint
            // We must update AIData so ContextSolver knows where to go
            var aiData = _agent.GetComponent<AIData>();
            if (aiData != null)
            {
                aiData.currentTarget = _agent.GetCurrentWaypoint();
            }
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;

            Transform wp = _agent.GetCurrentWaypoint();

            // Safety: If path is broken/missing, switch to attack in place
            if (wp == null)
            {
                _stateMachine.ChangeState(_agent.StateAttack);
                return;
            }

            // --- MOVEMENT ---
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // --- ROTATION (Use SLOW Combat Speed when looking at player) ---
            Transform combatTarget = _agent.GetTarget();

            if (combatTarget != null)
            {
                // Use the slow rotation method for aiming at player
                _agent.GetMotor().FaceCombatTarget(combatTarget.position);
            }
            else
            {
                // Fallback: Face movement direction using normal speed
                if (moveDir.sqrMagnitude > 0.1f)
                    _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);
            }

            // --- TRANSITION ---
            // Check distance to Waypoint (flat check to ignore height diff)
            Vector3 toWaypoint = wp.position - _agent.transform.position;
            toWaypoint.y = 0;

            if (toWaypoint.magnitude < _agent.waypointTolerance)
            {
                _agent.AdvanceWaypoint(); // Select next point for NEXT time
                _stateMachine.ChangeState(_agent.StateAttack);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sentinel\SentinelState_Combat.cs`
- Lines: 56
- Size: 1.7 KB
- Modified: 2025-12-14 10:26

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Combat : State
    {
        private EnemyAgent_Sentinel _agent;
        private float _fireTimer;

        public SentinelState_Combat(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Orbit + Flee" Profile
            _agent.Brain.behaviors = _agent.combatBehaviors;

            // Randomize first shot
            _fireTimer = Random.Range(0.5f, _agent.fireRate);
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move (Orbit/Strafe)
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // 2. Aim (Always lock on target)
            _agent.GetMotor().FaceTarget(_agent.GetTarget().position);

            // 3. Fire
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0)
            {
                _agent.HelperFireProjectile();
                _fireTimer = _agent.fireRate;
            }

            // 4. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // Use "HuntRange" (hysteresis) to prevent flickering
            if (dist > _agent.huntRange)
            {
                _stateMachine.ChangeState(_agent.StateHunt);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sentinel\SentinelState_Hunt.cs`
- Lines: 44
- Size: 1.2 KB
- Modified: 2025-12-14 10:35

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sentinel
{
    public class SentinelState_Hunt : State
    {
        private EnemyAgent_Sentinel _agent;

        public SentinelState_Hunt(EnemyAgent_Sentinel agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Load "Seek" Profile
            _agent.Brain.behaviors = _agent.huntBehaviors;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetController().IsStaggered) return;
            if (_agent.GetTarget() == null) return;

            // 1. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetMotor().Move(moveDir);

            // Face movement
            if (moveDir.sqrMagnitude > 0.1f)
                _agent.GetMotor().FaceTarget(_agent.transform.position + moveDir);

            // 2. Transition Check
            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            if (dist <= _agent.combatRange)
            {
                _stateMachine.ChangeState(_agent.StateCombat);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Aiming.cs`
- Lines: 65
- Size: 1.9 KB
- Modified: 2025-12-14 10:23

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using System.Collections.Generic;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Aiming : State
    {
        private EnemyAgent_Sniper _agent;
        private float _timer;

        public SniperState_Aiming(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // STOP MOVING (Clear behaviors or set empty list)
            _agent.Brain.behaviors = new List<DarkTowerTron.AI.Core.SteeringBehavior>();

            _timer = _agent.aimDuration;
            if (_agent.laserSight) _agent.laserSight.enabled = true;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
                return;
            }

            _timer -= Time.deltaTime;

            // 1. Visuals
            if (_agent.laserSight)
            {
                Vector3 start = _agent.firePoint ? _agent.firePoint.position : _agent.transform.position;
                // Aim at chest
                Vector3 end = _agent.GetTarget().position + Vector3.up * 1.0f;
                _agent.laserSight.SetPosition(0, start);
                _agent.laserSight.SetPosition(1, end);
            }

            // 2. Tracking (Stop tracking in last 0.2s for fairness)
            if (_timer > 0.2f)
            {
                _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
            }

            // 3. Transition
            if (_timer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateFiring);
            }
        }

        public override void Exit()
        {
            if (_agent.laserSight) _agent.laserSight.enabled = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Firing.cs`
- Lines: 24
- Size: 0.6 KB
- Modified: 2025-12-14 10:24

```csharp
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Firing : State
    {
        private EnemyAgent_Sniper _agent;

        public SniperState_Firing(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // Shoot
            _agent.HelperFireProjectile(35f); // Fast bullet

            // Immediately return to positioning
            _stateMachine.ChangeState(_agent.StatePositioning);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Positioning.cs`
- Lines: 54
- Size: 1.6 KB
- Modified: 2025-12-14 10:24

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper
{
    public class SniperState_Positioning : State
    {
        private EnemyAgent_Sniper _agent;
        private float _cooldownTimer;

        public SniperState_Positioning(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            // OPTIMIZATION: Assign the pre-filled list reference. 
            // Zero Garbage Allocation.
            _agent.Brain.behaviors = _agent.positioningBehaviors;

            _cooldownTimer = 1.0f;
        }

        public override void LogicUpdate()
        {
            if (_agent.GetTarget() == null) return;

            if (_cooldownTimer > 0) _cooldownTimer -= Time.deltaTime;

            float dist = Vector3.Distance(_agent.transform.position, _agent.GetTarget().position);

            // 1. Panic
            if (dist < _agent.panicDistance)
            {
                _stateMachine.ChangeState(_agent.StateTeleport);
                return;
            }

            // 2. Attack
            if (dist < _agent.attackRange && _cooldownTimer <= 0)
            {
                _stateMachine.ChangeState(_agent.StateAiming);
                return;
            }

            // 3. Move
            Vector3 moveDir = _agent.Brain.GetDirectionToMove();
            _agent.GetComponent<EnemyMotor>().Move(moveDir);
            _agent.GetComponent<EnemyMotor>().FaceTarget(_agent.GetTarget().position);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\States\Sniper\SniperState_Teleport.cs`
- Lines: 61
- Size: 1.7 KB
- Modified: 2025-12-14 10:24

```csharp
using UnityEngine;
using DarkTowerTron.AI.FSM;
using DG.Tweening;
using DarkTowerTron.Enemy.Agents;

namespace DarkTowerTron.Enemy.States.Sniper

{
    public class SniperState_Teleport : State
    {
        private EnemyAgent_Sniper _agent;
        private bool _isTeleporting;

        public SniperState_Teleport(EnemyAgent_Sniper agent)
        {
            _agent = agent;
        }

        public override void Enter()
        {
            _isTeleporting = true;
            _agent.transform.DOScale(Vector3.zero, 0.2f).OnComplete(PerformJump);
        }

        private void PerformJump()
        {
            if (_agent == null) return;

            Vector3 dirAway = (_agent.transform.position - _agent.GetTarget().position).normalized;

            // CONFIGURABLE DISTANCE
            float dist = _agent.teleportDistance;
            Vector3 dest = _agent.transform.position + (dirAway * dist);

            // Wall Check
            if (UnityEngine.Physics.Raycast(_agent.transform.position, dirAway, out RaycastHit hit, dist, _agent.wallLayer))
            {
                dest = hit.point - (dirAway * 2f);
            }

            dest.y = 0;
            _agent.transform.position = dest;

            // Reset Velocity
            _agent.GetComponent<EnemyMotor>().OnSpawn();

            _agent.transform.DOScale(Vector3.one, 0.2f).OnComplete(() =>
            {
                _isTeleporting = false;
            });
        }

        public override void LogicUpdate()
        {
            if (!_isTeleporting)
            {
                _stateMachine.ChangeState(_agent.StatePositioning);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\ArenaSpawner.cs`
- Lines: 38
- Size: 1.1 KB
- Modified: 2025-12-11 13:58

```csharp
using UnityEngine;
using DarkTowerTron.Managers; // For PoolManager

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        /// <summary>
        /// Spawns an enemy at a specific index or random location.
        /// </summary>
        public void SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints.Length == 0 || prefab == null) return;

            Transform sp;

            // 1. Determine Position
            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length)
            {
                sp = spawnPoints[forcedIndex];
            }
            else
            {
                sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            }

            // 2. Add Offset (prevent stacking)
            Vector3 offset = Random.insideUnitSphere * 2.0f;
            offset.y = 0;

            // 3. Pool Spawn
            PoolManager.Instance.Spawn(prefab, sp.position + offset, Quaternion.LookRotation(sp.forward));
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\AudioManager.cs`
- Lines: 40
- Size: 1.1 KB
- Modified: 2025-12-11 14:14

```csharp
using UnityEngine;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        [Header("Sources")]
        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// Plays a sound with optional pitch randomization.
        /// </summary>
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;

            if (randomizePitch)
            {
                _sfxSource.pitch = Random.Range(0.9f, 1.1f);
            }
            else
            {
                _sfxSource.pitch = 1.0f;
            }

            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DamageTextManager.cs`
- Lines: 65
- Size: 2.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Setup")]
        public GameObject textPrefab; // Assign the prefab here

        [Header("Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0); // Spawn above enemy head
        public Color normalColor = Color.white;
        public Color critColor = Color.yellow;
        public Color infoColor = Color.cyan; // For "STAGGER"

        private void OnEnable()
        {
            GameEvents.OnDamageDealt += ShowDamage;
            GameEvents.OnPopupText += ShowPopup;
        }

        private void OnDisable()
        {
            GameEvents.OnDamageDealt -= ShowDamage;
            GameEvents.OnPopupText -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit)
        {
            if (textPrefab == null || PoolManager.Instance == null) return;

            // Spawn
            GameObject obj = PoolManager.Instance.Spawn(textPrefab, pos + offset, Quaternion.identity);

            // Configure
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();
            if (floatingText)
            {
                Color c = isCrit ? critColor : normalColor;
                float scale = isCrit ? 1.5f : 1.0f;

                // N0 formats to integer (10 instead of 10.0)
                floatingText.Initialize(amount.ToString("N0"), c, scale);

                // Billboarding: Make text face the camera
                obj.transform.forward = Camera.main.transform.forward;
            }
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            if (textPrefab == null || PoolManager.Instance == null) return;

            GameObject obj = PoolManager.Instance.Spawn(textPrefab, pos + offset, Quaternion.identity);
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(message, infoColor, 1.2f);
                obj.transform.forward = Camera.main.transform.forward;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\DebugController.cs`
- Lines: 75
- Size: 2.4 KB
- Modified: 2025-12-13 10:14

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Managers
{
    public class DebugController : MonoBehaviour
    {
        [Header("Cheats")]
        public bool godMode = false;
        public bool infiniteFocus = false;

        [Header("Spawn Keys (NumPad)")]
        public GameObject[] enemiesToSpawn; // Assign prefabs in Inspector

        private PlayerEnergy _energy;
        private PlayerHealth _health;

        private void Start()
        {
            // Find player components safely
            var p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _energy = p.GetComponent<PlayerEnergy>();
                _health = p.GetComponent<PlayerHealth>();
            }
        }

        private void Update()
        {
            // 1. Time Control
            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale = (Time.timeScale == 1f) ? 0.1f : 1f; // Slow motion toggle
            }

            // 2. Kill All
            if (Input.GetKeyDown(KeyCode.K))
            {
                var enemies = FindObjectsOfType<DarkTowerTron.Enemy.EnemyController>();
                foreach (var e in enemies) e.Kill(true);
            }

            // 3. Recharge
            if (Input.GetKeyDown(KeyCode.R) && _energy)
            {
                _energy.AddFocus(100f);
                if (_health) _health.HealGrit(2);
            }

            // 4. Manual Spawning (NumPad 1-4)
            if (Input.GetKeyDown(KeyCode.Keypad1)) Spawn(0); // Grunt
            if (Input.GetKeyDown(KeyCode.Keypad2)) Spawn(1); // Sniper
            if (Input.GetKeyDown(KeyCode.Keypad3)) Spawn(2); // Orbiter
            if (Input.GetKeyDown(KeyCode.Keypad4)) Spawn(3); // Guardian

            // 5. Cheats Application
            if (infiniteFocus && _energy) _energy.AddFocus(100f);
            if (godMode && _health) _health.HealGrit(2);
        }

        private void Spawn(int index)
        {
            if (index < 0 || index >= enemiesToSpawn.Length) return;

            // Spawn at cursor logic or random offset
            Vector3 spawnPos = Vector3.zero + Random.insideUnitSphere * 5f;
            spawnPos.y = 0;

            PoolManager.Instance.Spawn(enemiesToSpawn[index], spawnPos, Quaternion.identity);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\FeedbackDirector.cs`
- Lines: 71
- Size: 2.3 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // <--- THIS WAS MISSING

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Global Audio")]
        public AudioClip hitClip;
        public AudioClip killClip;
        public AudioClip playerHurtClip;

        [Header("Hull")]
        public AudioClip hullBreakClip; // Drag "Glass Shatter" or "Alarm" here

        private bool _hasLastHullState;
        private bool _lastHasHull;

        private void OnEnable()
        {
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnHullStateChanged += OnHullChanged;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnHullStateChanged -= OnHullChanged;
        }

        private void OnHullChanged(bool hasHull)
        {
            bool lostHull = _hasLastHullState && _lastHasHull && !hasHull;

            _hasLastHullState = true;
            _lastHasHull = hasHull;

            // Only play feedback if we LOST the hull (became false)
            if (!lostHull) return;

            if (AudioManager.Instance) AudioManager.Instance.PlaySound(hullBreakClip, 1.0f);
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.5f, 0.7f); // Big shake
            if (GameTime.Instance) GameTime.Instance.HitStop(0.2f); // Dramatic pause
        }

        private void OnPlayerHit()
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(playerHurtClip);

            // 2. Camera
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.3f, 0.5f);

            // 3. Time
            if (GameTime.Instance) GameTime.Instance.HitStop(0.1f);
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(killClip, 0.8f);

            // 2. Camera (Lighter shake)
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.15f, 0.2f);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameFeel.cs`
- Lines: 98
- Size: 3.0 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DG.Tweening; // Requires DOTween

namespace DarkTowerTron.Core
{
    public class GameFeel : MonoBehaviour
    {
        public static GameFeel Instance;

        [Header("Audio Settings")]
        [SerializeField] private AudioSource _sfxSource;
        [SerializeField] private AudioClip _hitClip;
        [SerializeField] private AudioClip _killClip;
        [SerializeField] private AudioClip _playerHurtClip;

        private Camera _childCam; // The camera we shake (Child of Rig)

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // Find the Main Camera (which should be the Child of CameraRig)
            _childCam = Camera.main;
            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            // Auto-hook into events for generic feedback
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        // --- PUBLIC API ---

        public void CameraShake(float duration, float strength)
        {
            if (_childCam == null) return;
            // Shake local position so it doesn't fight the CameraRig's smooth follow
            _childCam.transform.DOShakePosition(duration, strength, 20, 90, false, true);
        }

        public void HitStop(float duration)
        {
            if (Time.timeScale < 0.1f) return; // Don't stack stops
            StartCoroutine(DoHitStop(duration));
        }

        // Updated API: Added 'randomizePitch' bool
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (!clip || !_sfxSource) return;

            if (randomizePitch)
            {
                _sfxSource.pitch = Random.Range(0.9f, 1.1f);
            }
            else
            {
                _sfxSource.pitch = 1.0f;
            }

            _sfxSource.PlayOneShot(clip, volume);
        }

        // --- EVENT HANDLERS ---

        private void OnPlayerHit()
        {
            PlaySound(_playerHurtClip);
            CameraShake(0.3f, 0.5f); // Heavy shake on damage
            HitStop(0.1f);
        }

        // Update the signature
        private void OnEnemyKilled(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats, bool rewardPlayer)
        {
            PlaySound(_killClip, 0.8f);
            CameraShake(0.15f, 0.2f); 
        }

        // --- INTERNAL ---

        System.Collections.IEnumerator DoHitStop(float duration)
        {
            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);
            Time.timeScale = 1.0f;
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\GameSession.cs`
- Lines: 139
- Size: 4.0 KB
- Modified: 2025-12-13 14:45

```csharp
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
```

## 📄 `Assets\Scripts\Managers\HUDManager.cs`
- Lines: 128
- Size: 4.2 KB
- Modified: 2025-12-14 08:19

```csharp
using UnityEngine;
using UnityEngine.UI;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [Header("Focus")]
        public Slider focusSlider;
        public Image focusFillImage;
        public Color normalFocusColor = Color.cyan;
        public Color overheatFocusColor = Color.red;

        [Header("Grit (Health)")]
        public GameObject[] gritPips; // Drag your Pip Images here
        public Color activePipColor = Color.white;
        public Color inactivePipColor = new Color(1, 1, 1, 0.2f); // Faded

        [Header("Hull / Wound")]
        public Image hullIcon; // Assign the Wound Image
        public Color hullActiveColor = Color.cyan; // Shield is UP
        public Color hullBrokenColor = new Color(1, 0, 0, 0.3f); // Shield BROKEN (Red/Transparent)

        [Header("System")]
        public TMPro.TextMeshProUGUI waveText;

        [Header("Score UI")]
        public TMPro.TextMeshProUGUI scoreText;
        public TMPro.TextMeshProUGUI multiplierText;
        public TMPro.TextMeshProUGUI timerText;

        private void Update()
        {
            // Simple Timer Update
            if (timerText && Managers.ScoreManager.Instance)
            {
                float t = Managers.ScoreManager.Instance.GameTime;
                // Format 00:00
                string minutes = Mathf.Floor(t / 60).ToString("00");
                string seconds = (t % 60).ToString("00");
                timerText.text = $"{minutes}:{seconds}";
            }
        }

        private void OnEnable()
        {
            GameEvents.OnFocusChanged += UpdateFocus;
            GameEvents.OnGritChanged += UpdateGrit;
            GameEvents.OnScoreChanged += UpdateScoreUI;
            GameEvents.OnHullStateChanged += UpdateHull;
            // Optional: Listen for wave changes if we added that event
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
            GameEvents.OnScoreChanged -= UpdateScoreUI;
            GameEvents.OnHullStateChanged -= UpdateHull;
        }

        private void UpdateHull(bool hasHull)
        {
            if (!hullIcon) return;

            if (hasHull)
            {
                // Hull is intact
                hullIcon.color = hullActiveColor;
                // Optional: hullIcon.sprite = shieldSprite;
            }
            else
            {
                // Hull is gone (Danger State)
                hullIcon.color = hullBrokenColor;
                // Optional: hullIcon.sprite = brokenSkullSprite;
            }
        }

        private void UpdateFocus(float current, float max)
        {
            if (focusSlider)
            {
                focusSlider.value = current / max;
            }

            // Optional: Change color if full (Overheat warning)
            if (focusFillImage)
            {
                focusFillImage.color = (current >= max) ? overheatFocusColor : normalFocusColor;
            }
        }

        private void UpdateGrit(int currentGrit)
        {

            Debug.Log($"[DEBUG HUD] Updating Grit UI: {currentGrit}");

            if (gritPips == null) return;

            Debug.Log($"[DEBUG HUD] Grit Pips Length: {gritPips.Length}");

            for (int i = 0; i < gritPips.Length; i++)
            {
                if (gritPips[i] == null) continue;

                Debug.Log($"[DEBUG HUD] Updating Pip {i}");

                Image pipImg = gritPips[i].GetComponent<Image>();
                if (pipImg)
                {

                    Debug.Log($"[DEBUG HUD] Setting Pip {i} Color");

                    // If currentGrit is 2, pips 0 and 1 are active.
                    pipImg.color = (i < currentGrit) ? activePipColor : inactivePipColor;
                }
            }
        }

        private void UpdateScoreUI(int score, int multiplier)
        {
            if (scoreText) scoreText.text = score.ToString("N0"); // "N0" adds commas (1,000)
            if (multiplierText) multiplierText.text = $"x{multiplier}";
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\MusicManager.cs`
- Lines: 53
- Size: 1.5 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DG.Tweening; // For smooth pitch fade
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        private AudioSource _source;
        private float _originalPitch;
        private float _originalVolume;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void OnEnable()
        {
            GameEvents.OnPlayerDied += OnDeath;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerDied -= OnDeath;
        }

        private void Start()
        {
            // Ensure loop is on
            _source.loop = true;
            if (!_source.isPlaying) _source.Play();
        }

        private void OnDeath()
        {
            // The "Power Down" Effect
            // Drop pitch to 0.5 and volume to 0.5 over 1 second
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true); // SetUpdate(true) ignores Time.timeScale = 0
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }

        // Called automatically when scene reloads
        public void ResetMusic()
        {
            _source.pitch = _originalPitch;
            _source.volume = _originalVolume;
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\PoolManager.cs`
- Lines: 89
- Size: 3.1 KB
- Modified: 2025-12-14 08:34

```csharp
using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        // Dictionary mapping a Prefab's InstanceID to a Queue of recycled objects
        private Dictionary<int, Queue<GameObject>> _poolDictionary = new Dictionary<int, Queue<GameObject>>();
        // Dictionary mapping a Spawned Object's InstanceID to the Prefab ID it came from (so we know where to return it)
        private Dictionary<int, int> _spawnedObjectsParentId = new Dictionary<int, int>();

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            int poolKey = prefab.GetInstanceID();

            if (!_poolDictionary.ContainsKey(poolKey))
            {
                _poolDictionary.Add(poolKey, new Queue<GameObject>());
            }

            GameObject objectToSpawn;

            // 1. POOLED OBJECT
            if (_poolDictionary[poolKey].Count > 0)
            {
                objectToSpawn = _poolDictionary[poolKey].Dequeue();

                // CRITICAL FIX: Move it BEFORE waking it up
                objectToSpawn.transform.position = position;
                objectToSpawn.transform.rotation = rotation;
            }
            // 2. NEW OBJECT
            else
            {
                // CRITICAL FIX: Instantiate AT position/rotation directly
                objectToSpawn = Instantiate(prefab, position, rotation);
                // OnEnable fires immediately here, but position is already correct
            }

            // Interface Call (root + children)
            objectToSpawn.SetActive(true);
            var poolables = objectToSpawn.GetComponentsInChildren<IPoolable>(true);
            foreach (var p in poolables) p.OnSpawn();

            // 3. Track it
            int instanceKey = objectToSpawn.GetInstanceID();
            if (!_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                _spawnedObjectsParentId.Add(instanceKey, poolKey);
            }

            return objectToSpawn;
        }

        public void Despawn(GameObject obj)
        {
            int instanceKey = obj.GetInstanceID();

            // Only pool objects we know about; otherwise destroy them
            if (_spawnedObjectsParentId.ContainsKey(instanceKey))
            {
                // Interface Call (root + children)
                var poolables = obj.GetComponentsInChildren<IPoolable>(true);
                foreach (var p in poolables) p.OnDespawn();

                int poolKey = _spawnedObjectsParentId[instanceKey];

                obj.SetActive(false);
                obj.transform.SetParent(transform); // Organize hierarchy

                _poolDictionary[poolKey].Enqueue(obj);
            }
            else
            {
                Destroy(obj);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\ScoreManager.cs`
- Lines: 98
- Size: 2.7 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance;

        [Header("Score Settings")]
        public int baseScorePerKill = 100;
        public int gloryKillBonus = 500;

        [Header("Multiplier Settings")]
        public int currentMultiplier = 1;
        public int maxMultiplier = 5;

        public int TotalScore { get; private set; }
        public float GameTime { get; private set; }

        private bool _isTracking = false;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        private void Start()
        {
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerHit += OnPlayerHit;
            _isTracking = true;
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerHit -= OnPlayerHit;
        }

        private void Update()
        {
            if (_isTracking) GameTime += Time.deltaTime;
        }

        // --- FIXED METHOD SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Determine score from Stats asset, or use default if missing
            int scoreValue = (stats != null) ? stats.scoreValue : baseScorePerKill;

            // Apply Multiplier
            AddScore(scoreValue * currentMultiplier);

            // Increase Multiplier
            if (currentMultiplier < maxMultiplier)
            {
                currentMultiplier++;
                UpdateUI();
            }
        }
        // -----------------------------

        private void OnPlayerHit()
        {
            if (currentMultiplier > 1)
            {
                currentMultiplier = 1;
                UpdateUI();
            }
        }

        public void StopTracking() { _isTracking = false; }

        public void AddScore(int amount)
        {
            TotalScore += amount;
            UpdateUI();
        }

        public void TriggerGloryKillBonus()
        {
            int bonus = gloryKillBonus * currentMultiplier;
            Debug.Log($"<color=yellow>GLORY KILL! +{bonus}</color>");
            AddScore(bonus);
        }

        private void UpdateUI()
        {
            GameEvents.OnScoreChanged?.Invoke(TotalScore, currentMultiplier);
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\VFXManager.cs`
- Lines: 48
- Size: 1.6 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class VFXManager : MonoBehaviour
    {
        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab; 

        private void OnEnable()
        {
            GameEvents.OnEnemyKilled += PlayDeathVFX;
            GameEvents.OnEnemySpawned += PlaySpawnVFX; // NEW
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= PlayDeathVFX;
            GameEvents.OnEnemySpawned -= PlaySpawnVFX;
        }

        // Update the signature to match the new Event
        private void PlayDeathVFX(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && PoolManager.Instance)
            {
                GameObject vfx = PoolManager.Instance.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && PoolManager.Instance)
            {
                // FIX: Force the VFX to the ground level (Y=0.1 to avoid z-fighting)
                Vector3 groundPos = new Vector3(pos.x, 0.1f, pos.z);

                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, groundPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Managers\WaveDirector.cs`
- Lines: 192
- Size: 6.5 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(ArenaSpawner))]
    public class WaveDirector : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> waves;
        public float timeBetweenWaves = 3.0f;

        private ArenaSpawner _spawner;

        private int _currentWaveIndex = 0;
        private int _essentialEnemiesAlive = 0;
        private int _gruntsAlive = 0;

        private bool _isSpawningMain = false;
        private bool _gameStarted = false;
        private Coroutine _gruntRoutine;

        private void Awake()
        {
            _spawner = GetComponent<ArenaSpawner>();
        }

        private void OnEnable() => GameEvents.OnEnemyKilled += OnEnemyKilled;
        private void OnDisable() => GameEvents.OnEnemyKilled -= OnEnemyKilled;

        public void StartGame()
        {
            _gameStarted = true;
            _currentWaveIndex = 0;
            StartCoroutine(StartGameRoutine());
        }

        private IEnumerator StartGameRoutine()
        {
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(RunWave(_currentWaveIndex));
        }

        private IEnumerator RunWave(int index)
        {
            if (index >= waves.Count)
            {
                GameEvents.OnGameVictory?.Invoke();
                yield break;
            }

            WaveDefinitionSO wave = waves[index];
            Debug.Log($"WAVE {index + 1}: {wave.waveName}");

            // --- COUNTDOWN ---
            GameEvents.OnWaveAnnounce?.Invoke(index);
            yield return new WaitForSeconds(1.0f);
            for (int c = 3; c > 0; c--)
            {
                GameEvents.OnCountdownChange?.Invoke(c.ToString());
                yield return new WaitForSeconds(1.0f);
            }
            GameEvents.OnCountdownChange?.Invoke("ENGAGE");
            GameEvents.OnWaveCombatStarted?.Invoke();
            yield return new WaitForSeconds(0.5f);
            GameEvents.OnCountdownChange?.Invoke("");
            // -----------------

            // Reset
            _isSpawningMain = true;
            _essentialEnemiesAlive = 0;
            _gruntsAlive = 0;

            // Start Grunt Logic (Infinite Reinforcements)
            if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
            _gruntRoutine = StartCoroutine(GruntLogic(wave));

            // Spawn Main Force
            foreach (var entry in wave.entries)
            {
                for (int i = 0; i < entry.count; i++)
                {
                    SpawnEnemy(entry.enemyPrefab, entry.spawnPointIndex);
                    yield return new WaitForSeconds(entry.rate);
                }
            }

            _isSpawningMain = false;
        }

        private IEnumerator GruntLogic(WaveDefinitionSO wave)
        {
            if (wave.maxGrunts <= 0 || wave.gruntPrefabs == null || wave.gruntPrefabs.Length == 0)
                yield break;

            // Anchor Logic: Keep spawning ONLY while VIPs are alive
            while (_essentialEnemiesAlive > 0 || _isSpawningMain)
            {
                if (_gruntsAlive < wave.maxGrunts)
                {
                    GameObject prefab = wave.gruntPrefabs[Random.Range(0, wave.gruntPrefabs.Length)];
                    SpawnEnemy(prefab, -1);
                }
                yield return new WaitForSeconds(wave.gruntSpawnRate);
            }
        }

        // NEW: We remove the 'isEssential' bool because we will ask the prefab itself
        private void SpawnEnemy(GameObject prefab, int forcedIndex)
        {
            if (_spawner == null) return;

            // SAFETY CHECK
            if (prefab == null)
            {
                Debug.LogError($"WaveDirector: Attempted to spawn NULL prefab in Wave {_currentWaveIndex}. Checking Next.");
                return;
            }

            _spawner.SpawnEnemy(prefab, forcedIndex);

            var motor = prefab.GetComponentInChildren<DarkTowerTron.Enemy.EnemyMotor>();
            bool countAsEssential = false;

            if (motor != null && motor.stats != null)
            {
                countAsEssential = motor.stats.isEssential;
            }
            else
            {
                // SAFETY FALLBACK:
                // If an enemy has no stats, we MUST assume it is Essential.
                // If we assume it is a Grunt, and it never dies properly or doesn't count,
                // the wave might hang. But if we assume Essential, at least the wave count goes up
                // and killing it will progress the wave.
                Debug.LogWarning($"Enemy {prefab.name} missing Stats! Defaulting to Essential to prevent soft-lock.");
                countAsEssential = true;
            }

            if (countAsEssential) _essentialEnemiesAlive++;
            else _gruntsAlive++;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!_gameStarted) return;

            if (stats != null && stats.isEssential)
            {
                _essentialEnemiesAlive--;

                // ANCHOR: If VIPs are dead, cut the reinforcement line immediately
                if (_essentialEnemiesAlive <= 0)
                {
                    if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);
                    Debug.Log("VIPs Down. Reinforcements Stopped.");
                }
            }
            else
            {
                _gruntsAlive--;
            }

            // Check victory on EVERY death (Grunt or VIP)
            CheckVictory();
        }

        private void CheckVictory()
        {
            // VICTORY CONDITION: Room must be totally silent.
            if (_essentialEnemiesAlive <= 0 && _gruntsAlive <= 0 && !_isSpawningMain)
            {
                Debug.Log("WAVE CLEARED - SECTOR SECURE");

                if (_gruntRoutine != null) StopCoroutine(_gruntRoutine);

                GameEvents.OnWaveCleared?.Invoke();
                _currentWaveIndex++;
                StartCoroutine(NextWaveRoutine());
            }
        }

        private IEnumerator NextWaveRoutine()
        {
            yield return new WaitForSeconds(timeBetweenWaves);
            StartCoroutine(RunWave(_currentWaveIndex));
        }
    }
}
```

## 📄 `Assets\Scripts\Physics\KinematicMover.cs`
- Lines: 261
- Size: 10.5 KB
- Modified: 2025-12-14 08:35

```csharp
using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Physics
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class KinematicMover : MonoBehaviour
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
        private HashSet<Collider> _ignoredColliders = new HashSet<Collider>();

        // Properties
        public Vector3 Velocity => _velocity;
        public bool IsGrounded => _isGrounded;
        public Vector3 GroundNormal => _groundNormal;

        private void Awake()
        {
            _capsule = GetComponent<CapsuleCollider>();
            if (Camera.main) _camTransform = Camera.main.transform;
            if (_obstacleMask == 0) _obstacleMask = 1;
        }

        public void Move(Vector3 desiredVelocity)
        {
            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

            // --- CULLING CHECK ---
            if (useCulling && _camTransform != null)
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
        public void IgnoreCollider(Collider col) => _ignoredColliders.Add(col);

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
                int count = UnityEngine.Physics.CapsuleCastNonAlloc(p1, p2, r, remaining.normalized, _hitBuffer, dist + _skinWidth, _obstacleMask);

                RaycastHit closest = default;
                float closestDist = Mathf.Infinity;
                bool hitFound = false;

                for (int j = 0; j < count; j++)
                {
                    if (_hitBuffer[j].distance <= 0 || _ignoredColliders.Contains(_hitBuffer[j].collider) || _hitBuffer[j].transform == transform) continue;
                    if (_hitBuffer[j].distance < closestDist)
                    {
                        closestDist = _hitBuffer[j].distance;
                        closest = _hitBuffer[j];
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
                if (col == _capsule || _ignoredColliders.Contains(col)) continue;
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

## 📄 `Assets\Scripts\Player\AfterImage.cs`
- Lines: 34
- Size: 0.9 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    public class AfterImage : MonoBehaviour
    {
        public float lifetime = 1.0f; // Decoy lasts 1 second (longer than dash)

        private void Start()
        {
            // 1. Notify Enemies: "Look at me!"
            GameEvents.OnDecoySpawned?.Invoke(transform);

            // 2. Visual Fade
            Renderer rend = GetComponentInChildren<Renderer>();
            if (rend)
            {
                // Fade alpha to 0
                rend.material.DOFade(0f, lifetime).SetEase(Ease.Linear);
            }

            // 3. Self Destruct
            Destroy(gameObject, lifetime);
        }

        private void OnDestroy()
        {
            // 4. Notify Enemies: "I'm dead, look at Player!"
            GameEvents.OnDecoyExpired?.Invoke();
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerAttack.cs`
- Lines: 94
- Size: 3.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening; 

namespace DarkTowerTron.Player
{
    public class PlayerAttack : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f; 
        public float selfRecoil = 15f;
        public LayerMask hitLayers; 
        public GameObject beamVisualPrefab; 

        private PlayerMovement _movement;

        // We override Awake to get the Movement reference, 
        // but we must call base.Awake() to get the Scanner too!
        protected override void Awake()
        {
            base.Awake(); 
            _movement = GetComponent<PlayerMovement>();
        }

        protected override void Fire()
        {
            // 1. Get Aim
            Vector3 fireDir = GetAimDirection();
            float beamLength = range;

            // 2. Hit Detection (Moved up to determine beam length)
            RaycastHit hit;
            bool hasHit = UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out hit, range, hitLayers);

            if (hasHit)
            {
                // NEW: Stop visual beam at the hit point
                // Calculate actual distance to hit
                beamLength = hit.distance;
            }

            // 3. Visuals
            if (beamVisualPrefab)
            {
                // We rotate the firepoint momentarily so the instantiated child aligns perfectly
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);
                
                // Scale Correction Logic
                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y; 
                float compZ  = beamLength / parentScale.z; // Use calculated length

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 4. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 5. Apply Damage
            if (hasHit)
            {
                // LOGIC CHECK:
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();
                
                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = 10f,
                        staggerAmount = 0.4f,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject
                    };

                    target.TakeDamage(info);
                    GameEvents.OnPlayerHit?.Invoke(); 
                }
                else
                {
                    // We hit a wall (No IDamageable). 
                    // The visual beam should stop here.
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerController.cs`
- Lines: 186
- Size: 6.0 KB
- Modified: 2025-12-14 08:28

```csharp
using UnityEngine;
using UnityEngine.InputSystem;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    // [RequireComponent(typeof(Blitz))] <-- REMOVE THIS
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovement _movement;
        
        // NEW REFERENCES
        private PlayerDodge _dodgeAbility;
        private PlayerExecution _executionAbility;

        // Weapon References
        private PlayerAttack _beamWeapon;
        private PlayerGun _gunWeapon;

        private GameControls _controls;
        private bool _inputEnabled = true;
        private Camera _cam;

        // Cache actions to avoid lookups in Update
        private InputAction _moveAction;
        private InputAction _lookPadAction;
        private InputAction _lookMouseAction;
        private InputAction _fireBeamAction;
        private InputAction _fireGunAction;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            
            // FIND NEW COMPONENTS
            _dodgeAbility = GetComponent<PlayerDodge>();
            _executionAbility = GetComponent<PlayerExecution>();
            
            _cam = Camera.main;

            _beamWeapon = GetComponent<PlayerAttack>();
            _gunWeapon = GetComponent<PlayerGun>();

            _controls = new GameControls();

            // --- STRICT BINDING (No Strings) ---
            // Direct access ensures compile-time errors if names change.

            // Cache actions once (no FindAction lookups)
            _moveAction = _controls.Gameplay.Move;
            _lookPadAction = _controls.Gameplay.LookGamepad;
            _lookMouseAction = _controls.Gameplay.LookMouse;
            _fireBeamAction = _controls.Gameplay.Melee;
            _fireGunAction = _controls.Gameplay.Gun;
        }

        private void OnEnable()
        {
            _controls.Gameplay.Blitz.performed += OnBlitzPerformed;
            _controls.Gameplay.GloryKill.performed += OnGloryKillPerformed;

            if (_inputEnabled) _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Gameplay.Blitz.performed -= OnBlitzPerformed;
            _controls.Gameplay.GloryKill.performed -= OnGloryKillPerformed;

            _controls.Disable();
        }

        private void OnBlitzPerformed(InputAction.CallbackContext ctx) => OnDodge();
        private void OnGloryKillPerformed(InputAction.CallbackContext ctx) => OnGloryKill();

        private void Update()
        {
            if (!_inputEnabled) return;

            HandleMovement();
            HandleAimingAndScanning();
            HandleFiring();
        }

        private void HandleMovement()
        {
            if (_moveAction == null) return;

            Vector2 input = _moveAction.ReadValue<Vector2>();
            Vector3 dir = new Vector3(input.x, 0, input.y).normalized;
            _movement.SetMoveInput(dir);
        }

        private void HandleAimingAndScanning()
        {
            Vector3 aimDir = transform.forward;

            // 1. Gamepad Stick
            if (_lookPadAction != null)
            {
                Vector2 stickInput = _lookPadAction.ReadValue<Vector2>();
                if (stickInput.sqrMagnitude > 0.05f)
                {
                    aimDir = new Vector3(stickInput.x, 0, stickInput.y).normalized;
                    _movement.LookAtDirection(aimDir);
                    UpdateScanner(aimDir); // Helper function
                    return; // Exit early if using stick
                }
            }

            // 2. Mouse
            if (_lookMouseAction != null)
            {
                Vector2 mousePos = _lookMouseAction.ReadValue<Vector2>();
                Ray ray = _cam.ScreenPointToRay(mousePos);
                Plane ground = new Plane(Vector3.up, Vector3.zero);

                if (ground.Raycast(ray, out float enter))
                {
                    Vector3 worldPoint = ray.GetPoint(enter);
                    Vector3 lookDir = (worldPoint - transform.position);
                    lookDir.y = 0;

                    if (lookDir != Vector3.zero)
                    {
                        aimDir = lookDir.normalized;
                        _movement.LookAtDirection(aimDir);
                    }
                }
            }

            UpdateScanner(aimDir);
        }

        private void UpdateScanner(Vector3 dir)
        {
            var scanner = GetComponent<TargetScanner>();
            if (scanner != null) scanner.UpdateScanner(dir);
        }

        private void HandleFiring()
        {
            // 1. Handle BEAM
            if (_beamWeapon != null)
            {
                // Direct access via generated class
                bool isBeam = _controls.Gameplay.Melee.ReadValue<float>() > 0.5f;
                _beamWeapon.SetFiring(isBeam);
            }

            // 2. Handle GUN
            if (_gunWeapon != null)
            {
                bool isGun = _controls.Gameplay.Gun.ReadValue<float>() > 0.5f;
                _gunWeapon.SetFiring(isGun);
            }
        }

        // --- ACTION HANDLERS ---

        private void OnDodge()
        {
            if (_inputEnabled && _dodgeAbility) _dodgeAbility.PerformDodge();
        }

        private void OnGloryKill()
        {
            if (_inputEnabled && _executionAbility) _executionAbility.PerformGloryKill();
        }

        public void ToggleInput(bool state)
        {
            _inputEnabled = state;
            if (state) _controls.Enable();
            else _controls.Disable();

            if (!state)
            {
                _movement.SetMoveInput(Vector3.zero);
                if (_beamWeapon != null) _beamWeapon.SetFiring(false);
                if (_gunWeapon != null) _gunWeapon.SetFiring(false);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerDodge.cs`
- Lines: 158
- Size: 5.0 KB
- Modified: 2025-12-13 11:15

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerDodge : MonoBehaviour
    {
        [Header("Dodge Settings")]
        public float focusCost = 25f;
        public float dashDistance = 8f;
        public float dashDuration = 0.15f;
        public LayerMask projectileLayer;
        public AudioClip dashClip; // Assign in Inspector

        [Header("Visuals")]
        public GameObject afterImagePrefab;
        public Transform indicatorRef;
        public Renderer indicatorRenderer;
        public Material readyMat;
        public Material notReadyMat;
        public LayerMask wallLayer;

        public bool IsInvulnerable { get; private set; }
        public bool IsDashing { get; private set; }

        private KinematicMover _mover;
        private PlayerEnergy _energy;
        private PlayerMovement _movement;

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _energy = GetComponent<PlayerEnergy>();
            _movement = GetComponent<PlayerMovement>();

            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        private void Update()
        {
            HandleIndicator();
        }

        public void PerformDodge()
        {
            if (IsDashing) return;

            if (_energy.SpendFocus(focusCost))
            {
                StartCoroutine(DodgeRoutine());
            }
        }

        private IEnumerator DodgeRoutine()
        {
            IsDashing = true;

            // PLAY SOUND
            if (GameFeel.Instance && dashClip) 
                GameFeel.Instance.PlaySound(dashClip, 1f, true);

            IsInvulnerable = true;
            if (indicatorRef) indicatorRef.gameObject.SetActive(false);

            // Visuals
            if (afterImagePrefab) Instantiate(afterImagePrefab, transform.position, transform.rotation);

            // Direction Logic
            Vector3 dashDir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dashDir = _movement.MoveInput.normalized;
            else dashDir = transform.forward;

            // Physics Loop
            // Speed in meters/second
            float speed = dashDistance / dashDuration;
            float timer = 0f;

            while (timer < dashDuration)
            {
                float dt = Time.deltaTime;
                timer += dt;
                // Do not multiply by dt here.
                // KinematicMover.Move(Velocity) applies (Velocity * dt) internally.
                _mover.Move(dashDir * speed);
                CatchProjectiles();
                yield return null;
            }

            yield return new WaitForSeconds(0.05f); // Recovery frame

            IsInvulnerable = false;
            IsDashing = false;
        }

        private void CatchProjectiles()
        {
            Collider[] hits = UnityEngine.Physics.OverlapSphere(transform.position, 2.5f, projectileLayer);
            foreach (var hit in hits)
            {
                IReflectable proj = hit.GetComponent<IReflectable>();
                var pScript = hit.GetComponent<Projectile>();

                if (proj != null && pScript != null && pScript.isHostile)
                {
                    proj.Redirect(transform.forward, gameObject);
                    _energy.AddFocus(20f);
                }
            }
        }

        private void HandleIndicator()
        {
            if (!indicatorRef) return;

            if (IsDashing)
            {
                indicatorRef.gameObject.SetActive(false);
                return;
            }

            indicatorRef.gameObject.SetActive(true);

            Vector3 dir;
            if (_movement.MoveInput.sqrMagnitude > 0.1f) dir = _movement.MoveInput.normalized;
            else dir = transform.forward;

            Vector3 targetPos;
            if (UnityEngine.Physics.Raycast(transform.position + Vector3.up * 0.5f, dir, out RaycastHit hit, dashDistance, wallLayer))
            {
                targetPos = hit.point - (dir * 0.5f);
            }
            else
            {
                targetPos = transform.position + (dir * dashDistance);
            }

            targetPos.y = 0.1f;
            indicatorRef.position = targetPos;
            indicatorRef.rotation = Quaternion.identity;

            if (indicatorRenderer && readyMat && notReadyMat)
            {
                bool canAfford = _energy.HasFocus(focusCost);
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

## 📄 `Assets\Scripts\Player\PlayerEnergy.cs`
- Lines: 100
- Size: 2.8 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Player
{
    public class PlayerEnergy : MonoBehaviour
    {
        [Header("Stats")]
        public float maxFocus = 100f;
        public float decayRate = 5f;

        [Header("Rewards (Defaults)")]
        public float defaultFocusOnKill = 30f;

        private float _currentFocus;
        private bool _isDead;
        private bool _isCombatActive = false;

        private void Start()
        {
            _currentFocus = maxFocus;

            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnPlayerDied += OnPlayerDied;

            GameEvents.OnWaveCombatStarted += EnableDecay;
            GameEvents.OnWaveCleared += DisableDecay;
            GameEvents.OnGameVictory += DisableDecay;

            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnPlayerDied -= OnPlayerDied;

            GameEvents.OnWaveCombatStarted -= EnableDecay;
            GameEvents.OnWaveCleared -= DisableDecay;
            GameEvents.OnGameVictory -= DisableDecay;
        }

        private void Update()
        {
            if (_isDead) return;

            if (_isCombatActive && _currentFocus > 0)
            {
                _currentFocus -= decayRate * Time.deltaTime;
                if (_currentFocus < 0) _currentFocus = 0;
                UpdateUI();
            }
        }

        // --- FIXED SIGNATURE ---
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Use specific reward if available, otherwise default
            float reward = (stats != null) ? stats.focusReward : defaultFocusOnKill;
            AddFocus(reward);
        }
        // -----------------------

        public bool HasFocus(float amount)
        {
            return _currentFocus >= amount;
        }

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
            if (_currentFocus > maxFocus) _currentFocus = maxFocus;
            UpdateUI();
        }

        private void EnableDecay() { _isCombatActive = true; }
        private void DisableDecay() { _isCombatActive = false; }

        private void OnPlayerDied() { _isDead = true; }

        private void UpdateUI()
        {
            GameEvents.OnFocusChanged?.Invoke(_currentFocus, maxFocus);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerExecution.cs`
- Lines: 86
- Size: 2.6 KB
- Modified: 2025-12-13 12:23

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // For ScoreManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip; // Assign in Inspector

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
        }

        public void PerformGloryKill()
        {
            if (_isBusy) return;

            // Logic Checks
            if (_scanner == null || _scanner.CurrentTarget == null)
            {
                // Optional: Play "Error" sound
                return;
            }

            if (!_scanner.CurrentTarget.IsStaggered)
            {
                // Optional: Play "Denied" sound
                return;
            }

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        private IEnumerator ExecutionRoutine(DarkTowerTron.Enemy.EnemyController target)
        {
            _isBusy = true;

            // 1. Teleport
            Vector3 enemyPos = target.transform.position;
            Vector3 attackPos = enemyPos - (transform.forward * 1.0f);
            transform.position = attackPos;

            // 2. Kill
            // This fires 'OnEnemyKilled', which PlayerHealth listens to for the heal.
            target.Kill(false);

            // PLAY SOUND
            if (GameFeel.Instance && executeClip) 
                GameFeel.Instance.PlaySound(executeClip, 1f);

            // 3. Rewards
            // Only handle Focus manually here (as a bonus for the move).
            // Health is handled by the Global Event "OnEnemyKilled".
            _energy.AddFocus(killRewardFocus);

            if (ScoreManager.Instance)
                ScoreManager.Instance.TriggerGloryKillBonus();

            // 4. Juice
            if (GameFeel.Instance)
            {
                GameFeel.Instance.HitStop(0.2f);
                GameFeel.Instance.CameraShake(0.3f, 0.8f);
            }

            yield return new WaitForSeconds(0.15f); // Animation lock

            _isBusy = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerGun.cs`
- Lines: 35
- Size: 1.1 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    // Inherits from WeaponBase instead of MonoBehaviour
    public class PlayerGun : WeaponBase 
    {
        [Header("Gun Specifics")]
        public GameObject bulletPrefab;
        public float bulletSpeed = 25f;

        protected override void Fire()
        {
            if (bulletPrefab && firePoint)
            {
                // 1. Get Aim (Handled by Base)
                Vector3 aimDir = GetAimDirection();

                // 2. Spawn
                GameObject p = PoolManager.Instance.Spawn(bulletPrefab, firePoint.position, Quaternion.LookRotation(aimDir));
                
                // 3. Setup
                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false; // Player bullet
                    proj.Initialize(aimDir);
                }
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerHealth.cs`
- Lines: 120
- Size: 3.5 KB
- Modified: 2025-12-14 08:43

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;
        public bool startWithHull = true; // Default to having the shield

        private int _currentGrit;
        private bool _hasHull;
        private bool _isDead;
        private PlayerMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
        }

        private void Start()
        {
            _currentGrit = maxGrit;
            _hasHull = startWithHull;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            UpdateUI();
        }

        private void OnDestroy()
        {
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            // 1. Calculate actual damage (for Grit calculation)
            int dmg = Mathf.Max(1, Mathf.RoundToInt(info.damageAmount));

            // LOGIC GATE
            if (_currentGrit > 0)
            {
                // PHASE 1: Take Grit Damage
                _currentGrit -= dmg;
                if (_currentGrit < 0) _currentGrit = 0; // Clamp, don't carry over damage to hull

                GameEvents.OnPlayerHit?.Invoke(); // Standard Ouch
            }
            else if (_hasHull)
            {
                // PHASE 2: Hull Break (Gate)
                // We absorb ALL damage from this single hit, regardless of amount.
                _hasHull = false;

                // Special Feedback for breaking the shield
                Debug.Log("<color=orange>HULL BREACHED!</color>");
                // We can fire OnPlayerHit for shake, or a specific Hull Break event
                GameEvents.OnPlayerHit?.Invoke();
            }
            else
            {
                // PHASE 3: Death
                Kill(false);
            }

            // Apply Physics (Always happens if not dead)
            if (!_isDead && _movement)
                _movement.ApplyKnockback(info.pushDirection * info.pushForce);

            UpdateUI();
            return true;
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            _currentGrit = 0;
            _hasHull = false;
            UpdateUI();

            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;

            // NOTE: We only heal Grit. Hull is not replenishable (per design).
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
            UpdateUI();
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (!rewardPlayer) return;

            // Only heal if allowed
            if (stats != null)
            {
                if (stats.healsGrit) HealGrit(stats.gritRewardAmount);
            }
            else
            {
                HealGrit(1);
            }
        }

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
            GameEvents.OnHullStateChanged?.Invoke(_hasHull);
        }
    }
}
```

## 📄 `Assets\Scripts\Player\PlayerMovement.cs`
- Lines: 165
- Size: 5.4 KB
- Modified: 2025-12-13 11:11

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Physics;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(KinematicMover))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Motion Settings")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        [Header("Wall Repulsion (Anti-Stick)")]
        public float wallBuffer = 0.6f; // How close before we push back (0.5 is player radius)
        public float repulsionForce = 5f; // How hard we push
        public LayerMask wallLayer;

        [Header("Physics")]
        public float gravity = 20f; // Gravity is controlled here

        // Expose input for Blitz
        public Vector3 MoveInput => _inputDir;

        private KinematicMover _mover;
        private Camera _cam;

        private Vector3 _inputDir;
        private Vector3 _currentVelocity;
        private Vector3 _externalForce;

        // Cache for optimization
        private Collider[] _wallBuffer = new Collider[5];

        private void Awake()
        {
            _mover = GetComponent<KinematicMover>();
            _cam = Camera.main;

            // Default mask if not set
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
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
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }

        public void LookAtMouse(Vector2 mouseScreenPos)
        {
            Ray ray = _cam.ScreenPointToRay(mouseScreenPos);
            // Use UnityEngine.Physics to disambiguate
            if (UnityEngine.Physics.Raycast(ray, out RaycastHit hit, 100f, LayerMask.GetMask(GameConstants.LAYER_GROUND)))
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
            HandleVelocity();
        }

        private void HandleVelocity()
        {
            float dt = Time.deltaTime;

            // 1. Calculate Target (Inputs)
            Vector3 targetVel = _inputDir * moveSpeed;
            Vector3 wallPush = CalculateWallRepulsion();
            targetVel += wallPush;

            // 2. Acceleration
            if (_inputDir.magnitude > 0.1f)
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, targetVel, acceleration * dt);
            }
            else
            {
                _currentVelocity = Vector3.MoveTowards(_currentVelocity, Vector3.zero, deceleration * dt);
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

            // 5. APPLY GRAVITY MANUALLY
            if (!_mover.IsGrounded)
            {
                // For a top-down game, a simple constant downward velocity works if we don't jump.
                finalVelocity.y -= gravity;
            }
            else
            {
                // Stick to ground
                finalVelocity.y = -2f;
            }

            // 6. EXECUTE
            _mover.Move(finalVelocity);
        }

        private Vector3 CalculateWallRepulsion()
        {
            Vector3 push = Vector3.zero;

            // Find walls within buffer range
            // We use the player's position + slight up offset (center of mass)
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position + Vector3.up, wallBuffer, _wallBuffer, wallLayer);

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
                    push += dir.normalized * repulsionForce;
                }
            }

            return push;
        }
    }
}
```

## 📄 `Assets\Scripts\Player\TargetScanner.cs`
- Lines: 94
- Size: 3.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy;

namespace DarkTowerTron.Player
{
    public class TargetScanner : MonoBehaviour
    {
        [Header("Settings")]
        public float scanRange = 25f; // Increased Default
        public float scanRadius = 2.0f; // Thicker Default
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public Transform reticlePrefab; 
        public Vector3 reticleOffset = new Vector3(0, 0.1f, 0);
        
        // NEW: Visual Feedback settings
        public Color lockedColor = Color.cyan;
        public Color executionColor = Color.yellow; // or Red

        public EnemyController CurrentTarget { get; private set; }

        private Transform _reticleInstance;
        private LineRenderer _reticleLine; // Assuming we use the LineRenderer reticle

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
            // Lift origin slightly to avoid floor clipping
            Vector3 origin = transform.position + Vector3.up * 1.0f;

            if (UnityEngine.Physics.SphereCast(origin, scanRadius, aimDirection, out RaycastHit hit, scanRange, enemyLayer))
            {
                EnemyController enemy = hit.collider.GetComponentInParent<EnemyController>();
                if (enemy != null)
                {
                    CurrentTarget = enemy;
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

## 📄 `Assets\Scripts\Player\WeaponBase.cs`
- Lines: 84
- Size: 2.4 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy;

namespace DarkTowerTron.Player
{
    // Abstract means you can't put this directly on an object, 
    // you must extend it (like PlayerGun : WeaponBase)
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        public float fireRate = 0.2f;
        
        [Header("Audio")]
        public AudioClip fireClip; // NEW: Drag sound here
        [Range(0f, 1f)] public float volume = 0.8f;

        protected float _timer;
        protected bool _isFiring;
        protected TargetScanner _scanner;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;

            if (_isFiring && _timer <= 0)
            {
                Fire();
                PlayFireSound(); // NEW
                _timer = fireRate;
            }
        }

        protected abstract void Fire();

        // NEW HELPER
        protected void PlayFireSound()
        {
            if (fireClip && GameFeel.Instance)
            {
                // Randomize pitch slightly for realism
                GameFeel.Instance.PlaySound(fireClip, volume, true); 
            }
        }

        // --- SHARED HELPER METHODS ---

        /// <summary>
        /// Calculates the best firing direction. 
        /// Defaults to forward. If Locked On, aims at Enemy Center Mass.
        /// </summary>
        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                // Logic moved here from Gun/Attack scripts
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
                
                // Try to find center of mass
                var col = _scanner.CurrentTarget.GetComponent<Collider>();
                if (col != null) targetPos = col.bounds.center;

                aimDir = (targetPos - firePoint.position).normalized;
            }

            return aimDir;
        }
    }
}
```

## 📄 `Assets\Scripts\UI\CountdownUI.cs`
- Lines: 68
- Size: 2.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Core;

namespace DarkTowerTron.UI
{
    public class CountdownUI : MonoBehaviour
    {
        [Header("UI References")]
        public TextMeshProUGUI waveTitleText; // "WAVE 1"
        public TextMeshProUGUI countdownText; // "3"

        private void Awake()
        {
            // Hide by default
            if (waveTitleText) waveTitleText.gameObject.SetActive(false);
            if (countdownText) countdownText.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameEvents.OnWaveAnnounce += ShowWaveTitle;
            GameEvents.OnCountdownChange += UpdateCountdown;
        }

        private void OnDisable()
        {
            GameEvents.OnWaveAnnounce -= ShowWaveTitle;
            GameEvents.OnCountdownChange -= UpdateCountdown;
        }

        private void ShowWaveTitle(int waveIndex)
        {
            if (waveTitleText)
            {
                waveTitleText.text = $"WAVE {waveIndex + 1}"; // +1 because index starts at 0
                waveTitleText.gameObject.SetActive(true);

                // Animation: Scale Up and Fade In
                waveTitleText.transform.localScale = Vector3.zero;
                waveTitleText.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
                waveTitleText.alpha = 1f;
            }
        }

        private void UpdateCountdown(string text)
        {
            if (countdownText)
            {
                // If text is empty, hide everything
                if (string.IsNullOrEmpty(text))
                {
                    countdownText.gameObject.SetActive(false);
                    if (waveTitleText) waveTitleText.DOFade(0, 0.5f); // Fade out title
                    return;
                }

                countdownText.gameObject.SetActive(true);
                countdownText.text = text;

                // Punch Animation for every number
                countdownText.transform.localScale = Vector3.one;
                countdownText.transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\FloatingText.cs`
- Lines: 56
- Size: 1.6 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DG.Tweening;
using DarkTowerTron.Managers; // Needed to talk to PoolManager

namespace DarkTowerTron.UI
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

        public void Initialize(string text, Color color, float sizeScale = 1f)
        {
            // 1. Setup Text
            textMesh.text = text;
            textMesh.color = color;
            textMesh.alpha = 1f;

            // 2. Reset Transform
            transform.localScale = Vector3.one * sizeScale;

            // 3. Animate Move Up
            transform.DOMoveY(transform.position.y + floatDistance, duration)
                .SetEase(motionEase);

            // 4. Animate Fade Out (start halfway through)
            textMesh.DOFade(0f, duration * 0.5f)
                .SetDelay(duration * 0.5f)
                .OnComplete(Despawn);

            // 5. Juice: Punch Scale
            transform.DOPunchScale(Vector3.one * 0.5f, 0.2f);
        }

        private void Despawn()
        {
            // Return to pool
            if (PoolManager.Instance != null)
            {
                PoolManager.Instance.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\UI\ResultScreen.cs`
- Lines: 56
- Size: 1.8 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using TMPro;
using DarkTowerTron.Managers;

namespace DarkTowerTron.UI
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

        // Called automatically when the GameObject is enabled (SetActive true)
        private void OnEnable()
        {
            if (ScoreManager.Instance == null) return;

            // 1. Stop the Timer
            ScoreManager.Instance.StopTracking();

            // 2. Get Stats
            int finalScore = ScoreManager.Instance.TotalScore;
            float finalTime = ScoreManager.Instance.GameTime;

            // 3. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                string minutes = Mathf.Floor(finalTime / 60).ToString("00");
                string seconds = (finalTime % 60).ToString("00");
                timeText.text = $"{minutes}:{seconds}";
            }

            // 4. Calculate Rank
            if (rankText)
            {
                string rank = "C";
                Color rankColor = Color.grey;

                if (finalScore >= rankS_Threshold) { rank = "S"; rankColor = Color.cyan; }
                else if (finalScore >= rankA_Threshold) { rank = "A"; rankColor = Color.green; }
                else if (finalScore >= rankB_Threshold) { rank = "B"; rankColor = Color.yellow; }

                rankText.text = rank;
                rankText.color = rankColor;
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Visuals\CameraShaker.cs`
- Lines: 29
- Size: 0.7 KB
- Modified: 2025-12-11 14:17

```csharp
using UnityEngine;
using DG.Tweening;

namespace DarkTowerTron.Visuals
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
