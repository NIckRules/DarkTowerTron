using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Combat
{
    public class PebbleAttack : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public float fireRate = 2f;
        public float telegraphTime = 0.5f;
        
        private EnemyStagger stagger;
        private Transform player;

        void Start()
        {
            stagger = GetComponent<EnemyStagger>();
            var p = GameObject.FindWithTag("Player");
            if(p) player = p.transform;
            StartCoroutine(AttackLoop());
        }

        IEnumerator AttackLoop()
        {
            Renderer rend = GetComponent<Renderer>();
            Vector3 originalScale = transform.localScale;

            while (true)
            {
                // 1. Wait (fireRate - telegraph).
                float waitTime = Mathf.Max(0, fireRate - telegraphTime);
                yield return new WaitForSeconds(waitTime);

                // 2. Check Stagger before starting telegraph
                if (stagger != null && stagger.isStaggered)
                {
                    yield return new WaitUntil(() => !stagger.isStaggered);
                    continue;
                }

                if (player == null) continue;

                // 3. Telegraph (Scale up / Change Color).
                if (rend) rend.material.color = Color.yellow;
                transform.localScale = originalScale * 1.2f;

                float timer = 0f;
                while (timer < telegraphTime)
                {
                    // Check interrupt
                    if (stagger != null && stagger.isStaggered)
                    {
                        // Reset scale immediately
                        transform.localScale = originalScale;
                        // Do NOT reset color, Stagger component handles it (Cyan)
                        break;
                    }

                    // Face player
                    Vector3 dir = (player.position - transform.position).normalized;
                    dir.y = 0;
                    if (dir != Vector3.zero) transform.rotation = Quaternion.LookRotation(dir);

                    timer += Time.deltaTime;
                    yield return null;
                }

                // If we were staggered during telegraph, wait it out and restart
                if (stagger != null && stagger.isStaggered)
                {
                    yield return new WaitUntil(() => !stagger.isStaggered);
                    continue;
                }

                // 4. Fire Projectile towards player.
                FireProjectile();

                // 5. Reset Visuals.
                transform.localScale = originalScale;
                if (rend && stagger != null) rend.material.color = stagger.normalColor;
            }
        }

        void FireProjectile()
        {
            if (projectilePrefab != null)
            {
                // Spawn slightly in front
                Vector3 spawnPos = transform.position + transform.forward * 0.6f;
                GameObject proj = Instantiate(projectilePrefab, spawnPos, transform.rotation);
                
                Projectile p = proj.GetComponent<Projectile>();
                if (p != null)
                {
                    p.speed = 8f; // Pebble speed
                    p.Initialize(transform.forward);
                }
            }
        }
    }
}