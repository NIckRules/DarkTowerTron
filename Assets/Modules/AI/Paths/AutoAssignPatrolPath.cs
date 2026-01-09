using UnityEngine;
using System.Collections;
using DarkTowerTron.Enemy.Modules;

namespace DarkTowerTron.AI.Paths
{
    [RequireComponent(typeof(EnemyPatrolModule))]
    public class AutoAssignPatrolPath : MonoBehaviour
    {
        public bool autoFindNearest = true;
        public PatrolPath explicitPath;

        private void Start()
        {
            if (gameObject.scene.name == null) return;
            var patrolModule = GetComponent<EnemyPatrolModule>();

            if (explicitPath != null)
            {
                SetPath(patrolModule, explicitPath);
            }
            else if (autoFindNearest)
            {
                StartCoroutine(FindAndAssignPathRoutine(patrolModule));
            }
        }

        private IEnumerator FindAndAssignPathRoutine(EnemyPatrolModule module)
        {
            yield return null;
            PatrolPath nearest = FindNearestPath();
            if (nearest != null) SetPath(module, nearest);
        }

        private void SetPath(EnemyPatrolModule module, PatrolPath path)
        {
            if (module != null)
            {
                module.patrolPath = path;
                module.currentWaypointIndex = GetClosestWaypointIndex(path);
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