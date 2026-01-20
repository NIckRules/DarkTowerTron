using UnityEngine;

namespace DarkTowerTron.Gameplay.Combat
{
    [System.Serializable]
    public struct DamageInfo
    {
        public float amount;
        public float staggerAmount; // Added to support StaggerModule
        public bool isCritical;
        public bool isRedirected;   // Added to support Reflection mechanics
        public Vector3 hitPoint;
        public Vector3 hitDirection;
        public GameObject source;

        public DamageInfo(float amount, bool isCritical = false, GameObject source = null)
        {
            this.amount = amount;
            this.staggerAmount = amount > 0 ? 1 : 0; // Default stagger = 1 if damage > 0
            this.isCritical = isCritical;
            this.isRedirected = false;
            this.source = source;
            this.hitPoint = Vector3.zero;
            this.hitDirection = Vector3.zero;
        }
    }
}