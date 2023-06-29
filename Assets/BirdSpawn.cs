using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdSpawn : MonoBehaviour
{
    public GameObject prehub;

    void Start()
    {
       StartCoroutine("BallSet");
       
    }

      int point=0;

    IEnumerator BallSet()
    {
        for (int i=0; i<15; i++)
        {
            yield return new WaitForSeconds(1.0f);
            Instantiate(prehub,new Vector3(11, Random.Range(-4, 4), -1),Quaternion.identity);
            point=point+1;
        }

    }

    void Update()
    {
        Debug.Log(point);      
    }





}
