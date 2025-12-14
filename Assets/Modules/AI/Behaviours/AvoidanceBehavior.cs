using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Avoidance", menuName = "DarkTowerTron/AI/Behaviors/Obstacle Avoidance")]
    public class AvoidanceBehavior : SteeringBehavior
    {
        public float avoidanceRadius = 2f; // Should match Detector radius roughly
        public float dangerWeight = 1f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            if (aiData.obstacles == null || aiData.obstacles.Count == 0) return;

            foreach (Collider obstacle in aiData.obstacles)
            {
                // Calculate direction TO the obstacle
                // Using ClosestPoint ensures we handle large walls correctly
                Vector3 closestPoint = obstacle.ClosestPoint(aiData.transform.position);
                Vector3 dirToObstacle = closestPoint - aiData.transform.position;
                dirToObstacle.y = 0;

                float distance = dirToObstacle.magnitude;

                // If too far, ignore
                if (distance > avoidanceRadius) continue;

                // Normalize direction
                Vector3 dirNormalized = dirToObstacle.normalized;

                // Map to 8 Directions
                for (int i = 0; i < AIDirections.EightDirections.Count; i++)
                {
                    // Dot Product: How aligned is this compass direction with the obstacle?
                    float dot = Vector3.Dot(dirNormalized, AIDirections.EightDirections[i]);

                    // If the compass direction points TOWARDS the obstacle (dot > 0.6 means <~50 degrees)
                    // We flag it as dangerous.
                    if (dot > 0.6f)
                    {
                        // The closer the obstacle, the higher the danger (1.0 at touch, 0.0 at radius)
                        float weight = dangerWeight * (1 - (distance / avoidanceRadius));

                        if (weight > danger[i])
                        {
                            danger[i] = weight;
                        }
                    }
                }
            }
        }
    }
}