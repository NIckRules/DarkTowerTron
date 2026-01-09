using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/In Range")]
    public class Decision_InRange : AIDecision
    {
        public float range = 1.5f;

        public override bool Decide(PluggableAIController controller)
        {
            if (controller.blackboard.Target == null) return false;

            // 1. Get Positions
            Vector3 myPos = controller.transform.position;
            Vector3 targetPos = controller.blackboard.Target.position;

            // 2. Flatten Y (Ignore Height)
            // This turns the check from a Sphere into a Cylinder (Infinite height)
            myPos.y = 0;
            targetPos.y = 0;

            // 3. Compare Squared Distance (Optimization)
            float distSqr = (myPos - targetPos).sqrMagnitude;

            return distSqr < (range * range);
        }
    }
}