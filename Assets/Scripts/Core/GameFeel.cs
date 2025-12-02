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
        public AudioClip swingClip; // NEW
        public AudioClip playerHurtClip; // NEW: Player Ouch

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

        public void PlaySwing()
        {
            if (swingClip && source)
            {
                // Slight pitch randomization makes it sound organic
                source.pitch = Random.Range(0.9f, 1.1f);
                source.PlayOneShot(swingClip);
            }
        }

        public void PlayKill()
        {
            if(killClip && source) source.PlayOneShot(killClip);
        }

        public void PlayPlayerHurt()
        {
            if(playerHurtClip && source) source.PlayOneShot(playerHurtClip);
        }
    }
}
