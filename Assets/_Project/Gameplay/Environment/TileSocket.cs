using UnityEngine;

namespace DarkTowerTron.Gameplay.Environment
{
    public enum SocketType { Wall, Gate, Connector }

    public class TileSocket : MonoBehaviour
    {
        [Header("Settings")]
        public SocketType type = SocketType.Wall;
        public float wallThickness = 0.5f; // Standard thickness

        [Header("State")]
        public bool isOccupied = false;

        private void OnDrawGizmos()
        {
            // Visual Styles based on Type
            Color color = type switch
            {
                SocketType.Wall => new Color(1f, 0.6f, 0f, 0.8f),   // Orange
                SocketType.Gate => new Color(0f, 1f, 1f, 0.8f),     // Cyan
                SocketType.Connector => new Color(0f, 1f, 0f, 0.8f),// Green
                _ => Color.white
            };

            Gizmos.color = color;
            Gizmos.matrix = transform.localToWorldMatrix;

            // 1. Draw the "Footprint" of the wall that will spawn here
            // If this socket is indented, we draw the box to show where the mesh actually sits
            Gizmos.DrawWireCube(new Vector3(0, 1.25f, 0), new Vector3(5f, 2.5f, wallThickness));

            // 2. Draw the "Forward" direction (Outward)
            Gizmos.DrawLine(Vector3.zero, Vector3.forward * 1.0f);
            Gizmos.DrawSphere(Vector3.forward * 1.0f, 0.15f);

            // 3. Draw a "Snap" diamond at the center
            Gizmos.DrawWireSphere(Vector3.zero, 0.1f);
        }
    }
}