using UnityEngine;
using TMPro;

namespace DarkTowerTron.Utils
{
    public class MetricsLogger : MonoBehaviour
    {
        public TextMeshProUGUI deathText;
        
        // Static counters for the session
        public static int staggerWasted = 0;
        public static int staggerKills = 0;
        public static int deaths = 0;

        public void AppendDeathLog(int wave, float time, int focus, int grit, int wound)
        {
            // Calculate metrics
            // TTFD: Time To First Death (handled externally or just use current time if it's the first death)
            // FDE: Focus Dump Efficiency (placeholder calculation)
            float fde = 0f; 
            // SWR: Stagger Waste Rate
            float swr = (staggerKills + staggerWasted) > 0 
                ? (float)staggerWasted / (staggerKills + staggerWasted) * 100f 
                : 0f;

            string log = $"DEATH | Wave:{wave} | T:{time:F1}s | Focus:{focus} | Grit:{grit} | Wound:{wound} | SWR:{swr:F0}%";
            Debug.Log(log);

            if (deathText != null)
            {
                deathText.text = $"Wave {wave} – {time:F1}s";
                deathText.gameObject.SetActive(true);
            }
            
            deaths++;
        }

        public void ResetSession()
        {
            staggerWasted = 0;
            staggerKills = 0;
            deaths = 0;
        }
    }
}
