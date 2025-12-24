using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner);
    }
}