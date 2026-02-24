using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> waypoints; //= new();

    private void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Count == 0) return;
        
        for (int i = 0; i < waypoints.Count - 1; i++)
        {
            if (waypoints[i] == null) continue;
            
            Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
        }
    }
}
