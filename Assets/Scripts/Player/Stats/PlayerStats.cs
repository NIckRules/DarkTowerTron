using UnityEngine;
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
                Debug.LogError(
                    $"[PlayerStats] CRITICAL: Missing PlayerStatsSO on {name}! Drag 'Stats_Player_Default' into the inspector.",
                    gameObject);
            }
        }

        // --- MOVEMENT ---
        public float MoveSpeed => IsOverdrive
            ? (Base?.moveSpeed ?? 10f) * (Base?.overdriveSpeedMult ?? 1f)
            : (Base?.moveSpeed ?? 10f);
        public float Acceleration => Base?.acceleration ?? 50f;

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