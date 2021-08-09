using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    
   public GameObject tips,text1;
    bool isPaused = false;

    void Start()
    {
        isPaused = true;
        pauseGame();
    }





    public void pauseGame()
    {

        if (isPaused)
        {
            text1.gameObject.SetActive(true);
            tips.gameObject.SetActive(true);
           // menubutton.gameObject.SetActive(true);
            Time.timeScale = 0;
            isPaused = false;
            

        }
        else
        {

            text1.gameObject.SetActive(false);
           // menubutton.gameObject.SetActive(false);
            tips.gameObject.SetActive(false);
            Time.timeScale = 1;
            isPaused = true;




        }








    }
    
       
        

        

        
        
        
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            pauseGame();


        }


        if (Input.GetKeyDown(KeyCode.M))
        {

            SceneManager.LoadScene("Main_Menu");
            Cursor.lockState = CursorLockMode.None;
                 


        }
    }
}
