using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPower : MonoBehaviour
{
    new Rigidbody rigidbody;
    GameObject top;
    [SerializeField]float power=50f;
    [SerializeField] float dribblingPower = 10f;
    bool touch;


    public void shoot()
    {
        rigidbody = top.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0.2f, 0.28f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * power;
    }

    public void dribbling()
    {
        rigidbody = top.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, 0f, this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * dribblingPower;
    }

    private void Update()
    {
        if(touch==true && Input.GetMouseButtonUp(0))
        {
            shoot();
            Debug.Log("suuut ve gool");
        }

        else if (touch == true && Input.GetMouseButtonUp(1))
        {
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
