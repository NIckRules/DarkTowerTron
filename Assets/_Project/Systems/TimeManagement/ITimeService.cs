using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.TimeManagement
{
    public interface ITimeService : IGameService
    {
        void HitStop(float duration);
        void SetTimeScale(float scale);
    }
}