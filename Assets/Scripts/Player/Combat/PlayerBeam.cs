using System;
using System.Collections.Generic;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.Systems.Stats;
using DG.Tweening;
using UnityEngine;
using DarkTowerTron;

namespace DarkTowerTron.Player.Combat
{
    public class PlayerBeam : WeaponBase
    {
        [Header("Beam Specifics")]
        public float range = 7f;
        public float beamRadius = 1.0f;
        public float selfRecoil = 15f;
        public GameObject beamVisualPrefab;

        private DarkTowerTron.Player.Movement.PlayerMotor _movement;

        protected override void Awake()
        {
            base.Awake();
            _movement = GetComponent<DarkTowerTron.Player.Movement.PlayerMotor>();
        }

        protected override float GetCurrentFireRate()
        {
            return _stats.BeamRate;
        }

        protected override void Fire()
        {
            // Use Smart Aim (Magnetism)
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

            // 3. Hit Detection (Projectiles + Enemies, blocked by Walls)
            int mask = GameConstants.MASK_PROJECTILE_COLLISION | (1 << GameConstants.LAYER_PROJECTILE);

            RaycastHit[] hits = UnityEngine.Physics.SphereCastAll(
                firePoint.position,
                beamRadius,
                fireDir,
                range,
                mask,
                QueryTriggerInteraction.Collide
            );

            if (hits == null || hits.Length == 0) return;

            Array.Sort(hits, (a, b) => a.distance.CompareTo(b.distance));

            var damaged = new HashSet<IDamageable>();
            var parried = new HashSet<Projectile>();

            foreach (var hit in hits)
            {
                if (hit.collider == null) continue;

                // Ignore self / child colliders (weapon/player)
                if (hit.collider.transform.IsChildOf(transform)) continue;

                // Stop at walls
                int hitLayer = hit.collider.gameObject.layer;
                if (hitLayer == GameConstants.LAYER_WALL || hitLayer == GameConstants.LAYER_DEFAULT)
                {
                    break;
                }

                // A) Parry hostile projectiles
                Projectile incomingProj = hit.collider.GetComponentInParent<Projectile>();
                if (incomingProj != null)
                {
                    // NEW: Parry is a perk/ability.
                    if (_stats == null || !_stats.HasAbility(AbilityType.Melee_Parry))
                    {
                        continue;
                    }

                    if (incomingProj.isHostile && !parried.Contains(incomingProj))
                    {
                        // Aim-based parry (more deterministic than relying on projectile rotation)
                        Vector3 deflectDir = fireDir;
                        if (incomingProj.TryParry(deflectDir, gameObject))
                        {
                            parried.Add(incomingProj);
                        }
                    }
                    continue;
                }

                // B) Damage enemies in the beam path (avoid double-hits from multiple colliders)
                IDamageable target = hit.collider.GetComponentInParent<IDamageable>();
                if (target != null && damaged.Add(target))
                {
                    DamageInfo info = new DamageInfo
                    {
                        damageAmount = _stats.BeamDamage,
                        staggerAmount = _stats.BeamStagger,
                        pushDirection = fireDir,
                        pushForce = 10f,
                        source = gameObject,
                        damageType = DamageType.Melee
                    };

                    target.TakeDamage(info);
                }
            }
        }
    }
}