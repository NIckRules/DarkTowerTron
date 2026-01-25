using UnityEngine;

namespace DarkTowerTron.Systems
{
    /// <summary>
    /// Attached to the [GlobalSystems] prefab. 
    /// Ensures the GameObject persists between scenes and handles Singleton behavior.
    /// </summary>
    [DefaultExecutionOrder(-100)]
    public class Bootstrapper : MonoBehaviour
    {
        private static bool _exists = false;

        private void Awake()
        {
            if (_exists)
            {
                Destroy(gameObject); // Duplicate detected
                return;
            }

            _exists = true;
            DontDestroyOnLoad(gameObject);

            Debug.Log("<color=cyan>[Bootstrapper]</color> Global Systems Loaded.");
        }
    }
}