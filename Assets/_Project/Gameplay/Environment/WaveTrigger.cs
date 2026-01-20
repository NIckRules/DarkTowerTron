using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core; // For GameConstants
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Systems.Waves;

namespace DarkTowerTron.Gameplay.Environment
{
    public class WaveTrigger : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private List<WaveDefinitionSO> _wavesForThisRoom;
        [SerializeField] private List<Transform> _spawnPoints;

        [Header("Arena Gates")]
        [SerializeField] private List<ArenaGate> _gates;

        private bool _hasTriggered = false;
        private Queue<WaveDefinitionSO> _waveQueue;

        private void OnTriggerEnter(Collider other)
        {
            if (_hasTriggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _hasTriggered = true;
                StartRoomEncounter();
            }
        }

        private void StartRoomEncounter()
        {
            // 1. Lock the room
            ToggleGates(true);

            // 2. Prepare the queue
            _waveQueue = new Queue<WaveDefinitionSO>(_wavesForThisRoom);

            // 3. Start the chain
            RunNextWave();
        }

        private void RunNextWave()
        {
            // Recursive Step: Are there waves left?
            if (_waveQueue.Count > 0)
            {
                var nextWave = _waveQueue.Dequeue();
                
                // Call the Service
                // We pass "RunNextWave" as the callback! This creates the loop.
                ServiceLocator.Get<IWaveService>().StartWave(nextWave, _spawnPoints, onWaveComplete: RunNextWave);
            }
            else
            {
                // Base Case: No waves left. Victory.
                FinishEncounter();
            }
        }

        private void FinishEncounter()
        {
            Debug.Log($"[WaveTrigger] Room Complete.");
            ToggleGates(false);
            
            // Optional: Disable collider so it never triggers again logic-wise
            GetComponent<Collider>().enabled = false; 
        }

        private void ToggleGates(bool close)
        {
            foreach (var gate in _gates)
            {
                if (gate == null) continue;
                
                if (close) gate.Close(); // Assuming your Gate has Close()
                else gate.Open();        // Assuming your Gate has Open()
            }
        }
    }
}