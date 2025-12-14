using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Chaser : EnemyBaseAI
    {
        [Header("Chaser Settings")]
        public float attackRange = 1.2f;
        public float damage = 1f;

        protected override void RunAI()
        {
            float dist = Vector3.Distance(transform.position, _currentTarget.position);

            if (dist <= attackRange)
            {
                // Only explode on the REAL player (optional choice, but logical)
                if (_currentTarget == _player)
                {
                    Explode();
                }
                else
                {
                    // If targeting decoy, just wait or circle
                    _motor.Move(Vector3.zero);
                }
            }
            else
            {
                // Chase Target
                Vector3 dir = (_currentTarget.position - transform.position).normalized;
                _motor.Move(dir);
                _motor.FaceTarget(_currentTarget.position);
            }
        }

        private void Explode()
        {
            IDamageable target = _player.GetComponent<IDamageable>();
            if (target != null)
            {
                DamageInfo info = new DamageInfo
                {
                    damageAmount = damage,
                    pushDirection = transform.forward,
                    pushForce = 20f,
                    source = gameObject
                };
                target.TakeDamage(info);
            }
            Destroy(gameObject);
        }
    }
}