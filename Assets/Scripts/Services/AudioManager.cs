using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core; // For GameLogger

namespace DarkTowerTron.Core.Services
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        // REMOVED: public static AudioManager Instance;

        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            // REMOVED: Singleton check
            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        public void PlaySound(SoundDef soundDef)
        {
            if (soundDef == null || _sfxSource == null) return;

            AudioClip clip = soundDef.GetClip();
            if (clip == null) return;

            _sfxSource.pitch = soundDef.GetPitch();
            _sfxSource.PlayOneShot(clip, soundDef.volume);
        }

        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;
            _sfxSource.pitch = randomizePitch ? Random.Range(0.9f, 1.1f) : 1f;
            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}