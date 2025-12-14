# 📦 Codebase Export
- **Profile:** `unity`
- **Generated:** 2025-12-13 12:31
- **Files:** 49
- **Total LOC:** 4081
- **Estimated tokens:** 32041

## 📁 Project Tree
```
Assets
  Scripts
    Combat
      Projectile.cs
    Core
      CameraRig.cs
      CircleRenderer.cs
      Data
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
        EnemyAgent_Orbiter.cs
        EnemyAgent_Sentinel.cs
      EnemyController.cs
      EnemyMotors.cs
      Legacy
        EnemyAI_Chaser.cs
        EnemyAI_Sniper.cs
        EnemyAI_Strafer.cs
        EnemyAI_Turret.cs
        EnemyBaseAI.cs
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
    Physic
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

## 📄 `Assets\Scripts\Combat\Projectile.cs`
- Lines: 144
- Size: 5.2 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // Needed for PoolManager

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable
    {
        [Header("Ballistics")]
        public float speed = 15f;
        public float lifetime = 5f;
        public bool isHostile = true;

        [Header("Damage Stats")]
        public float damage = 10f;
        public float stagger = 0f;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Material friendlyMaterial;
        // Cache original material to reset on respawn
        private Material _originalMaterial;

        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false;
        private float _lifeTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.material;
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;

            // RESET STATE (Crucial for Pooling)
            _isRedirected = false;

            // Restore original settings if we were redirected previously
            // Note: If you have different prefabs for Player vs Enemy, this usually handles itself,
            // but resetting material is safe.
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;

            // Reset Hostile State? 
            // Better to rely on the Spawner to set 'isHostile' correctly after spawning, 
            // OR reset to default here if the prefab dictates it. 
            // For now, we assume the Spawner doesn't change isHostile, but Redirect does.
            // So we must reset it.
            // Assumption: Prefab default is correct.
            // But wait! If we pool it, 'isHostile' might be stuck at false from previous redirection.
            // We need to reset it. But we don't know if the original was true or false (Player vs Enemy).
            // SIMPLE FIX: Reset logic is handled, but 'isHostile' needs to be passed in Initialize if we want perfection.
            // For this prototype, let's assume Redirect is the only thing changing it.

            // Actually, let's be safe. Initialize should take parameters or reset to Inspector defaults?
            // Inspector defaults are lost on runtime change.
            // Let's rely on the Prefab's integrity: 
            // A PlayerBullet Prefab always starts non-hostile. An EnemyBullet always starts hostile.
            // We just need to revert the "Redirect" changes.
        }

        // RESET LOGIC WHEN PULLED FROM POOL
        public void ResetHostility(bool startHostile)
        {
            isHostile = startHostile;
        }

        private void Update()
        {
            if (!_isInitialized) return;

            transform.Translate(_direction * speed * Time.deltaTime, Space.World);

            // Manual Lifetime check
            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0)
            {
                Despawn();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.isTrigger) return;

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
            else if (other.gameObject.layer == LayerMask.NameToLayer(GameConstants.LAYER_WALL) ||
                     other.gameObject.layer == LayerMask.NameToLayer("Default"))
            {
                Despawn();
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

            _lifeTimer = 3.0f; // Renew lifetime
        }

        private void Despawn()
        {
            // Use PoolManager if it exists, otherwise Destroy
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

## 📄 `Assets\Scripts\Core\Data\EnemyStatsSO.cs`
- Lines: 39
- Size: 1.2 KB
- Modified: 2025-12-11 14:21

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
        [Min(1)] public int gritRewardAmount = 1; // NEW: Default to 1

        [Header("Movement")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f;
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
- Lines: 41
- Size: 1.3 KB
- Modified: 2025-12-11 14:03

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

        // NEW: Passes Position AND Stats (to check if essential)
        public static Action<Vector3, EnemyStatsSO> OnEnemyKilled;

        public static Action OnPlayerHit;
        public static Action OnPlayerDied;

        // Feedback
        public static Action<Vector3, float, bool> OnDamageDealt;
        public static Action<Vector3, string> OnPopupText;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

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
- Lines: 31
- Size: 0.7 KB
- Modified: 2025-12-11 07:51

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
- Lines: 70
- Size: 2.2 KB
- Modified: 2025-12-13 12:26

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Kamikaze Settings")]
        public float attackRange = 1.5f; // Distance to trigger explosion
        public float damage = 1f;
        public float explosionForce = 20f;

        private ContextSolver _brain;

        protected override void Awake()
        {
            base.Awake();
            _brain = GetComponent<ContextSolver>();
        }

        protected override void RunAI()
        {
            // 1. Navigation (Smart)
            Vector3 smartDir = _brain.GetDirectionToMove();
            _motor.Move(smartDir);

            // Face movement direction
            if (smartDir.sqrMagnitude > 0.1f)
            {
                _motor.FaceTarget(transform.position + smartDir);
            }

            // 2. Attack Check (Distance)
            float dist = Vector3.Distance(transform.position, _currentTarget.position);

            if (dist <= attackRange)
            {
                Detonate();
            }
        }

        private void Detonate()
        {
            // 1. Try to Damage the Target
            IDamageable target = _currentTarget.GetComponent<IDamageable>();

            // If target is the player (or decoy with health), hurt them
            if (target != null)
            {
                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = transform.forward,
                    pushForce = explosionForce,
                    source = gameObject
                };
                target.TakeDamage(info);
            }

            // 2. Die (This triggers the Orange Explosion VFX via Event System)
            // We pass 'false' because we don't need a second kill sound, 
            // the explosion IS the sound.
            // Note: If you want a specific "Boom" sound different from death, add it here.
            _controller.Kill(true);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Orbiter.cs`
