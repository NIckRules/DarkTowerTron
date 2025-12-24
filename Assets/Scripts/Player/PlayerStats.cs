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

        // --- DYNAMIC PROPERTIES ---
        // These calculate the final value every time they are asked

        public float MoveSpeed
        {
            get
            {
                float val = baseStats.moveSpeed;
                if (IsOverdrive) val *= baseStats.overdriveSpeedMult;
                return val;
            }
        }

        public float Acceleration => baseStats.acceleration;

        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown;

        public float DamageMultiplier
        {
            get
            {
                float val = baseStats.damageMultiplier;
                if (IsOverdrive) val *= baseStats.overdriveDamageMult;
                return val;
            }
        }

        // Lower is faster for fire rate delay
        public float FireRateMultiplier
        {
            get
            {
                float val = baseStats.fireRateMultiplier;
                // Example: Overdrive makes you shoot 50% faster (multiplier 1.5x)
                // We handle the math in WeaponBase
                if (IsOverdrive) val *= 1.5f;
                return val;
            }
        }

        // --- LOGIC ---

        public void SetOverdrive(bool state)
        {
            if (IsOverdrive != state)
            {
                IsOverdrive = state;
                // Optional: Trigger Visuals/Sound here later
                Debug.Log($"Overdrive State: {state}");
            }
        }
    }
}