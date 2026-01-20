using UnityEngine;
using DarkTowerTron.Gameplay.AI;

namespace DarkTowerTron.Gameplay.Enemies
{
    public class EnemyPatrolModule : MonoBehaviour
    {
        [Header("Runtime Data")]
        public PatrolPath patrolPath;
        public int currentWaypointIndex;

        // Helper to get the current target transform safely
        public Transform GetCurrentWaypointTarget()
        {
            if (patrolPath == null || patrolPath.waypoints.Count == 0) return null;

            // Safety wrap
            if (currentWaypointIndex >= patrolPath.waypoints.Count) currentWaypointIndex = 0;

            var wp = patrolPath.waypoints[currentWaypointIndex];
            return wp != null ? wp.transform : null;
        }

        public void AdvanceWaypoint()
        {
            if (patrolPath == null) return;
            currentWaypointIndex = (currentWaypointIndex + 1) % patrolPath.waypoints.Count;
        }
    }
}