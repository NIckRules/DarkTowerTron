using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Systems.Stats; // NEW Namespace

namespace DarkTowerTron.Player.Stats
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Configuration")]
        public PlayerStatsSO baseStats; // The Template

        // --- The Dynamic Stats ---
        private Dictionary<StatType, ModifiableStat> _stats = new Dictionary<StatType, ModifiableStat>();
        private HashSet<AbilityType> _unlockedAbilities = new HashSet<AbilityType>();

        // Event for UI (e.g. Health bar needs to grow)
        public event System.Action OnStatsChanged;

        private void Awake()
        {
            InitializeStats();
        }

        private void InitializeStats()
        {
            if (baseStats == null) return;

            // Initialize from SO
            _stats[StatType.MoveSpeed] = new ModifiableStat(baseStats.moveSpeed);
            _stats[StatType.Acceleration] = new ModifiableStat(baseStats.acceleration);
            _stats[StatType.DashCooldown] = new ModifiableStat(baseStats.dashCooldown);
            _stats[StatType.MaxGrit] = new ModifiableStat(baseStats.maxGrit);
            _stats[StatType.GunDamage] = new ModifiableStat(baseStats.gunDamage);
            _stats[StatType.BeamDamage] = new ModifiableStat(baseStats.beamDamage);
            // Add others...
        }

        // --- PUBLIC ACCESSORS (The "Facade") ---
        // Keeps the rest of your code working without changes

        // Scanner
        public float ScanRange => baseStats.scanRange;
        public float ScanRadius => baseStats.scanRadius;

        // Overdrive
        public bool IsOverdrive { get; private set; }

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }

        // --- UPDATED ACCESSORS (With Overdrive Math) ---

        public float MoveSpeed
        {
            get
            {
                float val = GetValue(StatType.MoveSpeed);
                if (IsOverdrive) val *= baseStats.overdriveSpeedMult;
                return val;
            }
        }
        public float Acceleration => GetValue(StatType.Acceleration);
        public float Deceleration => baseStats.deceleration; // Some don't change
        public float RotationSpeed => baseStats.rotationSpeed;
        public float Gravity => baseStats.gravity;
        public float WallRepulsion => baseStats.wallRepulsionForce;
        public float ActionHangTime => baseStats.actionHangTime;

        // Abilities
        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown; // Duration is base; cooldown mods affect frequency
        public float DashCooldown => GetValue(StatType.DashCooldown);

        // Combat
        public float GunDamage
        {
            get
            {
                float val = GetValue(StatType.GunDamage);
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        // Rate is inverted (Lower is Faster)
        public float GunRate
        {
            get
            {
                float val = baseStats.gunFireRate;
                // If Overdrive makes it faster, we DIVIDE the delay
                if (IsOverdrive) val /= baseStats.overdriveFireRateMult;
                return val;
            }
        }
        public int GunStagger => baseStats.gunStagger;

        public float BeamDamage
        {
            get
            {
                float val = GetValue(StatType.BeamDamage);
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        public float BeamRate
        {
            get
            {
                float val = baseStats.beamFireRate;
                if (IsOverdrive) val /= baseStats.overdriveFireRateMult;
                return val;
            }
        }
        public int BeamStagger => baseStats.beamStagger;

        public int MaxGrit => Mathf.RoundToInt(GetValue(StatType.MaxGrit));
        public float MaxFocus => baseStats.maxFocus; // Could mod this
        public float FocusDecayRate => baseStats.focusDecayRate;
        public float BaseFocusOnKill => baseStats.baseFocusOnKill;


        // --- PERK SYSTEM ---

        // Tracks perks applied during the current session/run.
        public List<PerkSO> ActivePerks { get; private set; } = new List<PerkSO>();

        public void ApplyPerk(PerkSO perk)
        {
            if (perk == null) return;

            ActivePerks.Add(perk);

            // 1. Apply Stats
            foreach (var mod in perk.statModifiers)
            {
                if (_stats.TryGetValue(mod.targetStat, out var stat))
                {
                    if (mod.type == ModifierType.Additive) stat.AddModifier(mod.value);
                    else stat.AddMultiplier(mod.value);
                }
            }

            // 2. Unlock Abilities
            foreach (var ability in perk.abilitiesToUnlock)
            {
                _unlockedAbilities.Add(ability);
            }

            OnStatsChanged?.Invoke();
        }

        public bool HasAbility(AbilityType ability)
        {
            return _unlockedAbilities.Contains(ability);
        }

        // Helper
        private float GetValue(StatType type)
        {
            if (_stats.TryGetValue(type, out var stat)) return stat.Value;
            return 0f;
        }

        // Overdrive is handled in accessors above.
    }
}