using UnityEngine;
using UnityEditor;
using DarkTowerTron.Environment;
using System.Collections.Generic;

[CustomEditor(typeof(Zone))]
public class ZoneEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Zone zone = (Zone)target;

        GUILayout.Space(20);
        GUILayout.Label("Level Tools", EditorStyles.boldLabel);

        if (GUILayout.Button("Snap Tiles to Grid"))
        {
            zone.SnapTiles();
        }

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Bake Walls (Stable)"))
        {
            BakeWalls(zone);
        }

        if (GUILayout.Button("Clear Walls"))
        {
            ClearWalls(zone);
        }

        GUILayout.EndHorizontal();
    }

    private void BakeWalls(Zone zone)
    {
        ClearWalls(zone);

        if (zone.wallPrefabs == null || zone.wallPrefabs.Count == 0)
        {
            Debug.LogError("[Zone] No Wall Prefabs assigned!");
            return;
        }

        GameObject wallPrefab = zone.wallPrefabs[0];
        TileInfo[] tiles = zone.GetComponentsInChildren<TileInfo>();
        List<GameObject> createdWalls = new List<GameObject>();
        int globalWallCount = 0;

        // --- STEP 1: BUILD THE MAP ---
        Dictionary<Vector2Int, TileInfo> tileMap = new Dictionary<Vector2Int, TileInfo>();
        float gridSize = zone.tileSize;

        foreach (var tile in tiles)
        {
            Vector2Int coord = GetGridCoordinate(tile.transform.position, gridSize);

            if (!tileMap.ContainsKey(coord))
            {
                tileMap.Add(coord, tile);
            }
            else
            {
                Debug.LogWarning($"[Zone] Overlapping tiles at {coord}. Check {tile.name}");
            }
        }

        // --- STEP 2: ITERATE SOCKETS ---
        foreach (var tile in tiles)
        {
            if (tile.sockets == null) continue;

            Vector2Int myCoord = GetGridCoordinate(tile.transform.position, gridSize);
            string tileID = $"T[{myCoord.x},{myCoord.y}]";

            foreach (var socket in tile.sockets)
            {
                if (socket == null) continue;
                if (socket.type == SocketType.Connector) continue;

                // --- THE FIX: ROBUST DIRECTION CALCULATION ---
                // Instead of using socket.forward (which changes if you rotate visuals),
                // we calculate the vector from Tile Center to Socket Position.
                // This ALWAYS points towards the neighbor.

                Vector3 dirVector = socket.transform.position - tile.transform.position;

                // Determine direction based on largest axis
                Vector2Int direction = Vector2Int.zero;
                if (Mathf.Abs(dirVector.z) > Mathf.Abs(dirVector.x))
                    direction = new Vector2Int(0, (dirVector.z > 0) ? 1 : -1); // North/South
                else
                    direction = new Vector2Int((dirVector.x > 0) ? 1 : -1, 0); // East/West

                // (Optional) Diagonal check for Triangle tiles
                // If both components are significant (e.g. > 1.0m), treat as diagonal
                if (Mathf.Abs(dirVector.x) > 1.5f && Mathf.Abs(dirVector.z) > 1.5f)
                {
                    direction = new Vector2Int(
                        (dirVector.x > 0) ? 1 : -1,
                        (dirVector.z > 0) ? 1 : -1
                    );
                }

                Vector2Int neighborCoord = myCoord + direction;

                // --- STEP 3: CHECK NEIGHBOR ---
                bool hasNeighbor = tileMap.ContainsKey(neighborCoord);

                if (!hasNeighbor)
                {
                    // Spawn Wall
                    GameObject newWall = (GameObject)PrefabUtility.InstantiatePrefab(wallPrefab, zone.transform);

                    // Uses the Socket's exact transform (so your visual rotation is preserved!)
                    newWall.transform.position = socket.transform.position;
                    newWall.transform.rotation = socket.transform.rotation;

                    // Naming
                    string socketID = socket.name.Replace("Socket_", "");
                    globalWallCount++;
                    newWall.name = $"Wall_{tileID}_{socketID}_{globalWallCount:000}";

                    createdWalls.Add(newWall);
                    socket.isOccupied = true;
                }
                else
                {
                    socket.isOccupied = false;
                }
            }
        }

        Debug.Log($"<color=green>[Zone]</color> Baked {createdWalls.Count} walls using Center-to-Socket logic.");
    }

    private Vector2Int GetGridCoordinate(Vector3 pos, float size)
    {
        return new Vector2Int(
            Mathf.RoundToInt(pos.x / size),
            Mathf.RoundToInt(pos.z / size)
        );
    }

    private void ClearWalls(Zone zone)
    {
        for (int i = zone.transform.childCount - 1; i >= 0; i--)
        {
            Transform child = zone.transform.GetChild(i);
            if (child.name.StartsWith("Wall_"))
            {
                Undo.DestroyObjectImmediate(child.gameObject);
            }
        }
    }
}