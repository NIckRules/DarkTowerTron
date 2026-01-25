using UnityEngine;
using DG.Tweening; // Ensure you have DOTween installed/referenced
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
        private float _originalVolume = 1f;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            _originalPitch = _source.pitch;
            _originalVolume = _source.volume;
        }

        private void OnEnable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised += OnDeath;
        }

        private void OnDisable()
        {
            if (_playerDiedEvent != null) _playerDiedEvent.OnEventRaised -= OnDeath;
        }

        public void PlayMusic(AudioClip clip, float fadeDuration)
        {
            if (clip == null) return;
            if (_source.clip == clip && _source.isPlaying) return;

            _source.DOKill();

            if (_source.isPlaying)
            {
                // Crossfade
                _source.DOFade(0f, fadeDuration * 0.5f).OnComplete(() =>
                {
                    _source.clip = clip;
                    _source.Play();
                    _source.DOFade(_originalVolume, fadeDuration * 0.5f);
                });
            }
            else
            {
                // Fade In
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

        public void SetVolume(float volume)
        {
            _originalVolume = volume;
            _source.DOFade(volume, 0.5f);
        }

        private void OnDeath()
        {
            // Warren Spector / Deus Ex style death pitch shift
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true);
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }
    }
}