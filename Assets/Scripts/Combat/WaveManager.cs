using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DarkTowerTron.Player;

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
            var player = FindObjectOfType<GritAndFocus>();
            if (player != null)
            {
                player.OnDeath.AddListener(LogMetrics);
            }

            if (waves.Count > 0) StartCoroutine(RunWave(waves[0]));
        }

        void Update()
        {
            // Check for clear.
            // 1. If !isWaveActive return.
            if (!isWaveActive) return;

            // 2. If GameObject.FindGameObjectsWithTag("Enemy").Length == 0:
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                //    - isWaveActive = false.
                isWaveActive = false;

                //    - StartCoroutine(RunWave(nextWave)).
                currentWaveIndex++;
                if (currentWaveIndex < waves.Count)
                {
                    StartCoroutine(RunWave(waves[currentWaveIndex]));
                }
                else
                {
                    Debug.Log("ALL WAVES CLEARED! VICTORY!");
                }
            }
        }

        IEnumerator RunWave(Wave wave)
        {
            // Spawn logic.
            // 1. Wait 2 seconds (breathing room).
            yield return new WaitForSeconds(2f);

            // 2. isWaveActive = true.
            isWaveActive = true;
            Debug.Log($"Starting Wave {currentWaveIndex + 1}: {wave.name}");

            // 3. Foreach action in wave.spawns:
            foreach (var action in wave.spawns)
            {
                //    - Instantiate enemy.
                if (action.enemyPrefab != null)
                {
                    Vector3 spawnPos = action.spawnPoint != null ? action.spawnPoint.position : Vector3.zero;
                    Quaternion spawnRot = action.spawnPoint != null ? action.spawnPoint.rotation : Quaternion.identity;
                    Instantiate(action.enemyPrefab, spawnPos, spawnRot);
                }

                //    - Yield Wait(action.delayAfter).
                yield return new WaitForSeconds(action.delayAfter);
            }
        }

        public void LogMetrics()
        {
            // Outputs TTFD, FDE, SWR on player death
            // DEATH | Wave:X | T:XX.Xs | Focus:XX | Grit:X | Wound:X | FDE:X.XX | SWR:XX %
            
            // Note: FDE and SWR require MetricsLogger which is not yet implemented.
            // Logging basic info for now.
            
            var player = FindObjectOfType<GritAndFocus>();
            float focus = player != null ? player.currentFocus : 0;
            int grit = player != null ? player.currentGrit : 0;
            int wound = player != null ? player.wound : 0;

            Debug.Log($"DEATH | Wave:{currentWaveIndex + 1} | T:{Time.time:F1}s | Focus:{focus:F0} | Grit:{grit} | Wound:{wound}");
        }
    }
}