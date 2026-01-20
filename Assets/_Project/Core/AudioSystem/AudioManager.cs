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

            if (_musicManager == null)
                _musicManager = GetComponentInChildren<MusicManager>();
        }

        private void InitializePool()
        {
            _sfxPool = new List<AudioSource>();
            for (int i = 0; i < _initialPoolSize; i++)
            {
                CreateNewSource();
            }
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
            foreach (var source in _sfxPool)
            {
                if (!source.gameObject.activeInHierarchy) return source;
            }
            return CreateNewSource();
        }

        // --- IAudioService Implementation ---

        public void PlaySFX(SoundDef sound, Vector3 position)
        {
            if (sound == null) return;
            // FIX: Use GetClip() instead of .clip
            PlaySFX(sound.GetClip(), position, sound.volume);
        }

        public void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f)
        {
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = volume;
            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length));
        }

        // Forwarding to MusicManager (Now valid)
        public void PlayMusic(AudioClip musicClip, float fadeDuration = 1f)
            => _musicManager?.PlayMusic(musicClip, fadeDuration);

        public void StopMusic(float fadeDuration = 1f)
            => _musicManager?.StopMusic(fadeDuration);

        public void SetMusicVolume(float volume)
            => _musicManager?.SetVolume(volume);

        private System.Collections.IEnumerator DisableSourceDelayed(AudioSource source, float delay)
        {
            yield return new WaitForSeconds(delay);
            source.gameObject.SetActive(false);
        }
    }
}