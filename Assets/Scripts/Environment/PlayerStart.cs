using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Environment
{
    public class PlayerStart : MonoBehaviour
    {
        [Tooltip("Unique ID for this spawn point (e.g., 'Start', 'Arena2', 'Boss')")]
        public string spawnID = "Start";

        [Header("Visuals")]
        public Color gizmoColor = Color.green;

        // --- THE REGISTRY ---
        private static readonly Dictionary<string, Transform> _registry = new Dictionary<string, Transform>();

        private void OnEnable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (!_registry.ContainsKey(spawnID))
            {
                _registry.Add(spawnID, transform);
            }
            else if (_registry[spawnID] != transform)
            {
                Debug.LogWarning($"[PlayerStart] Duplicate spawnID '{spawnID}' found on '{name}'. Keeping first registration.", gameObject);
            }
        }

        private void OnDisable()
        {
            if (string.IsNullOrWhiteSpace(spawnID)) return;

            if (_registry.TryGetValue(spawnID, out Transform registered) && registered == transform)
            {
                _registry.Remove(spawnID);
            }
        }

        public static Transform GetSpawnPoint(string id)
        {
            if (!string.IsNullOrWhiteSpace(id) && _registry.TryGetValue(id, out Transform t)) return t;

            // Fallback: Try "Start" if the requested one is missing
            if (id != "Start" && _registry.TryGetValue("Start", out Transform def)) return def;

            return null;
        }
        // --------------------

        private void OnDrawGizmos()
        {
            Gizmos.color = gizmoColor;
            // Draw a capsule to represent the player
            Gizmos.DrawWireSphere(transform.position + Vector3.up * 0.5f, 0.5f);
            Gizmos.DrawLine(transform.position, transform.position + transform.forward * 2f);

            // Draw label in Scene View
#if UNITY_EDITOR
            UnityEditor.Handles.Label(transform.position + Vector3.up * 2f, $"Spawn: {spawnID}");
#endif
        }
    }
}