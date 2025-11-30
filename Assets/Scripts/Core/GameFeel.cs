using UnityEngine;
using System.Collections;
using DG.Tweening; // Ensure DOTween is imported

namespace DarkTowerTron.Core
{
    public class GameFeel : MonoBehaviour
    {
        public static GameFeel instance;

        [Header("Audio")]
        public AudioSource source;
        public AudioClip hitClip;  // Drag your "Thwack" sound here
        public AudioClip killClip; // Drag your "Boom" sound here

        void Awake()
        {
            instance = this;
            if(source == null) source = GetComponent<AudioSource>();
        }

        // 1. FREEZE FRAME (The "Zelda" pause)
        public void HitStop(float duration)
        {
            if (Time.timeScale < 1) return; // Prevent stacking
            StartCoroutine(DoHitStop(duration));
        }

        IEnumerator DoHitStop(float duration)
        {
            Time.timeScale = 0.0f; // Freeze
            yield return new WaitForSecondsRealtime(duration); // Ignore timescale
            Time.timeScale = 1.0f; // Unfreeze
        }

        // 2. SCREEN SHAKE (DOTween)
        public void CameraShake(float duration, float strength)
        {
            // Shake position, randomness 90, snapping false, fade out true
            if (Camera.main != null)
            {
                Camera.main.transform.DOShakePosition(duration, strength, 20, 90, false, true);
            }
        }

        // 3. SOUND
        public void PlayHit()
        {
            if(hitClip && source) source.PlayOneShot(hitClip);
        }

        public void PlayKill()
        {
            if(killClip && source) source.PlayOneShot(killClip);
        }
    }
}
