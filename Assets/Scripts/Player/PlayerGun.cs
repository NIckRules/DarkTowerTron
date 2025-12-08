using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(TargetScanner))]
    public class PlayerGun : MonoBehaviour, IWeapon
    {
        [Header("Gun Stats")]
        public GameObject bulletPrefab;
        public Transform firePoint;
        public float fireRate = 0.15f;

        private float _timer;
        private bool _isFiring;
        private TargetScanner _scanner;

        private void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        private void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;

            if (_isFiring && _timer <= 0)
            {
                Fire();
            }
        }

        private void Fire()
        {
            _timer = fireRate;

            if (bulletPrefab && firePoint)
            {
                // Default Aim: Forward
                Vector3 aimDir = firePoint.forward;

                // Auto-Aim Override
                if (_scanner.CurrentTarget != null)
                {
                    aimDir = (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
                }

                GameObject p = Instantiate(bulletPrefab, firePoint.position, Quaternion.LookRotation(aimDir));

                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = 20f;
                    proj.isHostile = false;
                    proj.Initialize(aimDir);
                }
            }
        }
    }
}