using UnityEngine;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "Attack_New", menuName = "DarkTowerTron/Combat/Enemy Attack Profile")]
    public class EnemyAttackSO : ScriptableObject
    {
        [Header("Offensive Stats")]
        public float damage = 10f;
        [Min(0)] public int stagger = 1;

        [Header("Projectile Settings")]
        [Tooltip("Leave empty if this is a melee attack.")]
        public GameObject projectilePrefab;
        public float projectileSpeed = 15f;
        public float lifetime = 5f;

        [Header("Accuracy")]
        [Tooltip("0 = Perfect Aim. Higher = More spread.")]
        public float spreadAngle = 0f;
    }
}