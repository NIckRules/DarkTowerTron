using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // Needed for PoolManager

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable
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
        // Cache original material to reset on respawn
        private Material _originalMaterial;

        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false;
        private float _lifeTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.material;
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;

            // RESET STATE (Crucial for Pooling)
            _isRedirected = false;

            // Restore original settings if we were redirected previously
            // Note: If you have different prefabs for Player vs Enemy, this usually handles itself,
            // but resetting material is safe.
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;

            // Reset Hostile State? 
            // Better to rely on the Spawner to set 'isHostile' correctly after spawning, 
            // OR reset to default here if the prefab dictates it. 
            // For now, we assume the Spawner doesn't change isHostile, but Redirect does.
            // So we must reset it.
            // Assumption: Prefab default is correct.
            // But wait! If we pool it, 'isHostile' might be stuck at false from previous redirection.
            // We need to reset it. But we don't know if the original was true or false (Player vs Enemy).
            // SIMPLE FIX: Reset logic is handled, but 'isHostile' needs to be passed in Initialize if we want perfection.
            // For this prototype, let's assume Redirect is the only thing changing it.

            // Actually, let's be safe. Initialize should take parameters or reset to Inspector defaults?
            // Inspector defaults are lost on runtime change.
            // Let's rely on the Prefab's integrity: 
            // A PlayerBullet Prefab always starts non-hostile. An EnemyBullet always starts hostile.
            // We just need to revert the "Redirect" changes.
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
            else if (other.gameObject.layer == LayerMask.NameToLayer(GameConstants.LAYER_WALL) ||
                     other.gameObject.layer == LayerMask.NameToLayer("Default"))
            {
                Despawn();
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
            // Use PoolManager if it exists, otherwise Destroy
            if (PoolManager.Instance != null)
            {
                PoolManager.Instance.Despawn(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}