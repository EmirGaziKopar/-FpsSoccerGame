using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneMotoru : MonoBehaviour
{
    public void goSingle()
    {

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
}
