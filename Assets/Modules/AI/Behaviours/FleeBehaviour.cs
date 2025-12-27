using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Flee", menuName = "DarkTowerTron/AI/Behaviors/Flee")]
    public class FleeBehavior : SteeringBehavior
    {
        [Tooltip("Enemy will only flee if target is closer than this distance.")]
        public float fleeDistance = 10f;

        [Tooltip("Strength of the flee desire (0 to 1).")]
        public float weight = 1.0f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate vector TO the target
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Keep it flat

            float distanceSqr = vectorToTarget.sqrMagnitude;

            // 2. Distance Check (Optimization)
            // If we are far enough away, we don't need to flee.
            if (distanceSqr > fleeDistance * fleeDistance) return;

            // 3. Calculate "Away" Direction
            Vector3 dirAway = -vectorToTarget.normalized;

            // 4. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: How well does this compass direction align with "Away"?
                float dot = Vector3.Dot(dirAway, AIDirections.EightDirections[i]);

                // We only care about directions that actually take us away (> 0)
                if (dot > 0)
                {
                    float value = dot * weight;

                    // If this behavior suggests a stronger interest than existing ones, override it
                    if (value > interest[i])
                    {
                        interest[i] = value;
                    }
                }
            }
        }
    }
}