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

        [Header("Abilities")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f; // Duration

        [Header("Combat Globals")]
        public float damageMultiplier = 1.0f;
        public float fireRateMultiplier = 1.0f;

        [Header("Overdrive")]
        public float overdriveThreshold = 80f; // Focus needed
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f;
    }
}