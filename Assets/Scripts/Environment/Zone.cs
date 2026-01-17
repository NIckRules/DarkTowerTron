using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Data; // Ensure we can see ColorPaletteSO

namespace DarkTowerTron.Environment
{
    /// <summary>
    /// Represents a single modular room or arena (Zone).
    /// Holds data about how this zone looks (Palette) and how it connects (Entry/Exit).
    /// </summary>
    public class Zone : MonoBehaviour
    {
        [Header("Zone Identity")]
        [Tooltip("Used for debugging or narrative triggers.")]
        public string zoneID;

        [Tooltip("The visual theme for this zone (Neon, Nier, etc).")]
        public ColorPaletteSO palette;

        [Header("Building Settings")]
        [Tooltip("The atomic grid size. Standard is 5 meters.")]
        public float tileSize = 5f;

        [Tooltip("Prefabs to be used by the Wall Baker. Order: 0=Straight, 1=OuterCorner, 2=InnerCorner")]
        public List<GameObject> wallPrefabs = new List<GameObject>();

        [Header("Connections")]
        [SerializeField] private Transform _entryPoint;
        [SerializeField] private Transform _exitPoint;
        [SerializeField] private Bounds _bounds = new Bounds(Vector3.zero, new Vector3(25, 10, 25));

        // Public Accessors
        public Transform EntryPoint => _entryPoint;
        public Transform ExitPoint => _exitPoint;
        public Bounds Bounds => _bounds;

        /// <summary>
        /// Editor Helper: Quickly aligns all child tiles to the grid.
        /// </summary>
        [ContextMenu("Snap Child Tiles")]
        public void SnapTiles()
        {
            // Find all tiles in children (we will refactor TileInfo next, but this works for now)
            var tiles = GetComponentsInChildren<Transform>();

            foreach (Transform t in tiles)
            {
                // Skip the Zone itself
                if (t == transform) continue;

                // Only snap objects that look like tiles (or have the TileInfo component)
                if (t.GetComponent<TileInfo>() != null)
                {
                    Vector3 localPos = t.localPosition;

                    // Snap X and Z to tileSize
                    localPos.x = Mathf.Round(localPos.x / tileSize) * tileSize;
                    localPos.z = Mathf.Round(localPos.z / tileSize) * tileSize;

                    // Flatten Y (Floor is always 0 in local space)
                    localPos.y = 0;

                    t.localPosition = localPos;
                }
            }
            Debug.Log($"<color=cyan>[Zone]</color> Snapped {tiles.Length} objects to grid.");
        }

        private void OnDrawGizmos()
        {
            // Draw Bounds
            Gizmos.color = new Color(1, 1, 0, 0.3f);
            Gizmos.DrawWireCube(transform.position + _bounds.center, _bounds.size);

            // Draw Connections
            if (_entryPoint != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(_entryPoint.position, 1f);
                Gizmos.DrawLine(_entryPoint.position, _entryPoint.position + _entryPoint.forward * 2);
            }

            if (_exitPoint != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(_exitPoint.position, 1f);
                Gizmos.DrawLine(_exitPoint.position, _exitPoint.position + _exitPoint.forward * 2);
            }
        }
    }
}