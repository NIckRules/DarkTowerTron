using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface IAimTarget
    {
        /// <summary>
        /// The world-space position aiming systems should target (Center of Mass).
        /// </summary>
        Vector3 AimPoint { get; }

        /// <summary>
        /// Approximate radius for magnetism forgiveness.
        /// </summary>
        float TargetRadius { get; }
    }
}