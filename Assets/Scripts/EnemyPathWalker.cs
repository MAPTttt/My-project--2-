using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathWalker : MonoBehaviour
{
    public Path path;
    public float speed = 3;
    
    private List<Transform> waypoints;
    private int current = 0;
    
    void Start()
    {
        if (path == null)
        {
            Debug.LogWarning($"{transform.name}: Path is null");
            return;
        }
        waypoints = path.waypoints;
    }

    void Update()
    {
        if(path == null) return;

        if (Vector3.Distance(transform.position, path.waypoints[current].position) < 0.3f)
            current = (current + 1) % waypoints.Count;
        
        transform.LookAt(waypoints[current].position);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
