using UnityEngine;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        public bool IsOverdrive { get; private set; }

        // --- MOVEMENT ---
        public float MoveSpeed => IsOverdrive ? baseStats.moveSpeed * baseStats.overdriveSpeedMult : baseStats.moveSpeed;
        public float Acceleration => baseStats.acceleration;

        // --- ABILITIES ---
        public float DashCost => baseStats.dashCost;
        public float DashDistance => baseStats.dashDistance;
        public float DashDuration => baseStats.dashCooldown;

        // --- WEAPON: GUN ---
        public float GunDamage => IsOverdrive ? baseStats.gunDamage * baseStats.overdriveDamageMult : baseStats.gunDamage;
        public float GunStagger => IsOverdrive ? baseStats.gunStagger * baseStats.overdriveDamageMult : baseStats.gunStagger;
        // Rate: Lower is faster. If OverdriveMult is 1.5 (Faster), we divide the delay.
        public float GunRate => IsOverdrive ? baseStats.gunFireRate / baseStats.overdriveFireRateMult : baseStats.gunFireRate;

        // --- WEAPON: BEAM ---
        public float BeamDamage => IsOverdrive ? baseStats.beamDamage * baseStats.overdriveDamageMult : baseStats.beamDamage;
        public float BeamStagger => IsOverdrive ? baseStats.beamStagger * baseStats.overdriveDamageMult : baseStats.beamStagger;
        public float BeamRate => IsOverdrive ? baseStats.beamFireRate / baseStats.overdriveFireRateMult : baseStats.beamFireRate;

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }
    }
}