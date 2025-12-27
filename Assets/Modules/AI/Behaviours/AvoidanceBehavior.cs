using UnityEngine;
using DarkTowerTron.AI.Utils;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Avoidance", menuName = "DarkTowerTron/AI/Behaviors/Obstacle Avoidance")]
    public class AvoidanceBehavior : SteeringBehavior
    {
        public float avoidanceRadius = 2f;
        public float dangerWeight = 1f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // 1. Safety Check: Use data from the agent
            if (aiData.ownerCollider == null) return;

            // 2. Logic
            if (aiData.obstacles == null || aiData.obstacles.Count == 0) return;

            foreach (Collider obstacle in aiData.obstacles)
            {
                // FIX: Access the collider via aiData
                Vector3 closestPoint = aiData.ownerCollider.ClosestPoint(aiData.transform.position);

                Vector3 dirToObstacle = closestPoint - aiData.transform.position;
                dirToObstacle.y = 0;

                float distance = dirToObstacle.magnitude;

                if (distance > avoidanceRadius) continue;

                Vector3 dirNormalized = dirToObstacle.normalized;

                for (int i = 0; i < AIDirections.EightDirections.Count; i++)
                {
                    float dot = Vector3.Dot(dirNormalized, AIDirections.EightDirections[i]);
                    if (dot > 0.6f)
                    {
                        float weight = dangerWeight * (1 - (distance / avoidanceRadius));
                        if (weight > danger[i]) danger[i] = weight;
                    }
                }
            }
        }
    }
}