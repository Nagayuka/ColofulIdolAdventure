using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTO : MonoBehaviour
{
    public AudioClip music;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(music);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
