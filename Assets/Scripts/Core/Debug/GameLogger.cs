using UnityEngine;
using System.Diagnostics; // Required for Conditional attribute
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Core
{
    public static class GameLogger
    {
        private static DebugProfileSO _profile;

        // Auto-load the profile from Resources if not set, or assign manually
        private static DebugProfileSO Profile
        {
            get
            {
                if (_profile == null)
                    _profile = Resources.Load<DebugProfileSO>("DebugProfile");
                return _profile;
            }
        }

        // Only compile this code in the Editor or Development Builds
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void Log(LogChannel channel, string message, GameObject context = null)
        {
            if (Profile == null) return;
            if (!Profile.IsChannelActive(channel)) return;

            string color = Profile.GetColor(channel);
            string prefix = $"<color={color}>[{channel}]</color>";
            
            UnityEngine.Debug.Log($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogWarning(LogChannel channel, string message, GameObject context = null)
        {
            // Warnings usually ignore the filter, or you can add a separate filter
            string prefix = $"<color=yellow>[{channel} WARNING]</color>";
            UnityEngine.Debug.LogWarning($"{prefix} {message}", context);
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogError(LogChannel channel, string message, GameObject context = null)
        {
            // Errors always show
            string prefix = $"<color=red>[{channel} ERROR]</color>";
            UnityEngine.Debug.LogError($"{prefix} {message}", context);
        }
    }
}