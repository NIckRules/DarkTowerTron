using UnityEngine;
using DarkTowerTron.Core;
using DG.Tweening;

namespace DarkTowerTron.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Settings")]
        public float animDuration = 1.0f;
        public float openHeight = -3f; // Move down to hide
        public float closedHeight = 0f; // Move up to block

        [Header("Parts")]
        public Transform gateVisuals;
        public Collider gateCollider;
        public Renderer gateRenderer; // To change color (Red=Locked, Green=Open)

        [Header("Colors")]
        public Color lockedColor = Color.red;
        public Color openColor = Color.green;

        private void Start()
        {
            // Start Open
            OpenGate(true);

            GameEvents.OnWaveCombatStarted += () => CloseGate();
            GameEvents.OnWaveCleared += () => OpenGate();
        }

        private void OnDestroy()
        {
            // Unsubscribe (using lambda requires careful cleanup, 
            // but for scene objects destroyed on load it's usually fine. 
            // Ideally, define methods to unsubscribe cleanly.)
            GameEvents.OnWaveCombatStarted -= CloseGate;
            GameEvents.OnWaveCleared -= OpenGate;
        }

        // Wrapper methods for event subscription cleanliness
        private void CloseGate() => SetGate(true);
        private void OpenGate() => SetGate(false);
        // Overload for instant snap
        private void OpenGate(bool instant) => SetGate(false, instant);

        private void SetGate(bool isClosed, bool instant = false)
        {
            float targetY = isClosed ? closedHeight : openHeight;
            Color targetColor = isClosed ? lockedColor : openColor;

            if (gateCollider) gateCollider.enabled = isClosed;

            if (gateVisuals)
            {
                if (instant)
                {
                    Vector3 pos = gateVisuals.localPosition;
                    pos.y = targetY;
                    gateVisuals.localPosition = pos;
                }
                else
                {
                    gateVisuals.DOLocalMoveY(targetY, animDuration).SetEase(Ease.OutBack);
                }
            }

            if (gateRenderer)
            {
                // Tween Color/Emission
                gateRenderer.material.DOColor(targetColor, "_BaseColor", animDuration);
                gateRenderer.material.DOColor(targetColor, "_EmissionColor", animDuration);
            }
        }
    }
}