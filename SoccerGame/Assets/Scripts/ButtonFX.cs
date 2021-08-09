using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{

    public AudioSource myFx;
    public AudioClip hoverFx;


    public void hoverSound()
    {

        myFx.PlayOneShot(hoverFx);


    }
}
