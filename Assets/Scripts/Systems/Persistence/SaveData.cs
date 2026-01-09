using System;

namespace DarkTowerTron.Systems.Persistence
{
    [Serializable]
    public class SaveData
    {
        // --- Header ---
        public string lastPlayedDate;
        public string version = "0.1";

        // --- Narrative Stats (The "Corruption") ---
        public int totalRuns;
        public int totalDeaths;
        public int totalKills;
        public float totalDamageDealt;

        // --- Progression ---
        public int highestWaveReached;
        public bool hasSeenTutorial;

        // --- Settings (Optional for now) ---
        public float masterVolume = 1.0f;

        // Constructor sets defaults
        public SaveData()
        {
            lastPlayedDate = DateTime.Now.ToString();
            totalRuns = 0;
            totalDeaths = 0;
            totalKills = 0;
            totalDamageDealt = 0;
            highestWaveReached = 0;
            hasSeenTutorial = false;
        }
    }
}