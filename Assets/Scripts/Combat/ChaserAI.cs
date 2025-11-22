using UnityEngine;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(Enemy))]
    [RequireComponent(typeof(Rigidbody))]
    public class ChaserAI : MonoBehaviour
    {
        [Header("Stats")]
        public float moveSpeed = 6f;
        public float explodeRange = 1.5f;
        public float separationRadius = 2.5f;
        public float separationForce = 5f;

        private Transform player;
        private Enemy enemyStats;
        private Rigidbody rb;

        // NEW: Knockback State
        private float knockbackTimer = 0f;

        void Start()
        {
            enemyStats = GetComponent<Enemy>();
            rb = GetComponent<Rigidbody>();
            GameObject p = GameObject.FindWithTag("Player");
            if (p != null) player = p.transform;
        }

        void FixedUpdate()
        {
            // 1. Decrease Knockback Timer
            if (knockbackTimer > 0)
            {
                knockbackTimer -= Time.fixedDeltaTime;
                return; // STOP AI while flying through the air
            }

            if (player == null || enemyStats.isStaggered) return;

            float distance = Vector3.Distance(transform.position, player.position);

            if (distance > explodeRange)
            {
                Vector3 dirToPlayer = (player.position - transform.position).normalized;

                // Boid Separation Logic
                Vector3 separation = Vector3.zero;
                Collider[] neighbors = Physics.OverlapSphere(transform.position, separationRadius);
                int count = 0;
                foreach (Collider c in neighbors)
                {
                    if (c.gameObject != gameObject && c.CompareTag("Enemy"))
                    {
                        Vector3 pushDir = transform.position - c.transform.position;
                        separation += pushDir.normalized / (pushDir.magnitude + 0.1f);
                        count++;
                    }
                }
                if (count > 0) separation /= count;

                Vector3 finalDir = (dirToPlayer + (separation * separationForce)).normalized;

                Vector3 targetPos = rb.position + finalDir * moveSpeed * Time.fixedDeltaTime;
                rb.MovePosition(targetPos);

                // Look logic
                Vector3 lookT = new Vector3(player.position.x, transform.position.y, player.position.z);
                transform.LookAt(lookT);
            }
            else
            {
                // Check explode logic...
                // (Simple distance check again to be safe)
                if (Vector3.Distance(transform.position, player.position) <= explodeRange + 0.5f)
                {
                    // Explode();
                    // Call logic on Enemy script or here
                    var pStats = player.GetComponent<DarkTowerTron.Player.PlayerStats>();
                    if (pStats) pStats.TakeDamage(1);
                    Destroy(gameObject);
                }
            }
        }

        // NEW: Public method to apply force and disable AI
        public void ApplyKnockback(Vector3 force, float duration)
        {
            knockbackTimer = duration; // Disable AI movement
            rb.AddForce(force, ForceMode.Impulse); // Apply physics
        }
    }
}