using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStander : MonoBehaviour
{
    public Transform target;
    
    void Update()
    {
        if (target == null) return;
        
        transform.LookAt(target);
    }
}
