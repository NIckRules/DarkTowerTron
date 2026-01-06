using UnityEngine;
using DG.Tweening;
using DarkTowerTron.Core; // For GameEvents

namespace DarkTowerTron.Services
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicManager : MonoBehaviour
    {
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
            // Auto-start if not playing
            if (!_source.isPlaying && _source.clip != null)
                _source.Play();
        }

        private void OnEnable()
        {
            // We can listen to Global Events here
            GameEvents.OnPlayerDied += OnDeath; // Legacy Event
            // TODO: Subscribe to 'Event_PlayerDeath' SO when migrated
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerDied -= OnDeath;
        }

        private void OnDeath()
        {
            // "Power Down" Effect
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
        }
    }
}