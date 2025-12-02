using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    public class Projectile : MonoBehaviour
    {
        [Header("Stats")]
        public float speed = 10f;
        public float lifetime = 5f;
        public bool isHostile = true;
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
            if (this == null) return; // Safety check

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
            // 1. Hit PLAYER
            if (other.CompareTag("Player"))
            {

                Debug.Log("<color=red>COLLISION</color>");

                // CHANGE: Use GetComponentInParent to find Blitz on the main body
                // even if we hit the "BlitzCatcher" child.
                var blitz = other.GetComponentInParent<Blitz>();
                var grit = other.GetComponentInParent<GritAndFocus>();

                if (blitz != null && blitz.IsInvulnerable())
                {
                    blitz.OnPerfectDodge();
                    Destroy(gameObject);
                    return;
                }

                if (grit != null) 
                {
                    grit.TakeDamage(transform.forward); // Pass direction
                }
                Destroy(gameObject);
                return;
            }

            // 3. Hit ENEMY (Must be reflected/redirected)
            // Check !isHostile to ensure only redirected bullets hurt enemies
            if (!isHostile && other.CompareTag("Enemy"))
            {
                EnemyHealth enemy = other.GetComponent<EnemyHealth>();
                if (enemy != null)
                {
                    Debug.Log("<color=green>-> REDIRECTED HIT! Staggering.</color>");
                    
                    // Break Shield if Orbiter/Turret
                    if (enemy.isShielded) enemy.isShielded = false;

                    // Deal Massive Stagger
                    enemy.TakeHit(50f, 100f, direction);
                    
                    // Juice
                    if(DarkTowerTron.Core.GameFeel.instance) 
                        DarkTowerTron.Core.GameFeel.instance.HitStop(0.05f);

                    Destroy(gameObject);
                }
                return;
            }

            // 3. If Wall/Default: Destroy.
            Destroy(gameObject);
        }

        public void Redirect(Vector3 newDirection)
        {
            // 1. Change Allegiance
            isHostile = false;
            
            // 2. Boost Physics
            speed *= 1.5f; // Faster!
            direction = newDirection.normalized;
            transform.forward = direction; // Rotate visual
            
            // 3. Reset Lifetime (Give it 3 more seconds to find a target)
            CancelInvoke(); // Stop previous destroy timers if any
            Destroy(gameObject, 3f); 

            // 4. Visual Feedback (Turn Cyan)
            var renderer = GetComponent<Renderer>();
            if (renderer)
            {
                renderer.material.color = Color.cyan;
                // Maximize Emission for "Overcharged" look
                renderer.material.SetColor("_EmissionColor", Color.cyan * 2f);
            }
        }
    }
}