using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPower : MonoBehaviour
{
    new Rigidbody rigidbody;
    GameObject top;
    [SerializeField]float power=50f;
    bool touch;

    public void shoot()
    {
        rigidbody = top.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, Random.Range(0f, 0.5f), this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a*power;
    }

    private void Update()
    {
        if(touch==true && Input.GetMouseButtonUp(0))
        {
            shoot();
            Debug.Log("suuut ve gool");
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
