using UnityEngine;
using System;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Feedback;
using DarkTowerTron.Core.Patterns; // For IPoolable

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Gameplay.Combat
{
    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IAimTarget, IPoolable, ICombatTarget
    {
        // --- EVENTS ---
        // Restored for compatibility with ArchitectHand / Props
        public event Action<DamageInfo> OnHitProcessed;
        public event Action<DamageInfo> OnTakeDamage;
        public event Action<EnemyStatsSO, bool> OnDeathProcessed;

        // New event from refactor (kept for future use)
        public event Action OnDeath;

        [Header("Debug")]
        public static bool EnableDebugGizmos = false;

        [Header("Configuration")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget;
        [SerializeField] private float _magnetismRadius = 0.75f;

        [Header("Execution Settings")]
        // Restored for EnemyController
        [SerializeField] private bool _keepPlayerGrounded = true;

        [Header("Feedback")]
        [SerializeField] private FeedbackConfigurationSO _hitFeedback;
        [SerializeField] private FeedbackConfigurationSO _deathFeedback;

        // Dependencies
        protected VitalityModule _vitality;
        protected StaggerModule _stagger;
        protected EnemyStatsSO _stats;

        // --- PROPERTIES ---
        public float CurrentHealth => _vitality != null ? _vitality.CurrentHealth : 0f;
        public float MaxHealth => _vitality != null ? _vitality.MaxHealth : 0f;

        // IDamageable Implementation
        public bool IsDead => _vitality != null && _vitality.IsDead;

        public bool IsStaggered => _stagger != null && _stagger.IsStaggered;

        // ICombatTarget Implementation
        public bool KeepPlayerGrounded => _keepPlayerGrounded;

        // Module Accessors
        public VitalityModule Vitality => _vitality;
        public StaggerModule Stagger => _stagger;

        // --- LIFECYCLE ---

        protected virtual void Awake()
        {
            _vitality = GetComponent<VitalityModule>();
            _stagger = GetComponent<StaggerModule>();

            if (_vitality) _vitality.OnDeath += HandleVitalityDeath;
        }

        protected virtual void OnDestroy()
        {
            if (_vitality) _vitality.OnDeath -= HandleVitalityDeath;
        }

        public void Initialize(EnemyStatsSO stats)
        {
            _stats = stats;
            float hp = 10f;
            int stg = 1;
            float decay = 1f;

            if (useOverrides)
            {
                hp = _overrideHealth;
                stg = _overrideStagger;
            }
            else if (stats != null)
            {
                hp = stats.maxHealth;
                stg = stats.maxStagger;
                decay = stats.staggerDecay;
            }

            _vitality?.Initialize(hp);
            _stagger?.Initialize(stg, decay);
        }

        public void OnSpawn()
        {
            // Reset state for pooling
            if (_stagger) _stagger.ResetStagger();
            if (_vitality) _vitality.Initialize(MaxHealth > 0 ? MaxHealth : 10);
        }

        public void OnDespawn()
        {
            if (_stagger) _stagger.ResetStagger();
        }

        // --- LOGIC PIPELINE ---

        public void TakeDamage(DamageInfo info)
        {
            if (IsDead) return;

            // 1. Logic
            if (IsStaggered)
            {
                // Logic: Staggered enemies take lethal damage or start execution
                if (info.damageAmount > 0)
                {
                    Kill(true);
                }
            }
            else
            {
                // Logic: Apply normal damage and stagger
                _stagger.AddStagger(info.staggerAmount);
                _vitality.TakeDamage(info.damageAmount);
            }

            // 2. Feedback
            if (_hitFeedback != null) _hitFeedback.Play(gameObject, transform.position);

            // 3. Events
            OnHitProcessed?.Invoke(info);
            OnTakeDamage?.Invoke(info);
        }

        public void Kill(bool rewardPlayer)
        {
            if (IsDead) return;

            if (_deathFeedback != null)
                _deathFeedback.Play(gameObject, transform.position);

            OnDeath?.Invoke();
            OnDeathProcessed?.Invoke(_stats, rewardPlayer);

            // Force Vitality death
            _vitality.TakeDamage(99999f);
        }

        // Helper Overload for simple float calls
        public void TakeDamage(float amount)
        {
            // FIX: Using correct arguments for DamageInfo struct
            // (amount, source, type)
            TakeDamage(new DamageInfo(amount, null, DamageType.Generic));
        }

        private void HandleVitalityDeath()
        {
            // Triggered when HP hits 0 naturally
            OnDeathProcessed?.Invoke(_stats, true);
            OnDeath?.Invoke();
        }

        // --- ICombatTarget Implementation ---
        public void OnExecutionHit() => Kill(true);

        // --- IAimTarget Implementation ---
        public Vector3 AimPoint
        {
            get
            {
                if (_aimTarget == null) return transform.position + Vector3.up * 1.0f;
                return _aimTarget.position;
            }
        }

        public float TargetRadius => _magnetismRadius;

        // --- DEBUG ---
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (!EnableDebugGizmos || !Application.isPlaying || _vitality == null) return;

            GUIStyle style = new GUIStyle();
            style.normal.textColor = Color.white;
            style.fontSize = 20;
            style.alignment = TextAnchor.MiddleCenter;
            style.fontStyle = FontStyle.Bold;

            float hp = CurrentHealth;
            float maxHp = MaxHealth;
            string hpColor = (hp < maxHp * 0.3f) ? "red" : "green";
            string label = $"<color={hpColor}>HP: {hp:F0}/{maxHp:F0}</color>";

            if (IsStaggered) label += "\n<color=yellow>[STAGGERED]</color>";

            Handles.Label(transform.position + Vector3.up * 2.5f, label, style);
        }
#endif
    }
}