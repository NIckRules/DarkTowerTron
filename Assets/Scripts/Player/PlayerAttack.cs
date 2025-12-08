using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening; 

namespace DarkTowerTron.Player
{
    public class PlayerAttack : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f; 
        public float selfRecoil = 15f;
        public LayerMask hitLayers; 
        public GameObject beamVisualPrefab; 

        private PlayerMovement _movement;

        // We override Awake to get the Movement reference, 
        // but we must call base.Awake() to get the Scanner too!
        protected override void Awake()
        {
            base.Awake(); 
            _movement = GetComponent<PlayerMovement>();
        }

        protected override void Fire()
        {
            // 1. Get Aim
            Vector3 fireDir = GetAimDirection();
            float beamLength = range;

            // 2. Hit Detection (Moved up to determine beam length)
            RaycastHit hit;
            bool hasHit = UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out hit, range, hitLayers);

            if (hasHit)
            {
                // NEW: Stop visual beam at the hit point
                // Calculate actual distance to hit
                beamLength = hit.distance;
            }

            // 3. Visuals
            if (beamVisualPrefab)
            {
                // We rotate the firepoint momentarily so the instantiated child aligns perfectly
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);
                
                // Scale Correction Logic
                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y; 
                float compZ  = beamLength / parentScale.z; // Use calculated length

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 4. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 5. Apply Damage
            if (hasHit)
            {
                // LOGIC CHECK:
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();
                
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
                else
                {
                    // We hit a wall (No IDamageable). 
                    // The visual beam should stop here.
                }
            }
        }
    }
}