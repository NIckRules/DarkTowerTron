using UnityEngine;
using DarkTowerTron.Player; // Required for GritAndFocus

namespace DarkTowerTron.Combat
{
    [RequireComponent(typeof(EnemyStagger))]
    public class EnemyHealth : MonoBehaviour
    {
        private EnemyStagger staggerComp;
        public bool isShielded = false;

        void Start()
        {
            staggerComp = GetComponent<EnemyStagger>();
        }

        public void TakeFatalHit()
        {
            // 1. Check staggerComp.isStaggered.
            if (staggerComp != null && staggerComp.isStaggered)
            {
                // 2. If TRUE: Call Die().
                Die();
            }
            else
            {
                // 3. If FALSE: Logic Gate
                Debug.Log("<color=grey>ARMOR DEFLECTED! Stagger them first!</color>");
            }
        }

        public void TakeHit(float damage, float stagger, Vector3 direction)
        {
            if (staggerComp != null)
            {
                staggerComp.AddStagger(stagger);
            }
        }

        void Die()
        {
            Debug.Log("<color=red>ENEMY EXECUTED!</color>");

            // 1. Find the Player object (Tag "Player").
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                // 2. Get GritAndFocus component.
                GritAndFocus grit = player.GetComponent<GritAndFocus>();

                // 3. Call grit.HealGrit().
                if (grit != null)
                {
                    grit.HealGrit();
                }
            }

            // 4. Spawn a "Death FX" or particle?
            // TODO: Instantiate(deathVFX, transform.position, Quaternion.identity);

            // 5. Destroy(gameObject).
            Destroy(gameObject);
        }
    }
}