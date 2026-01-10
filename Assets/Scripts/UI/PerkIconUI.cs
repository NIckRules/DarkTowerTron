using UnityEngine;
using UnityEngine.UI;
using DarkTowerTron.Systems.Stats;

namespace DarkTowerTron.UI
{
    // Make sure to add this requirement so we don't forget the trigger
    [RequireComponent(typeof(TooltipTrigger))]
    public class PerkIconUI : MonoBehaviour
    {
        public Image iconImage;
        private TooltipTrigger _tooltip;

        private void Awake()
        {
            _tooltip = GetComponent<TooltipTrigger>();
        }

        public void Setup(PerkSO perk)
        {
            if (perk == null) return;

            // 1. Icon Setup
            if (perk.icon != null)
            {
                iconImage.sprite = perk.icon;
                iconImage.enabled = true;
            }
            else
            {
                iconImage.color = Color.cyan;
            }

            // 2. Tooltip Injection
            if (_tooltip != null)
            {
                _tooltip.SetText(perk.perkName, perk.description);
            }
        }
    }
}