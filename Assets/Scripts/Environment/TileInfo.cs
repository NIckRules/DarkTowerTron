using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DarkTowerTron.Environment
{
    [ExecuteAlways]
    public class TileInfo : MonoBehaviour
    {
        public float tileSize = 4f;
        public Color labelColor = Color.cyan;
        public bool showCoordinates = true;

        private void OnDrawGizmos()
        {
            if (!showCoordinates) return;

            // Draw the outline of the tile
            Gizmos.color = new Color(labelColor.r, labelColor.g, labelColor.b, 0.3f);
            Gizmos.DrawWireCube(transform.position, new Vector3(tileSize, 0.1f, tileSize));

#if UNITY_EDITOR
            // Calculate "Local Grid" coordinates relative to parent (The Room Module)
            // If no parent, use World Space
            Vector3 pos = transform.position;
            if (transform.parent != null)
            {
                pos = transform.localPosition;
            }

            // Round to nearest logical index
            int x = Mathf.RoundToInt(pos.x / tileSize);
            int z = Mathf.RoundToInt(pos.z / tileSize);

            string label = $"{x}, {z}";
            
            // Draw text in Scene View
            GUIStyle style = new GUIStyle();
            style.normal.textColor = labelColor;
            style.fontSize = 15;
            style.alignment = TextAnchor.MiddleCenter;
            
            Handles.Label(transform.position + Vector3.up * 0.5f, label, style);
#endif
        }
    }
}