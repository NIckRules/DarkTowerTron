using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events;
using DarkTowerTron.Core.Services;
using DarkTowerTron.Core.AudioSystem;

namespace DarkTowerTron.Systems.VFX
{
    /// <summary>
    /// Listens to high-level game events and triggers audiovisual feedback.
    /// Acts as the bridge between "Gameplay Logic" and "Core Services".
    /// </summary>
    public class GameFeedbackSystem : MonoBehaviour
    {
        [Header("Inputs (Events)")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private VoidEventChannelSO _playerHitEvent;
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent;

        [Header("Assets (VFX)")]
        [SerializeField] private GameObject _defaultExplosion;
        [SerializeField] private GameObject _spawnVFX;
        [SerializeField] private GameObject _playerHitVFX;

        [Header("Settings")]
        [SerializeField] private LayerMask _groundLayer;

        // Services
        private IVFXService _vfxService;
        private IAudioService _audioService; // Now we can easily add sound too!

        private void Start()
        {
            _vfxService = ServiceLocator.Get<IVFXService>();
            _audioService = ServiceLocator.Get<IAudioService>();

            if (_groundLayer == 0) _groundLayer = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised += OnPlayerHit;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised += OnEnemySpawned;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= OnEnemyKilled;
            if (_playerHitEvent) _playerHitEvent.OnEventRaised -= OnPlayerHit;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised -= OnEnemySpawned;
        }

        // --- Logic Handlers ---

        private void OnEnemySpawned(Vector3 pos)
        {
            if (_spawnVFX == null) return;

            // Logic: Ground Snapping (Moved from Service to System)
            Vector3 vfxPos = pos + Vector3.up * 0.1f;
            if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2f, Vector3.down, out RaycastHit hit, 10f, _groundLayer))
            {
                vfxPos = hit.point + Vector3.up * 0.1f;
            }

            _vfxService.SpawnVFX(_spawnVFX, vfxPos, Quaternion.identity);
            // _audioService.PlaySFX("EnemySpawn", vfxPos); // Easy to add later
        }

        private void OnEnemyKilled(Vector3 position, EnemyStatsSO stats, bool byPlayer)
        {
            // Logic: Determine which explosion to use
            // GameObject explosion = stats.DeathVFX != null ? stats.DeathVFX : _defaultExplosion;

            _vfxService.SpawnVFX(_defaultExplosion, position, Quaternion.identity);
        }

        private void OnPlayerHit()
        {
            // Logic: Find player position (if needed) or just play UI shake
            // _vfxService.SpawnVFX(_playerHitVFX, playerPos, Quaternion.identity);
        }
    }
}