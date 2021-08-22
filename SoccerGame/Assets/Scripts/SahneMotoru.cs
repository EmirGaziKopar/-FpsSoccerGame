using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneMotoru : MonoBehaviour
{
    
    public GameObject warningText;
    public void goPrize()
    {
        if (PlayerPrefs.GetInt("boss") == 3)
        {
            SceneManager.LoadScene("Credits");



        }
        else
        {
           


                warningText.SetActive(true);
            Invoke("warningTextClose", 3);




        }



    }
    public void goRoy()
    {

        PlayerPrefs.SetInt("boss", 0);
        SceneManager.LoadScene("Singleplayer");


    }

    public void goFabre()
    {

        if (PlayerPrefs.GetInt("boss") == 1)
        {
            SceneManager.LoadScene("Singleplayer");


        }
        else
        {


            warningText.SetActive(true);
            Invoke("warningTextClose", 3);
        }



    }



    public void goLeon()
    {

        if (PlayerPrefs.GetInt("boss") == 2)
        {
            SceneManager.LoadScene("Singleplayer");


        }
        else
        {


            warningText.SetActive(true);
            Invoke("warningTextClose", 3);
        }

    }



    public void goSingle()
    {
        PlayerPrefs.DeleteKey("boss");
        SceneManager.LoadScene("Singleplayer");

    }
    public void goExit()
    {


        Application.Quit();



    }
    public void goMenu()
    {


        SceneManager.LoadScene("Main_Menu");


    }

    public void goStory()
    {


        SceneManager.LoadScene("StoryMode");
    }


    public void warningTextClose()
    {



        warningText.SetActive(false);
    }


}