- Lines: 91
- Size: 2.9 KB
- Modified: 2025-12-13 11:58

```csharp
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Orbiter : EnemyBaseAI
    {
        [Header("AI Settings")]
        public SteeringBehavior orbitClockwise;
        public SteeringBehavior orbitCounterClockwise;
        public SteeringBehavior avoidWalls; // Assign Beh_AvoidWalls here

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireInterval = 2.5f;
        public int burstCount = 2;
        public float burstRate = 0.2f;

        private ContextSolver _brain;
        private float _fireTimer;

        protected override void Awake()
        {
            base.Awake();
            _brain = GetComponent<ContextSolver>();
        }

        protected override void Start()
        {
            base.Start();

            // 1. Randomize Direction
            // We build the brain's behavior list dynamically at start
            bool isClockwise = Random.value > 0.5f;

            _brain.behaviors = new List<SteeringBehavior>();

            // Add the chosen orbit direction
            if (isClockwise && orbitClockwise) _brain.behaviors.Add(orbitClockwise);
            else if (orbitCounterClockwise) _brain.behaviors.Add(orbitCounterClockwise);

            // Always add wall avoidance
            if (avoidWalls) _brain.behaviors.Add(avoidWalls);

            // 2. Randomize Fire Timer
            _fireTimer = Random.Range(1f, fireInterval);
        }

        protected override void RunAI()
        {
            // --- 1. MOVEMENT (Context Steering) ---
            Vector3 smartDir = _brain.GetDirectionToMove();
            _motor.Move(smartDir);

            // Face the Target (Player) to shoot, even if moving sideways
            _motor.FaceTarget(_currentTarget.position);

            // --- 2. COMBAT ---
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0)
            {
                StartCoroutine(FireBurst());
                _fireTimer = fireInterval;
            }
        }

        private IEnumerator FireBurst()
        {
            for (int i = 0; i < burstCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;

                    // Use Base Helper
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 12f);
                }
                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Agents\EnemyAgent_Sentinel.cs`
- Lines: 81
- Size: 2.7 KB
- Modified: 2025-12-11 08:12

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core; // Access to Context Solver
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;
using System.Collections;

