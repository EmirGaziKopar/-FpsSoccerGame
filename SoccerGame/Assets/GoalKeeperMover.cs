using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperMover : MonoBehaviour
{
    public new GameObject gameObject;

    
    

    private void Awake()
    {
        gameObject = GetComponent<GameObject>();

    }

    private void Update()
    {



        transform.position = new Vector3(gameObject.transform.position.x, transform.position.y, transform.position.z);

    }
}
