using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    // Inherits from WeaponBase instead of MonoBehaviour
    [RequireComponent(typeof(PlayerLoadout))]
    public class PlayerGun : WeaponBase 
    {
        [Header("Gun Specifics")]
        public float bulletSpeed = 25f;

        private PlayerLoadout _loadout;

        protected override void Awake()
        {
            base.Awake();
            _loadout = GetComponent<PlayerLoadout>();
        }

        protected override void Fire()
        {
            // Read from loadout
            GameObject prefabToSpawn = _loadout.currentProjectile;

            if (prefabToSpawn && firePoint)
            {
                Vector3 aimDir = GetAimDirection();
                GameObject p = PoolManager.Instance.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));
                
                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;
                    proj.Initialize(aimDir);
                }
            }
        }
    }
}