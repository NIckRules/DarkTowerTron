using UnityEngine;
using DarkTowerTron.Managers;

namespace DarkTowerTron.Core.Services
{
    [DefaultExecutionOrder(-1000)]
    public class GameBootstrap : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.Clear();
            DontDestroyOnLoad(gameObject);

            // 1. Register Core Systems
            Register<AudioManager>();
            Register<PoolManager>();
            Register<VFXManager>();
            Register<ScoreManager>(); 
            Register<PaletteManager>(); 
            
            GameLogger.Log(LogChannel.System, "System Core & Managers Initialized.");
        }

        private void Register<T>() where T : MonoBehaviour
        {
            var component = GetComponentInChildren<T>();
            if (component != null)
            {
                ServiceLocator.Register(component);
            }
            else
            {
                // Fallback: Try to add it if missing? 
                // Better to error so you fix the prefab.
                GameLogger.LogError(LogChannel.System, $"[BOOT] Critical: Missing {typeof(T).Name} on SystemBootloader!", gameObject);
            }
        }
    }
}