using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class denki : MonoBehaviour
{
    public Sprite Light;
    public Sprite Dark;
    bool isAnimating=false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpriteRenderer renderer=GetComponent<SpriteRenderer>();
            if(isAnimating==false)
            {
                isAnimating=true;
                renderer.sprite=Light;
            }
            else
            {
                isAnimating=false;
                renderer.sprite=Dark;     
            }
        }
        
    }
}
