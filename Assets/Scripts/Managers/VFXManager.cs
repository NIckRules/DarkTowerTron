using UnityEngine;
using DarkTowerTron.Core;
using DarkTowerTron.Core.Data;

namespace DarkTowerTron.Managers
{
    public class VFXManager : MonoBehaviour
    {
        public static VFXManager Instance;

        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab;

        [Header("Settings")]
        public LayerMask groundLayer; // Set to 'Ground', 'Default', 'Wall'

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            // Default mask if forgotten
            if (groundLayer == 0) groundLayer = LayerMask.GetMask("Ground", "Default", "Wall");
        }

        private void OnEnable()
        {
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
            if (explosionPrefab && PoolManager.Instance)
            {
                // Explosion happens exactly where the enemy died (center mass)
                GameObject vfx = PoolManager.Instance.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && PoolManager.Instance)
            {
                // FIX: Find the actual floor below the spawn position
                Vector3 vfxPos = pos;

                // Cast from slightly above the spawn point downwards
                if (UnityEngine.Physics.Raycast(pos + Vector3.up * 2.0f, Vector3.down, out RaycastHit hit, 10f, groundLayer))
                {
                    // Found ground! Snap visual to it + slight offset to prevent z-fighting
                    vfxPos = hit.point + Vector3.up * 0.1f;
                }
                else
                {
                    // Fallback: Just put it at the enemy's feet (assuming pos is feet)
                    vfxPos = pos + Vector3.up * 0.1f;
                }

                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, vfxPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}