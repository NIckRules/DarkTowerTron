using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{

    [System.Serializable]
    public struct DamageInfo
    {
        // Primary stats
        public float damageAmount;
        public int staggerAmount;

        // Physics / Knockback
        public Vector3 pushDirection;
        public float pushForce;

        // Context
        public GameObject source;
        public bool isRedirected;
        public DamageType damageType;
        public bool isCritical; // Fixed CS1061 in BaseHitbox

        /// <summary>
        /// Helper constructor for simple damage events
        /// </summary>
        public DamageInfo(float amount, GameObject source = null, DamageType type = DamageType.Generic)
        {
            this.damageAmount = amount;
            this.source = source;
            this.damageType = type;

            // Defaults
            this.staggerAmount = 0;
            this.pushDirection = Vector3.zero;
            this.pushForce = 0;
            this.isRedirected = false;
            this.isCritical = false;
        }
    }
}