using UnityEngine;
using DarkTowerTron.Player; // Access PlayerHealth directly for special void logic

namespace DarkTowerTron.Core
{
    public class VoidKiller : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            // 1. Check for Player
            PlayerHealth player = other.GetComponentInParent<PlayerHealth>();
            if (player != null)
            {
                player.TakeVoidDamage();
                return;
            }

            // 2. Check for Enemies (Instant Kill)
            IDamageable damageable = other.GetComponentInParent<IDamageable>();
            if (damageable != null)
            {
                damageable.Kill(true);
            }
            else
            {
                // Debris/Bullets
                Destroy(other.gameObject);
                // Note: If object is Pooled, this might break pool logic if not handled.
                // Ideally check for IPoolable, but Destroy is a safe fallback for cleanup.
            }
        }
    }
}