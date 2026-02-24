using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFloater : MonoBehaviour
{
    public bool floatUnderground;
    
    public float height = 1.5f;
    public float speed = 3;
    
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        var sinValue = Mathf.Sin(Time.time * speed) * height;
        
        if (!floatUnderground)
            sinValue = Mathf.Abs(sinValue);
        
        transform.position = startPosition + sinValue * Vector3.up;
    }
}
