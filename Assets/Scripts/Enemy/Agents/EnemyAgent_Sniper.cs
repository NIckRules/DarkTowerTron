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

            if (wallLayer == 0) wallLayer = GameConstants.MASK_WALLS;

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