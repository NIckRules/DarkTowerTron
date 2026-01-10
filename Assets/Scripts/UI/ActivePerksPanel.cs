using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core; // For Global
using DarkTowerTron.Player.Stats;

namespace DarkTowerTron.UI
{
    public class ActivePerksPanel : MonoBehaviour
    {
        public GameObject iconPrefab;
        public Transform container;

        private void Start()
        {
            // Wait for Player to be registered
            if (Global.Player != null)
            {
                var stats = Global.Player.GetComponent<PlayerStats>();
                stats.OnStatsChanged += RefreshUI;
                RefreshUI(); // Initial state
            }
        }

        private void RefreshUI()
        {
            // 1. Clear old
            foreach (Transform child in container) Destroy(child.gameObject);

            // 2. Get Stats
            var stats = Global.Player.GetComponent<PlayerStats>();
            if (stats == null) return;

            // 3. Rebuild
            foreach (var perk in stats.ActivePerks)
            {
                GameObject obj = Instantiate(iconPrefab, container);
                var iconUI = obj.GetComponent<PerkIconUI>();
                iconUI.Setup(perk);
            }
        }
    }
}