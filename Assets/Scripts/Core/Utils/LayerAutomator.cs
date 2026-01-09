using UnityEngine;

namespace DarkTowerTron.Core.Utils
{
    [ExecuteAlways] // Runs in Editor Mode
    public class LayerAutomator : MonoBehaviour
    {
        [Header("Configuration")]
        [Tooltip("The layer for the Root object (Movement Capsule).")]
        public string rootLayerName = "Enemy";

        [Tooltip("The layer for all child objects (Visuals/Hitboxes).")]
        public string childLayerName = "Hitbox";

        [Tooltip("If true, updates happens automatically when you change something.")]
        public bool autoUpdate = true;

        private void Update()
        {
            // Don't run in the actual game, only in Editor
            if (Application.isPlaying) return;

            if (autoUpdate)
            {
                EnforceLayers();
            }
        }

        [ContextMenu("Force Fix Layers Now")]
        public void EnforceLayers()
        {
            int rootLayer = LayerMask.NameToLayer(rootLayerName);
            int childLayer = LayerMask.NameToLayer(childLayerName);

            // Safety Check: Do layers exist?
            if (rootLayer == -1 || childLayer == -1) return;

            // 1. Fix Root
            if (gameObject.layer != rootLayer)
            {
                gameObject.layer = rootLayer;
            }

            // 2. Fix Children
            foreach (Transform child in transform)
            {
                SetLayerRecursive(child, childLayer);
            }
        }

        private void SetLayerRecursive(Transform t, int layer)
        {
            // Optional: Don't overwrite Triggers if you want them on a specific layer?
            // For now, Hitbox layer is usually fine for triggers too if configured right.

            if (t.gameObject.layer != layer)
            {
                t.gameObject.layer = layer;
            }

            foreach (Transform child in t)
            {
                SetLayerRecursive(child, layer);
            }
        }

        private void Awake()
        {
            // Self-Destruct in Play Mode to save memory
            if (Application.isPlaying)
            {
                Destroy(this);
            }
        }
    }
}