using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{

    private float time;
    private float vecX;
    private float vecY;

    void Update()
    {
        time -= Time.deltaTime;
 
        if(time <= 0)
        {
           vecX = Random.Range(-8.0f, 8.0f);
           vecY = Random.Range(1.0f, 4.0f);
           this.transform.position = new Vector3(vecX,vecY,-1.0f);
           time = 1.0f;
        }
        
    }
}
