using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Combat
{
    public class FirePointRegistry : MonoBehaviour
    {
        [System.Serializable]
        public struct NamedPoint
        {
            public string id;
            public Transform point;
        }

        [Header("Configuration")]
        [Tooltip("If empty, auto-collects children starting with 'FirePoint_'.")]
        public List<NamedPoint> points = new List<NamedPoint>();

        private Dictionary<string, Transform> _lookup = new Dictionary<string, Transform>();

        private void Awake()
        {
            // 1. Load Manual Assignments
            foreach (var p in points)
            {
                if (!string.IsNullOrEmpty(p.id) && p.point != null)
                    _lookup[p.id] = p.point;
            }

            // 2. Auto-Discovery (Naming Convention: "FirePoint_Muzzle")
            var children = GetComponentsInChildren<Transform>(true);
            foreach (var t in children)
            {
                if (t.name.StartsWith("FirePoint_"))
                {
                    string id = t.name.Replace("FirePoint_", ""); // "Muzzle"
                    if (!_lookup.ContainsKey(id))
                    {
                        _lookup.Add(id, t);
                    }
                }
            }

            // 3. Fallback "Default"
            if (!_lookup.ContainsKey("Default"))
            {
                _lookup["Default"] = transform;
            }
        }

        public Transform GetPoint(string id)
        {
            if (string.IsNullOrEmpty(id)) id = "Default";

            if (_lookup.TryGetValue(id, out Transform t)) return t;

            // Graceful failure
            return _lookup["Default"];
        }
    }
}