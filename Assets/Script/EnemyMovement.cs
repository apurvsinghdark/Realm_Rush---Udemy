using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();


    private void Start()
    {
        StartCoroutine(FollowPath());
    }
    
    IEnumerator FollowPath()
    {
        print("Starting Patrol...");
        foreach (Waypoint block in path)
        {
            print("visting Patrol : " + block.name);
            transform.position = block.transform.position;

            yield return new WaitForSeconds(1f);
        }
        print("Ending Patrol");

    }
}
