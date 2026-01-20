using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, IGameService> _services = new Dictionary<Type, IGameService>();

        public static void Register<T>(T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                Debug.LogWarning($"[ServiceLocator] Service {type.Name} is already registered. Overwriting.");
                _services[type] = service;
            }
            else
            {
                _services.Add(type, service);
            }
        }

        public static void Unregister<T>(T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                _services.Remove(type);
            }
        }

        // Added this alias to fix the error in PaletteService
        public static void Deregister<T>(T service) where T : IGameService => Unregister<T>(service);

        public static T Get<T>() where T : IGameService
        {
            var type = typeof(T);
            if (!_services.TryGetValue(type, out var service))
            {
                throw new Exception($"[ServiceLocator] Service {type.Name} not found! Is it registered in the Bootstrapper?");
            }
            return (T)service;
        }

        // --- NEW: Fixes 'does not contain definition for TryGet' ---
        public static bool TryGet<T>(out T service) where T : IGameService
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var s))
            {
                service = (T)s;
                return true;
            }
            service = default;
            return false;
        }

        public static void Reset() => _services.Clear();
    }
}