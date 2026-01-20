using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debugging;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Patterns; // For IPoolable
using DarkTowerTron.Core.Services; // For ServiceLocator and IPoolService
using DarkTowerTron.Core.Physics;

namespace DarkTowerTron.Gameplay.Combat
{
    public enum ProjectileWeight { Light, Heavy, Unstoppable }

    [RequireComponent(typeof(SphereCollider))]
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour, IReflectable, IPoolable
    {
        [Header("Classification")]
        public ProjectileWeight weight = ProjectileWeight.Light;

        [Header("Ballistics")]
        public float speed = 25f;
        public float lifetime = 5f;
        public bool isHostile = true;

        [Header("Damage")]
        public float damage = 10f;
        public int stagger = 1;

        public DamageType damageType = DamageType.Projectile;

        [Header("Juice")]
        public FeedbackConfigurationSO spawnFeedback;
        public FeedbackConfigurationSO impactFeedback;

        [Header("Visuals")]
        public Renderer meshRenderer;
        public Material friendlyMaterial;
        public Material hostileMaterial;
        public Material parryableMaterial;

        [Header("Parry Logic")]
        public float parrySpeedMultiplier = 2.0f;
        public FeedbackConfigurationSO parryFeedback;

        private Vector3 _direction;
        private GameObject _source;
        private IMovementStrategy _movementStrategy;

        private bool _isInitialized = false;
        private bool _isRedirected = false;
        private float _lifeTimer;
        private bool _wasDeflectedThisFrame = false;
        private List<Collider> _ignoredColliders = new List<Collider>();

        private float _baseSpeed;
        private float _baseLifetime;

        private void Awake()
        {
            _baseSpeed = speed;
            _baseLifetime = lifetime;
        }

        public void OnSpawn()
        {
            speed = _baseSpeed;
            lifetime = _baseLifetime;

            if (TryGetComponent(out Rigidbody rb))
            {
                if (!rb.isKinematic)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    rb.Sleep();
                }
            }

            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.emitting = false;
                trail.Clear();
            }

            if (spawnFeedback != null) spawnFeedback.Play(gameObject, transform.position);
        }

        public void OnDespawn()
        {
            ResetIgnoredColliders();

            _isInitialized = false;
            _movementStrategy = null;
            _source = null;
            isHostile = true;

            speed = _baseSpeed;
            lifetime = _baseLifetime;
        }

        public bool TryParry(Vector3 deflectDirection, GameObject newOwner)
        {
            if (weight == ProjectileWeight.Unstoppable) return false;

            SetSource(newOwner);
            isHostile = false;
            _isRedirected = true;

            speed = _baseSpeed * parrySpeedMultiplier;
            _direction = deflectDirection.normalized;

            UpdateVisuals();
            if (parryFeedback != null) parryFeedback.Play(gameObject, transform.position);

            if (_movementStrategy == null) SetStrategy(new LinearMovement());
            _movementStrategy.Initialize(transform, _direction, speed);

            _lifeTimer = lifetime;

            return true;
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

            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.Clear();
                trail.emitting = true;
            }
        }

        public void SetStrategy(IMovementStrategy strategy) => _movementStrategy = strategy;

        public void SetSource(GameObject source)
        {
            _source = source;
            ResetIgnoredColliders();

            if (_source != null)
            {
                Collider myCol = GetComponent<Collider>();
                Collider[] sourceCols = _source.GetComponentsInChildren<Collider>();

                foreach (Collider c in sourceCols)
                {
                    if (!c.isTrigger)
                    {
                        UnityEngine.Physics.IgnoreCollision(myCol, c, true);
                        _ignoredColliders.Add(c);
                    }
                }
            }
        }

        public void ResetHostility(bool startHostile)
        {
            isHostile = startHostile;
            UpdateVisuals();
        }

        private void ResetIgnoredColliders()
        {
            Collider myCol = GetComponent<Collider>();
            if (myCol == null) return;

            foreach (Collider c in _ignoredColliders)
            {
                if (c != null) UnityEngine.Physics.IgnoreCollision(myCol, c, false);
            }
            _ignoredColliders.Clear();
        }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false;
            float dt = Time.deltaTime;

            Vector3 oldPos = transform.position;

            if (_movementStrategy == null) _movementStrategy = new LinearMovement();
            _movementStrategy.Move(transform, dt);

            Vector3 newPos = transform.position;
            Vector3 travelVec = newPos - oldPos;
            float moveDistance = travelVec.magnitude;

            if (moveDistance > 0)
            {
                int mask = GameConstants.MASK_PROJECTILE_COLLISION;

                if (UnityEngine.Physics.Raycast(oldPos, travelVec.normalized, out RaycastHit hit, moveDistance, mask, QueryTriggerInteraction.Collide))
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
            IDamageable target = other.GetComponent<IDamageable>();
            if (target == null) target = other.GetComponentInParent<IDamageable>();

            if (other.isTrigger && target == null) return;

            if (other.gameObject.layer == GameConstants.LAYER_WALL || other.gameObject.layer == GameConstants.LAYER_DEFAULT)
            {
                if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                Despawn();
                return;
            }

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
                    source = gameObject,
                    isRedirected = this._isRedirected,
                    damageType = this.damageType,
                    isCritical = false
                };

                target.TakeDamage(info);

                if (impactFeedback != null) impactFeedback.Play(null, transform.position);
                if (!_wasDeflectedThisFrame) Despawn();
            }
        }

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
            if (meshRenderer == null) return;

            if (!isHostile)
            {
                meshRenderer.sharedMaterial = friendlyMaterial;
                return;
            }

            if (weight == ProjectileWeight.Heavy && parryableMaterial != null)
            {
                meshRenderer.sharedMaterial = parryableMaterial;
            }
            else
            {
                meshRenderer.sharedMaterial = hostileMaterial;
            }
        }

        // FIX 2: Replaced Global.Pool with ServiceLocator
        private void Despawn()
        {
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Despawn at {transform.position}", gameObject);

            // Attempt to get the PoolService
            var pool = ServiceLocator.Get<IPoolService>();

            if (pool != null)
            {
                pool.Despawn(gameObject);
            }
            else
            {
                // Fallback for isolated testing/missing services
                Destroy(gameObject);
            }
        }
    }
}