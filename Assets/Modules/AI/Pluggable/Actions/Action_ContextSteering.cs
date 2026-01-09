using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.AI.Core; // For SteeringBehavior list
using System.Collections.Generic;

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Move via Context Steering")]
    public class Action_ContextSteering : AIAction
    {
        [Header("Movement Profile")]
        public float speedMultiplier = 1.0f;

        [Header("Behaviors to Apply")]
        // We configure the specific steering behaviors HERE in the asset
        public List<SteeringBehavior> behaviors;

        public override void Act(PluggableAIController controller)
        {
            // 1. Inject Behaviors into the Solver
            // Optimization Note: Doing this every frame is wasteful if the list doesn't change.
            // A better way is to do this in "OnEnter State", but for simplicity/robustness:
            controller.blackboard.ContextSolver.behaviors = behaviors;

            // 2. Get Direction
            Vector3 dir = controller.blackboard.ContextSolver.GetDirectionToMove();

            // 3. Move via IMover interface
            // (Assuming EnemyStats logic is handled inside the IMover or passed here. 
            // For now, let's assume the controller's Motor handles the base speed from StatsSO)
            controller.blackboard.Mover.Move(dir * speedMultiplier);

            // 4. Face Movement
            if (dir.sqrMagnitude > 0.01f)
            {
                Quaternion targetRot = Quaternion.LookRotation(dir);
                controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, targetRot, 10f * Time.deltaTime);
            }
        }
    }
}