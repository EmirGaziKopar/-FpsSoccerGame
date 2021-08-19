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
    [SerializeField]float power;
    [SerializeField] float dribblingPower;
    float backTime=1f;
    float backtime;
    bool isOverBackTime;
    
    

    float forwardRate;
    float backwardRate;

    Transform opponentPosition; //Bilgisayarýn rakibin hareketlerine göre hareket etmesi ve türevleri þeyler için kullanýlacak
    [SerializeField]GameObject opponentPointer;


    public enum Difficulty
    {
        Low, Medium, High, VeryHigh, highestLevel
    }


    [SerializeField] Difficulty difficulty;


    private void Awake()
    {
        isOverBackTime = true;
        y=transform.position.y;
        ballPosition = ballPointer.GetComponent<BallPosition>();
        ball = ballPointer.GetComponent<Transform>();
        body = BodyPointer.GetComponent<Transform>();
        x = transform.rotation.x;
        backtime = backTime;
        opponentPosition = opponentPointer.GetComponent<Transform>();

    }


    public void dribbling()
    {
        if (difficulty == Difficulty.Low)
        {
            if(transform.position.x >= 50)
            {
                float angleOfRate = 20f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if(transform.position.x < 50)
            {
                float angleOfRate = 20f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
                /*
            if (transform.position.x >= 50 || transform.position.x <= 60)
            {
                float angleOfRate = 16f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if(transform.position.x < 50 || transform.position.x >= 40)
            {
                float angleOfRate = 16f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x > 60)
            {
                float angleOfRate = -60f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 40)
            {
                float angleOfRate = -60f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
                */

        }
        
    }

    public void shoot()
    {
        if (difficulty == Difficulty.Low)
        {
            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 20f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.20f,0.25f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 20f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.20f, 0.25f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if(transform.position.x > 60)
            {
                float angleOfRate = 50f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.20f, 0.25f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 40)
            {
                float angleOfRate = 50f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.20f, 0.25f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
        }
        
        

    }

    void turn()
    {


        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -180, 0), .5f);
        //body.transform.LookAt(ball);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);


    }

    void runBack()
    {
        transform.position += new Vector3(0f, 0f, -speed * Time.deltaTime * 2);
    }

    void onRight(float angleOfRate)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -angleOfRate, 0), .5f);
    }
    void onLeft(float angleOfRate)
    {
        
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angleOfRate, 0), .5f);
        
    }

    private void FixedUpdate()
    {

        Debug.Log(transform.rotation.y);
        if (difficulty == Difficulty.Low)
        {
            if (ballPosition.transform.position.z+5 > transform.position.z && isOverBackTime == true)
            {
                if (touch == true)
                {

                    if (ballPosition.transform.position.z < 120)
                    {
                        dribbling();
                    }
                    else
                    {
                        shoot();
                        Debug.Log("suuut ve gool");
                    }


                }
                

                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, transform.position.z);
                body.transform.LookAt(ball);
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);


            }
            else
            {
                isOverBackTime = false;
                backTime -= Time.deltaTime;
                if (backTime < 0)
                {
                    isOverBackTime = true;
                }
                turn();
                runBack();


            }
        }
        else if (difficulty == Difficulty.Medium)
        {
            if (ballPosition.transform.position.z + 5 > transform.position.z && isOverBackTime == true)
            {
                if (transform.position.x >= 50) //Bunlarýn sayýsýný artýrarak bulunduðu konuma göre daha isabetli atýþlar yapan oyuncular çýkarabiliriz
                {

                    if (touch == true)
                    {
                        onRight(20);
                        if (ballPosition.transform.position.z < 120)
                        {
                            dribbling();
                        }
                        else
                        {
                            shoot();
                            Debug.Log("suuut ve gool");
                        }


                    }
                }
                
                else if (transform.position.x < 50)
                {



                    if (touch == true)
                    {
                        onLeft(20);
                        if (ballPosition.transform.position.z < 120)
                        {
                            dribbling();
                        }
                        else
                        {
                            shoot();
                            Debug.Log("suuut ve gool");
                        }



                    }
                }

                transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, y, transform.position.z);
                body.transform.LookAt(ball);
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);


            }
            else
            {
                isOverBackTime = false;
                backTime -= Time.deltaTime;
                if (backTime < 0)
                {
                    isOverBackTime = true;
                }
                turn();
                runBack();


            }
        }


    }


    private void Update()
    {

        if(difficulty == Difficulty.Low)
        {
            backwardRate = 1 / (0 + transform.position.y);//geri bakarken 1'e yaklaþýyoruz
            forwardRate = 1 / (1 - transform.position.y);//ileri bakarken 0'a yaklaþýyoruz




            transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
            body.transform.LookAt(ball);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
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
