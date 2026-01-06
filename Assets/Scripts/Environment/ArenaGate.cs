using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Events;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private VoidEventChannelSO _roomClearedEvent;

        [Header("Parts")]
        public Transform laserWall;    // The Pivot (Scales up/down)
        public Renderer baseRenderer;  // The Floor Strip
        public Renderer wallRenderer;  // NEW: The Actual Wall Mesh (Child)
        public Collider wallCollider;  // The Physics Block

        [Header("Settings")]
        public float animDuration = 0.5f;
        public Vector3 closedScale = new Vector3(1, 1, 1);

        [Header("Colors")]
        public Color lockedColor = Color.red;
        public Color openColor = Color.green;

        private void Start()
        {
            // Initial State: Open
            SetGate(false, true);
        }

        private void OnEnable()
        {
            if (_roomClearedEvent != null) _roomClearedEvent.OnEventRaised += OnRoomCleared;
        }

        private void OnDisable()
        {
            if (_roomClearedEvent != null) _roomClearedEvent.OnEventRaised -= OnRoomCleared;
        }

        private void OnRoomCleared()
        {
            SetGate(false);
        }

        public void ForceClose()
        {
            SetGate(true, false);
        }

        private void SetGate(bool isClosed, bool instant = false)
        {
            // 1. Collider
            if (wallCollider) wallCollider.enabled = isClosed;

            // 2. Visuals (Scaling the Pivot)
            if (laserWall)
            {
                Vector3 targetScale = isClosed ? closedScale : new Vector3(closedScale.x, 0f, closedScale.z);

                if (instant) laserWall.localScale = targetScale;
                else laserWall.DOScale(targetScale, animDuration).SetEase(Ease.OutBack);
            }

            // 3. Colors
            Color targetColor = isClosed ? lockedColor : openColor;

            // A. Base Strip (Opaque)
            if (baseRenderer)
            {
                baseRenderer.material.DOColor(targetColor, "_BaseColor", animDuration);
                baseRenderer.material.DOColor(targetColor * 2f, "_EmissionColor", animDuration);
            }

            // B. Laser Wall (Transparent) - NEW LOGIC
            if (wallRenderer)
            {
                // We want the wall to be semi-transparent (Alpha ~ 0.3 or 80/255)
                Color transparentColor = new Color(targetColor.r, targetColor.g, targetColor.b, 0.3f);

                // Use DOTween for smooth color transition
                wallRenderer.material.DOColor(transparentColor, "_BaseColor", animDuration);
                wallRenderer.material.DOColor(targetColor, "_EmissionColor", animDuration);
            }
        }
    }
}