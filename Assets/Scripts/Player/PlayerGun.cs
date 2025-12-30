using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
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

        protected override float GetCurrentFireRate()
        {
            return _stats.GunRate;
        }

        protected override void Fire()
        {
            GameObject prefabToSpawn = _loadout.currentProjectile;

            if (prefabToSpawn && firePoint)
            {
                Vector3 aimDir = GetAimDirection();
                GameObject p = PoolManager.Instance.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));

                var proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;

                    // Inject Stats
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;

                    proj.Initialize(aimDir);
                }
            }
        }
    }
}