using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Movement;
using DarkTowerTron.Player.Stats;
using UnityEngine;
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    [RequireComponent(typeof(PlayerMotor))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip;

        [Header("Positioning")]
        [Tooltip("How high above the ground to teleport to prevent clipping. 0.1 is usually enough.")]
        public float verticalBuffer = 0.2f;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMotor _movement;
        private PlayerStats _stats;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMotor>();
            _stats = GetComponent<PlayerStats>();
        }

        public void PerformGloryKill()
        {
            if (_isBusy) return;

            // Logic Checks
            if (_scanner == null || _scanner.CurrentTarget == null) return;

            if (!_scanner.CurrentTarget.IsStaggered) return;

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        private IEnumerator ExecutionRoutine(ICombatTarget target)
        {
            _isBusy = true;

            // 1. Calculate Base Position (Horizontal only first)
            Vector3 targetPos = target.transform.position;
            
            // Back up slightly from the target so we don't clip inside them
            Vector3 attackPos = targetPos - (transform.forward * 1.5f);

            // 2. Y-Axis Logic (Safe Ground Snap)
            if (target.KeepPlayerGrounded)
            {
                // FIX: Cast from High Up (Enemy Head + 2m) downwards
                // This ensures we don't start the raycast inside the floor if the enemy is short
                Vector3 rayOrigin = targetPos;
                rayOrigin.y += 2.0f;

                int groundMask = DarkTowerTron.Core.GameConstants.MASK_GROUND_ONLY;

                if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 10f, groundMask))
                {
                    // Add a small buffer so we don't clip into the floor after teleport.
                    attackPos.y = hit.point.y + verticalBuffer;
                }
                else
                {
                    // Fallback: Use Player's current height if we can't find ground
                    // This prevents teleporting into the void if the enemy is flying over a pit
                    attackPos.y = transform.position.y + verticalBuffer;
                }
            }
            else
            {
                // Air execution (maintain enemy height)
                attackPos.y = targetPos.y;
            }

            // 3. SAFE TELEPORT (Fixes the "Falling through ground" bug)
            if (_movement)
            {
                _movement.Teleport(attackPos);
                
                // Suspend gravity so we hang in the air during the animation
                _movement.SuspendGravity(_stats.ActionHangTime + 0.5f);
            }

            // 4. Trigger Target Reaction (Die or Reset)
            target.OnExecutionHit();

            // 5. Audio (Service Locator)
            if (executeClip && Global.Audio != null)
                Global.Audio.PlaySound(executeClip, 1f);

            // 6. Rewards
            _energy.AddFocus(killRewardFocus);

            if (Global.Score != null)
                Global.Score.TriggerGloryKillBonus();

            // 7. Juice
            // Replaced GameFeel with specific services

            // A. Time Stop
            if (Global.Time != null)
                Global.Time.HitStop(0.1f);

            // B. Shake (CameraShaker is still a Scene Singleton for now)
            if (DarkTowerTron.Visuals.CameraShaker.Instance)
                DarkTowerTron.Visuals.CameraShaker.Instance.Shake(0.2f, 0.5f);

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }
    }
}