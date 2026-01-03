using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Movement;
using DG.Tweening;

namespace DarkTowerTron.Player.Combat
{
    // RENAMED: Was PlayerAttack
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

        // Implement Abstract Method from WeaponBase
        protected override float GetCurrentFireRate()
        {
            // Read specific Beam stat
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            Vector3 fireDir = GetAimDirection();

            // 1. Visuals
            if (beamVisualPrefab)
            {
                Quaternion targetRot = Quaternion.LookRotation(fireDir);
                GameObject beam = Instantiate(beamVisualPrefab, firePoint.position, targetRot, firePoint);

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
            // CHANGE: Beam is instant, so we want to hit Enemies and Walls.
            // Use a specific mask for Player attacks: Walls (+ Default) + Enemy.
            int mask = GameConstants.MASK_WALLS | (1 << GameConstants.LAYER_ENEMY);

            if (UnityEngine.Physics.SphereCast(firePoint.position, beamRadius, fireDir, out RaycastHit hit, range, mask))
            {
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();

                if (target != null)
                {
                    DamageInfo info = new DamageInfo
                    {
                        // Read Stats
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,

                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject
                        ,
                        // NEW: Explicitly Melee
                        damageType = DamageType.Melee
                    };

                    target.TakeDamage(info);
                    GameEvents.OnPlayerHit?.Invoke();
                }
            }
        }
    }
}