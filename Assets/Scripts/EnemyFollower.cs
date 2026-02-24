using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    public float speed = 3;
    public Transform target;
    
    void Update()
    {
        if (target == null) return;
        
        transform.LookAt(target);
        transform.position += speed * transform.forward * Time.deltaTime;
    }
}
