using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;
using DarkTowerTron.Player.Stats;

// ALIAS: Safety against namespace collisions
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;

        [Header("Behavior")]
        public bool isAutomatic = true;

        [Header("Audio")]
        public SoundDef fireSound;

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;

        private bool _hasFiredThisPress = false;
        private RaycastHit[] _aimBuffer = new RaycastHit[10];

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
            if (!state) _hasFiredThisPress = false;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                if (isAutomatic || !_hasFiredThisPress)
                    _bufferTimer = inputBufferTime;
            }

            if (_bufferTimer > 0 && _timer <= 0)
            {
                if (!isAutomatic && _hasFiredThisPress) return;

                Fire();
                PlayFireSound();

                _timer = GetCurrentFireRate();
                _bufferTimer = 0;
                _hasFiredThisPress = true;
            }
        }

        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        protected void PlayFireSound()
        {
            // CHANGE: Services -> Global
            if (fireSound && Global.Audio != null)
                Global.Audio.PlaySound(fireSound);
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            // 1. HARD LOCK
            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                if (_scanner.CurrentTarget is IAimTarget aimTarget)
                    return (aimTarget.AimPoint - firePoint.position).normalized;

                return (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
            }

            Vector3 inputDir = transform.forward;

            // 2. SMART MAGNETISM
            float range = _stats ? _stats.ScanRange : 20f;
            float radius = 1.5f;
            int mask = (1 << GameConstants.LAYER_ENEMY) | GameConstants.MASK_WALLS;

            Vector3 p1 = transform.position + (Vector3.down * 2f);
            Vector3 p2 = transform.position + (Vector3.up * 8f);

            int hitCount = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1, p2, radius, inputDir, _aimBuffer, range, mask
            );

            IAimTarget bestTarget = null;
            float bestScore = -1f;

            for (int i = 0; i < hitCount; i++)
            {
                RaycastHit hit = _aimBuffer[i];
                IAimTarget candidate = hit.collider.GetComponentInParent<IAimTarget>();

                if (candidate == null) continue;

                // A. Wall Check
                Vector3 directionToTarget = candidate.AimPoint - firePoint.position;
                float distToTarget = directionToTarget.magnitude;

                if (UnityEngine.Physics.Raycast(firePoint.position, directionToTarget, distToTarget, GameConstants.MASK_WALLS))
                    continue;

                // B. Priority Scoring
                float angleScore = Vector3.Dot(inputDir, directionToTarget.normalized);

                if (angleScore > bestScore)
                {
                    bestScore = angleScore;
                    bestTarget = candidate;
                }
            }

            if (bestTarget != null)
            {
                return (bestTarget.AimPoint - firePoint.position).normalized;
            }

            // 3. TERRAIN FALLBACK
            Vector3 futurePos = transform.position + (inputDir * 15f);
            if (UnityEngine.Physics.Raycast(futurePos + Vector3.up * 10f, Vector3.down, out RaycastHit groundHit, 20f, GameConstants.MASK_GROUND_ONLY))
            {
                Vector3 aimAtPoint = groundHit.point + (Vector3.up * 1.5f);
                return (aimAtPoint - firePoint.position).normalized;
            }

            return inputDir;
        }
    }
}