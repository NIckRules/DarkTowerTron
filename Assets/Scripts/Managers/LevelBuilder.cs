using System.Collections.Generic;
using DarkTowerTron.Core.Debug;
using DarkTowerTron.Environment;
using UnityEngine;

namespace DarkTowerTron.Managers
{
    [ExecuteInEditMode]
    public class LevelBuilder : MonoBehaviour
    {
        [Header("Build Configuration")]
        public List<Zone> rooms;

        [Header("Actions")]
        public bool snapNow = false;

        private void Update()
        {
            if (snapNow)
            {
                snapNow = false;
                SnapRooms();
            }
        }

        public void SnapRooms()
        {
            if (rooms == null || rooms.Count == 0) return;

            Vector3 nextPosition = Vector3.zero;

            foreach (var room in rooms)
            {
                if (room == null) continue;

                room.transform.position = nextPosition;

                if (room.ExitPoint != null)
                {
                    nextPosition = room.ExitPoint.position;
                }
                else
                {
                    nextPosition += new Vector3(0, 0, 50);
                }
            }

            // FIX: Use LogChannel.System instead of string
            GameLogger.Log(LogChannel.System, $"[LevelBuilder] Aligned {rooms.Count} Zones.");
        }
    }
}