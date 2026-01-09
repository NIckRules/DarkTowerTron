using UnityEngine;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Systems.Persistence
{
    /// <summary>
    /// Listens to gameplay events and updates the persistent SaveData.
    /// </summary>
    public class StatsTracker : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private PersistenceManager _persistence;

        [Header("Listening To")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerDiedEvent;
        [SerializeField] private DamageTextEventChannelSO _damageEvent; // To track damage dealt

        private void Awake()
        {
            if (_persistence == null)
                _persistence = GetComponent<PersistenceManager>();
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
            // Respect the reward flag: if the enemy killed itself (suicide/contact),
            // don't count it as a player kill.
            if (!reward) return;

            if (_persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalKills++;
            }
        }

        private void OnPlayerDied()
        {
            if (_persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalDeaths++;
                _persistence.CurrentData.totalRuns++;
                _persistence.Save(); // Commit on death
            }
        }

        private void OnDamageDealt(Vector3 pos, float amount, bool isCrit, bool isStagger)
        {
            // Only track health damage, not stagger (optional choice)
            if (!isStagger && _persistence.CurrentData != null)
            {
                _persistence.CurrentData.totalDamageDealt += amount;
            }
        }
    }
}