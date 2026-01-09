using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;


namespace DarkTowerTron.Combat
{
    public class ContactDamager : MonoBehaviour
    {
        public float damage = 1f;
        public float pushForce = 10f;
        public float damageCooldown = 1.0f;
        public bool destroySelfOnHit = false; // Turn on for Kamikaze units

        private float _lastHitTime;

        private void OnTriggerStay(Collider other)
        {

            GameLogger.Log(LogChannel.Combat, $"ContactDamager triggered with {other.name}", gameObject);

            if (Time.time < _lastHitTime + damageCooldown) return;

            // Check Tag (Optimization)
            if (!other.CompareTag(GameConstants.TAG_PLAYER)) return;

            IDamageable target = other.GetComponentInParent<IDamageable>();
            if (target != null)
            {
                Vector3 pushDir = (other.transform.position - transform.position).normalized;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = pushDir,
                    pushForce = pushForce,
                    source = gameObject,
                    damageType = DamageType.Melee
                };

                if (target.TakeDamage(info))
                {
                    _lastHitTime = Time.time;
                    if (destroySelfOnHit)
                    {
                        var health = GetComponent<IDamageable>();
                        if (health != null) health.Kill(false);
                    }
                }
            }
        }
    }
}