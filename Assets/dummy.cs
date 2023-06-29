using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy : MonoBehaviour
{
    int alpha=0;

    void Update()
    {
        Vector3 mp= GameObject.Find("bear").transform.position;
        SpriteRenderer renderer= GetComponent<SpriteRenderer>();

        if( mp.x> 4.74f 
        && mp.y>-3.62f  && mp.y< 0.87f)
        {
            alpha=255;
        }
        renderer.color=new Color(1,1,1,alpha);
        
    }
}
