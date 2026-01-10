using UnityEngine;
using UnityEngine.EventSystems; // Required for Pointer interfaces
using DarkTowerTron.Core.Events;

namespace DarkTowerTron.UI
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Wiring")]
        [SerializeField] private TooltipEventChannelSO _tooltipEvent;

        [Header("Content")]
        public string header;
        [TextArea] public string content;

        // Allow other scripts (like PerkIconUI) to set this dynamically
        public void SetText(string newHeader, string newContent)
        {
            header = newHeader;
            content = newContent;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            // Delay could be added here if needed
            _tooltipEvent?.Show(header, content);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _tooltipEvent?.Hide();
        }
    }
}