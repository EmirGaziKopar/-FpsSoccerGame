using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{

    BallPositionSingle ballPosition;
    Transform ballPosition2;
    [SerializeField] GameObject ballPointer;
    public GameObject isPassedPointer;
    [SerializeField] float speed;
    MidPosition midPosition;
    public GameObject MidPointer;
    new Rigidbody rigidbody;
    [SerializeField] GoalKeeperEnum goalKeeperEnum;
    float y;
    float z;
    [SerializeField] isPassed isPassed;
    private bool touch;

    [Range(1,3)]
    [SerializeField] float shootHeight;


    [SerializeField] float degajPower;


    void right()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -80), .1f);
    }

    void rightGround()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void left()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, +80), .1f);
    }

    void leftGround()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void mid()
    {
        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    void others()
    {
        transform.position = Vector3.MoveTowards(transform.position, midPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, z);
    }

    private void Awake()
    {
        ballPosition = ballPointer.GetComponent<BallPositionSingle>();
        ballPosition2 = ballPointer.GetComponent<Transform>();

        isPassed = isPassedPointer.GetComponent<isPassed>();

        midPosition = MidPointer.GetComponent<MidPosition>();
        z = transform.position.z;
        y = transform.position.y;

        touch = false;
    }

    private void Update()
    {

        if(goalKeeperEnum == GoalKeeperEnum.Left)
        {
            if (isPassed.isAccess == true)
            {
                /*
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                */
                if (touch == true)
                {
                    degaj();
                }

                if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5) //left
                {
                    left();
                }

                else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55) //Mid
                {
                    mid();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5) // right
                {
                    right();
                }
                else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y <= 5)//leftGround
                {

                    leftGround();

                }
                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5)//rightGround
                {
                    rightGround();
                }


                else if (ballPosition.transform.position.x >= 60 || ballPosition.transform.position.x < 40)//OtherShoot
                {

                    others();

                }


                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);

            }
        }
        else if(goalKeeperEnum == GoalKeeperEnum.Right)
        {
            if (isPassed.isAccess == true)
            {
                /*
                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, z);
                */
                if (touch == true)
                {
                    degaj();
                }

                if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y > 5) //left
                {
                    left();
                }

                else if (ballPosition.transform.position.x > 45 && ballPosition.transform.position.x < 55) //Mid
                {
                    mid();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y > 5) // right
                {
                    right();
                }

                else if (ballPosition.transform.position.x > 40 && ballPosition.transform.position.x <= 45 && ballPosition.transform.position.y <= 5)//left
                {
                    leftGround();
                }

                else if (ballPosition.transform.position.x >= 55 && ballPosition.transform.position.x < 60 && ballPosition.transform.position.y <= 5)//right
                {
                    rightGround();
                }

                else if (ballPosition.transform.position.x >= 60 || ballPosition.transform.position.x < 40)
                {
                    others();
                }
                

                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), .1f);

            }
        }
    }
    public void degaj()
    {
        if(goalKeeperEnum == GoalKeeperEnum.Right)
        {
            rigidbody = ballPointer.GetComponent<Rigidbody>();
            Vector3 a = new Vector3(-this.transform.forward.x, shootHeight, -this.transform.forward.z);
            rigidbody.velocity = a * degajPower;
            Debug.Log("Buraya girildi degaj-Right");
        }
        else if(goalKeeperEnum == GoalKeeperEnum.Left)
        {
            rigidbody = ballPointer.GetComponent<Rigidbody>();
            Vector3 a = new Vector3(this.transform.forward.x, shootHeight, this.transform.forward.z);
            rigidbody.velocity = a * degajPower;
            Debug.Log("Buraya girildi degaj-Left");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {

            ballPointer = other.gameObject; //Buraya giren gameobject'i tespit etmemize yardýmcý oluyor
            touch = true;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {

            ballPointer = other.gameObject; //Buraya giren gameobject'i tespit etmemize yardýmcý oluyor
            Debug.Log("Collider içersinde çýkýldý");
            touch = false;
            
        }
    }
    


}