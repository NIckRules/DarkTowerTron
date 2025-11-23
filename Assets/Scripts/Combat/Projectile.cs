using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour
    {
        [Header("Stats")]
        public float speed = 10f; // Default (Pebble speed)
        public int damage = 1;    // Usually 1 Grit
        public float lifetime = 5f;

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = transform.forward * speed;
            Destroy(gameObject, lifetime);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                // 1. Get Player Components
                var grit = other.GetComponent<GritAndFocus>();
                var blitz = other.GetComponent<Blitz>();

                // 2. CHECK: Is Player Blitzing (Invulnerable)?
                if (blitz != null && blitz.IsInvulnerable())
                {
                    // PERFECT DODGE!
                    Debug.Log("<color=cyan>PERFECT DODGE! +30 Focus</color>");
                    if (grit) grit.AddFocus(30f);

                    // Destroy bullet (or reflect later)
                    Destroy(gameObject);
                }
                else
                {
                    // HIT!
                    if (grit) grit.TakeDamage();
                    Destroy(gameObject);
                }
            }
            else if (!other.CompareTag("Enemy") && !other.CompareTag("Projectile"))
            {
                // Hit Wall
                Destroy(gameObject);
            }
        }
    }
}