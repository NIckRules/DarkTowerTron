using UnityEngine;
using UnityEngine.Audio;
using DG.Tweening;

namespace DarkTowerTron.Core.AudioSystem
{
    public class MusicManager : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private AudioMixerGroup _musicMixerGroup;

        private AudioSource[] _stemSources;
        private MusicProfileSO _currentProfile; // CHANGED from ThemeSO

        private void Awake() => InitializeStemSources();

        private void InitializeStemSources()
        {
            foreach (Transform child in transform) Destroy(child.gameObject);

            int layerCount = 4;
            _stemSources = new AudioSource[layerCount];

            for (int i = 0; i < layerCount; i++)
            {
                GameObject child = new GameObject($"Stem_Source_{((MusicLayer)i)}");
                child.transform.SetParent(transform);

                AudioSource source = child.AddComponent<AudioSource>();
                source.outputAudioMixerGroup = _musicMixerGroup;
                source.loop = true;
                source.playOnAwake = false;
                source.volume = 0f;
                source.spatialBlend = 0f;

                _stemSources[i] = source;
            }
        }

        // 1. Load the Clips
        public void PlayProfile(MusicProfileSO profile)
        {
            if (profile == null || profile == _currentProfile) return;
            _currentProfile = profile;

            // Stop, Swap, Sync-Play
            for (int i = 0; i < _stemSources.Length; i++)
            {
                _stemSources[i].Stop();
                _stemSources[i].clip = profile.GetClip(i);
            }

            // Sync Play
            for (int i = 0; i < _stemSources.Length; i++)
            {
                if (_stemSources[i].clip != null) _stemSources[i].Play();
            }
        }

        // 2. Apply Volumes (Called every frame by AudioService)
        public void SyncVolumes(float[] targetVolumes)
        {
            if (targetVolumes.Length != _stemSources.Length) return;

            for (int i = 0; i < _stemSources.Length; i++)
            {
                // Smooth lerp to avoid popping if intensity jumps
                _stemSources[i].volume = Mathf.Lerp(_stemSources[i].volume, targetVolumes[i], Time.deltaTime * 3f);
            }
        }

        public void StopMusic(float duration)
        {
            foreach (var source in _stemSources)
                source.DOFade(0f, duration).OnComplete(() => source.Stop());
        }
    }
}