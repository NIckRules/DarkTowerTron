using UnityEngine;
using DarkTowerTron.Physics;
using DarkTowerTron.Combat;
using DarkTowerTron.AI.Core;
using DarkTowerTron.Enemy;
// REMOVED: using DarkTowerTron.AI.Paths; 

namespace DarkTowerTron.AI.Pluggable.Core
{
    [System.Serializable]
    public class AIBlackboard
    {
        [Header("Runtime Data")]
        public Transform Target;
        public Vector3 MoveDirection;
        public float StateTimeElapsed;

        // Component Cache (The "Universal" Body)
        public IMover Mover;
        public ContextSolver ContextSolver;
        public DamageReceiver Health;
        public EnemyController Controller;
        public PatternExecutor Weapon; // Optional but common enough to keep

        // REMOVED: public PatrolPath patrolPath;
        // REMOVED: public int currentWaypointIndex;
    }
}