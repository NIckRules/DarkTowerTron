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

        private void PlayDeathVFX(Vector3 pos)
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
                GameObject vfx = PoolManager.Instance.Spawn(spawnPrefab, pos, Quaternion.identity);
                var ps = vfx.GetComponent<ParticleSystem>();
                if (ps) ps.Play();
            }
        }
    }
}