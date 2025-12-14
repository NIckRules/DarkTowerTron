using UnityEngine;

namespace DarkTowerTron.Managers
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        [Header("Sources")]
        [SerializeField] private AudioSource _sfxSource;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// Plays a sound with optional pitch randomization.
        /// </summary>
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (clip == null || _sfxSource == null) return;

            if (randomizePitch)
            {
                _sfxSource.pitch = Random.Range(0.9f, 1.1f);
            }
            else
            {
                _sfxSource.pitch = 1.0f;
            }

            _sfxSource.PlayOneShot(clip, volume);
        }
    }
}