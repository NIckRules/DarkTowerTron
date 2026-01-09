using UnityEngine;
using System.Collections;
using DarkTowerTron.AI.Pluggable.Core; // Needed for Controller

namespace DarkTowerTron.AI.Paths
{
    [RequireComponent(typeof(PluggableAIController))]
    public class AutoAssignPatrolPath : MonoBehaviour
    {
        public bool autoFindNearest = true;
        public PatrolPath explicitPath;

        private void Start()
        {
            if (gameObject.scene.name == null) return;
            var controller = GetComponent<PluggableAIController>();

            if (explicitPath != null)
            {
                SetPath(controller, explicitPath);
            }
            else if (autoFindNearest)
            {
                StartCoroutine(FindAndAssignPathRoutine(controller));
            }
        }

        private IEnumerator FindAndAssignPathRoutine(PluggableAIController controller)
        {
            yield return null;
            PatrolPath nearest = FindNearestPath();
            if (nearest != null) SetPath(controller, nearest);
        }

        private void SetPath(PluggableAIController controller, PatrolPath path)
        {
            if (controller.blackboard != null)
            {
                controller.blackboard.patrolPath = path;
                controller.blackboard.currentWaypointIndex = GetClosestWaypointIndex(path);
            }
        }

        private PatrolPath FindNearestPath()
        {
            var allPaths = FindObjectsOfType<PatrolPath>();
            if (allPaths.Length == 0) return null;

            PatrolPath best = null;
            float closestDist = float.MaxValue;

            foreach (var path in allPaths)
            {
                if (path.waypoints.Count > 0 && path.waypoints[0] != null)
                {
                    float d = Vector3.Distance(transform.position, path.waypoints[0].transform.position);
                    if (d < closestDist) { closestDist = d; best = path; }
                }
            }
            return best;
        }

        private int GetClosestWaypointIndex(PatrolPath path)
        {
            int bestIndex = 0;
            float closestDist = float.MaxValue;

            for (int i = 0; i < path.waypoints.Count; i++)
            {
                if (path.waypoints[i] == null) continue;
                float d = Vector3.Distance(transform.position, path.waypoints[i].transform.position);
                if (d < closestDist) { closestDist = d; bestIndex = i; }
            }
            return bestIndex;
        }
    }
}