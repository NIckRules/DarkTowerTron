using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Managers;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Environment
{
    public class WaveTrigger : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> wavesForThisRoom;
        public Transform[] spawnPointsForThisRoom;

        [Header("Arena Gates")]
        public ArenaGate[] gatesToClose; // Assign gates here

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {

            Debug.Log("WaveTrigger: OnTriggerEnter called.");

            if (_triggered) return;

            if (other.CompareTag("Player"))
            {
                _triggered = true;
                StartRoomEncounter();
            }
        }

        private void StartRoomEncounter()
        {
            var director = FindObjectOfType<WaveDirector>();
            var spawner = FindObjectOfType<ArenaSpawner>();

            if (director && spawner)
            {
                // 1. Setup Data
                spawner.spawnPoints = spawnPointsForThisRoom;
                director.waves = wavesForThisRoom;
                
                // 2. Lock the doors instantly
                foreach (var gate in gatesToClose)
                {
                    if (gate) gate.ForceClose();
                }

                // 3. Start the Show
                director.StartGame();
            }
            
            gameObject.SetActive(false);
        }
    }
}