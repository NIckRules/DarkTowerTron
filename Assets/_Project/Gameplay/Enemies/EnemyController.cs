using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Patterns; 
using DarkTowerTron.Gameplay.Combat;
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Gameplay.Enemies
{
    [RequireComponent(typeof(EnemyMotor))]
    [RequireComponent(typeof(DamageReceiver))]
    [RequireComponent(typeof(EnemyVisuals))]
    public class EnemyController : MonoBehaviour, IPoolable, ICombatTarget
    {
        // --- Dependencies ---
        private DamageReceiver _receiver;
        private EnemyMotor _motor;
        private EnemyVisuals _visuals;
        private EnemyStatsSO _stats;

        // --- Event Wiring ---
        [Header("Broadcasting")]
        [Tooltip("Notifies ScoreManager and WaveDirector when this enemy dies.")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;

        [Header("Visual Feedback")]
        [Tooltip("Spawns floating damage numbers.")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;

        [Tooltip("Spawns status text (e.g. STAGGER).")]
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Audio")]
        public AudioClip staggerClip;

        // --- Public Accessors ---
        public bool IsStaggered => _receiver != null && _receiver.IsStaggered;
        public EnemyVisuals Visuals => _visuals;

        // --- Lifecycle ---

        private void Awake()
        {
            _motor = GetComponent<EnemyMotor>();
            _receiver = GetComponent<DamageReceiver>();
            _visuals = GetComponent<EnemyVisuals>();
        }

        private void Start()
        {
            if (_motor != null) _stats = _motor.stats;

            // Self-Initialization safety check (if placed in scene manually)
            if (_receiver != null && _stats != null && _receiver.CurrentHealth <= 0)
            {
                _receiver.Initialize(_stats);
            }
        }

        public void OnSpawn()
        {
            if (_motor != null) _stats = _motor.stats;
            
            // Reset Modules
            _receiver.Initialize(_stats);
            _visuals.ResetVisuals();
        }

        public void OnDespawn()
        {
            _visuals.ResetVisuals();
        }

        private void OnEnable()
        {
            if (_receiver == null) return;

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
            if (_receiver == null) return;

            _receiver.OnHitProcessed -= HandleHit;
            _receiver.OnDeathProcessed -= HandleDeath;

            if (_receiver.Stagger != null)
            {
                _receiver.Stagger.OnStaggerBreak -= HandleStaggerEnter;
                _receiver.Stagger.OnStaggerRecover -= HandleStaggerExit;
            }
        }

        // --- Handlers ---

        private void HandleHit(DamageInfo info)
        {
            _motor.ApplyKnockback(info.pushDirection * info.pushForce);

            // Visuals
            if (!IsStaggered) _visuals.PlayHitFlash();

            bool isCrit = IsStaggered;

            // Logic: Distinguish Health Damage vs Stagger Damage
            if (info.damageAmount > 0)
            {
                _damageEvent?.RaiseEvent(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                _damageEvent?.RaiseEvent(transform.position, info.staggerAmount, false, true);
            }
        }

        private void HandleStaggerEnter()
        {
            _popupEvent?.RaiseEvent(transform.position, "STAGGER");

            // Audio via Service Locator
            var audio = ServiceLocator.Get<IAudioService>();
            if (audio != null && staggerClip)
                audio.PlaySound(staggerClip, transform.position, 1f);

            _visuals.StartStaggerEffect();
        }

        private void HandleStaggerExit()
        {
            _visuals.StopStaggerEffect();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            // Notify Game Logic (Wave Director / Score)
            _enemyKilledEvent?.RaiseEvent(transform.position, stats, reward);

            // Despawn
            var pool = ServiceLocator.Get<IPoolService>();
            if (pool != null) 
                pool.Despawn(gameObject);
            else 
                Destroy(gameObject);
        }

        // --- Interface Implementation ---
        public void TakeDamage(DamageInfo info) => _receiver.TakeDamage(info);
        public void Kill(bool instant) => _receiver.Kill(true);
        public void SelfDestruct() => _receiver.Kill(false);
        public void OnExecutionHit() => _receiver.Kill(true);
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
        public bool IsDead => _receiver.IsDead;
    }
}