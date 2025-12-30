using UnityEngine;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        // --- RUNTIME STATE ---
        public bool IsOverdrive { get; private set; }

        // --- MODIFIERS (For Perks later) ---
        private float _speedMod = 1f;
        private float _damageMod = 1f;
        private float _fireRateMod = 1f;
        private float _dashCostMod = 1f;

        // --- DYNAMIC PROPERTIES ---
        // These calculate the final value in real-time

        public float MoveSpeed
        {
            get
            {
                float val = baseStats.moveSpeed * _speedMod;
                if (IsOverdrive) val *= baseStats.overdriveSpeedMult;
                return val;
            }
        }

        public float Acceleration => baseStats.acceleration;

        public float DashCost => baseStats.dashCost * _dashCostMod;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown;

        public float DamageMultiplier
        {
            get
            {
                float val = baseStats.damageMultiplier * _damageMod;
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        public float FireRateMultiplier
        {
            get
            {
                float val = baseStats.fireRateMultiplier * _fireRateMod;
                if (IsOverdrive) val *= baseStats.overdriveFireRateMult;
                return val;
            }
        }

        // --- WEAPON SPECIFIC ---
        public float GunDamage => baseStats.gunDamage + (2f * (_damageMod - 1f));
        public float GunStagger => baseStats.gunStagger;
        public float GunRate => baseStats.gunFireRate / FireRateMultiplier;

        public float BeamDamage => baseStats.beamDamage * DamageMultiplier;
        public float BeamStagger => baseStats.beamStagger;
        public float BeamRate => baseStats.beamFireRate / FireRateMultiplier;

        // --- LOGIC ---
        public void SetOverdrive(bool state)
        {
            if (IsOverdrive != state)
            {
                IsOverdrive = state;
                // Optional: Fire event for UI/VFX to show Overdrive state
            }
        }

        // --- PERK API (For Phase 4) ---
        public void AddSpeedMultiplier(float amount) { _speedMod += amount; }
        public void AddDamageMultiplier(float amount) { _damageMod += amount; }
        public void AddFireRateMultiplier(float amount) { _fireRateMod += amount; }
        public void ReduceDashCost(float percent) { _dashCostMod -= percent; }

        public void ResetMods()
        {
            _speedMod = 1f;
            _damageMod = 1f;
            _fireRateMod = 1f;
            _dashCostMod = 1f;
        }
    }
}