using UnityEngine;
using TMPro;
using DarkTowerTron.Managers;
using DarkTowerTron;

namespace DarkTowerTron.UI
{
    public class ResultScreen : MonoBehaviour
    {
        [Header("UI References")]
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI timeText;
        public TextMeshProUGUI rankText;

        [Header("Ranking Config")]
        public int rankS_Threshold = 50000;
        public int rankA_Threshold = 25000;
        public int rankB_Threshold = 10000;

        private void OnEnable()
        {
            // Note: Global.Score throws an error if missing (Hard Dependency), 
            // so we don't strictly need a null check here unless using TryGet.
            // We assume the Bootloader has run.

            // 1. Stop the Timer
            Global.Score.StopTracking();

            // 2. Get Stats
            int finalScore = Global.Score.TotalScore;
            float finalTime = Global.Score.GameTime;

            // 3. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                // Use FloorToInt for cleaner casting
                int minutes = Mathf.FloorToInt(finalTime / 60f);
                int seconds = Mathf.FloorToInt(finalTime % 60f);
                timeText.text = $"{minutes:00}:{seconds:00}";
            }

            // 4. Calculate Rank
            if (rankText)
            {
                CalculateRank(finalScore);
            }
        }

        private void CalculateRank(int score)
        {
            string rank = "C";
            Color rankColor = Color.grey; 
            // Note: In the future, these colors could come from a UIThemeSO or Palette

            if (score >= rankS_Threshold) 
            { 
                rank = "S"; 
                rankColor = Color.cyan; 
            }
            else if (score >= rankA_Threshold) 
            { 
                rank = "A"; 
                rankColor = Color.green; 
            }
            else if (score >= rankB_Threshold) 
            { 
                rank = "B"; 
                rankColor = Color.yellow; 
            }

            rankText.text = rank;
            rankText.color = rankColor;
        }
    }
}