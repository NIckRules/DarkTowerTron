using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [System.Serializable]
    public struct StatModifier
    {
        public StatType targetStat;
        public ModifierType type;
        public float value;
    }

    [CreateAssetMenu(fileName = "NewPerk", menuName = "DarkTowerTron/Stats/Perk Definition")]
    public class PerkSO : ScriptableObject
    {
        [Header("UI")]
        public string perkName;
        [TextArea] public string description;
        public Sprite icon;

        [Header("Effects")]
        public List<StatModifier> statModifiers;
        public List<AbilityType> abilitiesToUnlock;
    }
}