namespace DarkTowerTron.Enemy
{
    // "Agent" implies it uses the Context Steering System
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Sentinel : EnemyBaseAI
    {
        [Header("Sentinel Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float attackRange = 10f;
        public float fireInterval = 2.0f;

        private ContextSolver _brain;
        private float _fireTimer;

        protected override void Awake()
        {
            base.Awake();
            _brain = GetComponent<ContextSolver>();
        }

        protected override void Start()
        {
            base.Start();
            // Randomize start firing to avoid synchronization with other units
            _fireTimer = Random.Range(0.5f, fireInterval);
        }

        protected override void RunAI()
        {
            // --- 1. INTELLIGENT NAVIGATION ---
            // We don't calculate direction manually anymore. The Brain does it.
            // It considers the Target (Seek) AND the Walls (Avoidance).
            Vector3 smartDirection = _brain.GetDirectionToMove();

            // Feed the smart vector to the motor
            _motor.Move(smartDirection);

            // --- 2. COMBAT LOGIC ---
            // Distance check is still useful for deciding when to shoot
            float distToTarget = Vector3.Distance(transform.position, _currentTarget.position);

            // Face movement direction if moving, otherwise face target
            if (smartDirection.sqrMagnitude > 0.1f)
            {
                _motor.FaceTarget(transform.position + smartDirection);
            }
            else
            {
                _motor.FaceTarget(_currentTarget.position);
            }

            // Attack Cycle
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0 && distToTarget <= attackRange)
            {
                Fire();
                _fireTimer = fireInterval;
            }
        }

        private void Fire()
        {
            if (projectilePrefab && !_controller.IsStaggered)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;

                // Use the BaseAI helper to spawn from pool
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyController.cs`
- Lines: 163
- Size: 4.9 KB
- Modified: 2025-12-11 14:25

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    public class EnemyController : MonoBehaviour, IDamageable
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

        private Tween _flashTween;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            if (meshRenderer == null) meshRenderer = GetComponent<Renderer>();
            if (meshRenderer) normalColor = meshRenderer.material.color;
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;
            // Removed the error check to allow for legacy testing without stats if needed
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

            if (meshRenderer)
            {
                meshRenderer.material.DOKill();
                _flashTween = meshRenderer.material.DOColor(Color.red, 0.2f)
                    .From(staggerColor)
                    .SetLoops(-1, LoopType.Yoyo)
                    .SetEase(Ease.Linear);
            }

            DOVirtual.DelayedCall(2.0f, ExitStaggerState);
        }

        private void ExitStaggerState()
        {
            if (this == null) return;
            IsStaggered = false;

            if (_flashTween != null) _flashTween.Kill();
            meshRenderer.material.DOKill();

            _currentStagger = 0;
            if (meshRenderer) meshRenderer.material.color = normalColor;
        }

        private void Flash()
        {
            if (meshRenderer)
            {
                meshRenderer.material.DOColor(flashColor, 0.1f).OnComplete(() =>
                {
                    if (this != null) meshRenderer.material.color = IsStaggered ? staggerColor : normalColor;
                });
            }
        }

        public void Kill(bool instant)
        {
            // --- FIXED: Pass the stats so the Event System knows what died ---
            GameEvents.OnEnemyKilled?.Invoke(transform.position, _stats);
            // ---------------------------------------------------------------

#if UNITY_EDITOR
            if (UnityEditor.Selection.activeGameObject == gameObject) 
                UnityEditor.Selection.activeGameObject = null;
#endif
            Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\EnemyMotors.cs`
- Lines: 147
- Size: 4.8 KB
- Modified: 2025-12-13 11:15

```csharp
using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(KinematicMover))]
    public class EnemyMotor : MonoBehaviour
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

        // --- THE FIXED METHOD ---
        private void OnEnable()
        {
            _currentVelocity = Vector3.zero;
            _knockbackForce = Vector3.zero;
            _currentVerticalSpeed = 0f;

            // Fix: Check stats.rideHeight instead of local variable
            if (stats != null && stats.rideHeight > 0)
            {
                Vector3 startPos = transform.position;
                startPos.y = 0; // Snap to floor so we can rise up
                transform.position = startPos;
            }
        }
        // ------------------------

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

        public void FaceTarget(Vector3 targetPosition)
        {
            if (stats == null) return;

            Vector3 dir = targetPosition - transform.position;
            dir.y = 0;

            if (dir != Vector3.zero)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                // Use stats.rotationSpeed
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, stats.rotationSpeed * Time.deltaTime);
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

## 📄 `Assets\Scripts\Enemy\Legacy\EnemyAI_Chaser.cs`
- Lines: 55
- Size: 1.6 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Chaser : EnemyBaseAI
    {
        [Header("Chaser Settings")]
        public float attackRange = 1.2f;
        public float damage = 1f;

        protected override void RunAI()
        {
            float dist = Vector3.Distance(transform.position, _currentTarget.position);

            if (dist <= attackRange)
            {
                // Only explode on the REAL player (optional choice, but logical)
                if (_currentTarget == _player)
                {
                    Explode();
                }
                else
                {
                    // If targeting decoy, just wait or circle
                    _motor.Move(Vector3.zero);
                }
            }
            else
            {
                // Chase Target
                Vector3 dir = (_currentTarget.position - transform.position).normalized;
                _motor.Move(dir);
                _motor.FaceTarget(_currentTarget.position);
            }
        }

        private void Explode()
        {
            IDamageable target = _player.GetComponent<IDamageable>();
            if (target != null)
            {
                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = transform.forward,
                    pushForce = 20f,
                    source = gameObject
                };
                target.TakeDamage(info);
            }
            Destroy(gameObject);
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Legacy\EnemyAI_Sniper.cs`
- Lines: 151
- Size: 5.0 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Physics; // For LayerMasks
using DarkTowerTron.Managers;
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Sniper : EnemyBaseAI
    {
        [Header("Sniper Stats")]
        public float panicDistance = 5f;
        public float teleportCooldown = 5.0f; // New: No spamming
        public float fireRate = 4.0f;
        public float telegraphTime = 1.5f;

        [Header("Setup")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public LineRenderer laserSight;
        public LayerMask wallLayer; // New: For bounds checking

        private bool _isBusy;
        private float _fireTimer;
        private float _teleportTimer; // Tracks cooldown

        protected override void Start()
        {
            base.Start();
            if (laserSight) laserSight.enabled = false;

            // Default wall layer if not set
            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        protected override void RunAI()
        {
            // Cooldown management
            if (_teleportTimer > 0) _teleportTimer -= Time.deltaTime;
            if (_fireTimer > 0) _fireTimer -= Time.deltaTime;

            if (_isBusy) return;

            // 1. Panic Check (Teleport)
            // Only if cooldown is ready AND player is too close
            float dist = Vector3.Distance(transform.position, _currentTarget.position);
            if (dist < panicDistance && _teleportTimer <= 0)
            {
                StartCoroutine(TeleportAway());
                return;
            }

            // 2. Face Target
            _motor.FaceTarget(_currentTarget.position);

            // 3. Attack Cycle
            if (_fireTimer <= 0)
            {
                StartCoroutine(SniperShot());
            }
        }

        private IEnumerator TeleportAway()
        {
            _isBusy = true;
            AbortAttack();

            // 1. Shrink (Vanish)
            transform.DOScale(Vector3.zero, 0.2f);
            yield return new WaitForSeconds(0.2f);

            // 2. Calculate Safe Position
            Vector3 dirFromTarget = (transform.position - _currentTarget.position).normalized;
            float targetDist = 12f; // Try to go far away

            // RAYCAST CHECK:
            // Cast from Player towards the desired direction.
            // If we hit a wall, stop 2 units before the wall.
            Vector3 newPos;
            if (UnityEngine.Physics.Raycast(_currentTarget.position, dirFromTarget, out RaycastHit hit, targetDist, wallLayer))
            {
                // Hit wall -> Place sniper 2m in front of wall
                newPos = hit.point - (dirFromTarget * 2.0f);
            }
            else
            {
                // No wall -> Full distance
                newPos = _currentTarget.position + (dirFromTarget * targetDist);
            }

            newPos.y = 0; // Keep grounded
            transform.position = newPos;

            // 3. Grow (Appear)
            transform.DOScale(Vector3.one, 0.2f);
            yield return new WaitForSeconds(0.2f);

            _teleportTimer = teleportCooldown; // Reset Cooldown
            _fireTimer = 1.0f; // Delay before shooting
            _isBusy = false;
        }

        private IEnumerator SniperShot()
        {
            _isBusy = true;
            if (laserSight) laserSight.enabled = true;

            float aimTimer = 0f;
            while (aimTimer < telegraphTime)
            {
                if (_controller.IsStaggered) { AbortAttack(); _isBusy = false; yield break; }

                // Stop tracking in last 0.3s (Lock Aim)
                if (aimTimer < telegraphTime - 0.3f)
                    _motor.FaceTarget(_currentTarget.position);

                // Update Laser Visuals
                if (laserSight)
                {
                    Vector3 start = firePoint ? firePoint.position : transform.position;
                    laserSight.SetPosition(0, start);
                    laserSight.SetPosition(1, _currentTarget.position);
                }

                aimTimer += Time.deltaTime;
                yield return null;
            }

            // FIRE
            if (laserSight) laserSight.enabled = false;

            if (projectilePrefab && !_controller.IsStaggered)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;
                
                // ONE LINE TO RULE THEM ALL
                FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 30f);
            }

            _fireTimer = fireRate;
            _isBusy = false;
        }

        private void AbortAttack()
        {
            if (laserSight) laserSight.enabled = false;
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Legacy\EnemyAI_Strafer.cs`
- Lines: 82
- Size: 2.8 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Strafer : EnemyBaseAI
    {
        [Header("Strafe Settings")]
        public bool clockwise = true;
        public float idealDistance = 6f;

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint; // <--- ADDED THIS
        public float fireInterval = 2.5f;
        public int burstCount = 2;
        public float burstRate = 0.2f;

        private float _timer;

        protected override void Start()
        {
            base.Start();
            clockwise = Random.value > 0.5f;
            _timer = Random.Range(1f, fireInterval);
        }

        protected override void RunAI()
        {
            // --- MOVEMENT (Orbit) ---
            Vector3 offset = transform.position - _currentTarget.position;
            
            // FIX: Flatten the offset so we calculate distance/direction purely on the floor plane
            offset.y = 0; 

            Vector3 dirToTarget = -offset.normalized;
            float distance = offset.magnitude;

            Vector3 tangent = Vector3.Cross(Vector3.up, dirToTarget).normalized;
            if (!clockwise) tangent = -tangent;

            Vector3 correction = Vector3.zero;
            if (distance > idealDistance + 1f) correction = dirToTarget * 0.5f;
            else if (distance < idealDistance - 1f) correction = -dirToTarget * 0.5f;

            // The resulting vector is now guaranteed to be flat (y=0)
            _motor.Move((tangent + correction).normalized);
            
            // Face target (EnemyMotor.FaceTarget already handles flattening, so this is safe)
            _motor.FaceTarget(_currentTarget.position);

            // --- COMBAT ---
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                StartCoroutine(FireBurst());
                _timer = fireInterval;
            }
        }

        private IEnumerator FireBurst()
        {
            for (int i = 0; i < burstCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward * 1.0f;
                    Quaternion spawnRot = firePoint ? firePoint.rotation : transform.rotation;

                    // Fire
                    FireProjectile(projectilePrefab, spawnPos, spawnRot, transform.forward, 12f);
                }
                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Legacy\EnemyAI_Turret.cs`
- Lines: 62
- Size: 1.9 KB
- Modified: 2025-12-11 07:51

```csharp
using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Turret : EnemyBaseAI
    {
        [Header("Turret Stats")]
        // Removed rotationSpeed variable (Now handled by Stats_Guardian asset)
        public float fireInterval = 3.0f;
        public int burstCount = 5;
        public float burstRate = 0.1f;

        [Header("Setup")]
        public GameObject projectilePrefab;
        public Transform firePoint;

        private float _timer;

        protected override void Start()
        {
            base.Start();

            // REMOVED: Manual overrides for motor.rotationSpeed, moveSpeed, shield.
            // WHY: These are now defined in the 'Stats_Guardian' ScriptableObject.
            // Ensure your Stats_Guardian asset has MoveSpeed = 0, Rotation = 3, Shield = True.
        }

        protected override void RunAI()
        {
            // 1. Tracking
            _motor.FaceTarget(_currentTarget.position);

            // 2. Shooting Logic
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                StartCoroutine(FireBurst());
                _timer = fireInterval;
            }
        }

        private IEnumerator FireBurst()
        {
            for (int i = 0; i < burstCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;

                    // Fire using Base Helper
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
                }

                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}
```

## 📄 `Assets\Scripts\Enemy\Legacy\EnemyBaseAI.cs`
- Lines: 100
- Size: 3.1 KB
- Modified: 2025-12-11 07:51

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
    public abstract class EnemyBaseAI : MonoBehaviour
    {
        protected EnemyMotor _motor;
        protected EnemyController _controller;
        protected Transform _player;
        protected Transform _currentTarget;

        // NEW: State Flag
        protected bool _isSpawning = true; 

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
        }

        // NEW: OnEnable handles the Spawn Logic (Runs every time it comes from Pool)
        protected virtual void OnEnable()
        {
            _isSpawning = true;
            transform.localScale = Vector3.zero;

            // FIRE SPAWN EVENT
            GameEvents.OnEnemySpawned?.Invoke(transform.position);

            transform.DOScale(Vector3.one, 0.8f)
                .SetEase(Ease.OutBack)
                .OnComplete(() => _isSpawning = false);
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
- Lines: 48
- Size: 1.4 KB
- Modified: 2025-12-11 14:23

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

        private void OnEnable()
        {
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
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

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats)
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
- Size: 2.9 KB
- Modified: 2025-12-11 14:05

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
        private void OnEnemyKilled(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats)
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
- Lines: 135
- Size: 3.9 KB
- Modified: 2025-12-11 14:11

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
            GameEvents.OnPlayerDied -= TriggerGameOver;
            GameEvents.OnGameVictory -= TriggerVictory;
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
- Lines: 93
- Size: 3.0 KB
- Modified: 2025-12-11 07:51

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
            // Optional: Listen for wave changes if we added that event
        }

        private void OnDisable()
        {
            GameEvents.OnFocusChanged -= UpdateFocus;
            GameEvents.OnGritChanged -= UpdateGrit;
            GameEvents.OnScoreChanged -= UpdateScoreUI;
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
            if (gritPips == null) return;

            for (int i = 0; i < gritPips.Length; i++)
            {
                if (gritPips[i] == null) continue;

                Image pipImg = gritPips[i].GetComponent<Image>();
                if (pipImg)
                {
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
- Lines: 81
- Size: 2.8 KB
- Modified: 2025-12-11 17:42

```csharp
using UnityEngine;
using System.Collections.Generic;

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

                objectToSpawn.SetActive(true); // Now OnEnable fires at the correct location
            }
            // 2. NEW OBJECT
            else
            {
                // CRITICAL FIX: Instantiate AT position/rotation directly
                objectToSpawn = Instantiate(prefab, position, rotation);
                // OnEnable fires immediately here, but position is already correct
            }

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
- Lines: 96
- Size: 2.6 KB
- Modified: 2025-12-11 14:25

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
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats)
        {
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
- Size: 1.5 KB
- Modified: 2025-12-11 17:35

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
        private void PlayDeathVFX(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats)
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
- Lines: 194
- Size: 6.5 KB
- Modified: 2025-12-11 17:36

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
            if (_spawner == null || prefab == null) return;

            _spawner.SpawnEnemy(prefab, forcedIndex);

            // --- DATA INTEGRITY FIX ---
            // We check the prefab's stats to decide which counter to increment.
            // This ensures Spawn and Death logic use the exact same source of truth.
            
            var motor = prefab.GetComponentInChildren<DarkTowerTron.Enemy.EnemyMotor>();
            bool countAsEssential = false;

            if (motor != null && motor.stats != null)
            {
                countAsEssential = motor.stats.isEssential;
            }
            else
            {
                // Fallback: If no stats found, assume essential to prevent soft-lock, 
                // or assume grunt. Let's assume Essential if it was in the Main list?
                // Actually, let's look at the calling context.
                // But relying on the prefab is safer.
                Debug.LogWarning($"Enemy {prefab.name} missing Stats! Defaulting to Essential.");
                countAsEssential = true;
            }

            if (countAsEssential)
            {
                _essentialEnemiesAlive++;
            }
            else
            {
                _gruntsAlive++;
            }
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats)
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

## 📄 `Assets\Scripts\Physic\KinematicMover.cs`
- Lines: 240
- Size: 9.6 KB
- Modified: 2025-12-13 11:00

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
            if (_obstacleMask == 0) _obstacleMask = 1;
        }

        public void Move(Vector3 desiredVelocity)
        {
            float dt = Time.deltaTime;
            if (dt < 1e-5f) return;

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
- Modified: 2025-12-11 07:51

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

            // --- CACHE ACTIONS ---
            // We look them up once. If they don't exist, these variables will be null.
            _moveAction = _controls.Gameplay.Move;
            _lookPadAction = _controls.Gameplay.LookGamepad;
            _lookMouseAction = _controls.Gameplay.LookMouse;

            // Safely find actions even if you renamed them slightly differently
            _fireBeamAction = _controls.asset.FindAction("Melee");
            _fireGunAction = _controls.asset.FindAction("Gun");

            // --- BINDINGS ---
            // 1. Dodge (Space / RB)
            // Use FindAction to be safe, or direct access if you are sure
            var dodgeAction = _controls.asset.FindAction("Blitz");
            if (dodgeAction != null) dodgeAction.performed += ctx => OnDodge();

            // 2. Glory Kill (E / LB)
            var killAction = _controls.asset.FindAction("GloryKill");
            if (killAction != null) killAction.performed += ctx => OnGloryKill();
        }

        private void OnEnable()
        {
            if (_inputEnabled) _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }

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
            if (_beamWeapon != null && _fireBeamAction != null)
            {
                bool isBeam = _fireBeamAction.ReadValue<float>() > 0.5f;
                _beamWeapon.SetFiring(isBeam);
            }

            // 2. Handle GUN
            if (_gunWeapon != null && _fireGunAction != null)
            {
                bool isGun = _fireGunAction.ReadValue<float>() > 0.5f;
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
- Lines: 98
- Size: 2.8 KB
- Modified: 2025-12-11 14:21

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
        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats)
        {
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
- Lines: 93
- Size: 2.4 KB
- Modified: 2025-12-11 14:22

```csharp
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [Header("Stats")]
        public int maxGrit = 2;

        private int _currentGrit;
        private bool _isDead;
        private PlayerMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
        }

        private void Start()
        {
            _currentGrit = maxGrit;
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

            if (_currentGrit > 0)
            {
                _currentGrit--;
                GameEvents.OnPlayerHit?.Invoke();
                if (_movement) _movement.ApplyKnockback(info.pushDirection * info.pushForce);
            }
            else
            {
                Kill(false);
            }

            UpdateUI();
            return true;
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;
            Debug.Log("PLAYER DEAD");
            GameEvents.OnPlayerDied?.Invoke();
        }

        public void HealGrit(int amount = 1)
        {
            if (_isDead) return;
            _currentGrit = Mathf.Min(_currentGrit + amount, maxGrit);
            UpdateUI();
        }

        // Updated Event Handler
        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats)
        {
            if (stats != null)
            {
                // Check boolean flag first
                if (stats.healsGrit)
                {
                    // Use the specific amount defined in the asset
                    HealGrit(stats.gritRewardAmount);
                }
            }
            else
            {
                // Fallback for legacy/missing stats
                HealGrit(1);
            }
        }
        // -----------------------

        private void UpdateUI()
        {
            GameEvents.OnGritChanged?.Invoke(_currentGrit);
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
