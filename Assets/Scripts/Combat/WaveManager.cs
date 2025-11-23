using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DarkTowerTron.Combat
{
    public class WaveManager : MonoBehaviour
    {
        [System.Serializable]
        public class WaveAction
        {
            public GameObject enemyPrefab; // Drag Pebble/Sniper here
            public Transform spawnPoint;   // Drag Spawn_N/S/E/W here
            public float delayAfter = 1f;  // Wait before next spawn?
        }

        [System.Serializable]
        public class Wave
        {
            public string waveName;
            public List<WaveAction> spawns;
        }

        [Header("Level Config")]
        public List<Wave> waves;
        public float timeBetweenWaves = 3f;

        private int currentWaveIndex = 0;
        private bool isWaveActive = false;

        void Start()
        {
            if (waves.Count > 0)
                StartCoroutine(RunWave(waves[0]));
        }

        void Update()
        {
            if (!isWaveActive) return;

            // Check for Wave Clear
            // (Simple tag check is fine for prototype)
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                Debug.Log("<color=green>WAVE CLEARED</color>");
                isWaveActive = false;

                // Next Wave
                currentWaveIndex++;
                if (currentWaveIndex < waves.Count)
                {
                    StartCoroutine(RunWave(waves[currentWaveIndex]));
                }
                else
                {
                    Debug.Log("<color=gold>VICTORY - ALL WAVES CLEARED</color>");
                }
            }
        }

        IEnumerator RunWave(Wave wave)
        {
            Debug.Log($"STARTING WAVE: {wave.waveName}");
            yield return new WaitForSeconds(timeBetweenWaves);

            isWaveActive = true;

            foreach (var action in wave.spawns)
            {
                if (action.enemyPrefab != null && action.spawnPoint != null)
                {
                    Instantiate(action.enemyPrefab, action.spawnPoint.position, Quaternion.identity);
                }

                if (action.delayAfter > 0)
                    yield return new WaitForSeconds(action.delayAfter);
            }
        }
    }
}