using UnityEngine;
using TMPro;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(menuName = "DarkTowerTron/Visuals/UI Theme")]
    public class UIThemeSO : ScriptableObject
    {
        [Header("Fonts")]
        public TMP_FontAsset mainFont;
        public TMP_FontAsset digitFont;

        [Header("Colors")]
        public Color primaryColor = Color.cyan;   // Titles / Borders
        public Color accentColor = Color.yellow;  // Buttons / Highlights
        public Color dangerColor = Color.red;     // Game Over / Health
        public Color bodyColor = Color.white;     // Normal Text

        [Header("Sprites")]
        public Sprite buttonBackground;
        public Sprite panelBackground;
    }
}