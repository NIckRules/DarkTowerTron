using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Player
{
    public class PlayerBeam : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 0.5f;
        public float selfRecoil = 15f;
        public LayerMask hitLayers;
        public GameObject beamVisualPrefab;

        private PlayerMovement _movement;

        protected override void Awake()
        {
            base.Awake();
            _movement = GetComponent<PlayerMovement>();
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            Vector3 fireDir = GetAimDirection();

            // 1. Visuals
            if (beamVisualPrefab)
            {
                // Rotate firePoint temporarily to align the instantiated child
                Quaternion originalRot = firePoint.rotation;
                firePoint.rotation = Quaternion.LookRotation(fireDir);

                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, firePoint.rotation, firePoint);

                // Restore rotation (optional, usually safer)
                firePoint.rotation = originalRot;

                // Scale Correction
                Vector3 parentScale = firePoint.lossyScale;
                float compX = beamRadius / parentScale.x;
                float compY = beamRadius / parentScale.y;
                float compZ = range / parentScale.z;

                beam.transform.localScale = new Vector3(compX, compY, 0f);
                beam.transform.DOScaleZ(compZ, 0.1f).OnComplete(() => Destroy(beam, 0.1f));
            }

            // 2. Recoil
            if (_movement)
            {
                _movement.ApplyKnockback(-fireDir * selfRecoil);
            }

            // 3. Hit Detection
            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out RaycastHit hit, range, hitLayers))
            {
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,
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