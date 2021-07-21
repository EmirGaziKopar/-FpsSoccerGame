using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPosition ball; //Eriþilmek istenen nesne
    public GameObject ballPosition; 

    
    

    private void Awake()
    {
        ball = ballPosition.GetComponent<BallPosition>();

    }

    private void Update()
    {


        if(ball.transform.position.x > 41 && ball.transform.position.x < 58)
        {
            transform.position = new Vector3(ball.transform.position.x, transform.position.y, transform.position.z);
        }
        

    }
}
