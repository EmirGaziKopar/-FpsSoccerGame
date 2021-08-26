using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPowerSingle : MonoBehaviour
{


    int sayac = 0;
    int sayac1 = 0;

    new Rigidbody rigidbody;
    public AudioSource shoot_audio;
    public AudioSource dribbling_audio;
    GameObject top;
    [SerializeField] float power = 50f;
    [SerializeField] float dribblingPower = 10f;
    bool touch;

    public static bool isTouchBall;





    public void shoot()
    {
        sayac++;
        PlayerPrefs.SetInt("shootValueChar", sayac);
        PlayerPrefs.Save();
        rigidbody = top.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.2f, 0.28f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * power;
        shoot_audio.Play();
    }

    public void dribbling()
    {

        sayac1++;

        PlayerPrefs.SetInt("dripplingValueChar", sayac1);
        PlayerPrefs.Save();
        rigidbody = top.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * dribblingPower;
        dribbling_audio.Play();
    }

    private void Update()
    {
        if (touch == true && Input.GetMouseButtonUp(0))
        {

            CrowdAnimation.goalControl = false;
            isTouchBall = true;
            shoot();

            Debug.Log("suuut ve gool");

        }

        else if (touch == true && Input.GetMouseButtonUp(1))
        {

            CrowdAnimation.goalControl = false;
            isTouchBall = true;
            dribbling();
            Debug.Log("O ne sürmek öyle");
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            top = other.gameObject;
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