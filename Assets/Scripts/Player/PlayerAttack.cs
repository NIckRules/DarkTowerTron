using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [Header("Settings")]
        public float attackRange = 2.5f; // Increased slightly to feel better with SphereCast
        public float hitRadius = 0.5f;   // NEW: Thickness of the spear thrust
        public float attackCooldown = 0.3f;
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public GameObject spearPhantomPrefab;
        public Transform firePoint;

        private float cooldownTimer = 0f;

        void Update()
        {
            if (cooldownTimer > 0) cooldownTimer -= Time.deltaTime;

            if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0)
            {
                PerformAttack();
            }
        }

        void PerformAttack()
        {
            cooldownTimer = attackCooldown;

            // Visuals
            if (spearPhantomPrefab != null && firePoint != null)
            {
                GameObject phantom = Instantiate(spearPhantomPrefab, firePoint.position, firePoint.rotation);
                Destroy(phantom, 0.1f);
            }

            Vector3 origin = firePoint != null ? firePoint.position : transform.position;
            Vector3 direction = firePoint != null ? firePoint.forward : transform.forward;

            // Mask Logic
            int mask = enemyLayer.value;
            if (mask == 0)
            {
                int enemyLayerIndex = LayerMask.NameToLayer("Enemy");
                if (enemyLayerIndex != -1) mask = 1 << enemyLayerIndex;
                else mask = Physics.DefaultRaycastLayers;
            }

            RaycastHit hit;

            // --- CHANGE START: SphereCast (The "Thick" Ray) ---
            // This fires a sphere forward. It hits anything vertically misaligned within 'hitRadius'.
            if (Physics.SphereCast(origin, hitRadius, direction, out hit, attackRange, mask))
            {
                if (hit.collider.gameObject == gameObject) return;

                // 4. If hit: Get Modular Components
                EnemyStagger stagger = hit.collider.GetComponent<EnemyStagger>();
                EnemyHealth health = hit.collider.GetComponent<EnemyHealth>();

                // Logic: Kill if staggered, else add stagger
                if (stagger != null)
                {
                    if (stagger.isStaggered && health != null)
                    {
                        // EXECUTION JUICE
                        if (GameFeel.instance != null)
                        {
                            GameFeel.instance.HitStop(0.15f); // Long pause
                            GameFeel.instance.CameraShake(0.4f, 0.5f); // Big shake
                            GameFeel.instance.PlayKill();
                        }
                        
                        health.TakeFatalHit();
                        Debug.Log($"<color=red>Executed: {hit.collider.name}</color>");
                    }
                    else
                    {
                        // STAGGER JUICE
                        if (GameFeel.instance != null)
                        {
                            GameFeel.instance.HitStop(0.05f); // Short pause
                            GameFeel.instance.CameraShake(0.1f, 0.2f); // Small shake
                            GameFeel.instance.PlayHit();
                        }

                        stagger.AddStagger(1.0f);
                        Debug.Log($"<color=yellow>Staggered: {hit.collider.name}</color>");
                    }
                }
                else
                {
                    // Fallback for walls/props
                    Debug.Log($"Hit Object: {hit.collider.name}");
                }
            }
            // --- CHANGE END ---
            else
            {
                // Debugging: Why did we miss?
                // This cast has NO mask, so it hits everything.
                if (Physics.SphereCast(origin, hitRadius, direction, out RaycastHit debugHit, attackRange))
                {
                    // FIX: Don't complain if we hit a Trigger (Projectiles, Zones)
                    if (debugHit.collider.isTrigger) return; 

                    Debug.LogWarning($"Attack hit '{debugHit.collider.name}' (Layer: {LayerMask.LayerToName(debugHit.collider.gameObject.layer)}) which was excluded by the LayerMask.");
                }
            }
        }

        void OnDrawGizmos()
        {
            if (firePoint != null)
            {
                Gizmos.color = Color.red;
                // Draw the "Tube" of the attack
                Vector3 endPos = firePoint.position + firePoint.forward * attackRange;
                Gizmos.DrawWireSphere(firePoint.position, hitRadius);
                Gizmos.DrawLine(firePoint.position, endPos);
                Gizmos.DrawWireSphere(endPos, hitRadius);
            }
        }
    }
}