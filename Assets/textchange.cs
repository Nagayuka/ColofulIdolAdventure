using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class textchange : MonoBehaviour
{
    bool isAnimating;  
    int ID=1;

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            string[] omikuji=new string[5];
            omikuji[0]="○DAIKICHI○"; 
            omikuji[1]="kichi";  
            omikuji[2]="kyo"; 
            omikuji[3]="chukichi"; 
            omikuji[4]="shokichi"; 


            ID=Random.Range(0,5);//0~4
            GetComponent<TextMeshProUGUI>().text=omikuji[ID];

        }
            if(ID==0)
            {

                transform.Translate(0.005f, 0f, 0f);
                Vector3 goal = transform.position;

                if(goal.x>15.0f)
                {
                    SceneManager.LoadScene("7so");
                }

        
            }


    }
}
