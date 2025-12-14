using UnityEngine;
using DarkTowerTron.AI.Utils;
using DarkTowerTron.AI.Core; // Access Base Class

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Avoidance", menuName = "DarkTowerTron/AI/Behaviors/Obstacle Avoidance")]
    public class AvoidanceBehavior : SteeringBehavior
    {
        public float avoidanceRadius = 2f;
        public float dangerWeight = 1f;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // --- SAFETY CHECKS ---
            // 1. Owner Collider must exist
            if (ownerCollider == null)
            {
                // Try to get it if it was missed (e.g., Awake ran too early)
                ownerCollider = aiData.GetComponent<Collider>();
                if (ownerCollider == null) return; // Cannot proceed without it
            }
            // 2. Avoid Targets that are targets (Don't avoid player if seeking player)
            if (aiData.currentTarget != null && aiData.currentTarget.gameObject == ownerCollider.gameObject) return;
            // --- END SAFETY ---

            // --- Original Logic ---
            if (aiData.obstacles == null || aiData.obstacles.Count == 0) return;

            foreach (Collider obstacle in aiData.obstacles)
            {
                // Use the ownerCollider to get the correct center and radius for casting
                Vector3 closestPoint = ownerCollider.ClosestPoint(aiData.transform.position);

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