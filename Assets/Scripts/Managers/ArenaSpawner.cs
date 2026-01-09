using DarkTowerTron.Core.Debug;
using DarkTowerTron.Core.Services;
using UnityEngine;
using Global = DarkTowerTron.Core.Services.Services;

namespace DarkTowerTron.Managers
{
    public class ArenaSpawner : MonoBehaviour
    {
        [Header("Setup")]
        public Transform[] spawnPoints;

        [Header("Debug")]
        public bool showDebugRays = true;
        public float debugLineDuration = 20f;

        public GameObject SpawnEnemy(GameObject prefab, int forcedIndex = -1)
        {
            if (spawnPoints == null || spawnPoints.Length == 0 || prefab == null) return null;

            // 1. Pick Point
            Transform sp;
            if (forcedIndex >= 0 && forcedIndex < spawnPoints.Length) sp = spawnPoints[forcedIndex];
            else sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // 2. Randomize Offset
            Vector2 randomCircle = Random.insideUnitCircle * 2.0f;
            Vector3 attemptPos = sp.position + new Vector3(randomCircle.x, 0, randomCircle.y);

            // 3. Find Floor
            Vector3 spawnPos;

            int mask = LayerMask.GetMask("Ground", "Default", "Wall");
            Vector3 rayOrigin = attemptPos + Vector3.up * 50f;

            if (UnityEngine.Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 100f, mask))
            {
                spawnPos = hit.point;

                // Call dedicated Debugger
                if (showDebugRays) VisualizeSpawn(rayOrigin, hit, true);
            }
            else
            {
                // Fallback (Air Drop)
                spawnPos = attemptPos + Vector3.up * 2.0f;

                // Call dedicated Debugger
                if (showDebugRays) VisualizeSpawn(rayOrigin, new RaycastHit(), false);
            }

            return Global.Pool.Spawn(prefab, spawnPos, Quaternion.LookRotation(sp.forward));
        }

        // --- NEW DEBUG METHOD ---
        private void VisualizeSpawn(Vector3 origin, RaycastHit hit, bool success)
        {
            if (success)
            {
                // Draw Green Line to exact hit point
                Debug.DrawLine(origin, hit.point, Color.green, debugLineDuration);

                // Draw a small Cross at the hit point so you can see exactly where it landed
                Debug.DrawRay(hit.point, Vector3.up * 0.5f, Color.green, debugLineDuration);
                Debug.DrawRay(hit.point, Vector3.right * 0.5f, Color.green, debugLineDuration);

                // Log details
                string layerName = LayerMask.LayerToName(hit.collider.gameObject.layer);

                GameLogger.Log(LogChannel.System,
                    $"<color=green>[SPAWN HIT]</color> Object: <b>{hit.collider.name}</b> | Layer: <b>{layerName}</b> | Height Y: <b>{hit.point.y:F2}</b>",
                    hit.collider.gameObject);
            }
            else
            {
                // Draw Red Line all the way down
                Debug.DrawRay(origin, Vector3.down * 100f, Color.red, debugLineDuration);

                GameLogger.LogError(LogChannel.System,
                    $"<color=red>[SPAWN MISS]</color> Raycast from {origin} hit NOTHING! Enemy air-dropped.",
                    gameObject);
            }
        }
    }
}