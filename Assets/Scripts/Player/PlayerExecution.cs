using UnityEngine;
using System.Collections;
using DarkTowerTron.Core;
using DarkTowerTron.Managers; // For ScoreManager

namespace DarkTowerTron.Player
{
    [RequireComponent(typeof(PlayerEnergy))]
    [RequireComponent(typeof(PlayerHealth))]
    [RequireComponent(typeof(TargetScanner))]
    public class PlayerExecution : MonoBehaviour
    {
        [Header("Settings")]
        public float killRewardFocus = 50f;
        public AudioClip executeClip; // Assign in Inspector

        private PlayerEnergy _energy;
        private PlayerHealth _health;
        private TargetScanner _scanner;
        private bool _isBusy;

        private void Awake()
        {
            _energy = GetComponent<PlayerEnergy>();
            _health = GetComponent<PlayerHealth>();
            _scanner = GetComponent<TargetScanner>();
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

            // 1. Teleport
            Vector3 targetPos = target.transform.position;
            Vector3 attackPos = targetPos - (transform.forward * 1.0f);
            transform.position = attackPos;

            // 2. Trigger Target Reaction (Die or Reset)
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

            if (ScoreManager.Instance)
                ScoreManager.Instance.TriggerGloryKillBonus();

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