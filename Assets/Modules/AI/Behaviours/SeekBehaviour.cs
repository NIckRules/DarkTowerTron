using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Seek", menuName = "DarkTowerTron/AI/Behaviors/Seek")]
    public class SeekBehavior : SteeringBehavior
    {
        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Safety Check
            if (aiData.currentTarget == null) return;

            // 1. Calculate direction to target
            Vector3 directionToTarget = (aiData.currentTarget.position - aiData.transform.position);
            directionToTarget.y = 0; // Flatten (keep on ground plane)

            // Normalize
            directionToTarget.Normalize();

            // 2. Compare against our 8 compass directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: 1.0 = Perfect Alignment, 0.0 = 90 deg, -1.0 = Opposite
                float dot = Vector3.Dot(directionToTarget, AIDirections.EightDirections[i]);

                // We only care if the direction brings us closer (>0)
                if (dot > 0)
                {
                    // Apply interest
                    // We use the dot value directly (0 to 1) as the weight
                    if (dot > interest[i])
                    {
                        interest[i] = dot;
                    }
                }
            }
        }
    }
}