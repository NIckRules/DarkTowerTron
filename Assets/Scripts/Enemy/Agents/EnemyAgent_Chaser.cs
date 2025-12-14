using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Chaser; // Sub-namespace

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Kamikaze Settings")]
        public float attackRange = 1.5f;
        public float fuseDuration = 0.5f; // Time before boom
        public float damage = 1f;
        public float explosionForce = 20f;

        [Header("Steering Profiles")]
        public List<SteeringBehavior> chaseBehaviors; // Seek + AvoidWalls

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

            // Initialize States
            StateChase = new ChaserState_Chase(this);
            StatePriming = new ChaserState_Priming(this);
        }

        protected override void Start()
        {
            base.Start();
            FSM.Initialize(StateChase);
        }

        protected override void RunAI()
        {
            // Logic delegated to FSM
        }

        // --- HELPER FOR EXPLOSION ---
        public void Detonate()
        {
            if (_currentTarget == null) return;

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
                // Hit Decoy? Reward. Hit Wall? No Reward.
                if (_currentTarget.name.Contains("AfterImage") || _currentTarget.CompareTag("Untagged"))
                    _controller.Kill(true);
                else
                    _controller.SelfDestruct();
            }
        }

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