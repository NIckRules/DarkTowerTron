using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.Enemy.Agents
{
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Turret : EnemyBaseAI
    {
        [Header("Turret Combat")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public float fireInterval = 3.0f;
        public int burstCount = 5;
        public float burstRate = 0.1f;

        private ContextSolver _brain;
        private float _timer;

        protected override void Awake()
        {
            base.Awake();
            _brain = GetComponent<ContextSolver>();
        }

        protected override void Start()
        {
            base.Start();
            _timer = fireInterval;
        }

        protected override void RunAI()
        {
            // 1. Navigation
            // Even though speed is 0, we ask the brain. 
            // If we ever give it speed > 0 in stats, it will automatically start avoiding walls!
            Vector3 smartDir = _brain.GetDirectionToMove();
            _motor.Move(smartDir);

            // 2. Aiming (Always face target)
            _motor.FaceTarget(_currentTarget.position);

            // 3. Combat
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
                    // Use Base Helper
                    FireProjectile(projectilePrefab, spawnPos, transform.rotation, transform.forward, 15f);
                }
                yield return new WaitForSeconds(burstRate);
            }
        }
    }
}