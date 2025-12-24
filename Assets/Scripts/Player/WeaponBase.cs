using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Player
{
    // Abstract means you can't put this directly on an object, 
    // you must extend it (like PlayerGun : WeaponBase)
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        public float baseFireRate = 0.2f;
        
        [Header("Audio")]
        public AudioClip fireClip;
        [Range(0f, 1f)] public float volume = 0.8f;

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;
        protected TargetScanner _scanner;
        protected PlayerStats _stats;

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
                _timer = baseFireRate / _stats.FireRateMultiplier;
                _bufferTimer = 0;
            }
        }

        protected abstract void Fire();

        protected void PlayFireSound()
        {
            if (fireClip && Managers.AudioManager.Instance)
            {
                Managers.AudioManager.Instance.PlaySound(fireClip, volume, true);
            }
        }

        // --- SHARED HELPER METHODS ---

        /// <summary>
        /// Calculates the best firing direction. 
        /// Defaults to forward. If Locked On, aims at Enemy Center Mass.
        /// </summary>
        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
                
                // FIX: Access GetComponent via the .transform property
                var col = _scanner.CurrentTarget.transform.GetComponent<Collider>();
                
                if (col != null) targetPos = col.bounds.center;

                aimDir = (targetPos - firePoint.position).normalized;
            }

            return aimDir;
        }
    }
}