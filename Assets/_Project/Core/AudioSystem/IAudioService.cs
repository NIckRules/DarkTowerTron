using UnityEngine;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Core.AudioSystem
{
    public interface IAudioService : IGameService
    {
        // --- SFX ---
        void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f);
        void PlaySFX(SoundDef sound, Vector3 position);
        void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f);

        // --- Music (The New Profile API) ---
        void PlayMusicProfile(MusicProfileSO profile);
        void SetCombatIntensity(float intensity);
        void StopMusic(float fadeDuration = 1f);
    }
}