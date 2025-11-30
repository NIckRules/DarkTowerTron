using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(EnemyStagger))]
    public class OrbiterAttack : MonoBehaviour
    {
        [Header("Movement Stats")]
        public float moveSpeed = 4f;
        public float orbitRadiusMin = 3f;
        public float orbitRadiusMax = 5f;
        public float rotationSpeed = 5f; // How fast it faces player

        [Header("Combat Stats")]
        public GameObject projectilePrefab;
        public float fireRate = 2.5f;
        public float telegraphTime = 0.4f;
        public float bulletSpeed = 12f;
        public int burstCount = 2;
        public float burstGap = 0.3f;

        private Transform player;
        private Rigidbody rb;
        private EnemyStagger stagger;
        private float currentOrbitRadius;
        private bool isAttacking = false; // Is currently in the firing animation?

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            stagger = GetComponent<EnemyStagger>();

            // Randomize orbit distance on spawn for variety
            currentOrbitRadius = Random.Range(orbitRadiusMin, orbitRadiusMax);

            GameObject p = GameObject.FindWithTag("Player");
            if (p != null) player = p.transform;

            StartCoroutine(AttackLoop());
        }

        void FixedUpdate()
        {
            if (player == null) return;

            // 1. FREEZE Logic
            // If Staggered OR Attacking, just return. 
            // Since it is Kinematic, it stops moving immediately if we don't call MovePosition.
            if (stagger.isStaggered || isAttacking)
            {
                return;
            }

            // 2. ORBIT Logic
            Vector3 offset = transform.position - player.position;
            float distance = offset.magnitude;

            // Calculate Tangent (Circle direction)
            // Cross product of Up and Offset gives the perpendicular vector
            Vector3 orbitDir = Vector3.Cross(Vector3.up, offset).normalized;

            // Calculate Correction (Push in or Pull out)
            Vector3 correctionDir = Vector3.zero;
            if (distance > currentOrbitRadius + 0.5f)
            {
                correctionDir = -offset.normalized; // Move closer
            }
            else if (distance < currentOrbitRadius - 0.5f)
            {
                correctionDir = offset.normalized; // Move away
            }

            // Combine vectors (Orbit + Correction)
            Vector3 finalMoveDir = (orbitDir + correctionDir).normalized;

            // Apply Movement (Kinematic or Dynamic depending on setup, MovePosition is safest for AI)
            rb.MovePosition(rb.position + finalMoveDir * moveSpeed * Time.fixedDeltaTime);

            // 3. Face Player
            Vector3 lookTarget = player.position;
            lookTarget.y = transform.position.y; // Keep head level
            Quaternion targetRot = Quaternion.LookRotation(lookTarget - transform.position);
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRot, rotationSpeed * Time.fixedDeltaTime));
        }

        IEnumerator AttackLoop()
        {
            while (true)
            {
                // Wait for Cooldown
                yield return new WaitForSeconds(fireRate - telegraphTime);

                if (stagger.isStaggered || player == null) { yield return null; continue; }

                // --- TELEGRAPH PHASE ---
                isAttacking = true; // Stops movement
                GetComponent<Renderer>().material.color = Color.magenta; // Warning Color

                // Tilt Effect (Optional "Lean" forward)
                // We'll just freeze and look intently for now

                yield return new WaitForSeconds(telegraphTime);

                // --- FIRE PHASE ---
                if (!stagger.isStaggered && player != null)
                {
                    for (int i = 0; i < burstCount; i++)
                    {
                        if (stagger.isStaggered) break;
                        Fire();
                        yield return new WaitForSeconds(burstGap);
                    }
                }

                // Reset
                isAttacking = false; // Resume movement
                GetComponent<Renderer>().material.color = stagger.normalColor; // Use public var from script
            }
        }

        void Fire()
        {
            if (projectilePrefab == null) return;

            Vector3 spawnPos = transform.position + transform.forward;
            GameObject bullet = Instantiate(projectilePrefab, spawnPos, transform.rotation);
            bullet.GetComponent<Projectile>().Initialize(transform.forward * bulletSpeed);
        }
    }
}