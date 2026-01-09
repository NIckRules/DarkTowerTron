using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;

namespace DarkTowerTron.AI.Pluggable.Decisions
{
    [CreateAssetMenu(menuName = "AI/Decisions/Time Elapsed")]
    public class Decision_TimeElapsed : AIDecision
    {
        public float duration = 2.0f;

        public override bool Decide(PluggableAIController controller)
        {
            return controller.blackboard.StateTimeElapsed >= duration;
        }
    }
}