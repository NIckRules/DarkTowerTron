using UnityEngine;
using DarkTowerTron.Systems; // Namespace where Bootstrapper.cs lives
using DarkTowerTron.Core.Debugging; // Assuming GameLogger is here

namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// Automatically loads the Bootstrapper prefab before any scene loads.
    /// allows "Play from Anywhere" functionality.
    /// </summary>
    public static class Bootloader
    {
        // This attribute runs this method automatically when Unity enters Play Mode.
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Execute()
        {
            // 1. Check if the Bootstrapper already exists in the scene
            // (e.g., if you manually placed it for testing)
            if (Object.FindObjectOfType<Bootstrapper>() != null) return;

            // 2. Load the Prefab from the "Resources" folder
            // Make sure your prefab is named "Bootstrapper" and is inside a "Resources" folder!
            var prefab = Resources.Load<GameObject>("Bootstrapper");
            
            if (prefab == null)
            {
                // Fallback: Check for old name just in case
                prefab = Resources.Load<GameObject>("SystemBootloader");
            }

            if (prefab == null)
            {
                Debug.LogError("[Bootloader] CRITICAL: Could not find 'Bootstrapper' prefab in any Resources folder. The game services will not start!");
                return;
            }

            // 3. Spawn the persistent object
            var instance = Object.Instantiate(prefab);
            instance.name = "[BOOTSTRAPPER]";
            
            // Note: The Bootstrapper component itself handles DontDestroyOnLoad in its Awake().
        }
    }
}