using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// Automatically loads the SystemBootloader prefab before any scene loads.
    /// </summary>
    public static class Bootloader
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Execute()
        {
            // 1. Check if it already exists (prevent duplicates in Editor)
            if (Object.FindObjectOfType<GameBootstrap>() != null) return;

            // 2. Load from Resources
            var prefab = Resources.Load<GameObject>("SystemBootloader");
            if (prefab == null)
            {
                GameLogger.LogError(LogChannel.System, "CRITICAL: Missing 'SystemBootloader' in Resources folder!");
                return;
            }

            // 3. Spawn
            var instance = Object.Instantiate(prefab);
            instance.name = "[SYSTEM_BOOT]";
            
            // Note: DontDestroyOnLoad is handled by the GameBootstrap component in Awake.
        }
    }
}