using System.Collections.Generic;
using DarkTowerTron.Combat.Strategies;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Feedback;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Combat
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
            // LOG 1: Check initial state coming out of pool
            GameLogger.Log(LogChannel.Combat, $"[PROJ] OnSpawn - Pos: {transform.position} | Active: {gameObject.activeSelf}", gameObject);

            // Pool safety: ensure runtime modifications (Redirect/Parry) don't accumulate across reuse
            speed = _baseSpeed;
            lifetime = _baseLifetime;

            // 1. SAFE PHYSICS RESET
            if (TryGetComponent(out Rigidbody rb))
            {
                // Only reset velocity if the body is NOT Kinematic
                // (Kinematic bodies are moved by transform, so velocity doesn't apply)
                if (!rb.isKinematic)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    rb.Sleep();
                }
                else
                {
                    // Verify if we are kinematic
                    GameLogger.Log(LogChannel.Combat, "[PROJ] Body is Kinematic. Skipping velocity reset.", gameObject);
                }
            }

            // 2. RESET TRAILS
            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.emitting = false;
                trail.Clear();
                GameLogger.Log(LogChannel.Combat, "[PROJ] Trail Cleared.", gameObject);
            }

            // 3. Play spawn feedback
            if (spawnFeedback != null) spawnFeedback.Play(gameObject, transform.position);
        }

        public void OnDespawn() 
        {
            // 1. Clean up Physics (CRITICAL for Pooling)
            ResetIgnoredColliders();

            // 2. Reset Logic
            _isInitialized = false;
            _movementStrategy = null; 
            _source = null;
            isHostile = true; // Reset default hostility

            // Restore base tuning values for pooled reuse
            speed = _baseSpeed;
            lifetime = _baseLifetime;
        }

        // --- NEW: The Parry Logic ---
        public bool TryParry(Vector3 deflectDirection, GameObject newOwner)
        {
            if (weight == ProjectileWeight.Unstoppable) return false;

            // 1. Ownership Change
            SetSource(newOwner);
            isHostile = false; // Now it hurts enemies
            _isRedirected = true;

            // 2. Trajectory / Speed
            speed = _baseSpeed * parrySpeedMultiplier;
            _direction = deflectDirection.normalized;

            // 3. Visuals / Feedback
            UpdateVisuals();
            if (parryFeedback != null) parryFeedback.Play(gameObject, transform.position);

            // 4. Refresh Movement Strategy (restart trajectory)
            if (_movementStrategy == null) SetStrategy(new LinearMovement());
            _movementStrategy.Initialize(transform, _direction, speed);

            // 5. Reset Timer (give it time to hit the enemy)
            _lifeTimer = lifetime;

            return true;
        }

        public void Initialize(Vector3 dir)
        {
            // LOG 2: Check state right before moving
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Initialize - Dir: {dir} | StartPos: {transform.position}", gameObject);

            if (_movementStrategy == null) SetStrategy(new LinearMovement());

            _direction = dir.normalized;
            _movementStrategy.Initialize(transform, _direction, speed);

            _isInitialized = true;
            _lifeTimer = lifetime;
            _isRedirected = false;
            
            UpdateVisuals();

            // 4. RE-ENABLE TRAIL (The second half of the fix)
            var trail = GetComponent<TrailRenderer>();
            if (trail != null)
            {
                trail.Clear();
                trail.emitting = true;
                GameLogger.Log(LogChannel.Combat, "[PROJ] Trail Restarted.", gameObject);
            }
        }

        public void SetStrategy(IMovementStrategy strategy) => _movementStrategy = strategy;
        
        public void SetSource(GameObject source)
        {
            _source = source;
            
            // 1. Reset previous ignores (Safety if reused without Despawn)
            ResetIgnoredColliders();

            if (_source != null)
            {
                Collider myCol = GetComponent<Collider>();
                Collider[] sourceCols = _source.GetComponentsInChildren<Collider>();

                foreach (Collider c in sourceCols)
                {
                    // CRITICAL: Don't ignore triggers (like detection zones), only physical blockers
                    if (!c.isTrigger) 
                    {
                        UnityEngine.Physics.IgnoreCollision(myCol, c, true);
                        _ignoredColliders.Add(c); // Remember this so we can undo it
                    }
                }
            }
        }
        
        public void ResetHostility(bool startHostile) { isHostile = startHostile; UpdateVisuals(); }

        private void ResetIgnoredColliders()
        {
            Collider myCol = GetComponent<Collider>();
            
            // If our collider was destroyed or missing, we can't un-ignore
            if (myCol == null) return;

            // Loop backwards or forwards, doesn't matter here
            foreach (Collider c in _ignoredColliders)
            {
                if (c != null)
                {
                    UnityEngine.Physics.IgnoreCollision(myCol, c, false);
                }
            }
            _ignoredColliders.Clear();
        }

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

                // Ensure the Raycast detects Trigger hitboxes (e.g. Player/Enemy hitbox colliders)
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
            // If this is a trigger and NOT a hitbox/health component, ignore it (it's likely a zone)
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
                    damageType = this.damageType
                };

                if (target.TakeDamage(info))
                {
                    if (impactFeedback != null) impactFeedback.Play(null, transform.position);
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
            if (meshRenderer == null) return;

            if (!isHostile)
            {
                meshRenderer.sharedMaterial = friendlyMaterial;
                return;
            }

            // Hostile: show a distinct material for heavy/parryable projectiles.
            if (weight == ProjectileWeight.Heavy && parryableMaterial != null)
            {
                meshRenderer.sharedMaterial = parryableMaterial;
            }
            else
            {
                meshRenderer.sharedMaterial = hostileMaterial;
            }
        }

        private void Despawn()
        {
            GameLogger.Log(LogChannel.Combat, $"[PROJ] Despawn at {transform.position}", gameObject);

            // USE ALIAS 'Global' to avoid namespace collision
            if (Global.Pool) Global.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}