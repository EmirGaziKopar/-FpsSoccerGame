using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolder : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int golsayaci;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            golsayaci++;
        crowd_audio.Play();
        }
        

    }
}
