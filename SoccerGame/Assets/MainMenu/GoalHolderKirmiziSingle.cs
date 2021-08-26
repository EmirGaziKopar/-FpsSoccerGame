using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderKirmiziSingle : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int kýrmýzýtakýmgol;
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            BallPositionSingle.isGoal = true;
            kýrmýzýtakýmgol++;
        crowd_audio.Play();
            CrowdAnimation.goalControl = true;
        }
        

    }
}
