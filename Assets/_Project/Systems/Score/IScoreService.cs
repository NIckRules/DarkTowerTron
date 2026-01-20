using System;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Score
{
    public interface IScoreService : IGameService
    {
        int TotalScore { get; }
        int CurrentMultiplier { get; }

        // Event sends (TotalScore, Multiplier)
        event Action<int, int> OnScoreChanged;

        void AddScore(int amount);
        void ResetScore();
    }
}