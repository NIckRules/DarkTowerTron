using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.Events; // Needed for UI Events
using DarkTowerTron.Systems.Waves;

namespace DarkTowerTron.Gameplay.Environment
{
    public class ArenaController : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private List<WaveDefinitionSO> _waves;
        [SerializeField] private List<Transform> _spawnPoints;

        // NEW: Granular Control
        [SerializeField] private bool _useCountdown = true;
        [SerializeField] private float _countdownDuration = 3f;
        [SerializeField] private float _delayBetweenWaves = 2f;

        [Header("Gates")]
        [SerializeField] private List<ArenaGate> _gates;

        [Header("UI Broadcasting")]
        // Moved from Service to here
        [SerializeField] private StringEventChannelSO _announcementEvent;
        [SerializeField] private StringEventChannelSO _countdownEvent;

        // Dependencies
        private IWaveService _waveService;
        private Queue<WaveDefinitionSO> _waveQueue;
        private bool _isActive = false;

        private void Start()
        {
            _waveService = ServiceLocator.Get<IWaveService>();
            ToggleGates(false);
        }

        public void BeginEncounter()
        {
            if (_isActive) return;
            _isActive = true;

            ToggleGates(true);
            _waveQueue = new Queue<WaveDefinitionSO>(_waves);

            // Start the sequence
            StartCoroutine(RunWaveRoutine());
        }

        private IEnumerator RunWaveRoutine()
        {
            // Check if we have waves left
            if (_waveQueue.Count > 0)
            {
                var nextWave = _waveQueue.Dequeue();

                // 1. Announce Title
                if (_announcementEvent != null)
                    _announcementEvent.RaiseEvent(nextWave.waveName);

                // 2. Optional Countdown
                if (_useCountdown && _countdownEvent != null)
                {
                    float timer = _countdownDuration;
                    while (timer > 0)
                    {
                        // CeilToInt gives us "3", "2", "1" nice and clean
                        _countdownEvent.RaiseEvent(Mathf.CeilToInt(timer).ToString());
                        yield return new WaitForSeconds(1f);
                        timer -= 1f;
                    }
                    _countdownEvent.RaiseEvent(""); // Clear
                }

                // 3. Execute Wave via Service
                // Note: We cannot use the callback 'RunNextWave' directly inside Coroutine flow easily.
                // Instead, we wait for a flag or signal. 
                // A cleaner way for Coroutines is to wrap the Service call in a YieldInstruction 
                // but since our Service uses a callback, let's adapt.

                bool waveRunning = true;
                bool success = _waveService.StartWave(nextWave, _spawnPoints, onComplete: () => { waveRunning = false; });

                if (!success)
                {
                    Debug.LogError("[ArenaController] Service rejected wave!");
                    FinishEncounter();
                    yield break;
                }

                // 4. Wait for Wave Completion
                yield return new WaitUntil(() => !waveRunning);

                // 5. Inter-Wave Delay
                if (_waveQueue.Count > 0)
                {
                    yield return new WaitForSeconds(_delayBetweenWaves);
                    StartCoroutine(RunWaveRoutine()); // Loop
                }
                else
                {
                    FinishEncounter();
                }
            }
            else
            {
                FinishEncounter();
            }
        }

        private void FinishEncounter()
        {
            ToggleGates(false);
            _isActive = false;
        }

        private void ToggleGates(bool close)
        {
            foreach (var gate in _gates)
            {
                if (gate != null)
                {
                    if (close) gate.Close(); else gate.Open();
                }
            }
        }
    }
}