using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Perks/Stat Modifier")]
    public class Perk_StatModSO : PerkBaseSO
    {
        [Header("Bonuses (0.1 = +10%)")]
        public float speedBonus = 0f;
        public float damageBonus = 0f;
        public float fireRateBonus = 0f;
        public float dashCostReduction = 0f;

        public override bool Apply(PlayerController player)
        {
            var stats = player.GetComponent<PlayerStats>();
            if (stats)
            {
                if (speedBonus != 0) stats.AddSpeedMultiplier(speedBonus);
                if (damageBonus != 0) stats.AddDamageMultiplier(damageBonus);
                if (fireRateBonus != 0) stats.AddFireRateMultiplier(fireRateBonus);
                if (dashCostReduction != 0) stats.ReduceDashCost(dashCostReduction);

                Debug.Log($"<color=green>[PERK] Applied Stats: {perkName}</color>");
                return true;
            }
            return false;
        }
    }
}