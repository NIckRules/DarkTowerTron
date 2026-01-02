using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Managers;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(VitalityModule))]
    [RequireComponent(typeof(StaggerModule))]
    public class DamageReceiver : MonoBehaviour, IDamageable, IPoolable, ICombatTarget
    {
        // --- DEBUG SWITCH ---
        public static bool EnableDebugGizmos = false;

        [Header("Override")]
        public bool useOverrides = false;
        [SerializeField] private float _overrideHealth = 50f;
        [SerializeField] private int _overrideStagger = 3;

        // Dependencies
        private VitalityModule _vitality;
        private StaggerModule _stagger;
        private EnemyStatsSO _stats;

        // Events
        public event System.Action<DamageInfo> OnHitProcessed;
        public event System.Action<EnemyStatsSO, bool> OnDeathProcessed;

        // --- FACADE PROPERTIES (Data Access) ---
        public float CurrentHealth => _vitality != null ? _vitality.CurrentHealth : 0f;
        public float MaxHealth => _vitality != null ? _vitality.MaxHealth : 0f;
        public float CurrentStagger => _stagger != null ? _stagger.CurrentStagger : 0f;
        public float MaxStagger => _stagger != null ? _stagger.MaxStagger : 0f;

        public bool IsStaggered => _stagger != null && _stagger.IsStaggered;
        public bool IsDead => _vitality != null && _vitality.IsDead;

        // --- MODULE ACCESSORS (Fixes CS1061) ---
        public VitalityModule Vitality => _vitality;
        public StaggerModule Stagger => _stagger;
        // ---------------------------------------

        private void Awake()
        {
            _vitality = GetComponent<VitalityModule>();
            _stagger = GetComponent<StaggerModule>();

            // Internal Link: Ensure Vitality death triggers Main death
            if (_vitality) _vitality.OnDeath += HandleVitalityDeath;
        }

        private void OnDestroy()
        {
            if (_vitality) _vitality.OnDeath -= HandleVitalityDeath;
        }

        // --- INITIALIZATION ---
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
            else if (_stats != null)
            {
                hp = _stats.maxHealth;
                stg = _stats.maxStagger;
                decay = _stats.staggerDecay;
            }

            if (_vitality == null) _vitality = GetComponent<VitalityModule>();
            if (_stagger == null) _stagger = GetComponent<StaggerModule>();
            
            _vitality.Initialize(hp);
            _stagger.Initialize(stg, decay);
        }

        public void OnSpawn() { }

        public void OnDespawn()
        {
            if (_stagger) _stagger.ResetStagger();
        }

        // --- LOGIC PIPELINE ---
        public bool TakeDamage(DamageInfo info)
        {
            if (IsDead) return false;

            if (info.isRedirected)
            {
                Kill(true);
                return true;
            }

            if (IsStaggered)
            {
                // Damage while staggered = Execution opportunity or Bonus Damage
                // Design Choice: If gun (0 dmg) hits staggered -> No effect?
                // Or if Beam (10 dmg) hits staggered -> Instant Kill?
                if (info.damageAmount > 0) 
                {
                    Kill(true);
                }
            }
            else
            {
                _stagger.AddStagger(info.staggerAmount);
                _vitality.TakeDamage(info.damageAmount);
            }

            OnHitProcessed?.Invoke(info);
            return true;
        }

        public void Kill(bool rewardPlayer)
        {
            if (IsDead) return;
            
            // Fire event immediately
            OnDeathProcessed?.Invoke(_stats, rewardPlayer);
            
            // Force Vitality death
            _vitality.TakeDamage(99999f); 
        }

        private void HandleVitalityDeath()
        {
            // Fired when health drops to 0 naturally
            // We assume natural death grants rewards (true)
            OnDeathProcessed?.Invoke(_stats, true);
        }

        // --- ICombatTarget ---
        public void OnExecutionHit() => Kill(true);
        public bool KeepPlayerGrounded => true;

        // --- DEBUG GIZMOS ---
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
            float stg = CurrentStagger;
            float maxStg = MaxStagger;

            string hpColor = (hp < maxHp * 0.3f) ? "red" : "green";
            string stagColor = IsStaggered ? "yellow" : "cyan";

            string label = $"<color={hpColor}>HP: {hp:F0}/{maxHp:F0}</color>\n" +
                           $"<color={stagColor}>STG: {stg:F0}/{maxStg:F0}</color>";

            if (IsStaggered) label += "\n<color=yellow>[STAGGERED]</color>";

            Vector3 labelPos = transform.position + Vector3.up * 5f;
            UnityEditor.Handles.Label(labelPos, label, style);
        }
#endif
    }
}