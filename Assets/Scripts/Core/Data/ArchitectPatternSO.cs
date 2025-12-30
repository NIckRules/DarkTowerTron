using UnityEngine;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Bosses/Architect Pattern")]
    public class ArchitectPatternSO : ScriptableObject
    {
        [Header("Phase Timings")]
        public float startDelay = 1.0f;
        public float activeDuration = 6.0f;

        [Header("Configuration")]
        public float rotationSpeed = 15f;

        [Header("Hands Configuration (Size 4)")]
        [Tooltip("True = Move Outer, False = Move Inner")]
        public bool[] extendHands;

        [Tooltip("True = Laser Wall ON")]
        public bool[] activateWalls;

        [Tooltip("True = Fire Projectiles")]
        public bool[] activeGuns; // NEW: Specific firing control

        [Header("Shooting")]
        public AttackPatternSO shootingPattern;
    }
}