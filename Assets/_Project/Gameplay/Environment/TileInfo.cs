using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace DarkTowerTron.Gameplay.Environment
{
    public class TileInfo : MonoBehaviour
    {
        [Header("Building Data")]
        public List<TileSocket> sockets = new List<TileSocket>();

        [Header("Debug")]
        public bool showGizmos = true;

        // Defines "Orange" manually
        private Color colorOrange = new Color(1.0f, 0.5f, 0.0f);

        /// <summary>
        /// Generates a short, unique ID based on the tile's local grid position.
        /// Example: A tile at x=10, z=-5 becomes "T[2,-1]"
        /// </summary>
        public string GetGridID(float gridSize)
        {
            int x = Mathf.RoundToInt(transform.localPosition.x / gridSize);
            int z = Mathf.RoundToInt(transform.localPosition.z / gridSize);
            return $"T[{x},{z}]";
        }

        [ContextMenu("Find Sockets in Children")]
        public void FindSockets()
        {
            sockets = GetComponentsInChildren<TileSocket>().ToList();
        }

        private void OnDrawGizmos()
        {
            if (!showGizmos) return;

            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.color = new Color(0, 1, 1, 0.1f);
            Gizmos.DrawWireCube(Vector3.zero, new Vector3(5, 0.1f, 5));

            // (Socket drawing handled by TileSocket gizmos mostly, but we can keep simple lines)
        }
    }
}