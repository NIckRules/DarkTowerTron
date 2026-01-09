using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // Event Channels
using DarkTowerTron.Combat;
using DarkTowerTron.Enemy.Visuals;
using DarkTowerTron;

namespace DarkTowerTron.Enemy
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

            // Self-Initialization safety check
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
            // Note: Shooting coroutines in PatternExecutor are automatically killed 
            // when the GameObject is disabled/despawned.
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

            // LOGIC FIX:
            // If Health damage is > 0, we show Health Damage (White/Yellow).
            // If Health damage is 0 but Stagger > 0, we show Stagger Damage (Cyan).
            if (info.damageAmount > 0)
            {
                _damageEvent?.Raise(transform.position, info.damageAmount, isCrit, false);
            }
            else if (info.staggerAmount > 0)
            {
                _damageEvent?.Raise(transform.position, info.staggerAmount, false, true);
            }
        }

        private void HandleStaggerEnter()
        {
            // Popup Text (New Event System)
            _popupEvent?.Raise(transform.position, "STAGGER");

            // Audio via Service Locator
            if (Global.Audio != null && staggerClip)
                Global.Audio.PlaySound(staggerClip, 1f, true);

            _visuals.StartStaggerEffect();
        }

        private void HandleStaggerExit()
        {
            _visuals.StopStaggerEffect();
        }

        private void HandleDeath(EnemyStatsSO stats, bool reward)
        {
            // Notify Game Logic (Wave Director / Score)
            _enemyKilledEvent?.Raise(transform.position, stats, reward);

            // Despawn
            if (Global.Pool != null) Global.Pool.Despawn(gameObject);
            else Destroy(gameObject);
        }

        // --- Interface Implementation ---
        public bool TakeDamage(DamageInfo info) => _receiver.TakeDamage(info);
        public void Kill(bool instant) => _receiver.Kill(true);
        public void SelfDestruct() => _receiver.Kill(false);
        public void OnExecutionHit() => _receiver.Kill(true);
        public bool KeepPlayerGrounded => _receiver.KeepPlayerGrounded;
    }
}