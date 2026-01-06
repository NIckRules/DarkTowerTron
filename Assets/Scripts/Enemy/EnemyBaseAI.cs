using UnityEngine;
using DG.Tweening; // Logic relies on Tweening
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Managers;

using Global = DarkTowerTron.Core.Services.Services; 

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
            // OLD:
            // GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            // if (p) { _player = p.transform; ... }

            // NEW: Use the Service Locator
            if (GameServices.Player != null)
            {
                _player = GameServices.Player.transform;
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
            GameObject p = Global.Pool.Spawn(prefab, position, rotation);

            // 2. Setup Logic
            Projectile proj = p.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.ResetHostility(true); // Enemies always shoot hostile
                proj.speed = speed;
                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Smart Firing Logic: Calculates vector to Target's Center of Mass.
        /// </summary>
        protected void FireAtTarget(GameObject prefab, Transform firePointOrigin, float speed, float accuracyError = 0f)
        {
            if (prefab == null || _currentTarget == null) return;

            // 1. Determine Origin
            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            // 2. Determine Destination (AimPoint)
            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();

            if (aimTarget != null)
            {
                targetPos = aimTarget.AimPoint;
            }
            else
            {
                // Fallback for dumb objects
                targetPos = _currentTarget.position + Vector3.up * 1.0f;
            }

            // 3. Calculate Vector
            Vector3 direction = (targetPos - origin).normalized;

            // 4. Apply Inaccuracy (Optional)
            if (accuracyError > 0f)
            {
                direction = ApplySpread(direction, accuracyError);
            }

            // 5. Spawn & Init
            GameObject p = Global.Pool.Spawn(prefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);
                proj.speed = speed;

                // CRITICAL: Set Source to SELF (The Root Enemy Object)
                // This ensures the bullet ignores the enemy's own colliders
                proj.SetSource(this.gameObject);

                proj.Initialize(direction);
            }
        }

        /// <summary>
        /// Fires using a specific Attack Profile (Single Source of Truth).
        /// </summary>
        protected void FireAtTarget(EnemyAttackSO attackProfile, Transform firePointOrigin)
        {
            if (attackProfile == null || attackProfile.projectilePrefab == null || _currentTarget == null) return;

            // 1. Origin
            Vector3 origin = firePointOrigin ? firePointOrigin.position : transform.position;

            // 2. Destination (Smart Aim)
            Vector3 targetPos;
            var aimTarget = _currentTarget.GetComponent<IAimTarget>();

            if (aimTarget != null) targetPos = aimTarget.AimPoint;
            else targetPos = _currentTarget.position + Vector3.up * 1.0f;

            // 3. Vector
            Vector3 direction = (targetPos - origin).normalized;

            // 4. Spread (From Profile)
            if (attackProfile.spreadAngle > 0f)
            {
                direction = ApplySpread(direction, attackProfile.spreadAngle);
            }

            // 5. Spawn & Inject Data
            GameObject p = Global.Pool.Spawn(attackProfile.projectilePrefab, origin, Quaternion.LookRotation(direction));

            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                // INJECT DATA FROM SO
                proj.damage = attackProfile.damage;
                proj.stagger = attackProfile.stagger;
                proj.speed = attackProfile.projectileSpeed;
                proj.lifetime = attackProfile.lifetime;

                proj.ResetHostility(true);
                proj.SetSource(this.gameObject);
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