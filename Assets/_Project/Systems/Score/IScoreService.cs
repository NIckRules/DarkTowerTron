using System;
using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Score
{
    public interface IScoreService : IGameService
    {
        // State Properties
        int TotalScore { get; }
        int CurrentMultiplier { get; }
        float GameTime { get; } // Fixes CS1061 in ResultScreen/HUD

        // Events
        event Action<int, int> OnScoreChanged;

        // Methods
        void AddScore(int amount);
        void AddScore(int amount, Vector3 position); // Fixes CS1501 in PlayerExecution
        void ResetScore();
        void StopTracking(); // Fixes CS1061 in ResultScreen
    }
}