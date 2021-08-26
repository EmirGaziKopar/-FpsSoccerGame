using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderBlueSingle : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int mavitakimgol;
    public static bool isBlueTeamScored;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            BallPositionSingle.isGoal = true;
            mavitakimgol++;
            isBlueTeamScored = true;
            crowd_audio.Play();
            CrowdAnimation.goalControl = true;
        }


    }
}
