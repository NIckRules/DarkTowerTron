using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Enemy; // Access EnemyController

namespace DarkTowerTron.Combat
{
    /// <summary>
    /// Place this on Child Colliders (e.g. Head, Weakpoint).
    /// It forwards damage to the Main Controller on the Root.
    /// </summary>
    public class HitboxRelay : MonoBehaviour, IDamageable
    {
        [Header("Link")]
        [SerializeField] private EnemyController _mainController;

        [Header("Settings")]
        [SerializeField] private float _damageMultiplier = 1.0f; // 2.0 = Critical Spot

        private void Awake()
        {
            // Auto-link if empty
            if (_mainController == null)
                _mainController = GetComponentInParent<EnemyController>();
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_mainController == null) return false;

            // Apply Multiplier (e.g. Headshot)
            info.damageAmount *= _damageMultiplier;

            // Forward the hit
            return _mainController.TakeDamage(info);
        }

        public void Kill(bool instant)
        {
            if (_mainController) _mainController.Kill(instant);
        }
    }
}