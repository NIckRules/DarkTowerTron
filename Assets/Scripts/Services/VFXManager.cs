using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Events; // NEW
// ALIAS
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Core.Services
{
    public class VFXManager : MonoBehaviour
    {
        [Header("Wiring")]
        [SerializeField] private EnemyKilledEventChannelSO _enemyKilledEvent;
        [SerializeField] private Vector3EventChannelSO _enemySpawnedEvent; // NEW

        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab;
        public LayerMask groundLayer;

        private void Awake()
        {
            if (groundLayer == 0) groundLayer = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        private void OnEnable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised += PlayDeathVFX;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised += PlaySpawnVFX;
        }

        private void OnDisable()
        {
            if (_enemyKilledEvent) _enemyKilledEvent.OnEventRaised -= PlayDeathVFX;
            if (_enemySpawnedEvent) _enemySpawnedEvent.OnEventRaised -= PlaySpawnVFX;
        }

        private void PlayDeathVFX(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && Global.Pool != null)
            {
                GameObject vfx = Global.Pool.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && Global.Pool != null)
            {
                Vector3 vfxPos = pos + Vector3.up * 0.1f;
                if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2f, Vector3.down, out RaycastHit hit, 10f, groundLayer))
                {
                    vfxPos = hit.point + Vector3.up * 0.1f;
                }

                GameObject vfx = Global.Pool.Spawn(spawnPrefab, vfxPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}