using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    // Base class for all AI steering behaviors
    public abstract class SteeringBehavior : ScriptableObject
    {
        // Added: Reference to the owner's collider for better checks
        protected Collider ownerCollider;

        /// <summary>
        /// Called by ContextSolver when the behavior becomes active.
        /// </summary>
        public virtual void Initialize(Collider ownerCol)
        {
            // Store the collider passed from the agent
            this.ownerCollider = ownerCol;
        }

        public abstract void GetSteering(float[] interest, float[] danger, AIData aiData);
    }
}