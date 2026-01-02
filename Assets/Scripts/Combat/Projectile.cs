using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Managers;

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
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
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
        }

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            _lifeTimer = lifetime;
            _graceTimer = gracePeriod; // RESET TIMER
            _isRedirected = false; 
            
            if (meshRenderer && _originalMaterial) meshRenderer.material = _originalMaterial;
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

            float moveDistance = speed * Time.deltaTime;

            // --- ANTI-TUNNELING RAYCAST ---
            // Cast a ray forward equal to the distance we are about to move
            // We combine all relevant layers into one mask
            int layerMask = LayerMask.GetMask("Default", "Wall", "Player", "Enemy");

            if (UnityEngine.Physics.Raycast(transform.position, _direction, out RaycastHit hit, moveDistance, layerMask))
            {
                // IGNORE SELF / SOURCE
                if (_source != null && (hit.collider.gameObject == _source || hit.transform.IsChildOf(_source.transform))) 
                {
                    // Move normally if we hit the shooter (avoid stuck bullets)
                    transform.Translate(_direction * moveDistance, Space.World);
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
            else
            {
                // Clear path, move forward
                transform.Translate(_direction * moveDistance, Space.World);
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
        public void DeflectByEnemy(Vector3 surfaceNormal)
        {
            _wasDeflectedThisFrame = true;
            isHostile = true; // Now it hurts the player!

            // 1. Physics Math
            _direction = Vector3.Reflect(_direction, surfaceNormal).normalized;
            transform.rotation = Quaternion.LookRotation(_direction);
            speed *= 1.2f;

            // 2. Visual Change
            if (meshRenderer)
            {
                if (hostileMaterial)
                {
                    meshRenderer.material = hostileMaterial;
                }
                else
                {
                    // Fallback
                    meshRenderer.material.color = Color.red;
                }
            }
            
            // 3. Reset Timer
            _lifeTimer = lifetime;
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false; 
            _isRedirected = true;
            _direction = newDirection.normalized;
            speed *= 1.5f; 
            if (meshRenderer && friendlyMaterial) meshRenderer.material = friendlyMaterial;
            else if (meshRenderer) meshRenderer.material.color = Color.cyan;
            _lifeTimer = 3.0f; 
        }

        private void Despawn()
        {
            if (Services.Pool != null) Services.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}