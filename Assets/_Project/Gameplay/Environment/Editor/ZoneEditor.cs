using UnityEngine;
using UnityEditor;
using DarkTowerTron.Gameplay.Environment;
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

        if (GUILayout.Button("Bake Walls"))
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

        TileInfo[] tiles = zone.GetComponentsInChildren<TileInfo>();
        List<GameObject> createdWalls = new List<GameObject>();
        int globalWallCount = 0;

        // --- STEP 1: BUILD THE MAP ---
        Dictionary<Vector2Int, TileInfo> tileMap = new Dictionary<Vector2Int, TileInfo>();
        float gridSize = zone.tileSize;

        foreach (var tile in tiles)
        {
            Vector2Int coord = GetGridCoordinate(tile.transform.position, gridSize);
            if (!tileMap.ContainsKey(coord)) tileMap.Add(coord, tile);
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

                // FIX 1: Use the new category enum
                if (socket.category == SocketCategory.Open_Connector) continue;

                // Robust Direction Calculation (Center to Socket)
                Vector3 dirVector = socket.transform.position - tile.transform.position;
                Vector2Int direction = Vector2Int.zero;

                if (Mathf.Abs(dirVector.z) > Mathf.Abs(dirVector.x))
                    direction = new Vector2Int(0, (dirVector.z > 0) ? 1 : -1);
                else
                    direction = new Vector2Int((dirVector.x > 0) ? 1 : -1, 0);

                // Diagonal Check
                if (Mathf.Abs(dirVector.x) > 1.5f && Mathf.Abs(dirVector.z) > 1.5f)
                {
                    direction = new Vector2Int((dirVector.x > 0) ? 1 : -1, (dirVector.z > 0) ? 1 : -1);
                }

                Vector2Int neighborCoord = myCoord + direction;
                bool hasNeighbor = tileMap.ContainsKey(neighborCoord);

                // If no neighbor exists, we need a wall!
                if (!hasNeighbor)
                {
                    GameObject wallPrefab = null;

                    // FIX 2: Check for specific override first
                    if (socket.specificPrefabOverride != null)
                    {
                        wallPrefab = socket.specificPrefabOverride;
                    }
                    else
                    {
                        // FIX 3: Ask Zone for prefab based on Category
                        wallPrefab = zone.GetWallPrefab(socket.category);
                    }

                    if (wallPrefab != null)
                    {
                        GameObject newWall = (GameObject)PrefabUtility.InstantiatePrefab(wallPrefab, zone.transform);
                        newWall.transform.position = socket.transform.position;
                        newWall.transform.rotation = socket.transform.rotation;

                        globalWallCount++;
                        string socketID = socket.name.Replace("Socket_", "");
                        newWall.name = $"Wall_{tileID}_{socketID}_{globalWallCount:000}";

                        createdWalls.Add(newWall);
                        socket.isOccupied = true;
                    }
                }
                else
                {
                    socket.isOccupied = false;
                }
            }
        }

        Debug.Log($"<color=green>[Zone]</color> Baked {createdWalls.Count} walls.");
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