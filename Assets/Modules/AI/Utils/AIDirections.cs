using System.Collections.Generic;
using UnityEngine;

namespace DarkTowerTron.AI.Utils
{
    public static class AIDirections
    {
        public static List<Vector3> EightDirections = new List<Vector3>
        {
            new Vector3(0,0,1).normalized,   // 0: North
            new Vector3(1,0,1).normalized,   // 1: NorthEast
            new Vector3(1,0,0).normalized,   // 2: East
            new Vector3(1,0,-1).normalized,  // 3: SouthEast
            new Vector3(0,0,-1).normalized,  // 4: South
            new Vector3(-1,0,-1).normalized, // 5: SouthWest
            new Vector3(-1,0,0).normalized,  // 6: West
            new Vector3(-1,0,1).normalized   // 7: NorthWest
        };
    }
}