using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Managers
{
    public class PerkManager : MonoBehaviour
    {
        public static PerkManager Instance;

        [Header("Database")]
        public List<PerkBaseSO> availablePerks; // Pool of perks to choose from

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void GrantPerk(PerkBaseSO perk)
        {
            if (perk == null) return;

            if (GameServices.Player)
            {
                bool success = perk.Apply(GameServices.Player);

                if (success)
                {
                    // Juice
                    GameEvents.OnPopupText?.Invoke(GameServices.Player.transform.position, "UPGRADE!");
                    // Optional: Play Sound via FeedbackDirector using a "Upgrade" profile
                }
            }
        }

        public PerkBaseSO GetRandomPerk()
        {
            if (availablePerks.Count == 0) return null;
            return availablePerks[Random.Range(0, availablePerks.Count)];
        }
    }
}