using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron;

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(FirePointRegistry))]
    public class PatternExecutor : MonoBehaviour
    {
        private FirePointRegistry _registry;
        private bool _isFiring;

        // Exposed for AI Decision making
        public bool IsFiring => _isFiring;

        private void Awake()
        {
            _registry = GetComponent<FirePointRegistry>();
        }

        public bool Fire(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            if (_isFiring) return false; // Busy
            if (pattern == null || stats == null || stats.projectilePrefab == null) return false;

            StartCoroutine(ExecuteRoutine(pattern, stats, target));
            return true;
        }

        public void StopFiring()
        {
            StopAllCoroutines();
            _isFiring = false;
        }

        private IEnumerator ExecuteRoutine(AttackPatternSO pattern, EnemyAttackSO stats, Transform target)
        {
            _isFiring = true;

            // 1. Resolve Fire Point
            Transform firePoint = _registry.GetPoint(pattern.firePointID);

            // 2. Resolve Smart Aim Target (Optimization: Check once per burst)
            IAimTarget aimTarget = null;
            if (target != null)
            {
                aimTarget = target.GetComponent<IAimTarget>();
                if (aimTarget == null) aimTarget = target.GetComponentInChildren<IAimTarget>();
            }

            // 3. Windup
            yield return new WaitForSeconds(pattern.startDelay);

            // 4. Burst Loop
            float spinOffset = 0f;

            for (int i = 0; i < pattern.projectileCount; i++)
            {
                // Dynamic Aim Calculation per shot (Tracks moving player)
                Vector3 aimDir = firePoint.forward;

                if (pattern.aimMode == AimType.TargetPlayer && target != null)
                {
                    Vector3 targetPos;

                    // --- SMART AIM LOGIC ---
                    if (aimTarget != null)
                    {
                        targetPos = aimTarget.AimPoint;
                    }
                    else
                    {
                        // Fallback: Guess center mass
                        targetPos = target.position + Vector3.up;
                    }
                    // -----------------------

                    aimDir = (targetPos - firePoint.position).normalized;
                }

                // Apply Spin
                if (pattern.spinDuringFire)
                {
                    spinOffset += pattern.spinSpeed * pattern.delayBetweenShots; // Increment spin
                    aimDir = Quaternion.Euler(0, spinOffset, 0) * aimDir;
                }

                // Apply Spread (Random noise)
                float totalSpread = pattern.spreadAngle + stats.spreadAngle;
                if (totalSpread > 0)
                {
                    float noise = Random.Range(-totalSpread / 2f, totalSpread / 2f);
                    aimDir = Quaternion.Euler(0, noise, 0) * aimDir;
                }

                SpawnProjectile(pattern, stats, firePoint.position, aimDir);

                if (pattern.delayBetweenShots > 0)
                    yield return new WaitForSeconds(pattern.delayBetweenShots);
            }

            // 5. Cooldown
            yield return new WaitForSeconds(pattern.cooldownAfterBurst);

            _isFiring = false;
        }

        private void SpawnProjectile(AttackPatternSO pattern, EnemyAttackSO stats, Vector3 pos, Vector3 dir)
        {
            if (Global.Pool == null) return;

            GameObject p = Global.Pool.Spawn(stats.projectilePrefab, pos, Quaternion.LookRotation(dir));
            var proj = p.GetComponent<Projectile>();
            if (proj)
            {
                proj.ResetHostility(true);

                proj.damage = stats.damage;
                proj.stagger = stats.stagger;

                // Prefer stats as the source of truth for ballistics; fallback to pattern if needed.
                proj.speed = stats.projectileSpeed > 0 ? stats.projectileSpeed : pattern.speed;
                if (stats.lifetime > 0) proj.lifetime = stats.lifetime;

                proj.SetSource(gameObject); // Ignore self
                proj.Initialize(dir);
            }
        }
    }
}