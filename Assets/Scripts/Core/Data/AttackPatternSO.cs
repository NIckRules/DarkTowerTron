using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    // Define Enum here so it's accessible
    public enum AimType
    {
        TargetPlayer,   // Guardian style (Aim at player)
        ForwardRadial   // Boss style (Shoot straight out from hand)
    }

    [CreateAssetMenu(menuName = "DarkTowerTron/Combat/Attack Pattern")]
    public class AttackPatternSO : ScriptableObject
    {
        [Header("Aiming & Visuals")]
        public AimType aimMode = AimType.TargetPlayer;
        public float scaleMultiplier = 1.0f; // Boss bullets are huge
        public float speed = 15f;            // Projectile speed

        [Header("Pattern Shape")]
        public int projectileCount = 1;      // How many bullets per "Trigger"
        [Range(0, 360)] public float spreadAngle = 0f;
        public bool spinDuringFire = false;
        public float spinSpeed = 0f;

        [Header("Timing")]
        public float startDelay = 0.5f;      // Windup time
        public float delayBetweenShots = 0.1f; // Time between individual bullets in a burst/stream
    }
}