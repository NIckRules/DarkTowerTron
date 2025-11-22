using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Combat
{
    public class Projectile : MonoBehaviour
    {
        [Header("Stats")]
        public float speed = 15f;
        public int damage = 1;
        public float lifeTime = 5f;
        public bool isHostile = true;

        void Start()
        {
            Destroy(gameObject, lifeTime);
        }

        public void Initialize(Vector3 dir)
        {
            // Ensure Z is 0 if we are strictly 2D, but for 3D just normalize
            direction = dir.normalized;
        }

        private Vector3 direction;

        void Update()
        {
            // MOVEMENT
            transform.position += direction * speed * Time.deltaTime;
        }

        void OnTriggerEnter(Collider other)
        {
            // --- DEBUG SECTION ---
            Debug.Log($"<color=yellow>BULLET HIT: {other.name}</color> | Tag: {other.tag} | IsHostile: {isHostile}");
            // ---------------------

            // 1. Hit PARRY SHIELD
            if (isHostile && other.CompareTag("ParryShield"))
            {
                Debug.Log("-> Reflected by Shield");
                Reflect(other.transform.position);
                return;
            }

            // 2. Hit PLAYER
            if (isHostile && other.CompareTag("Player"))
            {
                PlayerStats player = other.GetComponent<PlayerStats>();
                if (player != null)
                {
                    player.TakeDamage(damage);
                    Destroy(gameObject);
                }
                return;
            }

            // 3. Hit ENEMY (Must be reflected first)
            if (!isHostile && other.CompareTag("Enemy"))
            {
                Debug.Log("-> Attempting to damage Enemy...");
                Enemy enemy = other.GetComponent<Enemy>();

                if (enemy != null)
                {
                    Debug.Log("<color=green>-> HIT CONFIRMED! Dealing Stagger.</color>");
                    enemy.TakeHit(50f, 100f, direction);
                    Destroy(gameObject);
                }
                else
                {
                    Debug.LogError("-> Hit object tagged 'Enemy' but found NO 'Enemy.cs' script!");
                }
                return;
            }

            // 4. Hit Walls
            if (!other.CompareTag("ParryShield") && !other.CompareTag("Player") && !other.CompareTag("Enemy") && !other.CompareTag("Projectile"))
            {
                Debug.Log("-> Hit Wall/Prop. Destroying.");
                Destroy(gameObject);
            }
        }

        void Reflect(Vector3 shieldPos)
        {
            isHostile = false;
            speed *= 1.5f;
            GetComponent<Renderer>().material.color = Color.cyan;
            direction = -direction;

            GameObject player = GameObject.FindWithTag("Player");
            if (player) player.GetComponent<PlayerParry>().OnSuccessfulParry();
        }
    }
}