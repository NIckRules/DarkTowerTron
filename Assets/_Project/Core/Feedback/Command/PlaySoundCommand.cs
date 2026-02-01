using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
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

            var audioService = ServiceLocator.Get<IAudioService>();

            if (sound != null && audioService != null)
            {
                // FIX: Pass the 'position' argument! 
                // Previously it was: audioService.PlaySound(sound); which defaults to (0,0,0)
                audioService.PlaySound(sound, position);
            }
        }
    }
}