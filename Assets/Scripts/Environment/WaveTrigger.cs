using UnityEngine;
using System.Collections.Generic;
using DarkTowerTron.Managers;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core; // <--- THIS WAS MISSING

namespace DarkTowerTron.Environment
{
    public class WaveTrigger : MonoBehaviour
    {
        [Header("Configuration")]
        public List<WaveDefinitionSO> wavesForThisRoom;
        public Transform[] spawnPointsForThisRoom;

        [Header("Arena Gates")]
        public ArenaGate[] gatesToClose;

        private bool _triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_triggered) return;

            if (other.CompareTag(GameConstants.TAG_PLAYER))
            {
                _triggered = true;
                StartRoomEncounter();
            }
        }

        private void StartRoomEncounter()
        {
            // USE SERVICE LOCATOR
            var director = GameServices.WaveDirector;

            // Logic: ArenaSpawner is attached to the same object as WaveDirector
            var spawner = director != null ? director.GetComponent<ArenaSpawner>() : null;

            if (director && spawner)
            {
                // 1. Hand off Spawn Points
                if (spawnPointsForThisRoom != null && spawnPointsForThisRoom.Length > 0)
                {
                    spawner.spawnPoints = spawnPointsForThisRoom;
                }

                // 2. Load Waves & Start
                director.waves = wavesForThisRoom;
                director.StartGame();

                // 3. Lock Gates
                ForceCloseGates();
            }
            else
            {
                Debug.LogError("WaveTrigger: Could not find WaveDirector via GameServices!");
            }

            gameObject.SetActive(false);
        }

        public void ForceCloseGates()
        {
            foreach (var gate in gatesToClose)
            {
                if (gate != null) gate.ForceClose();
            }
        }
    }
}