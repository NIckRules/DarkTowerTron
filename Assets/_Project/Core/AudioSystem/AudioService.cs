using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Core.AudioSystem
{
    public class AudioService : MonoBehaviour, IAudioService
    {
        [Header("Modules")]
        [SerializeField] private MusicManager _musicManager;
        [SerializeField] private AudioSource _sfxSourcePrefab;

        [Header("Settings")]
        [SerializeField] private int _initialPoolSize = 10;

        private List<AudioSource> _sfxPool;

        private void Awake()
        {
            // 1. Register Service
            ServiceLocator.Register<IAudioService>(this);

            // 2. Init Submodules
            InitializePool();

            if (_musicManager == null)
                _musicManager = GetComponentInChildren<MusicManager>();

            if (_musicManager == null)
                Debug.LogWarning("[AudioService] No MusicManager found in children!");
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IAudioService>(this);
        }

        // --- SFX Logic (Pooling) ---

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

        // 1. Generic Entry Point
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

        // 2. SoundDef Logic (Pitch Variation)
        public void PlaySFX(SoundDef sound, Vector3 position)
        {
            if (sound == null) return;
            AudioClip clip = sound.GetClip();
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = sound.volume;
            source.pitch = sound.GetPitch(); // Apply Variation
            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length / source.pitch));
        }

        // 3. Raw Clip Logic
        public void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f)
        {
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = volume;
            source.pitch = 1f;
            source.gameObject.SetActive(true);
            source.Play();

            StartCoroutine(DisableSourceDelayed(source, clip.length));
        }

        // 4. Music Forwarding (Facade)
        public void PlayMusic(AudioClip musicClip, float fadeDuration = 1f)
            => _musicManager?.PlayMusic(musicClip, fadeDuration);

        public void StopMusic(float fadeDuration = 1f)
            => _musicManager?.StopMusic(fadeDuration);

        public void SetMusicVolume(float volume)
            => _musicManager?.SetVolume(volume);

        private System.Collections.IEnumerator DisableSourceDelayed(AudioSource source, float delay)
        {
            // Small buffer to ensure clip finishes
            yield return new WaitForSeconds(delay + 0.1f);
            source.gameObject.SetActive(false);
        }
    }
}