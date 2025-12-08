using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Turret : EnemyBaseAI
    {
        [Header("Turret Stats")]
        public float rotationSpeed = 2.0f;
        public float fireInterval = 3.0f;
        public int burstCount = 5;
        public float burstRate = 0.1f;

        [Header("Setup")]
        public GameObject projectilePrefab;
        public Transform firePoint;

        private float _timer;

        protected override void Start()
        {
            base.Start(); // Important to call base.Start() for event subs!

            // Turret specific setup
            _motor.rotationSpeed = this.rotationSpeed;
            _motor.moveSpeed = 0f;
            _controller.hasFrontalShield = true;
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
                // Stop firing if we get staggered mid-burst
                if (_controller.IsStaggered) yield break;

                if (projectilePrefab)
                {
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;
                    
                    // Fire
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f); // 15f is default speed
                }

                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}