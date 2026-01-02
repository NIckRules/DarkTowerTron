using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Combat
{
    public class HitboxRelay : MonoBehaviour, IDamageable
    {
        [Header("Link")]
        // CHANGED: Serialized Object reference, cast to Interface at runtime
        // Why GameObject? Unity can't serialize Interfaces directly in Inspector easily.
        [SerializeField] private GameObject _mainControllerObject;

        private IDamageable _mainController;

        [Header("Settings")]
        [SerializeField] private float _damageMultiplier = 1.0f;

        private void Awake()
        {
            // Manual Assignment Logic
            if (_mainControllerObject != null)
            {
                _mainController = _mainControllerObject.GetComponent<IDamageable>();
            }

            // Auto-Link Fallback (If empty)
            if (_mainController == null)
            {
                // Try parent first
                _mainController = GetComponentInParent<IDamageable>();

                // If this object IS the parent (recursion risk), look specifically for other components?
                // No, Relay is usually on a child. 
                // But wait! If Relay is on Child, and Parent has Controller, GetComponentInParent works.
                // Note: GetComponentsInParent includes THIS object. We must ensure we don't find ourselves!

                if (_mainController == this as IDamageable)
                {
                    // If we found ourselves, look at parent specifically
                    if (transform.parent != null)
                        _mainController = transform.parent.GetComponentInParent<IDamageable>();
                }
            }

            if (_mainController == null)
            {
                GameLogger.LogWarning(LogChannel.Combat, $"HitboxRelay on {name} could not find an IDamageable parent!", gameObject);
            }
        }

        public bool TakeDamage(DamageInfo info)
        {
            if (_mainController == null) return false;

            // Apply multiplier
            info.damageAmount *= _damageMultiplier;

            // Forward the hit
            return _mainController.TakeDamage(info);
        }

        public void Kill(bool instant)
        {
            if (_mainController != null) _mainController.Kill(instant);
        }
    }
}