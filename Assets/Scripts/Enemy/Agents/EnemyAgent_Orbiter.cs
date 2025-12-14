using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Orbiter : EnemyBaseAI
    {
        [Header("AI Settings")]
        public SteeringBehavior orbitClockwise;
        public SteeringBehavior orbitCounterClockwise;
        public SteeringBehavior avoidWalls; // Assign Beh_AvoidWalls here

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireInterval = 2.5f;
        public int burstCount = 2;
        public float burstRate = 0.2f;

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

            // 1. Randomize Direction
            // We build the brain's behavior list dynamically at start
            bool isClockwise = Random.value > 0.5f;

            _brain.behaviors = new List<SteeringBehavior>();

            // Add the chosen orbit direction
            if (isClockwise && orbitClockwise) _brain.behaviors.Add(orbitClockwise);
            else if (orbitCounterClockwise) _brain.behaviors.Add(orbitCounterClockwise);

            // Always add wall avoidance
            if (avoidWalls) _brain.behaviors.Add(avoidWalls);

            // 2. Randomize Fire Timer
            _fireTimer = Random.Range(1f, fireInterval);
        }

        protected override void RunAI()
        {
            // --- 1. MOVEMENT (Context Steering) ---
            Vector3 smartDir = _brain.GetDirectionToMove();
            _motor.Move(smartDir);

            // Face the Target (Player) to shoot, even if moving sideways
            _motor.FaceTarget(_currentTarget.position);

            // --- 2. COMBAT ---
            _fireTimer -= Time.deltaTime;
            if (_fireTimer <= 0)
            {
                StartCoroutine(FireBurst());
                _fireTimer = fireInterval;
            }
        }

        private IEnumerator FireBurst()
        {
            for (int i = 0; i < burstCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;

                    // Use Base Helper
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 12f);
                }
                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}