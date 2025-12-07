using UnityEngine;
using System.Collections;
using DarkTowerTron.Combat;
using DarkTowerTron.Core;
using DarkTowerTron.Physics; // For LayerMasks
using DG.Tweening;

namespace DarkTowerTron.Enemy
{
    public class EnemyAI_Sniper : EnemyBaseAI
    {
        [Header("Sniper Stats")]
        public float panicDistance = 5f;
        public float teleportCooldown = 5.0f; // New: No spamming
        public float fireRate = 4.0f;
        public float telegraphTime = 1.5f;

        [Header("Setup")]
        public GameObject projectilePrefab;
        public Transform firePoint;
        public LineRenderer laserSight;
        public LayerMask wallLayer; // New: For bounds checking

        private bool _isBusy;
        private float _fireTimer;
        private float _teleportTimer; // Tracks cooldown

        protected override void Start()
        {
            base.Start();
            if (laserSight) laserSight.enabled = false;

            // Default wall layer if not set
            if (wallLayer == 0) wallLayer = LayerMask.GetMask("Default", GameConstants.LAYER_WALL);
        }

        protected override void RunAI()
        {
            // Cooldown management
            if (_teleportTimer > 0) _teleportTimer -= Time.deltaTime;
            if (_fireTimer > 0) _fireTimer -= Time.deltaTime;

            if (_isBusy) return;

            // 1. Panic Check (Teleport)
            // Only if cooldown is ready AND player is too close
            float dist = Vector3.Distance(transform.position, _currentTarget.position);
            if (dist < panicDistance && _teleportTimer <= 0)
            {
                StartCoroutine(TeleportAway());
                return;
            }

            // 2. Face Target
            _motor.FaceTarget(_currentTarget.position);

            // 3. Attack Cycle
            if (_fireTimer <= 0)
            {
                StartCoroutine(SniperShot());
            }
        }

        private IEnumerator TeleportAway()
        {
            _isBusy = true;
            AbortAttack();

            // 1. Shrink (Vanish)
            transform.DOScale(Vector3.zero, 0.2f);
            yield return new WaitForSeconds(0.2f);

            // 2. Calculate Safe Position
            Vector3 dirFromTarget = (transform.position - _currentTarget.position).normalized;
            float targetDist = 12f; // Try to go far away

            // RAYCAST CHECK:
            // Cast from Player towards the desired direction.
            // If we hit a wall, stop 2 units before the wall.
            Vector3 newPos;
            if (UnityEngine.Physics.Raycast(_currentTarget.position, dirFromTarget, out RaycastHit hit, targetDist, wallLayer))
            {
                // Hit wall -> Place sniper 2m in front of wall
                newPos = hit.point - (dirFromTarget * 2.0f);
            }
            else
            {
                // No wall -> Full distance
                newPos = _currentTarget.position + (dirFromTarget * targetDist);
            }

            newPos.y = 0; // Keep grounded
            transform.position = newPos;

            // 3. Grow (Appear)
            transform.DOScale(Vector3.one, 0.2f);
            yield return new WaitForSeconds(0.2f);

            _teleportTimer = teleportCooldown; // Reset Cooldown
            _fireTimer = 1.0f; // Delay before shooting
            _isBusy = false;
        }

        private IEnumerator SniperShot()
        {
            _isBusy = true;
            if (laserSight) laserSight.enabled = true;

            float aimTimer = 0f;
            while (aimTimer < telegraphTime)
            {
                if (_controller.IsStaggered) { AbortAttack(); _isBusy = false; yield break; }

                // Stop tracking in last 0.3s (Lock Aim)
                if (aimTimer < telegraphTime - 0.3f)
                    _motor.FaceTarget(_currentTarget.position);

                // Update Laser Visuals
                if (laserSight)
                {
                    Vector3 start = firePoint ? firePoint.position : transform.position;
                    laserSight.SetPosition(0, start);
                    laserSight.SetPosition(1, _currentTarget.position);
                }

                aimTimer += Time.deltaTime;
                yield return null;
            }

            // FIRE
            if (laserSight) laserSight.enabled = false;

            if (projectilePrefab && !_controller.IsStaggered)
            {
                Vector3 spawnPos = firePoint ? firePoint.position : transform.position + transform.forward;
                GameObject p = Instantiate(projectilePrefab, spawnPos, transform.rotation);

                // IMPORTANT: Initialize logic
                Projectile proj = p.GetComponent<Projectile>();
                if (proj)
                {
                    proj.speed = 30f;
                    proj.Initialize(transform.forward);
                }
            }

            _fireTimer = fireRate;
            _isBusy = false;
        }

        private void AbortAttack()
        {
            if (laserSight) laserSight.enabled = false;
        }
    }
}