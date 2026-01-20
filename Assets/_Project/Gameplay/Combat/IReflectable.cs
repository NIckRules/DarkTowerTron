using UnityEngine;
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null);
    }
}