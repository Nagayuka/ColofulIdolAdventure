using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omikujimotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetKeyDown(KeyCode.Space))
        {

            Transform myTransform = this.transform;
            Vector3 worldAngle = myTransform.eulerAngles;
            worldAngle.x = 0.0f; 
            worldAngle.y = 0.0f; 
            worldAngle.z = -20.0f; 
            myTransform.eulerAngles = worldAngle; 

            


        }


        if(Input.GetKeyUp(KeyCode.Space))
        {
            Transform my = this.transform;
            Vector3 world = my.eulerAngles;
            world.x = 0.0f; 
            world.y = 0.0f; 
            world.z = 10.0f; 
            my.eulerAngles = world; 
        }
        
    }
}
