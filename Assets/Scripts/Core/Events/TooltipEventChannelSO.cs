using UnityEngine;
using UnityEngine.Events;

namespace DarkTowerTron.Core.Events
{
    [CreateAssetMenu(menuName = "Events/UI/Tooltip Channel")]
    public class TooltipEventChannelSO : ScriptableObject
    {
        // Header, Content
        public UnityAction<string, string> OnShow;
        public UnityAction OnHide;

        public void Show(string header, string content)
        {
            OnShow?.Invoke(header, content);
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }
    }
}