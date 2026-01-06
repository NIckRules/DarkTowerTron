using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Events;
using DG.Tweening;

namespace DarkTowerTron.Player.Movement
{
    public class AfterImage : MonoBehaviour, IDamageable, ICombatTarget
    {
        [Header("Broadcasting")]
        [SerializeField] private TransformEventChannelSO _decoySpawnedEvent;
        [SerializeField] private VoidEventChannelSO _decoyExpiredEvent;

        [Header("Stats")]
        public float lifetime = 1.0f;
        public float health = 10f; // Default hp

        // State
        private bool _isDead = false;
        private Tween _fadeTween;

        // ICombatTarget
        public bool IsStaggered => false; // Decoys cannot be staggered
        public bool KeepPlayerGrounded => false;
        // Transform property is inherited from MonoBehaviour

        private void Start()
        {
            // 1. Notify AI
            _decoySpawnedEvent?.Raise(transform);

            // 2. Visual Fade
            Renderer rend = GetComponentInChildren<Renderer>();
            if (rend)
            {
                // Ensure we don't crash if material is missing
                _fadeTween = rend.material.DOFade(0f, lifetime).SetEase(Ease.Linear);
            }

            // 3. Schedule Death (Use Invoke to be safe against Tween errors)
            Invoke(nameof(Expire), lifetime);
        }

        private void OnDestroy()
        {
            // Cleanup
            if (_fadeTween != null) _fadeTween.Kill();

            _decoyExpiredEvent?.Raise();
        }

        public void OnExecutionHit()
        {
            // If player attacks their own decoy, pop it
            Kill(true);
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_isDead) return false;

            // Take damage
            health -= info.damageAmount;

            // Visual Shake (Feedback)
            transform.DOPunchScale(Vector3.one * 0.2f, 0.1f);

            if (health <= 0)
            {
                Kill(false);
            }
            
            // Return true so bullets register a hit and despawn
            return true; 
        }

        public void Kill(bool instant)
        {
            if (_isDead) return;
            _isDead = true;

            // Optional: Play "Pop" sound here via Services.Audio

            Destroy(gameObject);
        }

        private void Expire()
        {
            Kill(false);
        }
    }
}