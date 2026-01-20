using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Core.Patterns; // Access IAudioService (or Systems.Audio depending on where you put the interface)
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Core.Feedback
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Feedback/Commands/Play Sound")]
    public class PlaySoundCommand : FeedbackCommand
    {
        [Tooltip("The sound definition to play.")]
        public SoundDef sound;

        public override void Execute(GameObject owner, Vector3 position)
        {
            // 1. Get Service
            // Note: Ensure IAudioService is in the namespace you are using, usually Core.Patterns or Systems.Audio
            var audioService = ServiceLocator.Get<IAudioService>();

            if (sound != null && audioService != null)
            {
                // 2. Play Sound via Service
                audioService.PlaySound(sound);
            }
        }
    }
}