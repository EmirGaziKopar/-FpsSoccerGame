using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acılarıHesapla : MonoBehaviour
{

    float backwardRate;
    float forwardRate;
    float right;
    float horizontal;

    bool isRight;
    bool isForward;
    bool isLeft;
    bool backWardRate;


    Animator anim;




    private void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    private void Update()
    {


        Debug.Log(transform.rotation.y);


       

        


        









        
    }
        

        

                        
    
}
