using UnityEngine;
using System;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // For Event Channels if needed
using DarkTowerTron.Core.Feedback; // Keep if Feedback system exists, otherwise remove

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Gameplay.Combat
{

    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IAimTarget
    {
        // --- EVENTS (New Architecture Requirement) ---
        public event Action OnDeath;
        public event Action<DamageInfo> OnTakeDamage;

        // --- OLD EVENTS (Kept for backward compat, but mapped to new ones) ---
        public event Action<EnemyStatsSO, bool> OnDeathProcessed;

        [Header("Debug")]
        public static bool EnableDebugGizmos = false;

        [Header("Configuration")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        [Header("Aiming")]
        [SerializeField] private Transform _aimTarget;
        [SerializeField] private float _magnetismRadius = 0.75f;

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
        public bool IsDead => _vitality != null && _vitality.IsDead;
        public bool IsStaggered => _stagger != null && _stagger.IsStaggered;

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
            if (_vitality) _vitality.Initialize(MaxHealth);
        }

        public void OnDespawn() { }

        // --- INTERFACE IMPLEMENTATION ---

        public virtual void TakeDamage(DamageInfo info)
        {
            if (IsDead) return;

            // 1. Logic Pipeline
            if (IsStaggered)
            {
                // Critical Hit or Execution Logic
                if (info.amount > 0)
                {
                    // Instant Kill on Staggered? Or Double Damage?
                    // info.amount *= 2f; 
                    // For now, let's execute:
                    Kill(false);
                    return;
                }
            }
            else
            {
                // Apply Stagger & Health Damage
                // Note: You need to decide where Stagger Amount comes from.
                // Assuming DamageInfo needs a 'staggerAmount' field added, 
                // or we derive it from damage.
                float staggerAmt = info.amount > 0 ? 1 : 0; // Simplified

                _stagger.AddStagger(staggerAmt);
                _vitality.TakeDamage(info.amount);
            }

            // 2. Feedback
            if (_hitFeedback != null) _hitFeedback.Play(gameObject, transform.position);

            // 3. Notifications
            OnTakeDamage?.Invoke(info);
        }

        public void Kill(bool immediate)
        {
            if (IsDead) return;

            // Feedback
            if (_deathFeedback != null && !immediate)
                _deathFeedback.Play(gameObject, transform.position);

            // Events
            OnDeath?.Invoke();
            OnDeathProcessed?.Invoke(_stats, true);

            // Force Vitality State
            _vitality.TakeDamage(99999f);

            // Cleanup
            if (immediate) Destroy(gameObject);
            else Destroy(gameObject, 0.1f);
        }

        // Helper Overload for simple float calls
        public void TakeDamage(float amount)
        {
            TakeDamage(new DamageInfo(amount, false, null));
        }

        private void HandleVitalityDeath()
        {
            // Triggered when HP hits 0 naturally
            Kill(false);
        }

        // --- AIM TARGET IMPLEMENTATION ---

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