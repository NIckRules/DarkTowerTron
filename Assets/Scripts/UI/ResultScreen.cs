using UnityEngine;
using TMPro;
using DarkTowerTron.Managers;
using DarkTowerTron.Core.Services;

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

        // Called automatically when the GameObject is enabled (SetActive true)
        private void OnEnable()
        {
            if (Services.Score == null) return;

            // 1. Stop the Timer
            Services.Score.StopTracking();

            // 2. Get Stats
            int finalScore = Services.Score.TotalScore;
            float finalTime = Services.Score.GameTime;

            // 3. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                string minutes = Mathf.Floor(finalTime / 60).ToString("00");
                string seconds = (finalTime % 60).ToString("00");
                timeText.text = $"{minutes}:{seconds}";
            }

            // 4. Calculate Rank
            if (rankText)
            {
                string rank = "C";
                Color rankColor = Color.grey;

                if (finalScore >= rankS_Threshold) { rank = "S"; rankColor = Color.cyan; }
                else if (finalScore >= rankA_Threshold) { rank = "A"; rankColor = Color.green; }
                else if (finalScore >= rankB_Threshold) { rank = "B"; rankColor = Color.yellow; }

                rankText.text = rank;
                rankText.color = rankColor;
            }
        }
    }
}