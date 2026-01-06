using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data; 
using DarkTowerTron.Core.Services;
using DarkTowerTron.Managers;
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.Player.Combat
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

        // Cache for NonAlloc physics (Garbage Collection optimization)
        private RaycastHit[] _aimBuffer = new RaycastHit[10];

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
            if (fireSound && Services.Audio != null)
                Services.Audio.PlaySound(fireSound); 
        }

        protected Vector3 GetAimDirection()
        {
            if (firePoint == null) return transform.forward;

            // 1. HARD LOCK (Scanner) - Always wins
            if (_scanner != null && _scanner.CurrentTarget != null)
            {
                if (_scanner.CurrentTarget is IAimTarget aimTarget)
                    return (aimTarget.AimPoint - firePoint.position).normalized;

                return (_scanner.CurrentTarget.transform.position - firePoint.position).normalized;
            }

            Vector3 inputDir = transform.forward;

            // 2. SMART MAGNETISM (Priority Scoring)
            float range = _stats ? _stats.ScanRange : 20f;
            float radius = 1.5f;

            // Mask: Enemies + Walls (We need walls to check LoS)
            int mask = (1 << GameConstants.LAYER_ENEMY) | GameConstants.MASK_WALLS;

            // NEW: Define Vertical Range (The Pole)
            Vector3 p1 = transform.position + (Vector3.down * 2f); // Slightly below feet
            Vector3 p2 = transform.position + (Vector3.up * 8f);   // Covers high targets

            int hitCount = UnityEngine.Physics.CapsuleCastNonAlloc(
                p1,
                p2,
                radius,
                inputDir,
                _aimBuffer,
                range,
                mask
            );

            IAimTarget bestTarget = null;
            float bestScore = -1f;

            for (int i = 0; i < hitCount; i++)
            {
                RaycastHit hit = _aimBuffer[i];
                IAimTarget candidate = hit.collider.GetComponentInParent<IAimTarget>();

                // Skip non-targets or self
                if (candidate == null) continue;

                // A. WALL CHECK (Line of Sight)
                // Cast ray to the specific center point of the enemy
                Vector3 directionToTarget = candidate.AimPoint - firePoint.position;
                float distToTarget = directionToTarget.magnitude;

                // If we hit a wall before the enemy, skip
                if (UnityEngine.Physics.Raycast(
                        firePoint.position,
                        directionToTarget,
                        distToTarget,
                        GameConstants.MASK_WALLS
                    ))
                {
                    continue;
                }

                // B. PRIORITY SCORING (Dot Product)
                // 1.0 = Perfectly centered in crosshair.
                float angleScore = Vector3.Dot(inputDir, directionToTarget.normalized);

                if (angleScore > bestScore)
                {
                    bestScore = angleScore;
                    bestTarget = candidate;
                }
            }

            if (bestTarget != null)
            {
                // Snap pitch to the best target
                return (bestTarget.AimPoint - firePoint.position).normalized;
            }

            // 3. TERRAIN FALLBACK (Slopes)
            Vector3 futurePos = transform.position + (inputDir * 15f);
            if (UnityEngine.Physics.Raycast(
                    futurePos + Vector3.up * 10f,
                    Vector3.down,
                    out RaycastHit groundHit,
                    20f,
                    GameConstants.MASK_GROUND_ONLY
                ))
            {
                Vector3 aimAtPoint = groundHit.point + (Vector3.up * 1.5f);
                return (aimAtPoint - firePoint.position).normalized;
            }

            return inputDir;
        }
    }
}