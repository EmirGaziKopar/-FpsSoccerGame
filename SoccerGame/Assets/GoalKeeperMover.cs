using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPosition ballPosition;
    public GameObject goalKeeper;

    
    

    private void Awake()
    {
        ballPosition = goalKeeper.GetComponent<BallPosition>();

    }

    private void Update()
    {



        transform.position = new Vector3(ballPosition.transform.position.x, transform.position.y, transform.position.z);

    }
}
