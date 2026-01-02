using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Managers
{
    public class DamageTextManager : MonoBehaviour
    {
        [Header("Setup")]
        public GameObject textPrefab; // Assign the prefab here

        [Header("Settings")]
        public Vector3 offset = new Vector3(0, 2f, 0); // Spawn above enemy head
        public Color normalColor = Color.white;
        public Color critColor = Color.yellow;
        public Color infoColor = Color.cyan; // For "STAGGER"

        private void OnEnable()
        {
            GameEvents.OnDamageDealt += ShowDamage;
            GameEvents.OnPopupText += ShowPopup;
        }

        private void OnDisable()
        {
            GameEvents.OnDamageDealt -= ShowDamage;
            GameEvents.OnPopupText -= ShowPopup;
        }

        private void ShowDamage(Vector3 pos, float amount, bool isCrit)
        {
            if (textPrefab == null || Services.Pool == null) return;

            // Spawn
            GameObject obj = Services.Pool.Spawn(textPrefab, pos + offset, Quaternion.identity);

            // Configure
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();
            if (floatingText)
            {
                Color c = isCrit ? critColor : normalColor;
                float scale = isCrit ? 1.5f : 1.0f;

                // N0 formats to integer (10 instead of 10.0)
                floatingText.Initialize(amount.ToString("N0"), c, scale);

                // Billboarding: Make text face the camera
                obj.transform.forward = Camera.main.transform.forward;
            }
        }

        private void ShowPopup(Vector3 pos, string message)
        {
            if (textPrefab == null || Services.Pool == null) return;

            GameObject obj = Services.Pool.Spawn(textPrefab, pos + offset, Quaternion.identity);
            var floatingText = obj.GetComponent<DarkTowerTron.UI.FloatingText>();

            if (floatingText)
            {
                floatingText.Initialize(message, infoColor, 1.2f);
                obj.transform.forward = Camera.main.transform.forward;
            }
        }
    }
}