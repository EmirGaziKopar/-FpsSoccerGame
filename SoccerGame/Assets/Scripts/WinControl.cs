using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if((PlayerPrefs.GetInt("boss") == 0))
        {

 
            if (GoalHolderBlue.mavitakimgol==5 )
            {

            SceneManager.LoadScene("LoseScreen");
           

            }
            if(GoalHolderKirmizi.k�rm�z�tak�mgol == 5)
            {
                Debug.Log("roy yenildi");
                PlayerPrefs.SetInt("boss", 1);
                PlayerPrefs.Save();
            SceneManager.LoadScene("WinScreen");
                

             }


        }
        else if((PlayerPrefs.GetInt("boss") == 1))
            {


            if (GoalHolderBlue.mavitakimgol == 5)
            {

                SceneManager.LoadScene("LoseScreen");
                
                

            }
            else if (GoalHolderKirmizi.k�rm�z�tak�mgol == 5)
            {

                SceneManager.LoadScene("WinScreen");
                PlayerPrefs.SetInt("boss", 2);
                PlayerPrefs.Save();
            }



        }
       else if ((PlayerPrefs.GetInt("boss") == 2))
        {


            if (GoalHolderBlue.mavitakimgol == 5)
            {

                SceneManager.LoadScene("LoseScreen");


            }
            if (GoalHolderKirmizi.k�rm�z�tak�mgol == 5)
            {
                Debug.Log("bu niye �al��t�");
                PlayerPrefs.SetInt("boss", 3);
                PlayerPrefs.Save();
                SceneManager.LoadScene("WinScreen");

            }



        }

    }
}
