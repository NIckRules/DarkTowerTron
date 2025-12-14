using UnityEngine;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Detectors
{
    public class ObstacleDetector : Detector
    {
        [Header("Settings")]
        public float detectionRadius = 2f;
        public LayerMask obstacleMask;
        public bool showGizmos = true;

        // Optimization: Recycle this array to avoid Garbage Collection
        private Collider[] _colliders = new Collider[10];

        public override void Detect(AIData aiData)
        {
            // Clear previous data
            aiData.obstacles.Clear();

            // Find physics objects
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRadius, _colliders, obstacleMask);

            for (int i = 0; i < count; i++)
            {
                // Add to the data packet
                aiData.obstacles.Add(_colliders[i]);
            }
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, detectionRadius);
            }
        }
    }
}