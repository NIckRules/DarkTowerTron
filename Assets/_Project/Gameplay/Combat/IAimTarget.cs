using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    public interface IAimTarget
    {
        Vector3 AimPoint { get; }
        float TargetRadius { get; }
    }
}