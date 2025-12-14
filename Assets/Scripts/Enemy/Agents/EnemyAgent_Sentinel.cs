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