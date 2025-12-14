using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Strafer : EnemyBaseAI
    {
        [Header("Strafe Settings")]
        public bool clockwise = true;
        public float idealDistance = 6f;

        [Header("Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint; // <--- ADDED THIS
        public float fireInterval = 2.5f;
        public int burstCount = 2;
        public float burstRate = 0.2f;

        private float _timer;

        protected override void Start()
        {
            base.Start();
            clockwise = Random.value > 0.5f;
            _timer = Random.Range(1f, fireInterval);
        }

        protected override void RunAI()
        {
            // --- MOVEMENT (Orbit) ---
            Vector3 offset = transform.position - _currentTarget.position;
            
            // FIX: Flatten the offset so we calculate distance/direction purely on the floor plane
            offset.y = 0; 

            Vector3 dirToTarget = -offset.normalized;
            float distance = offset.magnitude;

            Vector3 tangent = Vector3.Cross(Vector3.up, dirToTarget).normalized;
            if (!clockwise) tangent = -tangent;

            Vector3 correction = Vector3.zero;
            if (distance > idealDistance + 1f) correction = dirToTarget * 0.5f;
            else if (distance < idealDistance - 1f) correction = -dirToTarget * 0.5f;

            // The resulting vector is now guaranteed to be flat (y=0)
            _motor.Move((tangent + correction).normalized);
            
            // Face target (EnemyMotor.FaceTarget already handles flattening, so this is safe)
            _motor.FaceTarget(_currentTarget.position);

            // --- COMBAT ---
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
                    Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward * 1.0f;
                    Quaternion spawnRot = firePoint ? firePoint.rotation : transform.rotation;

                    // Fire
                    FireProjectile(projectilePrefab, spawnPos, spawnRot, transform.forward, 12f);
                }
                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}