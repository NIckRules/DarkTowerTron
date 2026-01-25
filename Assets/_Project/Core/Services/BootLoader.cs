using UnityEngine;
using DarkTowerTron.Systems;

namespace DarkTowerTron.Core.Services
{
    public static class Bootloader
    {
        // --- CONFIGURATION ---
        // The path relative to ANY "Resources" folder in your project.
        // If file is at: Assets/_Project/Core/Resources/[GlobalSystems].prefab
        // Then set this to: "[GlobalSystems]"
        private const string SYSTEM_PREFAB_PATH = "[GlobalSystems]";

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Execute()
        {
            // 1. Safety Check: Don't spawn if a Bootstrapper already exists
            if (Object.FindObjectOfType<Bootstrapper>() != null) return;

            // 2. Load the Prefab
            var prefab = Resources.Load<GameObject>(SYSTEM_PREFAB_PATH);

            if (prefab == null)
            {
                // Helpful Debugging for Path Issues
                Debug.LogError($"[Bootloader] CRITICAL: Could not find prefab at path 'Resources/{SYSTEM_PREFAB_PATH}'.\n" +
                               "1. Ensure a folder named 'Resources' exists.\n" +
                               $"2. Ensure the file is named '{SYSTEM_PREFAB_PATH}' (check brackets/spelling).\n");
                return;
            }

            // 3. Spawn
            var instance = Object.Instantiate(prefab);
            instance.name = "[GlobalSystems]"; // Name in Hierarchy
        }
    }
}