using UnityEngine;
using DarkTowerTron.Core.Physics;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Gameplay.Enemies;

namespace DarkTowerTron.Gameplay.AI
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