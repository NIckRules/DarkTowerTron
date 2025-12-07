using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public class Projectile : MonoBehaviour, IReflectable
    {
        public float speed = 10f;
        public float lifetime = 5f;
        public bool isHostile = true;

        private Vector3 _dir;
        
        public void Initialize(Vector3 direction)
        {
            _dir = direction.normalized;
            Destroy(gameObject, lifetime);
        }

        private void Update()
        {
            transform.Translate(_dir * speed * Time.deltaTime, Space.World);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.isTrigger) return; // Ignore triggers

            IDamageable target = other.GetComponent<IDamageable>();
            
            if (target != null)
            {
                // Friendly Fire Check
                if (isHostile && other.CompareTag(GameConstants.TAG_ENEMY)) return;
                if (!isHostile && other.CompareTag(GameConstants.TAG_PLAYER)) return;

                DamageInfo info = new DamageInfo
                {
                    damageAmount = 10f,
                    pushDirection = _dir,
                    pushForce = 5f,
                    isRedirected = !isHostile
                };

                if (target.TakeDamage(info))
                {
                    Destroy(gameObject);
                }
            }
            else if (other.gameObject.layer == LayerMask.NameToLayer(GameConstants.LAYER_WALL))
            {
                Destroy(gameObject);
            }
        }

        public void Redirect(Vector3 newDirection, GameObject newOwner)
        {
            isHostile = false;
            _dir = newDirection.normalized;
            speed *= 1.5f;
            
            // Visuals
            GetComponent<Renderer>().material.color = Color.cyan;
            CancelInvoke();
            Destroy(gameObject, 3f);
        }
    }
}