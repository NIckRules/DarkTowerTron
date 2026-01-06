using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW: Event Channels
using DarkTowerTron.Visuals;

// ALIAS: Resolves Services conflict
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Managers
{
    public class FeedbackDirector : MonoBehaviour
    {
        [Header("Event Wiring")]
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private BoolEventChannelSO _hullEvent;

        [Header("Profiles")]
        public FeedbackProfileSO killProfile;
        public FeedbackProfileSO playerHurtProfile;

        // Note: 'hitProfile' seemed unused in your previous logic, 
        // kept here if you plan to wire it to an EnemyHit event later.
        public FeedbackProfileSO hitProfile;

        [Header("Hull")]
        public AudioClip hullBreakClip;

        // State for Edge Detection
        private bool _hasLastHullState;
        private bool _lastHasHull;

        private void OnEnable()
        {
            if (_playerHitEvent != null) _playerHitEvent.OnEventRaised += OnPlayerHit;
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_hullEvent != null) _hullEvent.OnEventRaised += OnHullChanged;
        }

        private void OnDisable()
        {
            if (_playerHitEvent != null) _playerHitEvent.OnEventRaised -= OnPlayerHit;
            if (_enemyKilledEvent != null) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_hullEvent != null) _hullEvent.OnEventRaised -= OnHullChanged;
        }

        private void OnHullChanged(bool hasHull)
        {
            bool lostHull = _hasLastHullState && _lastHasHull && !hasHull;

            _hasLastHullState = true;
            _lastHasHull = hasHull;

            // Only play feedback if we LOST the hull (became false)
            if (!lostHull) return;

            if (Global.Audio != null) Global.Audio.PlaySound(hullBreakClip, 1.0f);

            // Legacy Singletons (Consider refactoring these to Services later)
            if (CameraShaker.Instance) CameraShaker.Instance.Shake(0.5f, 0.7f);
            if (Global.Time != null) Global.Time.HitStop(0.2f);
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
            if (profile.sound && Global.Audio != null)
                Global.Audio.PlaySound(profile.sound);

            // 2. Camera
            if (CameraShaker.Instance)
                CameraShaker.Instance.Shake(profile.shakeDuration, profile.shakeStrength);

            // 3. Time
            if (Global.Time != null && profile.hitStopDuration > 0)
                Global.Time.HitStop(profile.hitStopDuration);
        }
    }
}