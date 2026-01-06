using UnityEngine;
using DarkTowerTron.Core; // For GameConstants
using DarkTowerTron.AI.Utils; // For AIDirections

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_VoidAvoidance", menuName = "DarkTowerTron/AI/Behaviors/Void Avoidance")]
    public class VoidAvoidanceBehavior : SteeringBehavior
    {
        [Header("Settings")]
        public float lookAheadDistance = 2f;
        public float voidDangerWeight = 1f; // 1.0 means "Absolutely Not"

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            // Loop through all 8 generic directions (N, NE, E, SE, S, SW, W, NW)
            for (int i = 0; i < AIDirections.EightDirections.Count; i++)
            {
                Vector3 direction = AIDirections.EightDirections[i];

                // 1. Calculate where this direction takes us
                // We use the AI's current position + direction * distance
                // Note: AIDirections are usually local or world? Context steering usually uses World Space directions relative to the agent.
                // Assuming AIDirections are unit vectors.

                Vector3 checkPos = aiData.transform.position + (direction * lookAheadDistance);

                // 2. Check for Ground
                // Lift origin up slightly to ensure we cast downwards cleanly
                Vector3 rayOrigin = checkPos + Vector3.up * 2.0f;

                // 3. The Logic: If we DO NOT hit ground, it is DANGEROUS
                if (!UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, 10f, GameConstants.MASK_GROUND_ONLY))
                {
                    // VOID DETECTED!
                    // Set danger for this specific direction slot
                    danger[i] = voidDangerWeight;
                }
            }
        }
    }
}