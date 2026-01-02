using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.Core;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.States.Guardian;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(StateMachine))]
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Guardian : EnemyBaseAI
    {
        [Header("Patrol Config")]
        public float waypointTolerance = 1.5f;
        public List<SteeringBehavior> moveBehaviors;

        [Header("Combat Config")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public List<AttackPatternSO> attackPatterns;

        // -- COMPONENTS --
        public ContextSolver Brain { get; private set; }
        public StateMachine FSM { get; private set; }

        // -- STATE DATA --
        public PatrolPath ActivePath { get; private set; }
        public int CurrentWaypointIndex { get; set; } = 0;

        // -- STATES --
        public GuardianState_Move StateMove { get; private set; }
        public GuardianState_Attack StateAttack { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            Brain = GetComponent<ContextSolver>();
            FSM = GetComponent<StateMachine>();

            StateMove = new GuardianState_Move(this);
            StateAttack = new GuardianState_Attack(this);
        }

        protected override void Start()
        {
            base.Start();

            // Auto-find path if not assigned
            if (ActivePath == null)
            {
                ActivePath = FindNearestPath();
            }

            if (ActivePath != null && ActivePath.waypoints.Count > 0)
            {
                FSM.Initialize(StateMove);
            }
            else
            {
                GameLogger.LogWarning(LogChannel.AI, $"{name}: No PatrolPath found! Standing still.", gameObject);
                FSM.Initialize(StateAttack);
            }
        }

        protected override void RunAI() { }

        public IEnumerator ExecutePattern(AttackPatternSO pattern)
        {
            if (pattern == null || projectilePrefab == null) yield break;

            yield return new WaitForSeconds(pattern.startDelay);

            float angleStep = (pattern.spreadAngle > 0 && pattern.projectileCount > 1)
                ? pattern.spreadAngle / (pattern.projectileCount - 1)
                : 0;

            float startAngle = -pattern.spreadAngle / 2f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                float currentAngle = startAngle + (angleStep * i);

                if (pattern.spinDuringFire)
                    startAngle += pattern.spinSpeed * pattern.delayBetweenShots;

                Quaternion rot = transform.rotation * Quaternion.Euler(0, currentAngle, 0);
                Vector3 fireDir = rot * Vector3.forward;

                Vector3 spawnPos = firePoint ? firePoint.position : transform.position;

                FireProjectile(projectilePrefab, spawnPos, rot, fireDir, pattern.speed);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }
        }

        // --- PATHFINDING HELPERS ---
        private PatrolPath FindNearestPath()
        {
            PatrolPath[] allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath closest = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float dist = Vector3.Distance(transform.position, path.waypoints[0].position);
                    if (dist < closestDist)
                    {
                        closestDist = dist;
                        closest = path;
                    }
                }
            }
            return closest;
        }

        public Transform GetCurrentWaypoint()
        {
            if (ActivePath == null || ActivePath.waypoints.Count == 0) return null;
            return ActivePath.waypoints[CurrentWaypointIndex];
        }

        public void AdvanceWaypoint()
        {
            if (ActivePath == null) return;
            CurrentWaypointIndex++;
            if (CurrentWaypointIndex >= ActivePath.waypoints.Count)
            {
                CurrentWaypointIndex = (ActivePath.loop) ? 0 : ActivePath.waypoints.Count - 1;
            }
        }

        // --- PUBLIC ACCESSORS (Fixes CS1061) ---
        public EnemyController GetController() => _controller;
        public EnemyMotor GetMotor() => _motor;

        // This was the missing one:
        public Transform GetTarget() => _currentTarget;
    }
}