using UnityEngine;

namespace DarkTowerTron.Utils
{
    [RequireComponent(typeof(AudioSource))]
    public class MusicControl : MonoBehaviour
    {
        private AudioSource source;
        private float originalPitch;

        void Start()
        {
            source = GetComponent<AudioSource>();
            originalPitch = source.pitch;
        }

        public void OnGameOver()
        {
            // Pitch down the music to sound like a dying machine
            source.pitch = 0.5f;
            source.volume = source.volume * 0.5f;
        }

        public void OnRestart()
        {
            source.pitch = originalPitch;
            // Reset volume (assuming 0.3 was your default)
            source.volume = 0.3f;
        }
    }
}