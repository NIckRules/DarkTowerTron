using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Narrative
{
    [CreateAssetMenu(fileName = "Narrative_Default", menuName = "DarkTowerTron/Narrative/Library")]
    public class NarrativeLibrarySO : ScriptableObject
    {
        [Header("Contexts")]
        public List<string> introLines;      // Level Start
        public List<string> hurtLines;       // Player Hit
        public List<string> killLines;       // Enemy Killed
        public List<string> deathLines;      // Player Died
        public List<string> victoryLines;    // Level End

        public string GetRandomLine(List<string> source)
        {
            if (source == null || source.Count == 0) return "...";
            return source[Random.Range(0, source.Count)];
        }
    }
}