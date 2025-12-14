using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    public abstract class SteeringBehavior : ScriptableObject
    {
        /// <summary>
        /// Calculates the Interest (Where I want to go) and Danger (Where I must NOT go).
        /// </summary>
        /// <param name="interest">Array of 8 floats (0 to 1)</param>
        /// <param name="danger">Array of 8 floats (0 to 1)</param>
        /// <param name="aiData">Contextual data (Targets, Obstacles)</param>
        public abstract void GetSteering(float[] interest, float[] danger, AIData aiData);
    }
}