using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour
{
    BallPosition ballPosition;
    [SerializeField] float speed;
    [SerializeField]GameObject ballPointer;
    public GameObject BodyPointer;
    Transform ball;
    Transform body;
    float y;//position
    bool touch;
    float x;//rotation
    new Rigidbody rigidbody;
    public float power;

    float backTime=1f;
    float backtime;
    bool isOverBackTime;

    private void Awake()
    {
        isOverBackTime = true;
        y=transform.position.y;
        ballPosition = ballPointer.GetComponent<BallPosition>();
        ball = ballPointer.GetComponent<Transform>();
        body = BodyPointer.GetComponent<Transform>();
        x = transform.rotation.x;
        backtime = backTime;
        

    }


    public void shoot()
    {
        rigidbody = ballPointer.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.2f, 0.22f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * power;

    }

    void turn()
    {
        
        
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -180, 0), .5f);
        
        
    }

    void runBack()
    {
        transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime * 2);
    }

    void onRight()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90 , 0), .5f);
    }
    void onLeft()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, +90, 0), .5f);
    }
    private void Update()
    {

        

        if (ballPosition.transform.position.z > transform.position.z && isOverBackTime == true)
        {
            if (transform.position.x >= 50)
            {
                onRight();
                if (touch == true)
                {
                    shoot();
                    Debug.Log("suuut ve gool");

                }
            }
            else if (transform.position.x < 50)
            {
                onLeft();
                if (touch == true)
                {
                    shoot();
                    Debug.Log("suuut ve gool");

                }
            }
            transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
            body.transform.LookAt(ball);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            isOverBackTime = false;
            backTime -= Time.deltaTime;
            if (backTime < 0) 
            {
                isOverBackTime = true;
            }
            runBack();
        }

        








        





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            ballPointer = other.gameObject;
            touch = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            touch = false;
        }
    }


}
