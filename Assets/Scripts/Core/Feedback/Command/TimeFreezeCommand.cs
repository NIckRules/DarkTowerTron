using UnityEngine;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Time Freeze")]
    public class TimeFreezeCommand : FeedbackCommand
    {
        [Range(0f, 1f)] public float duration = 0.05f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (Services.Time != null)
            {
                Services.Time.HitStop(duration);
            }
        }
    }
}