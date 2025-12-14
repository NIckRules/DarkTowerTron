using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Pattern Shape")]
        public int projectileCount = 1;
        [Range(0, 360)] public float spreadAngle = 0f; // 0 = Stream, 360 = Nova
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float delayBetweenShots = 0.1f; // Machine gun vs Shotgun
        public float startDelay = 0.5f; // Windup time

        [Header("Projectile Override")]
        public float speed = 15f;
        // Optional: Custom prefab for this specific attack? 
        // For now, we use the Agent's default prefab to keep it simple.
    }
}