using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(ContextSolver))]
    [RequireComponent(typeof(AIData))]
    public class EnemyAgent_Chaser : EnemyBaseAI
    {
        [Header("Kamikaze Settings")]
        public float attackRange = 1.5f;
        public float damage = 1f;
        public float explosionForce = 20f;

        private ContextSolver _brain;

        protected override void Awake()
        {
            base.Awake();
            _brain = GetComponent<ContextSolver>();
        }

        protected override void RunAI()
        {
            // 1. Navigation
            Vector3 smartDir = _brain.GetDirectionToMove();
            _motor.Move(smartDir);

            if (smartDir.sqrMagnitude > 0.1f)
                _motor.FaceTarget(transform.position + smartDir);

            // 2. Attack Check
            float dist = Vector3.Distance(transform.position, _currentTarget.position);

            if (dist <= attackRange)
            {
                Detonate();
            }
        }

        private void Detonate()
        {
            // LOG 1: Who are we hitting?
            Debug.Log($"[DEBUG CHASER] Detonate Triggered! Distance was close enough. Target is: {_currentTarget.name}");

            // 2. Try to find Health Component
            IDamageable targetHealth = _currentTarget.GetComponentInParent<IDamageable>();

            // Fallback check
            if (targetHealth == null)
            {
                Debug.LogWarning($"[DEBUG CHASER] GetComponentInParent<IDamageable> failed on {_currentTarget.name}. Trying GetComponentInChildren...");
                targetHealth = _currentTarget.GetComponentInChildren<IDamageable>();
            }

            // 3. Apply Damage
            if (targetHealth != null)
            {
                Debug.Log($"[DEBUG CHASER] Script FOUND on {targetHealth}. Sending {damage} damage.");

                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = transform.forward,
                    pushForce = explosionForce,
                    source = gameObject
                };

                bool result = targetHealth.TakeDamage(info);
                Debug.Log($"[DEBUG CHASER] TakeDamage returned: {result}");
            }
            else
            {
                Debug.LogError($"[DEBUG CHASER] CRITICAL FAILURE: Target '{_currentTarget.name}' has NO IDamageable script on Parent or Children!");
            }

            // 4. Die
            _controller.Kill(true);
        }
    }
}