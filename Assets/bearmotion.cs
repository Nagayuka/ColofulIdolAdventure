using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearmotion : MonoBehaviour
{
    public AudioClip Asioto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            for(int r = 0; r < 2; r++)
            {
                GetComponent<AudioSource>().PlayOneShot(Asioto);
            }
            transform.Translate(Vector3.up*0.005f);
            
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left*0.005f);

            for(int r = 0; r < 2; r++)
            {
                GetComponent<AudioSource>().PlayOneShot(Asioto);
            }
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right*0.005f);

            for(int r = 0; r < 2; r++)
            {
                GetComponent<AudioSource>().PlayOneShot(Asioto);
            }
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down*0.005f);
            for(int r = 0; r < 2; r++)
            {
                GetComponent<AudioSource>().PlayOneShot(Asioto);
            }
        }
    }
}
