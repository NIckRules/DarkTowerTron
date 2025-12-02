using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Utils;
using DarkTowerTron.Core;
using DG.Tweening; // For Beam Animation


namespace DarkTowerTron.Player
{
    public class PlayerAttack : MonoBehaviour
    {
        [Header("Settings")]
        public float attackRange = 4f; // Beams go further than spears
        public float hitRadius = 0.6f; // Thick beam
        public float attackCooldown = 0.5f; // Slower, heavier
        public float thrustForce = 20f; // How hard it pushes you forward
        public LayerMask enemyLayer;

        [Header("Visuals")]
        public GameObject beamPrefab; // Drag 'BeamRoot' here
        public Transform firePoint;

        private float cooldownTimer = 0f;
        private PlayerMovement movement;

        void Start()
        {
            movement = GetComponent<PlayerMovement>();
        }

        void Update()
        {
            if (cooldownTimer > 0) cooldownTimer -= Time.deltaTime;

            if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0)
            {
                PerformBeamAttack();
            }
        }

        void PerformBeamAttack()
        {
            cooldownTimer = attackCooldown;

            // 1. VISUALS: Spawn and Animate Beam
            if (beamPrefab != null && firePoint != null)
            {
                GameObject beam = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);

                // Scale Animation: Pop to full length, then fade
                beam.transform.localScale = new Vector3(1, 0, 1); // Start thin
                beam.transform.DOScaleZ(1, 0.1f).SetEase(Ease.OutBack); // Pop out

                Destroy(beam, 0.2f); // Short duration
            }

            // 2. PHYSICS: Propel Forward (Using existing movement logic)
            if (movement != null)
            {
                // Push in the direction we are aiming
                Vector3 thrustDir = firePoint != null ? firePoint.forward : transform.forward;
                movement.ApplyKnockback(thrustDir, thrustForce);
            }

            // 3. JUICE: Audio & Shake
            if (GameFeel.instance)
            {
                GameFeel.instance.PlaySwing(); // Or a new "Laser" sound
                GameFeel.instance.CameraShake(0.2f, 0.3f); // Recoil shake
            }

            // 4. HIT DETECTION (SphereCast)
            Vector3 origin = firePoint.position;
            Vector3 direction = firePoint.forward;

            // Mask setup (Same as before)
            int mask = enemyLayer.value;
            if (mask == 0) mask = Physics.DefaultRaycastLayers;

            if (Physics.SphereCast(origin, hitRadius, direction, out RaycastHit hit, attackRange, mask))
            {
                if (hit.collider.gameObject == gameObject) return;

                Debug.Log($"BEAM HIT: {hit.collider.name}");

                EnemyStagger stagger = hit.collider.GetComponent<EnemyStagger>();
                EnemyHealth health = hit.collider.GetComponent<EnemyHealth>();

                if (stagger != null)
                {
                    if (stagger.isStaggered && health != null)
                    {
                        health.TakeFatalHit();
                        if (GameFeel.instance) GameFeel.instance.PlayKill();
                    }
                    else
                    {
                        stagger.AddStagger(1.0f);
                        if (GameFeel.instance) GameFeel.instance.PlayHit();
                    }
                }
            }
        }

        void OnDrawGizmos()
        {
            if (firePoint != null)
            {
                Gizmos.color = Color.cyan;
                Vector3 endPos = firePoint.position + firePoint.forward * attackRange;
                Gizmos.DrawWireSphere(firePoint.position, hitRadius);
                Gizmos.DrawLine(firePoint.position, endPos);
                Gizmos.DrawWireSphere(endPos, hitRadius);
            }
        }
    }
}