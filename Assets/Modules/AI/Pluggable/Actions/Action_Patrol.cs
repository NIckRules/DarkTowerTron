using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Move/Patrol")]
    public class Action_Patrol : AIAction
    {
        public float waypointTolerance = 1.0f;
        public float speedMultiplier = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            var patrol = controller.GetComponent<EnemyPatrolModule>();
            if (patrol == null || patrol.patrolPath == null) return;

            Transform targetPoint = patrol.GetCurrentWaypointTarget();
            if (targetPoint == null) return;

            // 1. Calculate Flat Distance
            Vector3 flatPos = controller.transform.position; flatPos.y = 0;
            Vector3 flatTarget = targetPoint.position; flatTarget.y = 0;
            if (Vector3.Distance(flatPos, flatTarget) < waypointTolerance)
            {
                patrol.AdvanceWaypoint();

                Transform nextPoint = patrol.GetCurrentWaypointTarget();
                if (nextPoint != null) MoveTowards(controller, nextPoint.position);
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