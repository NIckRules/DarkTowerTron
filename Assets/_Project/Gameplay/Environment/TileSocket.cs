using UnityEngine;

namespace DarkTowerTron.Gameplay.Environment
{
    // Describes the physical/structural need of the socket
    public enum SocketCategory
    {
        Wall_Straight_5x5,
        Wall_Diagonal_5x5,
        Open_Connector
    }

    public class TileSocket : MonoBehaviour
    {
        [Header("Configuration")]
        public SocketCategory category = SocketCategory.Wall_Straight_5x5;
        [Header("Overrides")]
        [Tooltip("Force a specific prefab here, ignoring the Zone theme.")]
        public GameObject specificPrefabOverride;

        [Header("State")]
        public bool isOccupied = false;

        private void OnDrawGizmos()
        {
            // Visual debugging colors
            Color c = category switch
            {
                SocketCategory.Wall_Straight_5x5 => new Color(1f, 0.5f, 0f), // Orange
                SocketCategory.Wall_Diagonal_5x5 => new Color(1f, 0f, 1f),       // Purple
                _ => Color.white
            };

            Gizmos.color = c;
            Gizmos.matrix = transform.localToWorldMatrix;

            // Draw the footprint
            Gizmos.DrawWireCube(new Vector3(0, 1.25f, 0), new Vector3(4f, 2.5f, 0.5f));
            // Draw forward direction
            Gizmos.DrawLine(Vector3.zero, Vector3.forward);
            Gizmos.DrawSphere(Vector3.forward, 0.1f);
        }
    }
}