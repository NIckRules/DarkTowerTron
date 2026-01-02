using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Visuals; // <--- THIS WAS MISSING

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Profiles")]
        public FeedbackProfileSO hitProfile;
        public FeedbackProfileSO killProfile;
        public FeedbackProfileSO playerHurtProfile;

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

            if (Services.Audio != null) Services.Audio.PlaySound(hullBreakClip, 1.0f);
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.5f, 0.7f); // Big shake
            if (GameTime.Instance) GameTime.Instance.HitStop(0.2f); // Dramatic pause
        }

        private void OnPlayerHit()
        {
            ApplyProfile(playerHurtProfile);
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            ApplyProfile(killProfile);
        }

        // --- HELPER ---
        private void ApplyProfile(FeedbackProfileSO profile)
        {
            if (profile == null) return;

            // 1. Audio
            if (profile.sound && Services.Audio != null)
                Services.Audio.PlaySound(profile.sound);

            // 2. Camera
            if (Visuals.CameraShaker.Instance)
                Visuals.CameraShaker.Instance.Shake(profile.shakeDuration, profile.shakeStrength);

            // 3. Time
            if (Core.GameTime.Instance && profile.hitStopDuration > 0)
                Core.GameTime.Instance.HitStop(profile.hitStopDuration);
        }
    }
}