using System;
using UnityEngine;

namespace DarkTowerTron.Core
{
    public static class GameEvents
    {
        // Combat
        public static Action<Vector3> OnEnemyKilled;
        public static Action<Vector3> OnEnemySpawned; // Position
        public static Action OnPlayerHit;
        public static Action OnPlayerDied;
        public static Action OnGameVictory;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

        // System
        public static Action OnWaveCleared;
        
        // NEW: Announces upcoming wave (e.g., "WAVE 2")
        public static Action<int> OnWaveAnnounce; 
        
        // NEW: Fired when countdown finishes and enemies actually spawn
        public static Action OnWaveCombatStarted;
        
        // NEW: Updates the countdown number (3, 2, 1...)
        public static Action<string> OnCountdownChange;

        // AI Targeting
        // Fired when a high-priority target appears (Decoy)
        public static Action<Transform> OnDecoySpawned;
        // Fired when the decoy is gone (Enemies should revert to Player)
        public static Action OnDecoyExpired;

        // UI
        public static Action<int, int> OnScoreChanged; // Score, Multiplier

        // Feedback Events
        // Position, Amount, IsCritical (Glory Kill)
        public static Action<Vector3, float, bool> OnDamageDealt; 
        
        // Position, Text (e.g., "STAGGER", "BLOCKED")
        public static Action<Vector3, string> OnPopupText;
    }
}