using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    TextMesh textMesh;
    //Vector3 gridPos;
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GridSize;
        //waypoint.GridPos();
        transform.position = new Vector3(
            waypoint.GridPos().x,
            0f,
            waypoint.GridPos().y);
    }

    private void UpdateLabel()
    {
        textMesh = GetComponentInChildren<TextMesh>();

        int gridSize = waypoint.GridSize;

        string labelText = waypoint.GridPos().x / gridSize + "," + waypoint.GridPos().y / gridSize;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
