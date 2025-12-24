using UnityEngine;

namespace DarkTowerTron.Player
{
    public class PlayerLoadout : MonoBehaviour
    {
        [Header("Defaults")]
        public GameObject defaultProjectile;
        public GameObject defaultDecoy;

        [Header("Active Loadout (Debug/Runtime)")]
        public GameObject currentProjectile;
        public GameObject currentDecoy;

        private void Awake()
        {
            // Initialize with defaults on start
            ResetLoadout();
        }

        public void ResetLoadout()
        {
            currentProjectile = defaultProjectile;
            currentDecoy = defaultDecoy;
        }

        public void EquipProjectile(GameObject newPrefab)
        {
            if (newPrefab != null) currentProjectile = newPrefab;
        }

        public void EquipDecoy(GameObject newPrefab)
        {
            if (newPrefab != null) currentDecoy = newPrefab;
        }
    }
}