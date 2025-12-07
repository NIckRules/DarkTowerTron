using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    public class PlayerAttack : MonoBehaviour
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
        private bool _isFiring;
        private PlayerMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<PlayerMovement>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        private void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;

            // Logic driven by boolean state, not Input.GetButton
            if (_isFiring && _timer <= 0)
            {
                FireBeam();
            }
        }

        private void FireBeam()
        {
            _timer = cooldown;

            // 1. Visual Effect
            if (beamVisualPrefab)
            {
                // Instantiate as CHILD of firePoint
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, firePoint.rotation, firePoint);

                // --- SCALE CORRECTION ---
                Vector3 parentScale = firePoint.lossyScale;

                // Calculate local scale needed to keep the beam round
                // We divide by parent scale to counteract distortion
                float compensatedRadiusX = beamRadius / parentScale.x;
                float compensatedRadiusY = beamRadius / parentScale.y;
                float compensatedLength = range / parentScale.z;

                // FIX: Set X and Y to radius (Thickness), set Z to 0 (Start length)
                // Previously, Y was 0, which made it flat.
                beam.transform.localScale = new Vector3(compensatedRadiusX, compensatedRadiusY, 0f);

                // Animate Length (Z)
                beam.transform.DOScaleZ(compensatedLength, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 2. Recoil (Physics)
            if (_movement)
            {
                _movement.ApplyKnockback(-firePoint.forward * selfRecoil);
            }

            // 3. Hit Detection (SphereCast)
            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, firePoint.forward, out RaycastHit hit, range, hitLayers))
            {
                IDamageable target = hit.collider.GetComponent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = 10f,
                        staggerAmount = 0.4f,
                        pushDirection = firePoint.forward,
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