using UnityEngine;
using DarkTowerTron.Combat.Strategies; 

namespace DarkTowerTron.Core
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null);
    }
}