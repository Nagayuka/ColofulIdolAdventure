using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planemotion : MonoBehaviour
{
    public AudioClip Oto;
    // Start is called before the first frame update
    void Start()
    {
    
            
        GetComponent<AudioSource>().PlayOneShot(Oto);
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up*0.01f);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down*0.01f);
        }

        
    }
}
