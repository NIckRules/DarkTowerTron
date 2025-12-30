using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "PlayerStats_Default", menuName = "DarkTowerTron/Player/Base Stats")]
    public class PlayerStatsSO : ScriptableObject
    {
        [Header("Movement")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;

        [Header("Resources")]
        public int maxGrit = 2;
        public float maxFocus = 100f;

        [Header("Dash / Dodge")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f;

        [Header("Weapon: Gun (Ranged)")]
        public float gunFireRate = 0.15f;
        public float gunDamage = 0f;    // Usually 0 for this game
        public float gunStagger = 0.4f; // High stagger to setup kills

        [Header("Weapon: Beam (Melee)")]
        public float beamFireRate = 0.4f;
        public float beamDamage = 10f;
        public float beamStagger = 0.4f;

        [Header("Overdrive Modifiers")]
        public float overdriveThreshold = 80f;
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f; // Doubles damage
        public float overdriveFireRateMult = 1.5f; // Shoots faster (Multiplier > 1 means faster)
    }
}