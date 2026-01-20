using System.Collections;
using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Gameplay.Combat; // For ICombatTarget
using DarkTowerTron.Core.Feedback; // For CameraShaker
using DarkTowerTron.Core.AudioSystem; // For IAudioService
using DarkTowerTron.Systems.Score; // For IScoreService

namespace DarkTowerTron.Gameplay.Player
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
        public int killScoreAmount = 500; // New: explicit score value
        public AudioClip executeClip;

        [Header("Positioning")]
        [Tooltip("How high above the ground to teleport to prevent clipping. 0.1 is usually enough.")]
        public float verticalBuffer = 0.2f;

        // Dependencies
        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private PlayerMotor _movement;
        private PlayerStats _stats;
        
        // Services
        private IAudioService _audioService;
        private IScoreService _scoreService;

        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
            _movement = GetComponent<PlayerMotor>();
            _stats = GetComponent<PlayerStats>();
        }

        private void Start()
        {
            // Locate Services
            _audioService = ServiceLocator.Get<IAudioService>();
            _scoreService = ServiceLocator.Get<IScoreService>();
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
                // Cast from High Up (Enemy Head + 2m) downwards
                Vector3 rayOrigin = targetPos + Vector3.up * 2.0f;
                int groundMask = GameConstants.MASK_GROUND_ONLY; // Ensure GameConstants defines this, or use LayerMask.GetMask("Ground")

                if (Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 10f, groundMask))
                {
                    attackPos.y = hit.point.y + verticalBuffer;
                }
                else
                {
                    // Fallback: Use Player's current height
                    attackPos.y = transform.position.y + verticalBuffer;
                }
            }
            else
            {
                // Air execution (maintain enemy height)
                attackPos.y = targetPos.y;
            }

            // 3. Safe Teleport
            if (_movement)
            {
                _movement.Teleport(attackPos);
                // Suspend gravity during animation
                _movement.SuspendGravity(_stats.ActionHangTime + 0.5f);
            }

            // 4. Trigger Target Reaction (Die)
            target.OnExecutionHit();

            // 5. Audio & Rewards
            if (executeClip && _audioService != null)
                _audioService.PlaySound(executeClip, 1f);

            _energy.AddFocus(killRewardFocus);

            if (_scoreService != null)
                _scoreService.AddScore(killScoreAmount, "Glory Kill");

            // 6. Juice (Time Stop & Shake)
            StartCoroutine(HitStopRoutine(0.1f));

            if (CameraShaker.Instance)
                CameraShaker.Instance.Shake(0.2f, 0.5f);

            yield return new WaitForSeconds(0.1f);

            _isBusy = false;
        }

        // Simple local replacement for Global.Time.HitStop
        private IEnumerator HitStopRoutine(float duration)
        {
            if (Time.timeScale == 0) yield break; // Already paused

            float originalScale = Time.timeScale;
            Time.timeScale = 0f;
            
            // We use WaitForSecondsRealtime because timeScale is 0
            yield return new WaitForSecondsRealtime(duration);
            
            Time.timeScale = originalScale;
        }
    }
}