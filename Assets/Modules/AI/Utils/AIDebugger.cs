using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Enemy;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Utils
{
    [ExecuteAlways]
    public class AIDebugger : MonoBehaviour
    {
        [Header("Settings")]
        public bool showGizmos = true;
        public float lineScale = 2.0f;

        [Header("References")]
        public PluggableAIController controller;
        public EnemyMotor motor;

        private void OnEnable()
        {
            if (controller == null) controller = GetComponent<PluggableAIController>();
            if (motor == null) motor = GetComponent<EnemyMotor>();
        }

        private void OnDrawGizmos()
        {
            if (!showGizmos || Application.isPlaying == false) return;

            Vector3 pos = transform.position + Vector3.up * 1.0f; // Lift up to see better

            // 1. Draw ACTUAL Velocity (Green) - Where we are actually going
            if (motor != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawRay(pos, motor.Velocity.normalized * lineScale);
                // Draw arrow head
                Vector3 velTip = pos + motor.Velocity.normalized * lineScale;
                Gizmos.DrawSphere(velTip, 0.1f);
            }

            // 2. Draw LOGIC Intent (Yellow) - Where the Blackboard says we should go
            if (controller != null && controller.blackboard != null)
            {
                // Note: You need to ensure your Actions actually write to 'MoveDirection' in Blackboard
                // Currently Action_Patrol calculates it locally. We should fix that.
                /* 
                Gizmos.color = Color.yellow;
                Gizmos.DrawRay(pos, controller.blackboard.MoveDirection * lineScale * 0.8f);
                */
            }

            // 3. Draw TARGET Line (Red)
            if (controller != null && controller.blackboard != null)
            {
                // Target Entity
                if (controller.blackboard.Target != null)
                {
                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(pos, controller.blackboard.Target.position);
                }
                // Patrol Target
                else
                {
                    var patrol = controller.GetComponent<EnemyPatrolModule>();
                    if (patrol != null)
                    {
                        Transform wp = patrol.GetCurrentWaypointTarget();
                        if (wp != null)
                        {
                            Gizmos.color = new Color(1, 0.5f, 0); // Orange
                            Gizmos.DrawLine(pos, wp.position);
                            Gizmos.DrawWireSphere(wp.position, 0.5f);
                        }
                    }
                }
            }
        }
    }
}