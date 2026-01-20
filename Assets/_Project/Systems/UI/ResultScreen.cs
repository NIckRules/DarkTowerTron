using UnityEngine;
using TMPro;
using DarkTowerTron.Core.Services; // Access ServiceLocator
using DarkTowerTron.Systems.Score; // Access IScoreService

namespace DarkTowerTron.Systems.UI
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
            // 1. Get Service
            var scoreService = ServiceLocator.Get<IScoreService>();

            if (scoreService == null)
            {
                // Fallback for UI testing without services
                if (scoreText) scoreText.text = "0";
                if (timeText) timeText.text = "00:00";
                return;
            }

            // 2. Stop the Timer (Game Over state)
            scoreService.StopTracking();

            // 3. Get Stats from Service
            int finalScore = scoreService.TotalScore;
            float finalTime = scoreService.GameTime;

            // 4. Format Text
            if (scoreText) scoreText.text = finalScore.ToString("N0");

            if (timeText)
            {
                int minutes = Mathf.FloorToInt(finalTime / 60f);
                int seconds = Mathf.FloorToInt(finalTime % 60f);
                timeText.text = $"{minutes:00}:{seconds:00}";
            }

            // 5. Calculate Rank
            if (rankText)
            {
                CalculateRank(finalScore);
            }
        }

        private void CalculateRank(int score)
        {
            string rank = "C";
            Color rankColor = Color.grey;

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