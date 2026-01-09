using DarkTowerTron.Visuals;
using UnityEngine;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Camera Shake")]
    public class CameraShakeCommand : FeedbackCommand
    {
        public float duration = 0.2f;
        public float strength = 0.5f;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (CameraShaker.Instance != null)
            {
                CameraShaker.Instance.Shake(duration, strength);
            }
        }
    }
}