using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Enemy.States.Chaser;

namespace DarkTowerTron.Enemy.Agents
{
    public enum ChaserMode { Missile, MineLayer }

    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Mode Selection")]
        public ChaserMode mode = ChaserMode.Missile;

        [Header("Settings")]
        public float attackRange = 1.5f; 
        
        [Header("Mine Settings")]
        public GameObject hazardPrefab;
        public float fuseDuration = 0.5f;

        [Header("Missile Settings")]
        public float damage = 1f;
        public float explosionForce = 20f;

        [Header("Steering")]
        public System.Collections.Generic.List<SteeringBehavior> chaseBehaviors;

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

            StateChase = new ChaserState_Chase(this);
            StatePriming = new ChaserState_Priming(this);
        }

        protected override void Start()
        {
            base.Start();
            FSM.Initialize(StateChase);
        }

        protected override void RunAI() { }

        // --- ATTACK LOGIC ---

        public void TriggerAttack()
        {
            if (mode == ChaserMode.Missile)
            {
                // INSTANT BOOM
                DetonateMissile();
            }
            else
            {
                // PRIME MINE (Shake then Boom)
                FSM.ChangeState(StatePriming);
            }
        }

        public void DetonateMissile()
        {
            // Standard damage logic
            if (_currentTarget != null)
            {
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
                    // Hit Decoy? Reward.
                    if (_currentTarget.name.Contains("AfterImage")) _controller.Kill(true);
                    else _controller.SelfDestruct();
                }
            }
            else
            {
                _controller.SelfDestruct();
            }
        }

        public void DeployMine()
        {
            // Spawn Hazard
            if (hazardPrefab)
            {
                // Spawn at ground level
                Vector3 pos = transform.position;
                pos.y = 0;
                Instantiate(hazardPrefab, pos, Quaternion.identity);
            }
            
            // Die (No Reward, because you didn't kill it, it deployed)
            // Or Reward? Let's say SelfDestruct (No reward).
            _controller.SelfDestruct();
        }

        // ... Gizmos and Getters ...
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