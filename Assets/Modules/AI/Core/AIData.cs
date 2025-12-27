using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Core
{
    public class AIData : MonoBehaviour
    {
        [Header("Targets")]
        public Transform currentTarget;

        [Header("Dynamic Info (Read Only)")]
        public List<Transform> targets = new List<Transform>();
        public List<Collider> obstacles = new List<Collider>();

        // NEW: Cache the owner's collider here
        public Collider ownerCollider;

        private void Awake()
        {
            ownerCollider = GetComponent<Collider>();
        }

        public int GetTargetsCount() => targets != null ? targets.Count : 0;
    }
}