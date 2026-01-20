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