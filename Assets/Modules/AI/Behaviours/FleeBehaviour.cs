using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Flee", menuName = "DarkTowerTron/AI/Behaviors/Flee")]
    public class FleeBehavior : SteeringBehavior
    {
        public float fleeDistance = 10f; // Only flee if target is closer than this

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            if (aiData.currentTarget == null) return;

            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0;
            float dist = vectorToTarget.magnitude;

            // If we are safe, don't force movement
            if (dist > fleeDistance) return;

            // Flee direction is opposite to target
            Vector3 dirAway = -vectorToTarget.normalized;

            for (int i = 0; i < interest.Length; i++)
            {
                // We want to go in directions similar to 'dirAway'
                float dot = Vector3.Dot(dirAway, AIDirections.EightDirections[i]);

                if (dot > 0 && dot > interest[i])
                {
                    interest[i] = dot;
                }
            }
        }
    }
}