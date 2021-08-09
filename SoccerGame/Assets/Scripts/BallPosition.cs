using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour
{
    static public bool isGoal = false;
    Santra santra;
    [SerializeField] GameObject santraPointer;
    Rigidbody ballbody;

    private void Awake()
    {
        santra = santraPointer.GetComponent<Santra>();
        ballbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (isGoal==true)
        {
            transform.position = new Vector3(santra.transform.position.x, santra.transform.position.y, santra.transform.position.z);
            ballbody.velocity = Vector3.zero;
           isGoal = false;

        }
    }

}
