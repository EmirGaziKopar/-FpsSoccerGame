using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAnimation : MonoBehaviour    
{

    public static bool goalControl =false;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (goalControl)
        {
            anim.SetBool("isGoal", true);
            


        }
        else
        {

            anim.SetBool("isGoal", false);
        }
    }
}
