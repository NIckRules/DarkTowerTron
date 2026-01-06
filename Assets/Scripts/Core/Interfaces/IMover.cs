using UnityEngine;

namespace DarkTowerTron.Physics
{
    public interface IMover
    {
        // Data Access
        Vector3 Velocity { get; }
        bool IsGrounded { get; }

        // Actions
        void Move(Vector3 velocity); // Accepts Velocity (units/sec)
        void Teleport(Vector3 position);

        // Settings (Optional, for syncing)
        void SetEnabled(bool state);
    }
}