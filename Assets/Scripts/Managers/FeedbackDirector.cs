using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Visuals; // <--- THIS WAS MISSING

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Global Audio")]
        public AudioClip hitClip;
        public AudioClip killClip;
        public AudioClip playerHurtClip;

        [Header("Hull")]
        public AudioClip hullBreakClip; // Drag "Glass Shatter" or "Alarm" here

        private bool _hasLastHullState;
        private bool _lastHasHull;

        private void OnEnable()
        {
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
            GameEvents.OnHullStateChanged += OnHullChanged;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
            GameEvents.OnHullStateChanged -= OnHullChanged;
        }

        private void OnHullChanged(bool hasHull)
        {
            bool lostHull = _hasLastHullState && _lastHasHull && !hasHull;

            _hasLastHullState = true;
            _lastHasHull = hasHull;

            // Only play feedback if we LOST the hull (became false)
            if (!lostHull) return;

            if (AudioManager.Instance) AudioManager.Instance.PlaySound(hullBreakClip, 1.0f);
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.5f, 0.7f); // Big shake
            if (GameTime.Instance) GameTime.Instance.HitStop(0.2f); // Dramatic pause
        }

        private void OnPlayerHit()
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(playerHurtClip);

            // 2. Camera
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.3f, 0.5f);

            // 3. Time
            if (GameTime.Instance) GameTime.Instance.HitStop(0.1f);
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            // 1. Audio
            if (AudioManager.Instance) AudioManager.Instance.PlaySound(killClip, 0.8f);

            // 2. Camera (Lighter shake)
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.15f, 0.2f);
        }
    }
}