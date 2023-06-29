using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goal = transform.position;


        //右
        if(goal.x>10.0f)
        {
           SceneManager.LoadScene("8plane");

        }

        //左

        if(goal.x<-10.0f)
        {
           SceneManager.LoadScene("2hiroba");

        }

        //上
        if(goal.y>6.0f)
        {
           SceneManager.LoadScene("6shori");

        }

        //下
        if(goal.y<-6.0f)
        {
           SceneManager.LoadScene("7Omikuji");

        }
        
    }
}
