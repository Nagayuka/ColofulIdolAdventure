using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class otosiana : MonoBehaviour
{
    void Update()
    {

        Vector3 mp= GameObject.Find("bear").transform.position;
        Debug.Log(mp);


        if( mp.x> -1.47f && mp.x<0.90f
        && mp.y>-0.50f  && mp.y< 1.73f)
        {
            SceneManager.LoadScene("2hiroba");
        }

    }
        

}