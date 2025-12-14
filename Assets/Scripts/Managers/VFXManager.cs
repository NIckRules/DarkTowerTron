using UnityEngine;
using DarkTowerTron.Core;

namespace DarkTowerTron.Managers
{
    public class VFXManager : MonoBehaviour
    {
        [Header("Prefabs")]
        public GameObject explosionPrefab;
        public GameObject spawnPrefab; 

        private void OnEnable()
        {
            GameEvents.OnEnemyKilled += PlayDeathVFX;
            GameEvents.OnEnemySpawned += PlaySpawnVFX; // NEW
        }

        private void OnDisable()
        {
            GameEvents.OnEnemyKilled -= PlayDeathVFX;
            GameEvents.OnEnemySpawned -= PlaySpawnVFX;
        }

        // Update the signature to match the new Event
        private void PlayDeathVFX(Vector3 pos, DarkTowerTron.Core.Data.EnemyStatsSO stats, bool rewardPlayer)
        {
            if (explosionPrefab && PoolManager.Instance)
            {
                GameObject vfx = PoolManager.Instance.Spawn(explosionPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }

        private void PlaySpawnVFX(Vector3 pos)
        {
            if (spawnPrefab && PoolManager.Instance)
            {
                // FIX: Force the VFX to the ground level (Y=0.1 to avoid z-fighting)
                Vector3 groundPos = new Vector3(pos.x, 0.1f, pos.z);

                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, groundPos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}