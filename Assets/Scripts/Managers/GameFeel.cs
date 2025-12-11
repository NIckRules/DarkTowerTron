using UnityEngine;
using DG.Tweening; // Requires DOTween

namespace DarkTowerTron.Core
{
    public class GameFeel : MonoBehaviour
    {
        public static GameFeel Instance;

        [Header("Audio Settings")]
        [SerializeField] private AudioSource _sfxSource;
        [SerializeField] private AudioClip _hitClip;
        [SerializeField] private AudioClip _killClip;
        [SerializeField] private AudioClip _playerHurtClip;

        private Camera _childCam; // The camera we shake (Child of Rig)

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // Find the Main Camera (which should be the Child of CameraRig)
            _childCam = Camera.main;
            if (_sfxSource == null) _sfxSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            // Auto-hook into events for generic feedback
            GameEvents.OnPlayerHit += OnPlayerHit;
            GameEvents.OnEnemyKilled += OnEnemyKilled;
        }

        private void OnDisable()
        {
            GameEvents.OnPlayerHit -= OnPlayerHit;
            GameEvents.OnEnemyKilled -= OnEnemyKilled;
        }

        // --- PUBLIC API ---

        public void CameraShake(float duration, float strength)
        {
            if (_childCam == null) return;
            // Shake local position so it doesn't fight the CameraRig's smooth follow
            _childCam.transform.DOShakePosition(duration, strength, 20, 90, false, true);
        }

        public void HitStop(float duration)
        {
            if (Time.timeScale < 0.1f) return; // Don't stack stops
            StartCoroutine(DoHitStop(duration));
        }

        // Updated API: Added 'randomizePitch' bool
        public void PlaySound(AudioClip clip, float volume = 1f, bool randomizePitch = false)
        {
            if (!clip || !_sfxSource) return;

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

        // --- EVENT HANDLERS ---

        private void OnPlayerHit()
        {
            PlaySound(_playerHurtClip);
            CameraShake(0.3f, 0.5f); // Heavy shake on damage
            HitStop(0.1f);
        }

        private void OnEnemyKilled(Vector3 pos)
        {
            PlaySound(_killClip, 0.8f);
            CameraShake(0.15f, 0.2f); // Light shake on kill
        }

        // --- INTERNAL ---

        System.Collections.IEnumerator DoHitStop(float duration)
        {
            Time.timeScale = 0.0f;
            yield return new WaitForSecondsRealtime(duration);
            Time.timeScale = 1.0f;
        }
    }
}