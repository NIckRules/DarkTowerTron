using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Access ServiceLocator

namespace DarkTowerTron.Systems.Persistence
{
    /// <summary>
    /// Listens to gameplay events and updates the persistent SaveData.
    /// Place this on the same GameObject as PersistenceService in the Bootstrapper.
    /// </summary>
    public class StatsTracker : MonoBehaviour
    {
        [Header("Listening To")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private DamageTextEventChannelSO _damageEvent;

        // Dependency
        private IPersistenceService _persistence;

        private void Start()
        {
            // Resolve dependency via Locator
            _persistence = ServiceLocator.Get<IPersistenceService>();

            if (_persistence == null)
                Debug.LogError("[StatsTracker] Persistence Service not found!");
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised += OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised += OnDamageDealt;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerDiedEvent) _playerDiedEvent.OnEventRaised -= OnPlayerDied;
            if (_damageEvent) _damageEvent.OnEventRaised -= OnDamageDealt;
        }

        private void OnEnemyKilled(Vector3 pos, EnemyStatsSO stats, bool reward)
        {
            if (!reward || _persistence?.CurrentData == null) return;
            _persistence.CurrentData.totalKills++;
        }

        private void OnPlayerDied()
        {
            if (_persistence?.CurrentData == null) return;

            // Use the helper methods or modify directly
            _persistence.RecordDeath();
            // Note: RecordDeath already increments totalDeaths and Saves.

            // If you want to increment Runs on death:
            // _persistence.CurrentData.totalRuns++;
            // _persistence.Save();
        }

        private void OnDamageDealt(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            if (!isStagger && _persistence?.CurrentData != null)
            {
                _persistence.CurrentData.totalDamageDealt += amount;
            }
        }
    }
}