using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Gameplay.Player; // Access PlayerController & PlayerStats

namespace DarkTowerTron.Systems.UI
{
    public class ActivePerksPanel : MonoBehaviour
    {
        public GameObject iconPrefab;
        public Transform container;

        private PlayerStats _cachedStats;

        private void Start()
        {
            // Wait for Player to be registered (Singleton access)
            if (PlayerController.Instance != null)
            {
                _cachedStats = PlayerController.Instance.GetComponent<PlayerStats>();

                if (_cachedStats != null)
                {
                    _cachedStats.OnStatsChanged += RefreshUI;
                    RefreshUI(); // Initial state
                }
            }
        }

        private void OnDestroy()
        {
            // Good practice: Unsubscribe to avoid errors when changing scenes
            if (_cachedStats != null)
            {
                _cachedStats.OnStatsChanged -= RefreshUI;
            }
        }

        private void RefreshUI()
        {
            // Safety Check
            if (_cachedStats == null) return;

            // 1. Clear old icons
            foreach (Transform child in container) Destroy(child.gameObject);

            // 2. Rebuild list
            foreach (var perk in _cachedStats.ActivePerks)
            {
                if (perk == null) continue;

                GameObject obj = Instantiate(iconPrefab, container);

                // Assuming PerkIconUI is a simple script that sets an Image/Text
                var iconUI = obj.GetComponent<PerkIconUI>();
                if (iconUI != null)
                {
                    iconUI.Setup(perk);
                }
            }
        }
    }
}