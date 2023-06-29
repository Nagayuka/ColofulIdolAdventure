using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collection : MonoBehaviour
{

   bool isAnimating;

    static int count;

    public Sprite ZERO; //0
    public Sprite ONE; //1
    public Sprite TWO; //2
    public Sprite THREE; //3
    public Sprite FOUR; //4
    public Sprite FIVE; //5

    public AudioClip GET;


    void OnTriggerEnter2D(Collider2D get)
    {
        count = count+1;
        GetComponent<AudioSource>().PlayOneShot(GET);


    }

    // Update is called once per frame
    void Update()
    {
     SpriteRenderer renderer=GetComponent<SpriteRenderer>();

        Debug.Log(count);




        if(count==0)
        {
            renderer.sprite=ZERO;
            
        }

        if(count==1)
        {
            renderer.sprite=ONE;
            
        }

        if(count==2)
        {
            renderer.sprite=TWO;
        }

        if(count==3)
        {
            renderer.sprite=THREE;
        }

        if(count==4)
        {
            renderer.sprite=FOUR;
        }

        if(count==5)
        {
            renderer.sprite=FIVE;
        }
        
    
        
    }


}
