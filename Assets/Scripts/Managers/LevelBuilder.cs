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
        public List<LevelModule> rooms;

        [Header("Actions")]
        public bool snapNow = false;

        private void Update()
        {
            if (snapNow)
            {
                SnapRooms();
                snapNow = false;
            }
        }

        public void SnapRooms()
        {
            if (rooms == null || rooms.Count < 2) return;

            for (int i = 1; i < rooms.Count; i++)
            {
                LevelModule previous = rooms[i - 1];
                LevelModule current = rooms[i];

                if (previous != null && current != null && previous.exitPoint != null)
                {
                    current.SnapTo(previous.exitPoint);
                }
            }
            GameLogger.Log(LogChannel.System, "Level Snapped!", gameObject);
        }
    }
}