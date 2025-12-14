using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // Needed for PoolManager

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Ballistics")]
        public float speed = 15f;
        public float lifetime = 5f;
        public bool isHostile = true;

        [Header("Damage Stats")]
        public float damage = 10f;
        public float stagger = 0f;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Material friendlyMaterial;

        [Header("Safety")]
        public LayerMask wallLayer; // Explicit LayerMask

        private Material _originalMaterial;

        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false;
        private float _lifeTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.sharedMaterial; // sharedMaterial is safer for caching origin

            // Default mask if not set
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
        }

        public void OnSpawn()
        {
            // Reset logic happens in Initialize, but we can safety reset here too
            _lifeTimer = lifetime;
        }

        public void OnDespawn()
        {
            CancelInvoke();
            _isInitialized = false;
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;

            _isRedirected = false; // Reset status

            // Restore visual
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;
        }

        // RESET LOGIC WHEN PULLED FROM POOL
        public void ResetHostility(bool startHostile)
        {
            isHostile = startHostile;
        }

        private void Update()
        {
            if (!_isInitialized) return;

            transform.Translate(_direction * speed * Time.deltaTime, Space.World);

            // Manual Lifetime check
            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0)
            {
                Despawn();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.isTrigger) return;

            // OPTIMIZATION: Bitwise check against LayerMask
            // This is significantly faster than comparing strings or layer indices manually
            if ((wallLayer.value & (1 << other.gameObject.layer)) > 0)
            {
                Despawn();
                return;
            }

            IDamageable target = other.GetComponentInParent<IDamageable>();
            if (target != null)
            {
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = this.damage,
                    staggerAmount = this.stagger,
                    pushDirection = _direction,
                    pushForce = 5f,
                    source = gameObject,
                    isRedirected = this._isRedirected
                };

                if (target.TakeDamage(info)) Despawn();
            }
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false;
            _isRedirected = true;
            _direction = newDirection.normalized;
            speed *= 1.5f;

            if (meshRenderer && friendlyMaterial) meshRenderer.material = friendlyMaterial;
            else if (meshRenderer) meshRenderer.material.color = Color.cyan;

            _lifeTimer = 3.0f; // Renew lifetime
        }

        private void Despawn()
        {
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}