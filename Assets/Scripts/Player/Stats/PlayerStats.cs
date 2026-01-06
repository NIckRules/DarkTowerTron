using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Player.Stats
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Base Configuration")]
        public PlayerStatsSO baseStats;

        public bool IsOverdrive { get; private set; }

        // Helper property to shorten null checks
        private PlayerStatsSO Base => baseStats;

        private void Awake()
        {
            if (baseStats == null)
            {
                GameLogger.LogError(LogChannel.Player,
                    $"[PlayerStats] CRITICAL: Missing PlayerStatsSO on {name}! Drag 'Stats_Player_Default' into the inspector.",
                    gameObject);
            }
        }

        // --- MOVEMENT & PHYSICS ---
        public float MoveSpeed => IsOverdrive
            ? (Base?.moveSpeed ?? 12f) * (Base?.overdriveSpeedMult ?? 1f)
            : (Base?.moveSpeed ?? 12f);
        public float Acceleration => Base?.acceleration ?? 60f;
        public float Deceleration => Base?.deceleration ?? 40f;
        public float RotationSpeed => Base?.rotationSpeed ?? 25f;
        public float Gravity => Base?.gravity ?? 20f;
        public float WallRepulsion => Base?.wallRepulsionForce ?? 5f;
        public float ActionHangTime => Base?.actionHangTime ?? 0.2f;

        // --- SCANNER ---
        public float ScanRange => Base?.scanRange ?? 25f;
        public float ScanRadius => Base?.scanRadius ?? 2f;

        // --- ABILITIES ---
        public float DashCost => Base?.dashCost ?? 0f;
        public float DashDistance => Base?.dashDistance ?? 0f;
        public float DashDuration => Base?.dashCooldown ?? 0f;

        // --- WEAPON: GUN ---
        public float GunDamage => IsOverdrive
            ? (Base?.gunDamage ?? 1f) * (Base?.overdriveDamageMult ?? 1f)
            : (Base?.gunDamage ?? 1f);
        public int GunStagger => Base?.gunStagger ?? 0;
        // Rate: Lower is faster. If OverdriveMult is 1.5 (Faster), we divide the delay.
        public float GunRate => IsOverdrive
            ? (Base?.gunFireRate ?? 0.2f) / (Base?.overdriveFireRateMult ?? 1f)
            : (Base?.gunFireRate ?? 0.2f);

        // --- WEAPON: BEAM ---
        public float BeamDamage => IsOverdrive
            ? (Base?.beamDamage ?? 1f) * (Base?.overdriveDamageMult ?? 1f)
            : (Base?.beamDamage ?? 1f);
        public int BeamStagger => Base?.beamStagger ?? 0;
        public float BeamRate => IsOverdrive
            ? (Base?.beamFireRate ?? 0.2f) / (Base?.overdriveFireRateMult ?? 1f)
            : (Base?.beamFireRate ?? 0.2f);

        // --- RESOURCES ---
        public int MaxGrit => Base?.maxGrit ?? 3;
        public float MaxFocus => Base?.maxFocus ?? 100f;
        
        // Future proofing: Modifiers could change these later
        public float FocusDecayRate => Base?.focusDecayRate ?? 5f; 
        public float BaseFocusOnKill => Base?.baseFocusOnKill ?? 20f;

        public void SetOverdrive(bool state)
        {
            IsOverdrive = state;
        }
    }
}