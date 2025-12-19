using UnityEngine;

namespace DarkTowerTron.Core
{
    public struct DamageInfo
    {
        public float damageAmount;
        public float staggerAmount;
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
    }

    public interface IDamageable
    {
        bool TakeDamage(DamageInfo info);
        void Kill(bool instant);
    }

    public interface IReflectable
    {
        void Redirect(Vector3 newDirection, GameObject newOwner);
    }

    // NEW: Standardizes input for any weapon (Beam, Gun, Sword)
    public interface IWeapon
    {
        void SetFiring(bool isFiring);
    }

    public interface IPoolable
    {
        void OnSpawn();
        void OnDespawn();
    }

    /// <summary>
    /// Implemented by anything the Player can Lock-On to and Execute (Enemy or Prop).
    /// </summary>
    public interface ICombatTarget
    {
        Transform transform { get; } // Access to position
        bool IsStaggered { get; }    // Can we teleport to it?
        
        // Called when Player presses 'E' on this target
        void OnExecutionHit();
    }
}