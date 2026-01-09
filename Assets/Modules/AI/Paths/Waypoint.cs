using UnityEngine;
using DarkTowerTron.AI.Pluggable.Core; // Needed for AIState reference

namespace DarkTowerTron.AI.Paths
{
    public class Waypoint : MonoBehaviour
    {
        [Tooltip("How long the AI should wait here before moving on.")]
        public float waitTime = 0f;

        [Tooltip("Optional: A specific State to inject into the AI when it arrives.")]
        public AIState overrideState;

        [Tooltip("How long to stay in the override state before resuming patrol.")]
        public float overrideDuration = 5f;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, 0.5f);
        }
    }
}