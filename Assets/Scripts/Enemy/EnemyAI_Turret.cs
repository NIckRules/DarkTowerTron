using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Turret : EnemyBaseAI
    {
        [Header("Turret Stats")]
        // Removed rotationSpeed variable (Now handled by Stats_Guardian asset)
        public float fireInterval = 3.0f;
        public int burstCount = 5;
        public float burstRate = 0.1f;

        [Header("Setup")]
        public GameObject projectilePrefab;
        public Transform firePoint;

        private float _timer;

        protected override void Start()
        {
            base.Start();

            // REMOVED: Manual overrides for motor.rotationSpeed, moveSpeed, shield.
            // WHY: These are now defined in the 'Stats_Guardian' ScriptableObject.
            // Ensure your Stats_Guardian asset has MoveSpeed = 0, Rotation = 3, Shield = True.
        }

        protected override void RunAI()
        {
            // 1. Tracking
            _motor.FaceTarget(_currentTarget.position);

            // 2. Shooting Logic
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                StartCoroutine(FireBurst());
                _timer = fireInterval;
            }
        }

        private IEnumerator FireBurst()
        {
            for (int i = 0; i < burstCount; i++)
            {
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;

                    // Fire using Base Helper
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
                }

                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}