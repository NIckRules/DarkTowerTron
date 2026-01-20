using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.Core.AudioSystem
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
        [Header("Listening")]
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;

        private AudioSource _source;
        private float _originalPitch;
        private float _originalVolume;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void Start()
        {
            if (!_source.isPlaying && _source.clip != null)
                _source.Play();
        }

        private void OnEnable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnDeath;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnDeath;
        }

        // --- NEW METHODS (Fixes Error CS1061) ---

        public void PlayMusic(AudioClip clip, float fadeDuration)
        {
            if (clip == null) return;
            if (_source.clip == clip && _source.isPlaying) return;

            _source.DOKill();

            if (_source.isPlaying)
            {
                // Crossfade: Fade Out -> Swap -> Fade In
                _source.DOFade(0f, fadeDuration * 0.5f).OnComplete(() =>
                {
                    _source.clip = clip;
                    _source.Play();
                    _source.DOFade(_originalVolume, fadeDuration * 0.5f);
                });
            }
            else
            {
                // Just Fade In
                _source.clip = clip;
                _source.volume = 0f;
                _source.Play();
                _source.DOFade(_originalVolume, fadeDuration);
            }
        }

        public void StopMusic(float fadeDuration)
        {
            _source.DOKill();
            _source.DOFade(0f, fadeDuration).OnComplete(() => _source.Stop());
        }

        // ----------------------------------------

        private void OnDeath()
        {
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true);
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }

        public void ResetMusic()
        {
            _source.DOKill();
            _source.pitch = _originalPitch;
            _source.volume = _originalVolume;
        }

        public void SetVolume(float volume)
        {
            _source.volume = volume;
            _originalVolume = volume; // Update "Original" so fades return to this level
        }
    }
}