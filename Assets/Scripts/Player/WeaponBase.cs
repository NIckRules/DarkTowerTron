using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; // For SoundDef
using DarkTowerTron.Managers; // For AudioManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;

        [Header("Audio")]
        public SoundDef fireSound;

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                _bufferTimer = inputBufferTime;
            }

            if (_bufferTimer > 0 && _timer <= 0)
            {
                Fire();
                PlayFireSound();

                // Get rate dynamically from the specific weapon implementation
                _timer = GetCurrentFireRate();

                _bufferTimer = 0;
            }
        }

        // Abstract Methods
        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        // Helpers
        protected void PlayFireSound()
        {
            if (fireSound && AudioManager.Instance)
            {
                AudioManager.Instance.PlaySound(fireSound);
            }
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                // Aim at the specific target transform
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;

                // Try to find center of mass via Collider
                var col = _scanner.CurrentTarget.transform.GetComponent<Collider>();
                if (col != null) targetPos = col.bounds.center;

                aimDir = (targetPos - firePoint.position).normalized;
            }

            return aimDir;
        }
    }
}