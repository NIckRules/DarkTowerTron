using System.Text;
using UnityEngine;

namespace DarkTowerTron.Systems.Narrative
{
    public static class TextCorruptor
    {
        private static char[] _glitchChars = new char[] { '$', '#', '%', '&', '!', '?', '0', '1', 'X' };

        public static string Corrupt(string input, float corruptionLevel)
        {
            if (string.IsNullOrEmpty(input)) return "";
            if (corruptionLevel <= 0) return input;

            StringBuilder sb = new StringBuilder(input);
            int length = sb.Length;

            // 1. Character Replacement (Light Corruption)
            int charsToReplace = Mathf.FloorToInt(length * corruptionLevel * 0.5f);
            for (int i = 0; i < charsToReplace; i++)
            {
                int index = Random.Range(0, length);
                if (sb[index] == ' ') continue; // Don't replace spaces usually
                sb[index] = _glitchChars[Random.Range(0, _glitchChars.Length)];
            }

            // 2. Redaction (Heavy Corruption)
            // If corruption is > 0.5, block out whole words
            if (corruptionLevel > 0.5f)
            {
                // Simple logic: insert [ERR] randomly
                if (Random.value < corruptionLevel)
                {
                    sb.Append(" [FATAL_ERR]");
                }
            }

            // 3. Zalgo/Hex (Extreme Corruption)
            if (corruptionLevel > 0.8f)
            {
                // Hex dump style
                return $"0x{Random.Range(1000, 9999)} // {sb.ToString()}";
            }

            return sb.ToString();
        }
    }
}