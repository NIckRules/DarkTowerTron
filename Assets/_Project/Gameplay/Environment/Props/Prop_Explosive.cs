using UnityEngine;
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Gameplay.Enemies;
using DarkTowerTron.Core.Services; // For ServiceLocator
using DarkTowerTron.Core.Patterns; // For IPoolService

namespace DarkTowerTron.Gameplay.Environment
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Explosive : MonoBehaviour
    {
        [Header("Explosive Settings")]
        public GameObject hazardZonePrefab;
        public GameObject explosionPrefab; // New: Explicit reference, removed Global.VFX dependency

        [Tooltip("If true, Stagger Damage from weapons is applied directly to Health.")]
        public bool volatileOnStagger = true;

        [Header("Visual Feedback")]
        [SerializeField] private DamageTextEventChannelSO _damageTextEvent;

        // References
        private DamageReceiver _receiver;
        private EnemyVisuals _visuals;

        private void Awake()
        {
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            _receiver.Initialize(null);
        }

        private void OnEnable()
        {
            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover += _visuals.StopStaggerEffect;
            }
        }

        private void OnDisable()
        {
            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= _visuals.StartStaggerEffect;
                _receiver.Stagger.OnStaggerRecover -= _visuals.StopStaggerEffect;
            }
        }

        private void HandleHit(DamageInfo info)
        {
            // 1. Visual Flash
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();

            // 2. Damage Numbers
            bool isCrit = _receiver.IsStaggered;

            if (info.damageAmount > 0)
            {
                // Show Health Damage
                _damageTextEvent?.RaiseEvent(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                // Show Stagger Damage
                _damageTextEvent?.RaiseEvent(transform.position, info.staggerAmount, false, true);
            }

            // 3. Volatile Logic
            // If this prop is volatile, Stagger actually hurts it
            if (volatileOnStagger && info.staggerAmount > 0)
            {
                _receiver.Vitality.TakeDamage(info.staggerAmount);
            }
        }

        private void HandleDeath(EnemyStatsSO stats, bool rewardPlayer)
        {
            Explode();
        }

        private void Explode()
        {
            // Resolve Pool Service
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool == null)
            {
                // Fallback: Just destroy if no pool exists (e.g. testing in isolation)
                Destroy(gameObject);
                return;
            }

            Vector3 pos = transform.position;

            // 1. Spawn Hazard (Fire/Acid on ground)
            if (hazardZonePrefab)
                pool.Spawn(hazardZonePrefab, pos, Quaternion.identity);

            // 2. Spawn Explosion Visuals
            
            if (explosionPrefab)
                pool.Spawn(explosionPrefab, pos, Quaternion.identity);

            // 3. Despawn Self
            pool.Despawn(gameObject);
        }
    }
}