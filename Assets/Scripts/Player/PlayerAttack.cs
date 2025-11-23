using UnityEngine;
using DarkTowerTron.Combat; // Required for Enemy reference

namespace DarkTowerTron.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [Header("Settings")]
        public float attackRange = 2f;
        public float attackCooldown = 0.3f;
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public GameObject spearPhantomPrefab; // Cyan capsule
        public Transform firePoint; // Child object offset

        private float cooldownTimer = 0f;

        void Update()
        {
            // Cooldown management
            if (cooldownTimer > 0) cooldownTimer -= Time.deltaTime;

            if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0)
            {
                PerformAttack();
            }
        }

        void PerformAttack()
        {
            // 1. Reset cooldown.
            cooldownTimer = attackCooldown;

            // 2. Instantiate spearPhantomPrefab at firePoint (destroy after 0.1s).
            if (spearPhantomPrefab != null && firePoint != null)
            {
                GameObject phantom = Instantiate(spearPhantomPrefab, firePoint.position, firePoint.rotation);
                Destroy(phantom, 0.1f);
            }

            // 3. Raycast forward from firePoint, distance = attackRange, mask = enemyLayer.
            // Use transform.position/forward if firePoint is missing
            Vector3 origin = firePoint != null ? firePoint.position : transform.position;
            Vector3 direction = firePoint != null ? firePoint.forward : transform.forward;

            RaycastHit hit;
            if (Physics.Raycast(origin, direction, out hit, attackRange, enemyLayer))
            {
                // 4. If hit: Get Modular Components (Stagger & Health)
                EnemyStagger stagger = hit.collider.GetComponent<EnemyStagger>();
                EnemyHealth health = hit.collider.GetComponent<EnemyHealth>();

                if (stagger != null)
                {
                    // 5. Logic: Kill if staggered, else add stagger
                    if (stagger.isStaggered && health != null)
                    {
                        health.TakeFatalHit();
                        Debug.Log($"Executed Enemy: {hit.collider.name}");
                    }
                    else
                    {
                        stagger.AddStagger(0.4f); // 40% stagger per hit
                        Debug.Log($"Staggered Enemy: {hit.collider.name}");
                    }
                }
            }
        }

        void OnDrawGizmos()
        {
            // Draw a red line showing attack range.
            if (firePoint != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(firePoint.position, firePoint.position + firePoint.forward * attackRange);
            }
            else
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, transform.position + transform.forward * attackRange);
            }
        }
    }
}