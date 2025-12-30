using UnityEngine;
using DarkTowerTron.Core;
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
        public float stagger = 0f;

        [Header("Visuals")]
        public Renderer meshRenderer; 
        public Material friendlyMaterial;

        private Material _originalMaterial;
        private Vector3 _direction;
        private GameObject _source;
        private bool _isInitialized = false;
        private bool _isRedirected = false; 
        private float _lifeTimer;
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
            
            // Countdown Grace Period
            if (_graceTimer > 0) _graceTimer -= Time.deltaTime;

            transform.Translate(_direction * speed * Time.deltaTime, Space.World);

            _lifeTimer -= Time.deltaTime;
            if (_lifeTimer <= 0) Despawn();
        }

        private void OnTriggerEnter(Collider other)
        {
            // SAFETY CHECK: If grace period active, ignore everything
            if (_graceTimer > 0) return;

            if (other.isTrigger) return;

            // FIX: Ignore the shooter (and its children/parents usually)
            if (_source != null && (other.gameObject == _source || other.transform.IsChildOf(_source.transform)))
            {
                return;
            }

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
            _lifeTimer = 3.0f; 
        }

        private void Despawn()
        {
            if (PoolManager.Instance) PoolManager.Instance.Despawn(gameObject);
            else Destroy(gameObject);
        }
    }
}