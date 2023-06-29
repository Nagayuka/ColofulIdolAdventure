using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goal = transform.position;

        //下
        if(goal.y<-6.0f)
        {
           SceneManager.LoadScene("5hiroba2");

        }
                
        
    }
}
