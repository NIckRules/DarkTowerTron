using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.Player.Movement;

// ALIAS: Resolves Services conflict
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Player.Combat
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerStats))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip;

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMovement _movement;
        private PlayerStats _stats;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMovement>();
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

            // 1. Calculate Position
            Vector3 targetPos = target.transform.position;
            Vector3 attackPos = targetPos - (transform.forward * 1.0f);

            // 2. Y-Axis Logic (Verticality Support)
            if (target.KeepPlayerGrounded)
            {
                // HYGIENE: Use Constant Mask
                if (UnityEngine.Physics.Raycast(targetPos + Vector3.up, Vector3.down, out RaycastHit hit, 10f, GameConstants.MASK_GROUND_ONLY))
                {
                    attackPos.y = hit.point.y;
                }
                else
                {
                    attackPos.y = targetPos.y; // Fallback
                }
            }
            else
            {
                // Go to exact height (e.g. Floating Anchor)
                attackPos.y = targetPos.y;
            }

            transform.position = attackPos;

            // 3. Suspend Gravity (The "Matrix" Pause)
            if (_movement)
            {
                _movement.ResetVelocity();
                _movement.SuspendGravity(_stats.ActionHangTime);
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