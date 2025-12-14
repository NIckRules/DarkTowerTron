using System;
using UnityEngine;
using DarkTowerTron.Core.Data; // Needed for EnemyStatsSO

namespace DarkTowerTron.Core
{
    public static class GameEvents
    {
        // --- COMBAT ---
        // OLD: public static Action<Vector3> OnEnemyKilled;

        // Updated Signature: Vector3 pos, Stats, bool rewardPlayer
        public static Action<Vector3, EnemyStatsSO, bool> OnEnemyKilled;

        public static Action OnPlayerHit;
        public static Action OnPlayerDied;

        // Feedback
        public static Action<Vector3, float, bool> OnDamageDealt;
        public static Action<Vector3, string> OnPopupText;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

        // NEW: True = Hull Active, False = Hull Broken (Danger)
        public static Action<bool> OnHullStateChanged;

        // System
        public static Action<Vector3> OnEnemySpawned;
        public static Action OnWaveCleared;
        public static Action OnGameVictory;
        public static Action<int> OnWaveAnnounce;
        public static Action<string> OnCountdownChange;
        public static Action OnWaveCombatStarted;

        // AI
        public static Action<Transform> OnDecoySpawned;
        public static Action OnDecoyExpired;

        // UI
        public static Action<int, int> OnScoreChanged;

        /// <summary>
        /// CRITICAL FIX-004: Call this when loading scenes or quitting.
        /// Prevents static events from holding references to destroyed objects.
        /// </summary>
        public static void Cleanup()
        {
            OnEnemyKilled = null;
            OnPlayerHit = null;
            OnPlayerDied = null;
            OnDamageDealt = null;
            OnPopupText = null;
            OnFocusChanged = null;
            OnGritChanged = null;
            OnHullStateChanged = null;
            OnEnemySpawned = null;
            OnWaveCleared = null;
            OnGameVictory = null;
            OnWaveAnnounce = null;
            OnCountdownChange = null;
            OnWaveCombatStarted = null;
            OnDecoySpawned = null;
            OnDecoyExpired = null;
            OnScoreChanged = null;
            
            Debug.Log("[GameEvents] All static listeners cleared.");
        }
    }
}