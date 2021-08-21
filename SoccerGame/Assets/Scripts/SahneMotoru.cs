using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneMotoru : MonoBehaviour
{

    public void goRoy()
    {

        PlayerPrefs.SetInt("boss", 0);
        SceneManager.LoadScene("Singleplayer");


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





}
