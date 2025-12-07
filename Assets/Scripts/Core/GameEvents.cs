using System;
using UnityEngine;

namespace DarkTowerTron.Core
{
    public static class GameEvents
    {
        // Combat
        public static Action<Vector3> OnEnemyKilled;
        public static Action OnPlayerHit;
        public static Action OnPlayerDied;

        // Resources
        public static Action<float, float> OnFocusChanged;
        public static Action<int> OnGritChanged;

        // System
        public static Action OnWaveCleared;

        // AI Targeting
        // Fired when a high-priority target appears (Decoy)
        public static Action<Transform> OnDecoySpawned;
        // Fired when the decoy is gone (Enemies should revert to Player)
        public static Action OnDecoyExpired;
    }
}