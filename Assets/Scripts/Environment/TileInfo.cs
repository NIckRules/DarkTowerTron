using UnityEngine;

#if UNITY_EDITOR
using UnityEditor; // <--- WRAP THIS
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

            Gizmos.color = new Color(labelColor.r, labelColor.g, labelColor.b, 0.3f);
            Gizmos.DrawWireCube(transform.position, new Vector3(tileSize, 0.1f, tileSize));

            // --- WRAP THE LABEL LOGIC ---
#if UNITY_EDITOR
            Vector3 pos = transform.position;
            if (transform.parent != null) pos = transform.localPosition;

            int x = Mathf.RoundToInt(pos.x / tileSize);
            int z = Mathf.RoundToInt(pos.z / tileSize);
            string label = $"{x}, {z}";
            
            GUIStyle style = new GUIStyle();
            style.normal.textColor = labelColor;
            style.fontSize = 15;
            style.alignment = TextAnchor.MiddleCenter;
            
            Handles.Label(transform.position + Vector3.up * 0.5f, label, style);
#endif
        }
    }
}