using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPosition ballPosition; //Eriþilmek istenen nesne'nin scripti
    public GameObject ballPointer; //
    public GameObject isPassedPointer;
    [SerializeField]float speed;


    

    


    [SerializeField]isPassed isPassed;


    
    

    private void Awake()
    {
        ballPosition = ballPointer.GetComponent<BallPosition>();

        isPassed = isPassedPointer.GetComponent<isPassed>();

        


        
        

    }

    private void Update()
    {
       

        if (isPassed.isAccess == true )
        {
            
                
            

            if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5 && transform.position.x >= ballPosition.transform.position.x && transform.position.x > 40 && transform.position.x < 60) //left
                {

                transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, +80), .1f);
                
                }

                else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55)
                {
                    transform.position = new Vector3(ballPosition.transform.position.x, transform.position.y, transform.position.z); //translate

                }
                
                else if(ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5 && transform.position.x <= ballPosition.transform.position.x && transform.position.x > 40 && transform.position.x < 60) // right
                {

                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -80), .1f);
               
                }
                else if (ballPosition.transform.position.x > 50 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5 && transform.position.x <= ballPosition.transform.position.x && transform.position.x > 40 && transform.position.x < 60)
                {

                
                    transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
                
                

                
                }
                else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 50 && ballPosition.transform.position.y <= 5 && transform.position.x >= ballPosition.transform.position.x && transform.position.x > 40 && transform.position.x < 60)
                {


                    transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);




                }


            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);
                
        }




        

        
        

    }
}
