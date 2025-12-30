using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Perks/Loadout Change")]
    public class Perk_LoadoutSO : PerkBaseSO
    {
        [Header("New Equipment")]
        public GameObject projectilePrefab; // New Bullet
        public GameObject decoyPrefab;      // New Dash Ghost

        public override bool Apply(PlayerController player)
        {
            var loadout = player.GetComponent<PlayerLoadout>();
            if (loadout)
            {
                if (projectilePrefab) loadout.EquipProjectile(projectilePrefab);
                if (decoyPrefab) loadout.EquipDecoy(decoyPrefab);

                Debug.Log($"<color=green>[PERK] Equipped Gear: {perkName}</color>");
                return true;
            }
            return false;
        }
    }
}