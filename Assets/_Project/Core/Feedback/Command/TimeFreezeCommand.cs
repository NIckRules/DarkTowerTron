using UnityEngine;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Systems.TimeManagement;  // Access ITimeService

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Time Freeze")]
    public class TimeFreezeCommand : FeedbackCommand
    {
        [Range(0f, 1f)] public float duration = 0.05f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // Look up the service safely
            var timeService = ServiceLocator.Get<ITimeService>();
            
            if (timeService != null)
            {
                timeService.HitStop(duration);
            }
        }
    }
}