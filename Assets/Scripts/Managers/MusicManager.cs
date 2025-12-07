using UnityEngine;
using DG.Tweening; // For smooth pitch fade
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
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

        private void OnEnable()
        {
            GameEvents.OnPlayerDied += OnDeath;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerDied -= OnDeath;
        }

        private void Start()
        {
            // Ensure loop is on
            _source.loop = true;
            if (!_source.isPlaying) _source.Play();
        }

        private void OnDeath()
        {
            // The "Power Down" Effect
            // Drop pitch to 0.5 and volume to 0.5 over 1 second
            _source.DOPitch(_originalPitch * 0.5f, 1.0f).SetUpdate(true); // SetUpdate(true) ignores Time.timeScale = 0
            _source.DOFade(_originalVolume * 0.5f, 1.0f).SetUpdate(true);
        }

        // Called automatically when scene reloads
        public void ResetMusic()
        {
            _source.pitch = _originalPitch;
            _source.volume = _originalVolume;
        }
    }
}