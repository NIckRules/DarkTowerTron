using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy;

namespace DarkTowerTron.Player
{
    // Abstract means you can't put this directly on an object, 
    // you must extend it (like PlayerGun : WeaponBase)
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        public float fireRate = 0.2f; // Time between shots

        protected float _timer;
        protected bool _isFiring;
        protected TargetScanner _scanner;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;

            if (_isFiring && _timer <= 0)
            {
                Fire();
                _timer = fireRate; // Reset timer automatically
            }
        }

        // Children MUST implement this (The "Bang")
        protected abstract void Fire();

        // --- SHARED HELPER METHODS ---

        /// <summary>
        /// Calculates the best firing direction. 
        /// Defaults to forward. If Locked On, aims at Enemy Center Mass.
        /// </summary>
        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                // Logic moved here from Gun/Attack scripts
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
                
                // Try to find center of mass
                var col = _scanner.CurrentTarget.GetComponent<Collider>();
                if (col != null) targetPos = col.bounds.center;

                aimDir = (targetPos - firePoint.position).normalized;
            }

            return aimDir;
        }
    }
}