using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Core.Debug;

namespace DarkTowerTron.Core.Data
{
    [CreateAssetMenu(fileName = "DebugProfile", menuName = "DarkTowerTron/Debug/Profile")]
    public class DebugProfileSO : ScriptableObject
    {
        [Header("Global Toggle")]
        public bool enableLogging = true;

        [Header("Channels")]
        public bool logPlayer = true;
        public bool logAI = true;
        public bool logCombat = true;
        public bool logUI = true;
        public bool logPhysics = false; // Usually noisy, keep off
        public bool logSystem = true;
        public bool logVFX = false;

        public bool IsChannelActive(LogChannel channel)
        {
            if (!enableLogging) return false;

            switch (channel)
            {
                case LogChannel.Player: return logPlayer;
                case LogChannel.AI: return logAI;
                case LogChannel.Combat: return logCombat;
                case LogChannel.UI: return logUI;
                case LogChannel.Physics: return logPhysics;
                case LogChannel.System: return logSystem;
                case LogChannel.VFX: return logVFX;
                default: return true;
            }
        }

        // Color coding for the console to make reading faster
        public string GetColor(LogChannel channel)
        {
            switch (channel)
            {
                case LogChannel.Player: return "cyan";
                case LogChannel.AI: return "orange";
                case LogChannel.Combat: return "red";
                case LogChannel.UI: return "yellow";
                case LogChannel.Physics: return "green";
                case LogChannel.System: return "white";
                default: return "grey";
            }
        }
    }
}