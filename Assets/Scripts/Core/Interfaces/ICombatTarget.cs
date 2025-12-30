using UnityEngine;

namespace DarkTowerTron.Core
{
    public interface ICombatTarget
    {
        Transform transform { get; }
        bool IsStaggered { get; }

        // NEW: Tells the Execution script if it should snap Y to ground
        bool KeepPlayerGrounded { get; }

        void OnExecutionHit();
    }
}