using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderBlue : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int mavitakimgol;
    public static bool isBlueTeamScored;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            BallPosition.isGoal = true;
            mavitakimgol++;
            isBlueTeamScored = true;
            crowd_audio.Play();
            
        }


    }
}
