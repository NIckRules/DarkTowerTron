using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.UI
{
    public enum UIElementType { Title, Body, Button, Panel, Digits, Danger }

    public class UIThemeReceiver : MonoBehaviour
    {
        public UIThemeSO theme; // Assign in Inspector or Load from Manager
        public UIElementType type = UIElementType.Body;

        private void OnEnable()
        {
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            if (theme == null) return;

            var text = GetComponent<TextMeshProUGUI>();
            var img = GetComponent<Image>();

            switch (type)
            {
                case UIElementType.Title:
                    if (text) { text.font = theme.mainFont; text.color = theme.primaryColor; }
                    break;
                case UIElementType.Body:
                    if (text) { text.font = theme.mainFont; text.color = theme.bodyColor; }
                    break;
                case UIElementType.Digits:
                    if (text) { text.font = theme.digitFont; text.color = theme.accentColor; }
                    break;
                case UIElementType.Danger:
                    if (text) { text.font = theme.mainFont; text.color = theme.dangerColor; }
                    break;
                case UIElementType.Button:
                    if (img) { img.sprite = theme.buttonBackground; img.color = theme.accentColor; }
                    // Button text is usually handled by a child receiver set to "Body" or "Title"
                    break;
            }
        }
    }
}