using UnityEngine;

namespace DarkTowerTron.Core
{
    [System.Serializable]
    public struct DamageInfo
    {
        public float damageAmount;
        public float staggerAmount;
        public Vector3 pushDirection;
        public float pushForce;
        public GameObject source;
        public bool isRedirected;
    }
}