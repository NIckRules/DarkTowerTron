using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;
using DarkTowerTron.Core.Services; // Add namespace

namespace DarkTowerTron.Core.Services
{
    public class VFXManager : MonoBehaviour
    {
        // REMOVED: public static VFXManager Instance;

        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab;
        public LayerMask groundLayer;

        private void Awake()
        {
            // REMOVED: Singleton check
            if (groundLayer == 0) groundLayer = GameConstants.MASK_PHYSICS_OBSTACLES;
        }

        private void OnEnable()
        {
            // Keep event subscriptions for now (Session 3 will refactor this)
            GameEvents.OnEnemyKilled += PlayDeathVFX;
            GameEvents.OnEnemySpawned += PlaySpawnVFX;
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= PlayDeathVFX;
            GameEvents.OnEnemySpawned -= PlaySpawnVFX;
        }

        private void PlayDeathVFX(Vector3 pos, EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab)
            {
                // UPDATED: Use Services.Pool
                GameObject vfx = Services.Pool.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab)
            {
                Vector3 vfxPos = pos + Vector3.up * 0.1f;
                // Simplified Raycast for brevity
                if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2f, Vector3.down, out RaycastHit hit, 10f, groundLayer))
                {
                    vfxPos = hit.point + Vector3.up * 0.1f;
                }

                // UPDATED: Use Services.Pool
                GameObject vfx = Services.Pool.Spawn(spawnPrefab, vfxPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}