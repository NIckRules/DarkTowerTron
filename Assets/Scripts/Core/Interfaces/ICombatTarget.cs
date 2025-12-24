using UnityEngine;

namespace DarkTowerTron.Core
{
    /// <summary>
    /// Implemented by anything the Player can Lock-On to and Execute (Enemy or Prop).
    /// </summary>
    public interface ICombatTarget
    {
        Transform transform { get; } // Required to get position
        bool IsStaggered { get; }    // Execution condition

        void OnExecutionHit();
    }
}