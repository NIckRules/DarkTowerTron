using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "NewEnemyStats", menuName = "DarkTowerTron/Enemy Stats")]
    public class EnemyStatsSO : ScriptableObject
    {
        [Header("Wave Logic")]
        public bool isEssential = true;

        [Header("Rewards")]
        public int scoreValue = 100;
        public float focusReward = 30f;
        public bool healsGrit = true;
        [Min(1)] public int gritRewardAmount = 1;

        [Header("Movement")]
        public float moveSpeed = 8f;
        public float rotationSpeed = 10f; // Fast, for navigation
        public float combatRotationSpeed = 3f; // Slow, for aiming at player
        public float acceleration = 20f;

        [Header("Flight (Set 0 for Ground)")]
        public float rideHeight = 0f;
        public float verticalSmoothTime = 0.5f;

        [Header("Separation (Flocking)")]
        public float separationRadius = 1.5f;
        public float separationForce = 8f;

        [Header("Combat & Stagger")]
        public float maxHealth = 10f; // NEW: Actual HP
        [Min(1)] public int maxStagger = 3; // INT (e.g. 3 hits)
        public float staggerDecay = 1.0f; // Decay speed (1 per second)

        [Header("Defenses")]
        public bool hasFrontalShield = false;
        [Range(0f, 1f)] public float shieldAngle = 0.5f;

        // --- NEW: VALIDATION LOGIC ---
        // This runs automatically whenever you change a value in the Inspector
        private void OnValidate()
        {
            // Prevent negative movement
            moveSpeed = Mathf.Max(0f, moveSpeed);
            rotationSpeed = Mathf.Max(0f, rotationSpeed);
            combatRotationSpeed = Mathf.Max(0.1f, combatRotationSpeed);
            acceleration = Mathf.Max(0.1f, acceleration); // 0 accel = infinite stuck

            // Prevent negative rewards
            scoreValue = Mathf.Max(0, scoreValue);
            focusReward = Mathf.Max(0f, focusReward);
            gritRewardAmount = Mathf.Max(1, gritRewardAmount);

            // Prevent 0 HP zombies
            maxHealth = Mathf.Max(1f, maxHealth);

            // Stagger must be a positive integer and decay shouldn't be zero
            maxStagger = Mathf.Max(1, maxStagger);
            staggerDecay = Mathf.Max(0.01f, staggerDecay);

            // Flocking safety
            separationRadius = Mathf.Max(0.1f, separationRadius);
        }
    }
}