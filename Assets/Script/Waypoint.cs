using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    //Vector2Int gridPos;

    const int gridSize = 10;
    public int GridSize => gridSize; //Encapsulated

    public Vector2Int GridPos()
    {
        return new Vector2Int(
             Mathf.RoundToInt(transform.position.x / gridSize) * gridSize,
             Mathf.RoundToInt(transform.position.z / gridSize) * gridSize
        ); 
    }
}
