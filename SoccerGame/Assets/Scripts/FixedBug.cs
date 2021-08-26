using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBug : MonoBehaviour
{

    bool touch;
    GameObject ballPointer;
    new Rigidbody rigidbody;
    [Range(15, 40)]
    [SerializeField] float power;
    [SerializeField] Transform characterPosition;
    [SerializeField]BallPositionSingle ballPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballPosition.transform.position.z > characterPosition.position.z)
        {
            if (touch == true)
            {
                shoot();
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            ballPointer = other.gameObject; //other gameobject temasa geçen objenin referansýný almamýzý yani topun referansýný almamýzý saðladý
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

    public void shoot()
    {
        rigidbody = ballPointer.GetComponent<Rigidbody>();
        Vector3 a = new Vector3(this.transform.forward.x, 0.2f , this.transform.forward.z); //Topun karþýya gitmesini saðlayan z.
        rigidbody.velocity = a * power;

    }
}
