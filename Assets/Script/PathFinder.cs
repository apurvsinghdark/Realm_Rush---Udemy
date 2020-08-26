﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();

    private void Start()
    {
        LoadBlocks();
    }

    private void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<Waypoint>();
      
        foreach (Waypoint waypoint in waypoints)
        {
            var gridPos = waypoint.GridPos();
            bool isOverLapping = grid.ContainsKey(gridPos);

            if (isOverLapping)
            {
                Debug.LogWarning("Grid Contain Overlapping " + waypoint);
            }
            else
                grid.Add(waypoint.GridPos(), waypoint);
        }
        print(grid.Count);
    }
}
