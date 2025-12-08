using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    // Added IWeapon
    public class PlayerAttack : MonoBehaviour, IWeapon
    {
        [Header("Beam Config")]
        public float range = 7f;
        public float beamRadius = 0.5f;
        public float cooldown = 0.4f;
        public float selfRecoil = 15f;
        public LayerMask hitLayers;

        [Header("Visuals")]
        public Transform firePoint;
        public GameObject beamVisualPrefab;

        private float _timer;
        private PlayerMovement _movement;
        private TargetScanner _scanner; // Add reference
        private bool _isFiring; // State from controller

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
            _scanner = GetComponent<TargetScanner>(); // Auto-find scanner
        }

        // Interface Implementation
        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        private void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;

            if (_isFiring && _timer <= 0)
            {
                FireBeam();
            }
        }

        private void FireBeam()
        {
            _timer = cooldown;

            // --- AUTO AIM LOGIC ---
            Vector3 fireDir = firePoint.forward;
            float finalRange = range;

            // If we have a scanner and a target, snap to it!
            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                Vector3 dirToTarget = (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
                fireDir = dirToTarget;
                
                // Adjust FirePoint rotation temporarily for the instantiation?
                firePoint.rotation = Quaternion.LookRotation(fireDir);
            }
            // ----------------------

            if (beamVisualPrefab)
            {
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, firePoint.rotation, firePoint);
                Vector3 parentScale = firePoint.lossyScale;
                float compensatedRadiusX = beamRadius / parentScale.x;
                float compensatedRadiusY = beamRadius / parentScale.y;
                float compensatedLength = range / parentScale.z;

                beam.transform.localScale = new Vector3(compensatedRadiusX, compensatedRadiusY, 0f);
                beam.transform.DOScaleZ(compensatedLength, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out RaycastHit hit, range, hitLayers))
            {
                IDamageable target = hit.collider.GetComponent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = 10f,
                        staggerAmount = 0.4f,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject
                    };

                    target.TakeDamage(info);
                    GameEvents.OnPlayerHit?.Invoke();
                }
            }
        }
    }
}