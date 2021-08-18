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

    Transform opponentPosition; //Bilgisayar�n rakibin hareketlerine g�re hareket etmesi ve t�revleri �eyler i�in kullan�lacak
    [SerializeField]GameObject opponentPointer;



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
        rigidbody = ballPointer.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun kar��ya gitmesini sa�layan z.
        rigidbody.velocity = a * dribblingPower;
    }

    public void shoot()
    {
        rigidbody = ballPointer.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.2f, 0.22f), this.transform.forward.z); //Topun kar��ya gitmesini sa�layan z.
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
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -20 , 0), .5f);
    }
    void onLeft()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, +20, 0), .5f);
    }

    private void FixedUpdate()
    {

        Debug.Log(transform.rotation.y);
        if (ballPosition.transform.position.z > transform.position.z && isOverBackTime == true)
        {
            if (transform.position.x >= 50) //Bunlar�n say�s�n� art�rarak bulundu�u konuma g�re daha isabetli at��lar yapan oyuncular ��karabiliriz
            {
                
                if (touch == true)
                {
                    onRight();
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
                    onLeft();
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


    private void Update()
    {

        backwardRate = 1 / (0 + transform.position.y);//geri bakarken 1'e yakla��yoruz
        forwardRate = 1 / (1 - transform.position.y);//ileri bakarken 0'a yakla��yoruz




        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        body.transform.LookAt(ball);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);














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
