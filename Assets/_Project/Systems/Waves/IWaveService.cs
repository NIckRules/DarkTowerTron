using System;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Waves
{
    public interface IWaveService : IGameService
    {
        /// <summary>
        /// Is the service currently processing a wave?
        /// </summary>
        bool IsWaveActive { get; }

        /// <summary>
        /// Starts a specific wave using the provided spawn points.
        /// </summary>
        /// <param name="wave">The wave data to run.</param>
        /// <param name="spawnPoints">List of valid spawn transforms for this encounter.</param>
        /// <param name="onComplete">Callback when all enemies are dead.</param>
        /// <returns>False if service was already busy.</returns>
        bool StartWave(WaveDefinitionSO wave, List<Transform> spawnPoints, Action onComplete);

        void CancelWave();
    }
}