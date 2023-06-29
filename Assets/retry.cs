using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public AudioClip Attack;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(Attack);
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.Space))
        {
           SceneManager.LoadScene("8plane"); 
        }
        
    }
}
