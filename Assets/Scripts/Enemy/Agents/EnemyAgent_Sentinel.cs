using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
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

        [Header("Loadout")]
        public EnemyAttackSO weaponProfile; // <--- REPLACES prefab and speed fields
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
            if (weaponProfile && !_controller.IsStaggered)
            {
                Transform fp = firePoint ? firePoint : transform;

                // Pass the Profile, not manual numbers
                FireAtTarget(weaponProfile, fp);
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