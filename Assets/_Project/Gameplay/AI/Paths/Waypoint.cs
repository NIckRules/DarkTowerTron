using UnityEngine;

#if UNITY_EDITOR
using UnityEditor; // <--- WRAP THIS
#endif

namespace DarkTowerTron.Gameplay.AI
{
    public class Waypoint : MonoBehaviour
    {
        public float waitTime = 0f;
        public AIState overrideState;
        public float overrideDuration = 5f;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, 0.5f);

            // --- WRAP THE LABEL LOGIC ---
#if UNITY_EDITOR
            Handles.Label(transform.position + Vector3.up, name);
#endif
        }
    }
}