using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtTheObject : MonoBehaviour
{
    Transform ball;
    [SerializeField]GameObject ballPointer;

    private void Start()
    {
        ball = ballPointer.GetComponent<Transform>();
    }

    private void Update()
    {
        transform.LookAt(ball);
    }
}
