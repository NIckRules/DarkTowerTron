using UnityEngine;
using DarkTowerTron.Combat;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Enemy.Visuals;

// ALIAS
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Environment.Props
{
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class Prop_Explosive : MonoBehaviour
    {
        [Header("Explosive Settings")]
        public GameObject hazardZonePrefab;

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

        private void HandleHit(DarkTowerTron.Core.DamageInfo info)
        {
            // 1. Visual Flash
            if (!_receiver.IsStaggered)
                _visuals.PlayHitFlash();

            // 2. Damage Numbers (Updated Logic)
            bool isCrit = _receiver.IsStaggered;

            if (info.damageAmount > 0)
            {
                // Show Health Damage (White/Yellow)
                _damageTextEvent?.Raise(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                // Show Stagger Damage (Cyan) - Fixes the "0 Damage" issue
                _damageTextEvent?.Raise(transform.position, info.staggerAmount, false, true);
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
            Vector3 pos = transform.position;

            if (hazardZonePrefab)
                Global.Pool.Spawn(hazardZonePrefab, pos, Quaternion.identity);

            if (Global.VFX != null && Global.VFX.explosionPrefab)
                Global.Pool.Spawn(Global.VFX.explosionPrefab, pos, Quaternion.identity);

            Global.Pool.Despawn(gameObject);
        }
    }
}