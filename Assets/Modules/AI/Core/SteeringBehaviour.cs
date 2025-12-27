using UnityEngine;

namespace DarkTowerTron.AI.Core
{
    public abstract class SteeringBehavior : ScriptableObject
    {
        // REMOVED: protected Collider ownerCollider;
        // REMOVED: public virtual void Initialize(...)

        public abstract void GetSteering(float[] interest, float[] danger, AIData aiData);
    }
}