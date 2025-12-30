using UnityEngine;
using DarkTowerTron.Player;

namespace DarkTowerTron.Core.Data
{
    public abstract class PerkBaseSO : ScriptableObject
    {
        [Header("UI Info")]
        public string perkName;
        [TextArea] public string description;
        public Sprite icon;

        // Returns true if successfully applied
        public abstract bool Apply(PlayerController player);
    }
}