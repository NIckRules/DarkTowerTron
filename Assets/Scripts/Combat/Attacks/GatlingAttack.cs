using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Combat
{
    public class GatlingAttack : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public int burstCount = 5;
        public float timeBetweenShots = 0.1f;

        private EnemyStagger stagger;
        private Transform player;

        void Start()
        {
            stagger = GetComponent<EnemyStagger>();
            var p = GameObject.FindWithTag("Player");
            if (p) player = p.transform;
            StartCoroutine(AttackLoop());
        }

        IEnumerator AttackLoop()
        {
            // 1. Loop.
            while (true)
            {
                // 2. Spin Up (Telegraph).
                float telegraphDuration = 0.3f;
                float timer = 0f;

                // Track player during telegraph
                while (timer < telegraphDuration)
                {
                    if (stagger != null && stagger.isStaggered) break;

                    if (player != null)
                    {
                        Vector3 dir = (player.position - transform.position).normalized;
                        dir.y = 0; // Keep flat
                        if (dir != Vector3.zero)
                        {
                            transform.rotation = Quaternion.LookRotation(dir);
                        }
                    }

                    timer += Time.deltaTime;
                    yield return null;
                }

                // Check if Staggered (Break/Restart if true).
                if (stagger != null && stagger.isStaggered)
                {
                    yield return new WaitUntil(() => !stagger.isStaggered);
                    continue;
                }

                // 3. Burst Loop (for i < burstCount):
                if (stagger != null) stagger.decayMultiplier = 0.5f; // Harder to stagger while shooting

                for (int i = 0; i < burstCount; i++)
                {
                    // Check if Staggered (Break if true).
                    if (stagger != null && stagger.isStaggered) break;

                    // Fire bullet.
                    FireProjectile();

                    // Wait(timeBetweenShots).
                    yield return new WaitForSeconds(timeBetweenShots);
                }

                // Reset decay multiplier
                if (stagger != null) stagger.decayMultiplier = 1.0f;

                // Wait for next attack cycle (e.g. 2 seconds downtime)
                yield return new WaitForSeconds(2.0f);
            }
        }

        void FireProjectile()
        {
            if (projectilePrefab != null)
            {
                // Spawn slightly in front to avoid self-collision
                Vector3 spawnPos = transform.position + transform.forward * 0.6f;
                GameObject proj = Instantiate(projectilePrefab, spawnPos, transform.rotation);
                
                Projectile p = proj.GetComponent<Projectile>();
                if (p != null)
                {
                    p.speed = 10f; // Gatling speed from design
                    p.Initialize(transform.forward);
                }
            }
        }
    }
}