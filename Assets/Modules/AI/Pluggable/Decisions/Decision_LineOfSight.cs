using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DarkTowerTron.Core; // GameConstants

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/Line Of Sight")]
    public class Decision_LineOfSight : AIDecision
    {
        public float range = 15f;
        public LayerMask blockLayer;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            Vector3 eyePos = controller.transform.position + Vector3.up * 1.0f;
            Vector3 targetPos = controller.blackboard.Target.position + Vector3.up * 1.0f;
            Vector3 dir = targetPos - eyePos;
            float dist = dir.magnitude;

            if (dist > range) return false;

            // Check if wall is in between
            if (UnityEngine.Physics.Raycast(eyePos, dir, dist, blockLayer))
            {
                return false; // Hit a wall
            }

            return true; // Clear shot
        }
    }
}