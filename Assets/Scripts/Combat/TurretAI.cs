using UnityEngine;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(Enemy))]
    public class TurretAI : MonoBehaviour
    {
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireRate = 2f;
        public float aimHeight = 1.0f; // Aim at chest level (1 meter up)

        private Transform player;
        private float timer;
        private Enemy enemyStats;

        void Start()
        {
            enemyStats = GetComponent<Enemy>();
            GameObject playerObj = GameObject.FindWithTag("Player");
            if (playerObj != null) player = playerObj.transform;
        }

        void Update()
        {
            if (player == null || enemyStats.isStaggered) return;

            // 1. ROTATION FIX: Look at player, but keep head straight
            // We create a target point that is at the SAME HEIGHT as the turret
            Vector3 lookTarget = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(lookTarget);

            timer += Time.deltaTime;
            if (timer >= fireRate)
            {
                timer = 0;
                Shoot();
            }
        }

        void Shoot()
        {
            if (projectilePrefab == null) return;

            GameObject proj = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Projectile pScript = proj.GetComponent<Projectile>();

            if (pScript != null)
            {
                // 2. AIMING FIX: Target the Chest, not the Feet
                Vector3 playerChest = player.position + Vector3.up * aimHeight;

                Vector3 dir = (playerChest - firePoint.position).normalized;
                pScript.Initialize(dir);
            }
            else
            {
                Destroy(proj);
            }
        }
    }
}