using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(EnemyController))]
    public abstract class EnemyBaseAI : MonoBehaviour
    {
        // Protected = Accessible by Child scripts
        protected EnemyMotor _motor;
        protected EnemyController _controller;
        protected Transform _player;       // The real player
        protected Transform _currentTarget; // The active target (Player or Decoy)

        protected virtual void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _controller = GetComponent<EnemyController>();
        }

        protected virtual void Start()
        {
            // 1. Find Player
            GameObject p = GameObject.FindGameObjectWithTag(GameConstants.TAG_PLAYER);
            if (p)
            {
                _player = p.transform;
                _currentTarget = _player;
            }

            // 2. Subscribe to Decoy Events
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
            // Safety Checks
            if (_player == null) return;
            if (_currentTarget == null) _currentTarget = _player;

            // GLOBAL RULE: If staggered, AI stops thinking
            if (_controller.IsStaggered) return;

            // Run Child Logic
            RunAI();
        }

        // Abstract = Children MUST implement this
        protected abstract void RunAI();

        // --- Event Handlers ---
        private void OnDecoySpawned(Transform decoy)
        {
            _currentTarget = decoy;
        }

        private void OnDecoyExpired()
        {
            // Revert to player if they are still alive
            if (_player != null) _currentTarget = _player;
        }
    }
}