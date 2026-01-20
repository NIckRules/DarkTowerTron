using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IPoolService

namespace DarkTowerTron.Gameplay.Player
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

        protected override void Fire()
        {
            GameObject prefabToSpawn = _loadout.currentProjectile;

            // 1. Get Pool Service
            var pool = ServiceLocator.Get<IPoolService>();

            if (prefabToSpawn && firePoint && pool != null)
            {
                // Use Smart Aim (Inherited from WeaponBase)
                Vector3 aimDir = GetAimDirection();

                // 2. Spawn via Service
                GameObject p = pool.Spawn(prefabToSpawn, firePoint.position, Quaternion.LookRotation(aimDir));

                var proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = bulletSpeed;
                    proj.isHostile = false;

                    // Stats Injection
                    proj.damage = _stats.GunDamage;
                    proj.stagger = _stats.GunStagger;

                    // CRITICAL: Self-Hit Protection
                    // Ensure the bullet knows the Player fired it so it doesn't collide with the player immediately
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