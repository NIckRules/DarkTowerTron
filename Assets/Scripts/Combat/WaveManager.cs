using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Player; // Access Player namespace

namespace DarkTowerTron.Combat
{
    public class WaveManager : MonoBehaviour
    {
        [System.Serializable]
        public class WaveAction 
        { 
            public GameObject enemyPrefab; 
            public Transform spawnPoint; 
            public float delayAfter = 1f; 
        }

        [System.Serializable]
        public class Wave 
        { 
            public string name; 
            public List<WaveAction> spawns; 
        }

        public List<Wave> waves;
        private int currentWaveIndex = 0;
        private bool isWaveActive = false;

        void Start()
        {
            if (waves.Count > 0) StartCoroutine(RunWave(waves[0]));
        }

        void Update()
        {
            if (!isWaveActive) return;

            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                isWaveActive = false;
                Debug.Log("<color=green>WAVE CLEARED</color>");

                // NEW: Stop Decay
                var player = FindObjectOfType<GritAndFocus>();
                if(player) player.SetCombatState(false);

                currentWaveIndex++;
                if (currentWaveIndex < waves.Count) StartCoroutine(RunWave(waves[currentWaveIndex]));
                else Debug.Log("VICTORY");
            }
        }

        IEnumerator RunWave(Wave wave)
        {
            Debug.Log($"STARTING WAVE: {wave.name}");
            yield return new WaitForSeconds(2f); // Breathing room

            isWaveActive = true;

            // NEW: Start Decay
            var player = FindObjectOfType<GritAndFocus>();
            if(player) player.SetCombatState(true);

            foreach (var action in wave.spawns)
            {
                if (action.enemyPrefab && action.spawnPoint)
                    Instantiate(action.enemyPrefab, action.spawnPoint.position, action.spawnPoint.rotation);
                
                if(action.delayAfter > 0) yield return new WaitForSeconds(action.delayAfter);
            }
        }
    }
}