using UnityEngine;

namespace DarkTowerTron.Core
{
    public enum DamageType { Generic, Projectile, Melee, Explosion, Environment }

    [System.Serializable]
    public struct DamageInfo
    {
        public float damageAmount;
        public int staggerAmount; // CHANGED TO INT
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
        public DamageType damageType; 
    }
}