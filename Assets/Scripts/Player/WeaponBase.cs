using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; 
using DarkTowerTron.Managers;

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerStats))]
    public abstract class WeaponBase : MonoBehaviour, IWeapon
    {
        [Header("Weapon Base Stats")]
        public Transform firePoint;
        
        [Header("Behavior")]
        public bool isAutomatic = true; // Gun = True, Beam = False

        [Header("Audio")]
        public SoundDef fireSound; 

        [Header("Feel")]
        public float inputBufferTime = 0.2f;

        protected PlayerStats _stats;
        protected TargetScanner _scanner;
        
        protected float _timer;
        protected float _bufferTimer;
        protected bool _isFiring;
        
        // NEW: Tracks if we already shot during this specific button press
        private bool _hasFiredThisPress = false;

        protected virtual void Awake()
        {
            _scanner = GetComponent<TargetScanner>();
            _stats = GetComponent<PlayerStats>();
        }

        public void SetFiring(bool state)
        {
            _isFiring = state;
            
            // RESET Logic: If we released the button, we can fire again
            if (!state)
            {
                _hasFiredThisPress = false;
            }
        }

        protected virtual void Update()
        {
            if (_timer > 0) _timer -= Time.deltaTime;
            if (_bufferTimer > 0) _bufferTimer -= Time.deltaTime;

            if (_isFiring)
            {
                // Only fill buffer if we are allowed to fire (for Semi-Auto)
                if (isAutomatic || !_hasFiredThisPress)
                {
                    _bufferTimer = inputBufferTime;
                }
            }

            // TRIGGER LOGIC
            if (_bufferTimer > 0 && _timer <= 0)
            {
                // Semi-Auto Check
                if (!isAutomatic && _hasFiredThisPress)
                {
                    // Do nothing, waiting for release
                    return;
                }

                Fire();
                PlayFireSound();
                
                _timer = GetCurrentFireRate();
                _bufferTimer = 0;
                
                // Mark as fired
                _hasFiredThisPress = true; 
            }
        }

        // ... (Rest of script: GetCurrentFireRate, Fire, Helpers match previous) ...
        protected abstract float GetCurrentFireRate();
        protected abstract void Fire();

        protected void PlayFireSound()
        {
            if (fireSound && AudioManager.Instance)
                AudioManager.Instance.PlaySound(fireSound); 
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;
            Vector3 aimDir = firePoint.forward;

            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                Vector3 targetPos = _scanner.CurrentTarget.transform.position;
                var col = _scanner.CurrentTarget.transform.GetComponent<Collider>();
                if (col != null) targetPos = col.bounds.center;
                aimDir = (targetPos - firePoint.position).normalized;
            }
            return aimDir;
        }
    }
}