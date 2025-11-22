using UnityEngine;

namespace DarkTowerTron.Combat
{
    public class DebrisSpawner : MonoBehaviour
    {
        public GameObject shardPrefab;
        public int shardCount = 10;
        public float explosionForce = 500f;

        public void SpawnDebris()
        {
            // SAFETY CHECK: If we forgot to assign the prefab, stop here.
            if (shardPrefab == null)
            {
                Debug.LogWarning($"{gameObject.name} is missing a Shard Prefab in DebrisSpawner!");
                return;
            }

            for (int i = 0; i < shardCount; i++)
            {
                Vector3 randomPos = transform.position + Random.insideUnitSphere * 0.5f;
                GameObject shard = Instantiate(shardPrefab, randomPos, Random.rotation);

                Rigidbody rb = shard.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce, transform.position, 2f);
                }

                Destroy(shard, 3f);
            }
        }
    }
}