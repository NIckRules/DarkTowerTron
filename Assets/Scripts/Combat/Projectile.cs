using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Combat.Strategies;

// ALIAS: Resolves the conflict between 'Services' (Namespace) and 'Services' (Class)
using Global = DarkTowerTron.Core.Services.Services; 

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Ballistics")]
        public float speed = 25f;
        public float lifetime = 5f;
        public bool isHostile = true;
        
        [Header("Damage")]
        public float damage = 10f;
        public int stagger = 1;
        public DamageType damageType = DamageType.Projectile;

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial; 
        public Material hostileMaterial; 

        private Vector3 _direction; 
        private GameObject _source;
        private IMovementStrategy _movementStrategy;
        
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
        private bool _wasDeflectedThisFrame = false;

        public void OnSpawn() { }

        public void OnDespawn() 
        {
            _isInitialized = false;
            _movementStrategy = null; 
        }

        public void Initialize(Vector3 dir)
        {
            if (_movementStrategy == null) SetStrategy(new LinearMovement());

            _direction = dir.normalized;
            _movementStrategy.Initialize(transform, _direction, speed);

            _isInitialized = true;
            _lifeTimer = lifetime;
            _isRedirected = false;
            
            UpdateVisuals();
        }

        public void SetStrategy(IMovementStrategy strategy) => _movementStrategy = strategy;
        public void SetSource(GameObject source) => _source = source;
        public void ResetHostility(bool startHostile) { isHostile = startHostile; UpdateVisuals(); }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false;
            float dt = Time.deltaTime;

            Vector3 oldPos = transform.position;
            _movementStrategy.Move(transform, dt);
            
            Vector3 newPos = transform.position;
            Vector3 travelVec = newPos - oldPos;
            float moveDistance = travelVec.magnitude;

            if (moveDistance > 0)
            {
                int mask = GameConstants.MASK_PROJECTILE_COLLISION;

                if (UnityEngine.Physics.Raycast(oldPos, travelVec.normalized, out RaycastHit hit, moveDistance, mask))
                {
                    if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform)))
                    {
                        return; 
                    }

                    transform.position = hit.point;
                    HandleCollision(hit.collider);
                }
            }

            _lifeTimer -= dt;
            if (_lifeTimer <= 0) Despawn();
        }

        private void HandleCollision(Collider other)
        {
            if (other.isTrigger && other.GetComponent<ShieldHitbox>() == null) return;

            if (other.gameObject.layer == GameConstants.LAYER_WALL || other.gameObject.layer == GameConstants.LAYER_DEFAULT)
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
                    pushDirection = transform.forward,
                    pushForce = 5f,
                    source = _source,
                    isRedirected = this._isRedirected,
                    damageType = this.damageType
                };

                if (target.TakeDamage(info))
                {
                    if (!_wasDeflectedThisFrame) Despawn();
                }
            }
        }

        private void OnTriggerEnter(Collider other) { }

        public void DeflectByEnemy(Vector3 surfaceNormal, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true; 
            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            _source = null; 
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = false; 
            _isRedirected = true;
            _direction = newDirection.normalized;
            _source = newOwner;
            speed *= 1.5f;
            _lifeTimer = 3.0f;
            ApplyStrategy(overrideStrategy ?? new LinearMovement());
            UpdateVisuals();
        }

        private void ApplyStrategy(IMovementStrategy strategy)
        {
            SetStrategy(strategy);
            _movementStrategy.Initialize(transform, _direction, speed);
        }

        private void UpdateVisuals()
        {
            // CRITICAL FIX: Use sharedMaterial to respect the Palette Manager
            if (meshRenderer) 
                meshRenderer.sharedMaterial = isHostile ? hostileMaterial : friendlyMaterial;
        }

        private void Despawn()
        {
            // USE ALIAS 'Global' to avoid namespace collision
            if (Global.Pool) Global.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}