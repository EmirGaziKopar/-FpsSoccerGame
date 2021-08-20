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


        

        backwardRate = -1 / (0 + transform.position.y); //geri bakarken 1'e yaklaşıyoruz

        forwardRate = 1 / (1 - transform.position.y); //ileri bakarken 0'a yaklaşıyoruz



        


        horizontal = 0.01f / (0.7071068f - transform.rotation.y);


        


        









        Debug.Log("Sag:" + right);
    }
        

        

                        
    
}
