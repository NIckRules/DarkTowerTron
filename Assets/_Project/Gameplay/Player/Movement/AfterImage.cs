using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Combat; // Required for IDamageable

namespace DarkTowerTron.Gameplay.Player
{
    public class AfterImage : MonoBehaviour, IDamageable
    {
        [Header("Settings")]
        [SerializeField] private float _lifetime = 1f;

        [Header("Events")]
        [SerializeField] private VoidEventChannelSO _onReturnToPool;

        private float _timer;

        // --- IDamageable Implementation ---

        public bool IsDead => false; // AfterImages don't really "die", they vanish

        public void TakeDamage(DamageInfo info)
        {
            // If an enemy hits the afterimage, we might want to destroy it immediately
            // or play a "poof" sound.
            FinishEffect();
        }

        public void Kill(bool immediate)
        {
            FinishEffect();
        }

        // ----------------------------------

        private void OnEnable()
        {
            _timer = _lifetime;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                FinishEffect();
            }
        }

        private void FinishEffect()
        {
            gameObject.SetActive(false);
            if (_onReturnToPool != null)
                _onReturnToPool.RaiseEvent();
        }
    }
}