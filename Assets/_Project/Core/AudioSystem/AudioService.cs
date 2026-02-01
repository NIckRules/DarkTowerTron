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

        [Header("Dynamic State")]
        [Range(0f, 1f)] public float combatIntensity = 0f;
        [SerializeField] private float _intensityDecaySpeed = 0.2f;

        private List<AudioSource> _sfxPool;
        private MusicProfileSO _activeProfile;

        private void Awake()
        {
            ServiceLocator.Register<IAudioService>(this);
            InitializePool();

            if (_musicManager == null)
                _musicManager = GetComponentInChildren<MusicManager>();
        }

        private void Update()
        {
            if (_musicManager != null && _activeProfile != null)
            {
                // 1. Decay intensity naturally
                combatIntensity = Mathf.MoveTowards(combatIntensity, 0f, _intensityDecaySpeed * Time.deltaTime);

                // 2. Ask Profile for volumes
                float[] vols = _activeProfile.GetLayerVolumes(combatIntensity);

                // 3. Apply to Manager
                _musicManager.SyncVolumes(vols);
            }
        }

        private void OnDestroy()
        {
            ServiceLocator.Unregister<IAudioService>(this);
        }

        // --- IAudioService Music Implementation ---

        public void PlayMusicProfile(MusicProfileSO profile)
        {
            _activeProfile = profile;
            _musicManager?.PlayProfile(profile);
        }

        public void SetCombatIntensity(float value)
        {
            combatIntensity = Mathf.Max(combatIntensity, value);
        }

        public void StopMusic(float fadeDuration = 1f)
        {
            _musicManager?.StopMusic(fadeDuration);
        }

        // --- SFX Logic ---

        private void InitializePool()
        {
            _sfxPool = new List<AudioSource>();
            for (int i = 0; i < _initialPoolSize; i++) CreateNewSource();
        }

        private AudioSource CreateNewSource()
        {
            GameObject obj = new GameObject("SFX_Source");
            obj.transform.SetParent(transform);
            var source = obj.AddComponent<AudioSource>();

            // Isometric settings
            source.minDistance = 20f;
            source.maxDistance = 500f;
            source.rolloffMode = AudioRolloffMode.Linear;

            obj.SetActive(false);
            _sfxPool.Add(source);
            return source;
        }

        private AudioSource GetFreeSource()
        {
            foreach (var s in _sfxPool) if (!s.gameObject.activeInHierarchy) return s;
            return CreateNewSource();
        }

        public void PlaySound(Object soundDef, Vector3 position = default, float volume = 1f)
        {
            if (soundDef == null) return;
            if (soundDef is SoundDef def) PlaySFX(def, position);
            else if (soundDef is AudioClip clip) PlaySFX(clip, position, volume);
        }

        public void PlaySFX(SoundDef sound, Vector3 position)
        {
            if (sound == null) return;
            AudioClip clip = sound.GetClip();
            if (clip == null) return;

            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = sound.volume;
            source.pitch = sound.GetPitch();

            // Smart 2D/3D Blend
            float dist = Vector3.Distance(position, Camera.main.transform.position);
            source.spatialBlend = (dist < 5f) ? 0f : 1f;

            source.gameObject.SetActive(true);
            source.Play();
            StartCoroutine(DisableSourceDelayed(source, clip.length / source.pitch));
        }

        public void PlaySFX(AudioClip clip, Vector3 position, float volume = 1f)
        {
            if (clip == null) return;
            var source = GetFreeSource();
            source.transform.position = position;
            source.clip = clip;
            source.volume = volume;
            source.pitch = 1f;
            source.spatialBlend = 1f;
            source.gameObject.SetActive(true);
            source.Play();
            StartCoroutine(DisableSourceDelayed(source, clip.length));
        }

        private System.Collections.IEnumerator DisableSourceDelayed(AudioSource source, float delay)
        {
            yield return new WaitForSeconds(delay + 0.1f);
            source.gameObject.SetActive(false);
        }
    }
}