using UnityEngine;
using UnityEngine.Serialization;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "PlayerStats_Default", menuName = "DarkTowerTron/Player/Base Stats")]
    public class PlayerStatsSO : ScriptableObject
    {
        [Header("Movement")]
        public float moveSpeed = 12f;
        public float acceleration = 60f;
        public float deceleration = 40f;
        public float rotationSpeed = 25f;

        [Header("Physics & Feel")]
        public float gravity = 20f;
        public float wallRepulsionForce = 5f;
        [Tooltip("Time gravity is suspended after a dash/kill")]
        [FormerlySerializedAs("postActionHangTime")]
        public float actionHangTime = 0.2f;

        [Header("Scanner")]
        public float scanRange = 25f;
        public float scanRadius = 2f;

        [Header("Resources")]
        public int maxGrit = 2;
        public float maxFocus = 100f;
        public float focusDecayRate = 5f;       // Moved here
        public float baseFocusOnKill = 30f;     // Moved here (Default reward)

        [Header("Dash / Dodge")]
        public float dashCost = 25f;
        public float dashDistance = 8f;
        public float dashCooldown = 0.15f;

        [Header("Weapon: Gun (Ranged)")]
        public float gunFireRate = 0.15f;
        public float gunDamage = 0f;    // Usually 0 for this game
        [Min(0)] public int gunStagger = 1; // 1 shot = 1 point

        [Header("Weapon: Beam (Melee)")]
        public float beamFireRate = 0.4f;
        public float beamDamage = 10f;
        [Min(0)] public int beamStagger = 1; // 1 hit = 1 point

        // --- Validation ---
        private void OnValidate()
        {
            moveSpeed = Mathf.Max(0f, moveSpeed);
            acceleration = Mathf.Max(0.01f, acceleration);
            deceleration = Mathf.Max(0f, deceleration);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);

            gravity = Mathf.Max(0f, gravity);
            wallRepulsionForce = Mathf.Max(0f, wallRepulsionForce);
            actionHangTime = Mathf.Max(0f, actionHangTime);

            scanRange = Mathf.Max(0f, scanRange);
            scanRadius = Mathf.Max(0f, scanRadius);

            maxGrit = Mathf.Max(1, maxGrit);
            maxFocus = Mathf.Max(0f, maxFocus);
            focusDecayRate = Mathf.Max(0f, focusDecayRate);
            baseFocusOnKill = Mathf.Max(0f, baseFocusOnKill);

            dashCost = Mathf.Max(0f, dashCost);
            dashDistance = Mathf.Max(0f, dashDistance);
            dashCooldown = Mathf.Max(0.001f, dashCooldown);

            gunFireRate = Mathf.Max(0.001f, gunFireRate);
            gunDamage = Mathf.Max(0f, gunDamage);
            gunStagger = Mathf.Max(0, gunStagger);

            beamFireRate = Mathf.Max(0.001f, beamFireRate);
            beamDamage = Mathf.Max(0f, beamDamage);
            beamStagger = Mathf.Max(0, beamStagger);

            overdriveThreshold = Mathf.Clamp(overdriveThreshold, 0f, 100f);
            overdriveSpeedMult = Mathf.Max(0.01f, overdriveSpeedMult);
            overdriveDamageMult = Mathf.Max(0f, overdriveDamageMult);
            overdriveFireRateMult = Mathf.Max(0.01f, overdriveFireRateMult);
        }

        [Header("Overdrive Modifiers")]
        public float overdriveThreshold = 80f;
        public float overdriveSpeedMult = 1.2f;
        public float overdriveDamageMult = 2.0f; // Doubles damage
        public float overdriveFireRateMult = 1.5f; // Shoots faster (Multiplier > 1 means faster)
    }
}