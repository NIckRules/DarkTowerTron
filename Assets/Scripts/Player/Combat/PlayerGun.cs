using DarkTowerTron.Combat;
using DarkTowerTron.Player.Stats;
using UnityEngine;
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(DarkTowerTron.Player.Stats.PlayerLoadout))]
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
            GameObject prefabToSpawn = _loadout.currentProjectile;

            if (prefabToSpawn && firePoint)
            {
                // Use Smart Aim
                Vector3 aimDir = GetAimDirection();

                // Use Global Pool
                GameObject p = Global.Pool.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));

                var proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;

                    // Stats Injection
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;

                    // CRITICAL: Self-Hit Protection
                    proj.SetSource(gameObject);

                    proj.Initialize(aimDir);
                }
            }
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.GunRate;
        }
    }
}