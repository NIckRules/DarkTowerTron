using System;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;

namespace DarkTowerTron.Systems.Waves
{
    public interface IWaveService : IGameService
    {
        bool IsWaveActive { get; }
        
        /// <summary>
        /// Starts a wave sequence using the provided spawn points.
        /// </summary>
        void StartWave(WaveDefinitionSO waveData, List<Transform> spawnPoints, Action onWaveComplete);
        
        void CancelCurrentWave();
    }
}