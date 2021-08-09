using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderBlue : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int mavitakimgol;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            BallPosition.isGoal = true;
            mavitakimgol++;
            crowd_audio.Play();
            
        }


    }
}
