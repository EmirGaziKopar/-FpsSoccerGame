using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour
{

    int sayac = 0;
    int sayac1 = 0;
    BallPositionSingle ballPosition;
    float speed;
    [SerializeField]GameObject ballPointer;
    public GameObject BodyPointer;
    Transform ball;
    Transform body;
    float y;//position
    bool touch;
    float x;//rotation
    new Rigidbody rigidbody;
    float power;
    float dribblingPower;
    float backTime=1f;
    float backtime;
    bool isOverBackTime;

    [SerializeField]Animator anim;
    

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
        
        if(difficulty == Difficulty.Low)
        {
            power = 35f;
            speed = 3f;
            dribblingPower = 10f;

        }
        else if(difficulty == Difficulty.Medium)
        {
            power = 50f;
            speed = 4.6f;
            dribblingPower = 14f;
        }
        else if(difficulty == Difficulty.High)
        {
            power = 54f;
            speed = 7f;//6
            dribblingPower = 20f;//18
        }
        else if(difficulty == Difficulty.VeryHigh)
        {
            power = 55f;
            speed = 6.5f;
            dribblingPower = 18f;
        }
        else if(difficulty == Difficulty.highestLevel)
        {
            power = 65f;
            speed = 7f;

        }
        isOverBackTime = true;
        y=transform.position.y;
        ballPosition = ballPointer.GetComponent<BallPositionSingle>();
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
           /* if(transform.position.x >= 50)
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
           */
                
            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 12f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if(transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 12f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x > 60)
            {
                float angleOfRate = 25f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 40)
            {
                float angleOfRate = 25f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
                

        }
        else if(difficulty == Difficulty.Medium)
        {
            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 12f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 12f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x > 60)
            {
                float angleOfRate = 25f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 40)
            {
                float angleOfRate = 25f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
        }
        else if(difficulty == Difficulty.High)
        {
            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 12f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 12f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x > 60 && transform.position.x<=70)
            {
                float angleOfRate = 25f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if(transform.position.x<40 && transform.position.x >= 30)
            {
                float angleOfRate = 25f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x > 70)//60
            {
                float angleOfRate = 35f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
            else if (transform.position.x < 30)//40
            {
                float angleOfRate = 35f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * dribblingPower;
            }
        }
        
    }

    public void shoot()
    {
        anim.SetBool("Shot", true);
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

        else if(difficulty == Difficulty.Medium)
        {
            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 15f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 15f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if(transform.position.x>60 && transform.position.x <= 70)
            {
                float angleOfRate = 35f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if(transform.position.x<40 && transform.position.x >= 30)
            {
                float angleOfRate = 35f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x > 70)
            {
                float angleOfRate = 55f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 30)
            {
                float angleOfRate = 55f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
        }
        else if (difficulty == Difficulty.High)
        {
            if (transform.rotation.y > 0.46 && transform.rotation.y < 0.76)
            {
                float angleOfRate = 80f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            if(transform.rotation.y < -0.46 && transform.rotation.y > -0.76)
            {
                float angleOfRate = 80f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            if(transform.rotation.y > 0.8)
            {
                float angleOfRate = 95f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            if (transform.rotation.y < -0.8)
            {
                float angleOfRate = 95f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }

            if (transform.position.x >= 50 && transform.position.x <= 60)
            {
                float angleOfRate = 35f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 50 && transform.position.x >= 40)
            {
                float angleOfRate = 35f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x > 60 && transform.position.x <= 70)
            {
                float angleOfRate = 45f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 40 && transform.position.x >= 30)
            {
                float angleOfRate = 45f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if(transform.position.x>70 && transform.position.x <= 80)
            {
                float angleOfRate = 65f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if(transform.position.x>=20 && transform.position.x < 30)
            {
                float angleOfRate = 65f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x > 80)//70
            {
                float angleOfRate = 75f;
                onRight(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
                rigidbody.velocity = a * power;
            }
            else if (transform.position.x < 20)//30
            {
                float angleOfRate = 75f;
                onLeft(angleOfRate);
                rigidbody = ballPointer.GetComponent<Rigidbody>();
                Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.22f, 0.23f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
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
        if(GoalHolderBlue.isBlueTeamScored == true)
        {
            anim.SetBool("HappinessOfGoal", true);
            GoalHolderBlue.isBlueTeamScored = false;
            
        }
        Debug.Log(transform.rotation.y);
        if (ballPosition.transform.position.z + 5 > transform.position.z && isOverBackTime == true)
        {
            if(CharacterPower.isTouchBall == true)
            {
                anim.SetBool("HappinessOfGoal", false);
                CharacterPower.isTouchBall = false;
            }
            if (touch == true)
            {
                CrowdAnimation.goalControl = false;
                anim.SetBool("HappinessOfGoal", false); 
                if (ballPosition.transform.position.z < Random.Range(120,160))
                {
                    sayac1++;
                    dribbling();
                    PlayerPrefs.SetInt("dripplingValue", sayac1);
                    PlayerPrefs.Save();

                }
                else
                {
                    sayac++;
                    shoot();
                    PlayerPrefs.SetInt("shootValue", sayac);
                    PlayerPrefs.Save();

                    Debug.Log("suuut ve gool");
                }


            }
            else
            {
                anim.SetBool("Shot", false);
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
        backwardRate = 1 / (0 + transform.position.y);//geri bakarken 1'e yaklaþýyoruz
        forwardRate = 1 / (1 - transform.position.y);//ileri bakarken 0'a yaklaþýyoruz


        transform.position = Vector3.MoveTowards(transform.position, ballPosition.transform.position, Time.deltaTime * speed);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        body.transform.LookAt(ball);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);



    }



    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            CrowdAnimation.goalControl = false;
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
