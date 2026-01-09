using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.AI.Paths;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Move/Patrol")]
    public class Action_Patrol : AIAction
    {
        public float waypointTolerance = 1.0f;
        public float speedMultiplier = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            var bb = controller.blackboard;
            if (bb.patrolPath == null || bb.patrolPath.waypoints.Count == 0) return;

            Waypoint currentWaypoint = bb.patrolPath.waypoints[bb.currentWaypointIndex];
            if (currentWaypoint == null) return;

            Transform targetPoint = currentWaypoint.transform;

            // 1. Calculate Flat Distance
            Vector3 flatPos = controller.transform.position; flatPos.y = 0;
            Vector3 flatTarget = targetPoint.position; flatTarget.y = 0;
            float distance = Vector3.Distance(flatPos, flatTarget);

            // 2. Check Arrival
            if (distance <= waypointTolerance)
            {
                // We Arrived.

                // Optional: Snap position to avoid "Orbiting" if we stop here? 
                // No, just switch target immediately so we don't stop moving.

                bb.currentWaypointIndex = (bb.currentWaypointIndex + 1) % bb.patrolPath.waypoints.Count;

                // CRITICAL FIX: Don't stop. 
                // Immediately get the NEXT waypoint and start moving towards IT in this same frame.
                // This prevents the 1-frame freeze.

                var nextWaypoint = bb.patrolPath.waypoints[bb.currentWaypointIndex];
                if (nextWaypoint != null)
                {
                    MoveTowards(controller, nextWaypoint.transform.position);
                }
            }
            else
            {
                // 3. Keep Moving
                MoveTowards(controller, targetPoint.position);
            }
        }

        private void MoveTowards(PluggableAIController controller, Vector3 targetPos)
        {
            Vector3 dir = (targetPos - controller.transform.position).normalized;
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // Store in blackboard for Debugger visualization
            controller.blackboard.MoveDirection = dir;

            if (controller.blackboard.Mover is DarkTowerTron.Enemy.EnemyMotor motor)
            {
                motor.FaceTarget(targetPos);
            }
        }
    }
}