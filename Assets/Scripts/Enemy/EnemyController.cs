using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services; // Services.Pool / Audio
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.Visuals; // NEW

namespace DarkTowerTron.Enemy
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))] // NEW DEPENDENCY
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyVisuals _visuals; // NEW
        private EnemyStatsSO _stats;

        [Header("Broadcasting")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Audio")]
        public AudioClip staggerClip;

        // Facade Property
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;
        public EnemyVisuals Visuals => _visuals;

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Initialization Safety
            if (_receiver != null && _stats != null && _receiver.CurrentHealth <= 0)
            {
                _receiver.Initialize(_stats);
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            _receiver.Initialize(_stats);
            _visuals.ResetVisuals(); // Reset colors
        }

        public void OnDespawn()
        {
            // Visuals handle their own tween killing in Reset/OnDestroy, 
            // but we call Reset here to be safe before pooling.
            _visuals.ResetVisuals();
        }

        private void OnEnable()
        {
            _receiver.OnHitProcessed += HandleHit;
            _receiver.OnDeathProcessed += HandleDeath;
            
            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak += HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover += HandleStaggerExit;
            }
        }
        
        private void OnDisable()
        {
            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;
            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
            }
        }

        // --- HANDLERS ---
        
        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);
            
            // DELEGATE TO VISUALS
            if (!IsStaggered) _visuals.PlayHitFlash();
            
            bool isCrit = IsStaggered;
            GameEvents.OnDamageDealt?.Invoke(transform.position, info.damageAmount, isCrit);
        }

        private void HandleStaggerEnter()
        {
            GameEvents.OnPopupText?.Invoke(transform.position, "STAGGER");

            if (Services.Audio != null && staggerClip)
                Services.Audio.PlaySound(staggerClip, 1f, true);

            // DELEGATE TO VISUALS
            _visuals.StartStaggerEffect();
        }

        private void HandleStaggerExit()
        {
            // DELEGATE TO VISUALS
            _visuals.StopStaggerEffect();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            if (_enemyKilledEvent != null)
                _enemyKilledEvent.Raise(transform.position, stats, reward);
            
            if (Services.Pool != null) Services.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }

        // --- INTERFACES ---
        public bool TakeDamage(DamageInfo info) => _receiver.TakeDamage(info);
        public void Kill(bool instant) => _receiver.Kill(true); 
        public void SelfDestruct() => _receiver.Kill(false);    
        public void OnExecutionHit() => _receiver.Kill(true); 
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
    }
}