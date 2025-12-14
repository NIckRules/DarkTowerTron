using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core.Behaviors
{
    [CreateAssetMenu(fileName = "Beh_Orbit", menuName = "DarkTowerTron/AI/Behaviors/Orbit")]
    public class OrbitBehavior : SteeringBehavior
    {
        [Header("Orbit Settings")]
        public float idealDistance = 7f;
        public float distanceCorrectionStrength = 0.5f; // How hard we push back/in
        public bool clockwise = true;

        public override void GetSteering(float[] interest, float[] danger, AIData aiData)
        {
            if (aiData.currentTarget == null) return;

            // 1. Calculate Vectors
            Vector3 vectorToTarget = aiData.currentTarget.position - aiData.transform.position;
            vectorToTarget.y = 0; // Flatten
            float distance = vectorToTarget.magnitude;
            Vector3 dirToTarget = vectorToTarget.normalized;

            // 2. Calculate Tangent (The Orbit Direction)
            // Cross product of Up(0,1,0) and Forward gives Right
            Vector3 tangent = Vector3.Cross(Vector3.up, dirToTarget).normalized;
            if (!clockwise) tangent = -tangent;

            // 3. Calculate Correction (Push In or Pull Out)
            Vector3 correction = Vector3.zero;

            // Allow a "dead zone" of 1 unit where we just orbit purely
            if (distance > idealDistance + 1f)
            {
                correction = dirToTarget * distanceCorrectionStrength; // Move closer
            }
            else if (distance < idealDistance - 1f)
            {
                correction = -dirToTarget * distanceCorrectionStrength; // Back away
            }

            // 4. Combine
            Vector3 finalDir = (tangent + correction).normalized;

            // 5. Map to 8 Directions
            for (int i = 0; i < interest.Length; i++)
            {
                float dot = Vector3.Dot(finalDir, AIDirections.EightDirections[i]);
                if (dot > 0 && dot > interest[i])
                {
                    interest[i] = dot;
                }
            }
        }
    }
}