using UnityEngine;
using DarkTowerTron.Physics; // For IMover
using DarkTowerTron.Combat;  // For PatternExecutor
using DarkTowerTron.AI.Core; // For ContextSolver
using DarkTowerTron.AI.Paths;
using DarkTowerTron.Enemy;

namespace DarkTowerTron.AI.Pluggable.Core
{
    [System.Serializable]
    public class AIBlackboard
    {
        [Header("Runtime Data")]
        public Transform Target;
        public Vector3 MoveDirection;
        public float StateTimeElapsed; // Resets on state change

        public PatternExecutor Weapon;

        [Header("Context Data")]
        public PatrolPath patrolPath; // Assign this in the Controller Inspector!
        public int currentWaypointIndex;

        // Component Cache (Filled in Awake)
        public IMover Mover;
        public ContextSolver ContextSolver;
        public DamageReceiver Health;
        public EnemyController Controller; // Now this works

        // Generic Parameters
        public Vector3 PatrolDestination;
    }
}