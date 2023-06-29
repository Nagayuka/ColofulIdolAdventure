using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getkento : MonoBehaviour
{
    
    void Update()
    {
        Vector3 goal =new Vector3(1.0f,-2.6f,-1.0f);
        goal.x = 0.1f*Mathf.Sin(2.4f * Time.time);
        goal.y = -0.2f*Mathf.Sin(7.0f * Time.time)-2.0f;
        transform.position = goal;
    }
    
     void OnTriggerEnter2D(Collider2D get)
    {
       Destroy(gameObject);
    }
}
