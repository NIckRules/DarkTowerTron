using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Combat
{
    public class SniperAttack : EnemyAttack
    {
        public GameObject projectilePrefab;
        public LineRenderer laser;
        public float bulletSpeed = 25f;

        private EnemyStagger stagger;
        private Transform player;
        private Rigidbody playerRb; // For velocity prediction

        void Start()
        {
            stagger = GetComponent<EnemyStagger>();
            var p = GameObject.FindWithTag("Player");
            if (p)
            {
                player = p.transform;
                playerRb = p.GetComponent<Rigidbody>();
            }
            StartCoroutine(AttackLoop());
        }

        IEnumerator AttackLoop()
        {
            if (laser != null)
            {
                laser.positionCount = 2;
                laser.enabled = false;
            }

            while (true)
            {
                // 1. Wait (Cooldown) - 3 seconds (Total 4s cycle with 1s telegraph)
                yield return new WaitForSeconds(3f);

                // Check Stagger
                if (stagger != null && stagger.isStaggered)
                {
                    yield return new WaitUntil(() => !stagger.isStaggered);
                    continue;
                }

                if (player == null) continue;

                // 2. Telegraph Phase (1s)
                BeginTelegraph();
                if (laser != null) laser.enabled = true;
                
                float telegraphDuration = 1.0f;
                float timer = 0f;
                Vector3 targetPos = player.position;

                while (timer < telegraphDuration)
                {
                    if (stagger != null && stagger.isStaggered)
                    {
                        if (laser != null) laser.enabled = false;
                        break;
                    }

                    if (player != null)
                    {
                        // Prediction logic
                        Vector3 velocity = (playerRb != null) ? playerRb.velocity : Vector3.zero;
                        targetPos = player.position + (velocity * 0.3f); // 0.3s prediction
                        
                        // Update Laser
                        if (laser != null)
                        {
                            laser.SetPosition(0, transform.position);
                            laser.SetPosition(1, targetPos);
                        }

                        // Face target
                        Vector3 dir = (targetPos - transform.position).normalized;
                        dir.y = 0; // Keep flat
                        if (dir != Vector3.zero) transform.rotation = Quaternion.LookRotation(dir);
                    }

                    timer += Time.deltaTime;
                    yield return null;
                }

                if (laser != null) laser.enabled = false;
                EndTelegraph();

                // If staggered during telegraph, restart loop
                if (stagger != null && stagger.isStaggered)
                {
                    yield return new WaitUntil(() => !stagger.isStaggered);
                    continue;
                }

                // 3. Fire Phase
                Fire();
            }
        }

        public override void Fire()
        {
            if (projectilePrefab != null)
            {
                Vector3 spawnPos = transform.position + transform.forward * 0.6f;
                GameObject proj = Instantiate(projectilePrefab, spawnPos, transform.rotation);
                
                Projectile p = proj.GetComponent<Projectile>();
                if (p != null)
                {
                    p.speed = bulletSpeed;
                    p.Initialize(transform.forward);
                }
            }
        }
    }
}