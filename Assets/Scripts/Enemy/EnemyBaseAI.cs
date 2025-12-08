using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers; // Needed for PoolManager

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

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
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