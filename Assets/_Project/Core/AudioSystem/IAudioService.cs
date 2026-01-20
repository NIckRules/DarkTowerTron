using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Data; // For SoundDef

namespace DarkTowerTron.Core.AudioSystem
{
    public interface IAudioService : IGameService
    {
        void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f);

        void PlaySFX(SoundDef sound, Vector3 position);
        void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f);

        void PlayMusic(AudioClip musicClip, float fadeDuration = 1f);
        void StopMusic(float fadeDuration = 1f);
        void SetMusicVolume(float volume);
    }
}