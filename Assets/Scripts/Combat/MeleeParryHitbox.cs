using UnityEngine;

namespace DarkTowerTron.Combat
{
    public class MeleeParryHitbox : MonoBehaviour
    {
        public float knockbackForce = 25f;
        public float stunDuration = 0.5f; // How long AI is disabled

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                // Check specifically for the Chaser AI
                ChaserAI chaser = other.GetComponent<ChaserAI>();

                if (chaser != null)
                {
                    Debug.Log("HOME RUN!");

                    // Calculate direction: From Player -> To Enemy
                    Vector3 dir = (other.transform.position - transform.position).normalized;
                    dir.y = 0; // Keep it flat so they don't fly into orbit

                    // Call the new function
                    chaser.ApplyKnockback(dir * knockbackForce, stunDuration);

                    // Optional: Add small stagger?
                    // other.GetComponent<Enemy>().TakeHit(0, 10f, Vector3.zero);
                }
            }
        }
    }
}