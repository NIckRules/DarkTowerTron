using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Managers;
using DarkTowerTron.Combat.Strategies;

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
        
        [Header("Safety")]
        public float gracePeriod = 0.05f; // Ignore hits for first 0.05s
        public LayerMask wallLayer;

        [Header("Damage Stats")]
        public float damage = 10f;
        [Min(0)] public int stagger = 1; // Changed to Int
        public DamageType damageType = DamageType.Projectile; // NEW

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial; // Used when Player Blitzes
        public Material hostileMaterial;  // NEW: Used when Enemy Shield Reflects

        private Material _originalMaterial;
        private Vector3 _direction;
        private GameObject _source;

        // Default strategy if none provided
        private IMovementStrategy _movementStrategy;
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private bool _isEnemyDeflected = false;
        private float _lifeTimer;
        // NEW: State to prevent self-destruction on bounce
        private bool _wasDeflectedThisFrame = false;
        private float _graceTimer;

        private void Awake()
        {
            if (meshRenderer) _originalMaterial = meshRenderer.sharedMaterial;
            if (wallLayer == 0) wallLayer = LayerMask.GetMask(GameConstants.LAYER_WALL, "Default");
        }

        public void OnSpawn()
        {
            _lifeTimer = lifetime;
        }

        public void OnDespawn()
        {
            CancelInvoke();
            _isInitialized = false;
            _movementStrategy = null;
            _isRedirected = false;
            _isEnemyDeflected = false;
        }

        public void Initialize(Vector3 dir)
        {
            // Default to Linear if strategy wasn't injected externally
            if (_movementStrategy == null)
                _movementStrategy = new LinearMovement();

            _movementStrategy.Initialize(transform, dir, speed);

            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;
            _graceTimer = gracePeriod; // RESET TIMER
            _isRedirected = false;
            _isEnemyDeflected = false;

            UpdateVisuals();
        }

        // NEW: Allow injecting a specific strategy (e.g. from a Boss pattern)
        public void SetStrategy(IMovementStrategy strategy)
        {
            _movementStrategy = strategy;
        }

        public void ResetHostility(bool startHostile) { isHostile = startHostile; }

        public void SetSource(GameObject source)
        {
            _source = source;
        }

        private void Update()
        {
            if (!_isInitialized) return;
            _wasDeflectedThisFrame = false; // Reset flag every frame

            // Countdown Grace Period
            if (_graceTimer > 0) _graceTimer -= Time.deltaTime;

            float dt = Time.deltaTime;

            // 1. STRATEGY MOVEMENT (Updates Transform)
            // Capture position BEFORE move so we can Raycast the travelled segment
            Vector3 oldPos = transform.position;
            _movementStrategy?.Move(transform, dt);
            Vector3 newPos = transform.position;

            Vector3 travelVec = newPos - oldPos;
            float moveDistance = travelVec.magnitude;
            Vector3 travelDir = moveDistance > 0f ? (travelVec / moveDistance) : _direction;

            // Keep direction updated for pushDirection / deflection math
            if (moveDistance > 0f) _direction = travelDir;

            // --- ANTI-TUNNELING RAYCAST ---
            // Cast a ray forward equal to the distance we are about to move
            // We combine all relevant layers into one mask
            int layerMask = LayerMask.GetMask("Default", "Wall", "Player", "Enemy");

            if (moveDistance > 0f && UnityEngine.Physics.Raycast(oldPos, travelDir, out RaycastHit hit, moveDistance, layerMask))
            {
                // IGNORE SELF / SOURCE
                if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform))) 
                {
                    // Ignore hits on our current owner; keep the strategy-applied movement.
                }
                else
                {
                    // WE HIT SOMETHING!
                    // Move to the hit point
                    transform.position = hit.point;
                    // Trigger collision logic manually
                    HandleCollision(hit.collider);
                    return; // Stop moving this frame
                }
            }
            // -----------------------------

            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0) Despawn();
        }

        // Refactored logic from OnTriggerEnter to a shared method
        private void HandleCollision(Collider other)
        {
            // Respect grace period
            if (_graceTimer > 0) return;

            if (other.isTrigger && other.GetComponent<ShieldHitbox>() == null) return; // Ignore random triggers, but hit Shields

            // Wall Check
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
                    isRedirected = this._isRedirected,
                    damageType = this.damageType
                };

                if (target.TakeDamage(info))
                {
                    if (!_wasDeflectedThisFrame) Despawn();
                }
            }
        }

        // Keep OnTriggerEnter as a backup for overlaps
        private void OnTriggerEnter(Collider other)
        {
             HandleCollision(other);
        }

        // --- NEW METHOD FOR SHIELDS ---
        // Backward-compatible overload
        public void DeflectByEnemy(Vector3 surfaceNormal)
        {
            DeflectByEnemy(surfaceNormal, null);
        }

        // Strategy-capable overload (e.g. perks / boss patterns)
        public void DeflectByEnemy(Vector3 surfaceNormal, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true;

            _isRedirected = false;
            _isEnemyDeflected = true;

            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            _source = null;

            // Preserve previous shield reflect tuning
            speed *= 1.2f;
            _lifeTimer = lifetime;

            // STRATEGY LOGIC
            if (overrideStrategy != null)
            {
                SetStrategy(overrideStrategy);
            }
            else
            {
                // Default: Shields usually bounce linearly
                SetStrategy(new LinearMovement());
            }

            if (_movementStrategy == null) _movementStrategy = new LinearMovement();
            _movementStrategy.Initialize(transform, _direction, speed);

            UpdateVisuals();
        }

        // Backward-compatible overload
        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            Redirect(newDirection, newOwner, null);
        }

        // "overrideStrategy" allows the Perk System to inject Homing/Spiral logic
        public void Redirect(Vector3 newDirection, GameObject newOwner, IMovementStrategy overrideStrategy = null)
        {
            _wasDeflectedThisFrame = true;
            isHostile = false;
            _isRedirected = true;
            _isEnemyDeflected = false;

            _direction = newDirection.normalized;
            _source = newOwner;

            speed *= 1.5f;
            _lifeTimer = 3.0f;

            // STRATEGY LOGIC
            if (overrideStrategy != null)
            {
                SetStrategy(overrideStrategy);
            }
            else
            {
                // Default: Reset to Linear (Clean slate)
                SetStrategy(new LinearMovement());
            }

            if (_movementStrategy == null) _movementStrategy = new LinearMovement();
            _movementStrategy.Initialize(transform, _direction, speed);

            UpdateVisuals();
        }

        private void UpdateVisuals()
        {
            if (!meshRenderer) return;

            if (_isRedirected)
            {
                if (friendlyMaterial) meshRenderer.material = friendlyMaterial;
                else meshRenderer.material.color = Color.cyan;
                return;
            }

            if (_isEnemyDeflected)
            {
                if (hostileMaterial) meshRenderer.material = hostileMaterial;
                else meshRenderer.material.color = Color.red;
                return;
            }

            if (_originalMaterial) meshRenderer.material = _originalMaterial;
        }

        private void Despawn()
        {
            if (Services.Pool != null) Services.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}