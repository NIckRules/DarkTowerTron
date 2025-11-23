using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    public class Projectile : MonoBehaviour
    {
        [Header("Stats")]
        public float speed = 10f;
        public float lifetime = 5f;
        public LayerMask hitLayers; // Everything but Projectile

        private Vector3 direction;

        void Start()
        {
            Destroy(gameObject, lifetime);
        }

        public void Initialize(Vector3 dir)
        {
            direction = dir.normalized;
        }

        void Update()
        {
            // Raycast Movement (Anti-Tunneling).
            // 1. Move distance = speed * deltaTime.
            float distance = speed * Time.deltaTime;

            // 2. Raycast forward.
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, distance, hitLayers))
            {
                // 3. If Hit -> HandleHit(hit.collider).
                HandleHit(hit.collider);
            }
            else
            {
                // 4. Else -> transform.position += direction * distance.
                transform.position += direction * distance;
            }
        }

        void HandleHit(Collider other)
        {
            // 1. If Tag "Player":
            if (other.CompareTag("Player"))
            {
                //    - Get Blitz component.
                Blitz blitz = other.GetComponent<Blitz>();

                //    - If Blitz.IsInvulnerable() -> Reward Focus (Perfect Dodge) & Destroy.
                if (blitz != null && blitz.IsInvulnerable())
                {
                    blitz.OnPerfectDodge();
                    Destroy(gameObject);
                    return;
                }

                //    - Else -> GritAndFocus.TakeDamage() & Destroy.
                GritAndFocus grit = other.GetComponent<GritAndFocus>();
                if (grit != null)
                {
                    grit.TakeDamage();
                }
                Destroy(gameObject);
                return;
            }

            // 2. If Tag "Enemy": Ignore (bullets pass through enemies for now).
            if (other.CompareTag("Enemy"))
            {
                return;
            }

            // 3. If Wall/Default: Destroy.
            Destroy(gameObject);
        }
    }
}