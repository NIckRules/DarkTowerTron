using UnityEngine;

namespace DarkTowerTron.Environment
{
    public class PlayerStart : MonoBehaviour
    {
        [Tooltip("Unique ID for this spawn point (e.g., 'Start', 'Arena2', 'Boss')")]
        public string spawnID = "Start";

        [Header("Visuals")]
        public Color gizmoColor = Color.green;

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