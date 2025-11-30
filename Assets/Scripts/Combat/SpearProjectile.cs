using UnityEngine;

namespace DarkTowerTron.Combat
{
    public class SpearProjectile : MonoBehaviour
    {
        public float speed = 20f;
        public float lifetime = 2f;
        public int pierceCount = 1;
        public float damageMultiplier = 1f;

        private Vector3 direction;
        private bool initialized = false;

        public void Initialize(Vector3 dir)
        {
            direction = dir.normalized;
            initialized = true;
            Destroy(gameObject, lifetime);
        }

        void Update()
        {
            if (!initialized) return;
            transform.position += direction * speed * Time.deltaTime;
        }

        void OnTriggerEnter(Collider c)
        {
            // Logic for hitting enemies would go here
            // For now, we just handle the visual/destruction logic or simple hit
            
            // Example: if (c.CompareTag("Enemy")) { ... }

            // Decrement pierce count
            pierceCount--;
            if (pierceCount <= 0)
            {
                SelfDestruct();
            }
        }

        public void SelfDestruct()
        {
            // Handle trail fading etc here if needed
            Destroy(gameObject);
        }
    }
}
