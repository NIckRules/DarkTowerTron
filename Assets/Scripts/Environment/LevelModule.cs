using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class LevelModule : MonoBehaviour
    {
        [Header("Sockets")]
        public Transform entryPoint; // Where the previous room connects (South)
        public Transform exitPoint;  // Where the next room connects (North)

        [Header("Debug")]
        public Color gizmoColor = Color.cyan;
        public Vector3 roomSize = new Vector3(40, 10, 40); // For visualization only

        private void OnDrawGizmos()
        {
            // Draw Bounds
            Gizmos.color = new Color(gizmoColor.r, gizmoColor.g, gizmoColor.b, 0.2f);
            Gizmos.DrawCube(transform.position, roomSize);
            Gizmos.color = gizmoColor;
            Gizmos.DrawWireCube(transform.position, roomSize);

            // Draw Sockets
            if (entryPoint)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(entryPoint.position, 1f);
                Gizmos.DrawLine(entryPoint.position, entryPoint.position + Vector3.up * 5);
            }

            if (exitPoint)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(exitPoint.position, 1f);
                Gizmos.DrawLine(exitPoint.position, exitPoint.position + Vector3.up * 5);
            }
        }

        // Helper to snap this room's entry to a target position
        public void SnapTo(Transform targetExit)
        {
            if (entryPoint == null) return;

            // Calculate offset required to move Entry to Target
            Vector3 offset = targetExit.position - entryPoint.position;
            transform.position += offset;
        }
    }
}