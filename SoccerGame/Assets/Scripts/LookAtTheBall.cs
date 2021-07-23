using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTheBall : MonoBehaviour
{
    Transform ball;
    Transform head;
    public GameObject headPointer;
    public GameObject ballPointer;




    private void Awake()
    {
        ball = ballPointer.GetComponent<Transform>();
        head = headPointer.GetComponent<Transform>();
    }

    private void Update()
    {

        head.transform.LookAt(ball);
    }
}
