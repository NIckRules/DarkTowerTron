using UnityEngine;

namespace DarkTowerTron.Core
{
    [RequireComponent(typeof(LineRenderer))]
    public class CircleRenderer : MonoBehaviour
    {
        [Header("Settings")]
        public int segments = 50; // Smoothness
        public float radius = 1.0f;
        public float lineWidth = 0.1f;

        private LineRenderer _line;

        void Awake()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        // Draw immediately in Editor so you can see it
        void OnValidate()
        {
            _line = GetComponent<LineRenderer>();
            DrawCircle();
        }

        public void DrawCircle()
        {
            if (_line == null) return;

            _line.useWorldSpace = false; // Move with the parent
            _line.startWidth = lineWidth;
            _line.endWidth = lineWidth;
            _line.positionCount = segments + 1; // +1 to close the loop

            float angleStep = 360f / segments;

            for (int i = 0; i < segments + 1; i++)
            {
                float angle = i * angleStep * Mathf.Deg2Rad;

                // Draw on X/Z plane (Flat on ground)
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;

                _line.SetPosition(i, new Vector3(x, 0, z));
            }
        }
    }
}