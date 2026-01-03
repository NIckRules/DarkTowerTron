using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // For ScoreManager
using DarkTowerTron.Core.Services;
using DarkTowerTron.Player.Stats;
using DarkTowerTron.Player.Movement;

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
        public AudioClip executeClip; // Assign in Inspector

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
            if (_scanner == null || _scanner.CurrentTarget == null)
            {
                // Optional: Play "Error" sound
                return;
            }

            if (!_scanner.CurrentTarget.IsStaggered)
            {
                // Optional: Play "Denied" sound
                return;
            }

            StartCoroutine(ExecutionRoutine(_scanner.CurrentTarget));
        }

        // Change parameter type to Interface
        private IEnumerator ExecutionRoutine(ICombatTarget target)
        {
            _isBusy = true;

            // 1. Calculate Position
            Vector3 targetPos = target.transform.position;
            Vector3 attackPos = targetPos - (transform.forward * 1.0f); 

            // 2. Y-Axis Logic (The Fix)
            if (target.KeepPlayerGrounded)
            {
                // Find the ground below the target
                if (UnityEngine.Physics.Raycast(targetPos + Vector3.up, Vector3.down, out RaycastHit hit, 10f, LayerMask.GetMask("Ground")))
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

            // 2. Suspend Gravity (The "Matrix" Pause)
            if (_movement)
            {
                _movement.ResetVelocity();
                _movement.SuspendGravity(_stats.ActionHangTime);
            }

            // 3. Trigger Target Reaction (Die or Reset)
            target.OnExecutionHit();

            // PLAY SOUND
            if (GameFeel.Instance && executeClip) 
                GameFeel.Instance.PlaySound(executeClip, 1f);

            // 3. Rewards
            // We assume execution always gives Focus (movement fuel)
            _energy.AddFocus(killRewardFocus);
            
            // LOGIC CHECK: Only heal if it was a living enemy? 
            // Or rely on OnEnemyKilled event?
            // Since EnemyController.Kill fires OnEnemyKilled, the health will update automatically.
            // DamageableProp DOES NOT fire OnEnemyKilled (usually), so Anchors won't heal you.
            // This is correct behavior!

            if (Services.Score != null)
                Services.Score.TriggerGloryKillBonus();

            // 4. Juice
            if (GameFeel.Instance)
            {
                GameFeel.Instance.HitStop(0.1f);
                GameFeel.Instance.CameraShake(0.2f, 0.5f);
            }

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }
    }
}