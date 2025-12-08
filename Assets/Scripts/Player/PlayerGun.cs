using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    // Inherits from WeaponBase instead of MonoBehaviour
    public class PlayerGun : WeaponBase 
    {
        [Header("Gun Specifics")]
        public GameObject bulletPrefab;
        public float bulletSpeed = 25f;

        protected override void Fire()
        {
            if (bulletPrefab && firePoint)
            {
                // 1. Get Aim (Handled by Base)
                Vector3 aimDir = GetAimDirection();

                // 2. Spawn
                GameObject p = PoolManager.Instance.Spawn(bulletPrefab, firePoint.position, Quaternion.LookRotation(aimDir));
                
                // 3. Setup
                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false; // Player bullet
                    proj.Initialize(aimDir);
                }
            }
        }
    }
}