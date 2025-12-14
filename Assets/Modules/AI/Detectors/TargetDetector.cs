using UnityEngine;
using DarkTowerTron.AI.Core;

namespace DarkTowerTron.AI.Detectors
{
    public class TargetDetector : Detector
    {
        [Header("Settings")]
        public float detectionRange = 20f;
        public LayerMask targetLayer; // Set to 'Player' and 'AfterImage'
        public bool showGizmos = false;

        private Collider[] _colliders = new Collider[5];

        public override void Detect(AIData aiData)
        {
            // 1. Find potential targets
            int count = UnityEngine.Physics.OverlapSphereNonAlloc(transform.position, detectionRange, _colliders, targetLayer);

            // 2. Logic: Pick the closest one
            float closestDist = float.MaxValue;
            Transform bestTarget = null;

            for (int i = 0; i < count; i++)
            {
                float dist = Vector3.SqrMagnitude(_colliders[i].transform.position - transform.position);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    bestTarget = _colliders[i].transform;
                }
            }

            // 3. Output
            aiData.currentTarget = bestTarget;
        }

        private void OnDrawGizmos()
        {
            if (showGizmos && Application.isPlaying)
            {
                Gizmos.color = Color.magenta;
                Gizmos.DrawWireSphere(transform.position, detectionRange);
            }
        }
    }
}