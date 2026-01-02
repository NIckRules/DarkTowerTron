using UnityEngine;
using DG.Tweening; // Logic relies on Tweening
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Services;
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
            GameObject p = Services.Pool.Spawn(prefab, position, rotation);

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