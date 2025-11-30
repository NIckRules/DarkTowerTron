using UnityEngine;

namespace DarkTowerTron.Combat
{
    public abstract class EnemyAttack : MonoBehaviour
    {
        public abstract void Fire();

        public virtual void BeginTelegraph()
        {
            // Optional base implementation
        }

        public virtual void EndTelegraph()
        {
            // Optional base implementation
        }
    }
}
