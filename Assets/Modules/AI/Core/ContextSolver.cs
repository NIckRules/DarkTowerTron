using System.Collections.Generic;
using UnityEngine;
using DarkTowerTron.AI.Utils;

namespace DarkTowerTron.AI.Core
{
    [RequireComponent(typeof(AIData))]
    public class ContextSolver : MonoBehaviour
    {
        [Header("Settings")]
        public List<SteeringBehavior> behaviors;
        public List<Detector> detectors;

        [Header("Debug")]
        public bool showGizmos = true;

        private float[] _interestMap = new float[8];
        private float[] _dangerMap = new float[8];
        private AIData _aiData;
        private Collider _ownerCollider;

        private void Awake()
        {
            _aiData = GetComponent<AIData>();
            // Get the AI's own collider (usually on the root)
            _ownerCollider = GetComponent<Collider>();
        }

        public Vector3 GetDirectionToMove()
        {
            // SAFETY CHECK: If we are called before Awake or missing component
            if (_aiData == null) return transform.forward;

            // 1. Reset Maps
            System.Array.Clear(_interestMap, 0, 8);
            System.Array.Clear(_dangerMap, 0, 8);

            // 2. Run Detectors
            foreach (var detector in detectors)
            {
                // Extra safety check in case a detector slot is null in Inspector
                if (detector != null) detector.Detect(_aiData);
            }

            // 3. Run Behaviors
            foreach (var behavior in behaviors)
            {
                if (behavior != null) behavior.GetSteering(_interestMap, _dangerMap, _aiData);
            }

            // 4. Process Maps
            for (int i = 0; i < 8; i++)
            {
                if (_dangerMap[i] > 0)
                {
                    _interestMap[i] = Mathf.Clamp01(_interestMap[i] - _dangerMap[i]);
                }
            }

            // 5. Average
            Vector3 outputDirection = Vector3.zero;
            for (int i = 0; i < 8; i++)
            {
                outputDirection += AIDirections.EightDirections[i] * _interestMap[i];
            }

            return outputDirection.normalized;
        }

        private void OnDrawGizmos()
        {
            // STRICT SAFETY CHECKS FOR EDITOR GIZMOS
            if (!showGizmos) return;
            if (!Application.isPlaying) return; // Only draw when logic is actually running
            if (_aiData == null) return;        // Don't draw if not initialized

            Gizmos.color = Color.yellow;
            // This call was causing the crash because it ran when _aiData was null
            Gizmos.DrawRay(transform.position, GetDirectionToMove() * 2);
        }
    }
}