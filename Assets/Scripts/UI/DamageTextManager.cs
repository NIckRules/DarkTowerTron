using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Events;
// ALIAS
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.UI
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private DamageTextEventChannelSO _damageEvent;
        [SerializeField] private PopupTextEventChannelSO _popupEvent;

        [Header("Setup")]
        public GameObject textPrefab;

        [Header("Damage Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0);
        public Color healthColor = Color.white;
        public Color critColor = Color.yellow;
        public Color staggerColor = Color.cyan; // Distinct color for Stagger Damage

        [Header("Narrative Settings")]
        public Color narrativeColor = new Color(1f, 0.5f, 0f); // Orange
        [Tooltip("Words to inject via the Popup channel")]
        public List<string> barks = new List<string> { "WHAM!", "CRUNCH!", "ERROR", "VOID" };

        private void OnEnable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised += ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised += ShowPopup;
        }

        private void OnDisable()
        {
            if (_damageEvent != null) _damageEvent.OnEventRaised -= ShowDamage;
            if (_popupEvent != null) _popupEvent.OnEventRaised -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (textPrefab == null || Global.Pool == null) return;

            // 1. Determine Appearance
            Color finalColor;
            float finalScale;
            string text;
            bool isDramatic = isCrit;

            if (isStagger)
            {
                finalColor = staggerColor;
                finalScale = 0.8f; // Stagger numbers slightly smaller
                text = amount.ToString("N0"); // e.g. "5"
            }
            else
            {
                finalColor = isCrit ? critColor : healthColor;
                finalScale = isCrit ? 1.5f : 1.0f;
                text = amount.ToString("N0");
            }

            // 2. Spawn & Init
            SpawnText(pos, text, finalColor, finalScale, isDramatic);
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            // If the message is a keyword like "BARK", pick a random narrative word
            if (message == "BARK" && barks.Count > 0)
            {
                message = barks[Random.Range(0, barks.Count)];
                SpawnText(pos, message, narrativeColor, 1.3f, true); // Dramatic!
            }
            else
            {
                // Standard Popup (e.g. "REFLECT", "ARMORED")
                SpawnText(pos, message, critColor, 1.2f, true);
            }
        }

        private void SpawnText(Vector3 pos, string text, Color color, float scale, bool dramatic)
        {
            if (textPrefab == null || Global.Pool == null) return;

            GameObject obj = Global.Pool.Spawn(textPrefab, pos + offset, Quaternion.identity);
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(text, color, scale, dramatic);
                // Billboarding
                obj.transform.forward = Camera.main.transform.forward;
            }
        }
    }
}