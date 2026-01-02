using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.Core.Services
{
    /// <summary>
    /// A simple, static registry for game systems.
    /// Replaces the Singleton pattern for Managers.
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new();

        /// <summary>
        /// Registers a service instance. Overwrites if type already exists.
        /// </summary>
        public static void Register<T>(T service) where T : class
        {
            var type = typeof(T);
            if (_services.ContainsKey(type))
            {
                Debug.LogWarning($"[ServiceLocator] Service {type.Name} is being overwritten.");
            }
            _services[type] = service;
        }

        /// <summary>
        /// Gets a service instance. Throws error if missing.
        /// </summary>
        public static T Get<T>() where T : class
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var service))
            {
                return service as T;
            }

            throw new InvalidOperationException($"[ServiceLocator] Service {type.Name} not registered! Ensure SystemBootloader is running.");
        }

        /// <summary>
        /// Safely tries to get a service. Useful for optional dependencies (e.g. testing AI without UI).
        /// </summary>
        public static bool TryGet<T>(out T service) where T : class
        {
            var type = typeof(T);
            if (_services.TryGetValue(type, out var obj))
            {
                service = obj as T;
                return true;
            }

            service = null;
            return false;
        }

        /// <summary>
        /// Clears all services. Call on Domain Reload or Application Quit.
        /// </summary>
        public static void Clear()
        {
            _services.Clear();
        }
    }
}