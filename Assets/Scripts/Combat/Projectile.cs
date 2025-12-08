using UnityEngine;
using DarkTowerTron.Core;

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
        public Renderer meshRenderer; // DRAG MESH HERE
        public Material friendlyMaterial; // DRAG CYAN MAT HERE

        // Internal state
        private Vector3 _direction;
        private bool _isInitialized = false;
        private bool _isRedirected = false;

        public void Initialize(Vector3 dir)
        {
            _direction = dir.normalized;
            _isInitialized = true;
            Destroy(gameObject, lifetime);
        }

        private void Update()
        {
            if (!_isInitialized) return;
            transform.Translate(_direction * speed * Time.deltaTime, Space.World);
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

                if (target.TakeDamage(info)) Destroy(gameObject);
            }
            else if (other.gameObject.layer == LayerMask.NameToLayer(GameConstants.LAYER_WALL) ||
                     other.gameObject.layer == LayerMask.NameToLayer("Default"))
            {
                Destroy(gameObject);
            }
        }

        // Called by Blitz
        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false;
            _isRedirected = true;
            _direction = newDirection.normalized;
            speed *= 1.5f;

            // BEST PRACTICE: Use the assigned variables
            if (meshRenderer && friendlyMaterial)
            {
                meshRenderer.material = friendlyMaterial;
            }
            // Fallback just in case
            else if (meshRenderer)
            {
                meshRenderer.material.color = Color.cyan;
            }

            CancelInvoke();
            Destroy(gameObject, 3f);
        }
    }
}