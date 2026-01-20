using UnityEngine;
using DarkTowerTron.Core.Patterns; // If IPoolable is here
using DarkTowerTron.Gameplay.Combat; // Required for DamageInfo / IDamageable

namespace DarkTowerTron.Gameplay.Combat
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class Projectile : MonoBehaviour, IPoolable
    {
        [Header("Settings")]
        [SerializeField] private float _speed = 20f;
        [SerializeField] private float _damage = 10f;
        [SerializeField] private float _lifetime = 5f;
        [SerializeField] private DamageType _damageType = DamageType.Physical; // Fixed Error

        private Rigidbody _rb;
        private float _timer;
        private bool _active;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _rb.useGravity = false;
            _rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }

        public void OnSpawn()
        {
            _timer = _lifetime;
            _active = true;
            _rb.velocity = transform.forward * _speed;
        }

        public void OnDespawn()
        {
            _active = false;
            _rb.velocity = Vector3.zero;
        }

        private void Update()
        {
            if (!_active) return;

            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                // Return to pool (Assuming PoolService handles this or self-destruct)
                gameObject.SetActive(false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!_active) return;

            // Try to find an IDamageable
            IDamageable target = other.GetComponent<IDamageable>();

            // If hitting a Hitbox, it handles the redirection
            if (target != null)
            {
                // Create the struct
                DamageInfo info = new DamageInfo(_damage, false, gameObject);
                // Note: If you want to pass DamageType, add it to the DamageInfo struct definition!

                target.TakeDamage(info);
            }

            // Destroy/Return to pool on impact
            gameObject.SetActive(false);
        }
    }
}