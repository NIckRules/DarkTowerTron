using DarkTowerTron.Core.Data;
using UnityEngine;
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Core.Feedback.Commands
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Play Sound")]
    public class PlaySoundCommand : FeedbackCommand
    {
        [Tooltip("The sound definition to play.")]
        public SoundDef sound;

        public override void Execute(GameObject owner, Vector3 position)
        {
            if (sound != null && Global.Audio != null)
            {
                // Note: Your AudioManager.PlaySound currently ignores position (2D).
                // If you add 3D sound support later, pass 'position' here.
                Global.Audio.PlaySound(sound);
            }
        }
    }
}