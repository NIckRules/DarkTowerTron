using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors // Note: Sub-namespace optional but clean
{
    [CreateAssetMenu(fileName = "Beh_Seek", menuName = "DarkTowerTron/AI/Behaviors/Seek")]
    public class SeekBehavior : SteeringBehavior
    {
        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // If no target, do nothing
            if (aiData.currentTarget == null) return;

            // 1. Calculate direction to target
            Vector3 directionToTarget = (aiData.currentTarget.position - aiData.transform.position);
            directionToTarget.y = 0; // Flatten
            directionToTarget.Normalize();

            // 2. Compare against our 8 compass directions
            for (int i = 0; i < interest.Length; i++)
            {
                // Dot Product: 1.0 = Same direction, 0.0 = 90 deg, -1.0 = Opposite
                float dot = Vector3.Dot(directionToTarget, AIDirections.EightDirections[i]);

                // We only care if it's generally in the right direction (>0)
                if (dot > 0)
                {
                    // Add to interest (accumulate if multiple behaviors exist)
                    // We use Mathf.Max to allow other behaviors to override if they are stronger
                    // But usually adding is fine. Let's simpler logic: Set if higher.
                    if (dot > interest[i])
                    {
                        interest[i] = dot;
                    }
                }
            }
        }
    }
}