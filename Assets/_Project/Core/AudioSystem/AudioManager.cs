using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.AudioSystem
{
    public class AudioManager : MonoBehaviour, IAudioService
    {
        [Header("References")]
        [SerializeField] private AudioSource _sfxSourcePrefab;
        [SerializeField] private MusicManager _musicManager;

        [Header("Settings")]
        [SerializeField] private int _initialPoolSize = 10;

        private List<AudioSource> _sfxPool;

        private void Awake()
        {
            InitializePool();
            if (_musicManager == null) _musicManager = GetComponentInChildren<MusicManager>();
        }

        private void InitializePool()
        {
            _sfxPool = new List<AudioSource>();
            for (int i = 0; i < _initialPoolSize; i++) CreateNewSource();
        }

        private AudioSource CreateNewSource()
        {
            var source = Instantiate(_sfxSourcePrefab, transform);
            source.gameObject.SetActive(false);
            _sfxPool.Add(source);
            return source;
        }

        private AudioSource GetFreeSource()
        {
            foreach (var s in _sfxPool) if (!s.gameObject.activeInHierarchy) return s;
            return CreateNewSource();
        }

        // --- IAudioService Implementation ---

        // 1. The Bridge Method (Fixes CS1061)
        public void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f)
        {
            if (soundDef == null) return;

            if (soundDef is SoundDef def)
            {
                PlaySFX(def, position);
            }
            else if (soundDef is AudioClip clip)
            {
                PlaySFX(clip, position, volume);
            }
        }

        // 2. SoundDef Specific (Uses Pitch/Volume from SO)
        public void PlaySFX(SoundDef sound, Vector3 position)
        {
            if (sound == null) return;

            AudioClip clip = sound.GetClip();
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;

            // Apply SoundDef Settings
            source.volume = sound.volume;
            source.pitch = sound.GetPitch(); // CRITICAL: Uses your randomization logic

            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length / source.pitch)); // Adjust delay for pitch
        }

        // 3. Raw AudioClip fallback
        public void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f)
        {
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = volume;
            source.pitch = 1f; // Reset pitch for raw clips

            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length));
        }

        public void PlayMusic(AudioClip musicClip, float fadeDuration = 1f)
            => _musicManager?.PlayMusic(musicClip, fadeDuration);

        public void StopMusic(float fadeDuration = 1f)
            => _musicManager?.StopMusic(fadeDuration);

        public void SetMusicVolume(float volume)
            => _musicManager?.SetVolume(volume);

        private System.Collections.IEnumerator DisableSourceDelayed(AudioSource source, float delay)
        {
            // Safety buffer
            yield return new WaitForSeconds(delay + 0.1f);
            source.gameObject.SetActive(false);
        }
    }
}