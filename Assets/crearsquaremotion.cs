using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crearsquaremotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("B");
       
    }


    int point=0;

    // Update is called once per frame


    IEnumerator B()
    {
        for (int i=0; i<15; i++)
        {
            yield return new WaitForSeconds(1.0f);

            point=point+1;
        }

    }

    void Update()
    {
        
        if(point>14)
        {
            transform.Translate(Vector3.left*0.005f);
        }

        Vector3 goal = transform.position;


        if(goal.x<-7.0f)
        {
           SceneManager.LoadScene("9marius");

        }

        
    }

    void OnTriggerEnter2D(Collider2D crear)
    {
        Debug.Log("clear");
        SceneManager.LoadScene("9marius");
    }

}
