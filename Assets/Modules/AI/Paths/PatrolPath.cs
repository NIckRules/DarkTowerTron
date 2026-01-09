using UnityEngine;
using System.Collections.Generic;

namespace DarkTowerTron.AI.Paths
{
    public class PatrolPath : MonoBehaviour
    {
        public List<Waypoint> waypoints;
        public bool loop = true;

        private void OnDrawGizmos()
        {
            if (waypoints == null || waypoints.Count < 2) return;

            Gizmos.color = Color.cyan;
            for (int i = 0; i < waypoints.Count - 1; i++)
            {
                if (waypoints[i] && waypoints[i + 1])
                    Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
            }

            if (loop && waypoints[0] && waypoints[waypoints.Count - 1])
            {
                Gizmos.DrawLine(waypoints[waypoints.Count - 1].transform.position, waypoints[0].transform.position);
            }
        }
    }
}