using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core;
using DG.Tweening; // For the shake

namespace DarkTowerTron.AI.Pluggable.Actions
{
    [CreateAssetMenu(menuName = "AI/Actions/Visuals/Prime Effect")]
    public class Action_Visual_Prime : AIAction
    {
        public float shakeDuration = 0.5f;
        public float shakeStrength = 0.5f;

        public override void Act(PluggableAIController controller)
        {
            // 1. Visual Color Flash (Using the System we built in Phase 2)
            if (controller.blackboard.Controller.Visuals != null)
            {
                controller.blackboard.Controller.Visuals.StartPrimingEffect();
            }

            // 2. Physical Shake
            controller.transform.DOShakeScale(shakeDuration, shakeStrength, 20, 90);
        }
    }
}