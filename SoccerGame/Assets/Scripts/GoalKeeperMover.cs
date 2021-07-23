using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPosition ballPosition;
    public GameObject ballPointer;
    public GameObject isPassedPointer;
    [SerializeField] float speed;
    MidPosition midPosition;
    public GameObject MidPointer;


 

    float y;

    float z;








    [SerializeField] isPassed isPassed;





    private void Awake()
    {
        ballPosition = ballPointer.GetComponent<BallPosition>();

        isPassed = isPassedPointer.GetComponent<isPassed>();

        midPosition = MidPointer.GetComponent<MidPosition>();
        z = transform.position.z;
        y = transform.position.y;




    }

    private void Update()
    {


        if (isPassed.isAccess == true)
        {
            /*
            transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, y, z);
            */

            if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5) //left
            {
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, +80), .1f);
            }

            else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55) //Mid
            {
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
            }

            else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5) // right
            {
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -80), .1f);
            }
            else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y <= 5)//left
            {

                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);

            }
            else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5)//right
            {
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
            }


            else if (ballPosition.transform.position.x >= 60 || ballPosition.transform.position.x < 40)
            {

                transform.position = Vector3.MoveTowards(transform.position, midPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);

            }


            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);

        }




    }
}