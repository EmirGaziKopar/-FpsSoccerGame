using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
public class BallPosition : MonoBehaviourPunCallbacks
{
    static public bool isGoal = false;
    Santra santra;
    [SerializeField] GameObject santraPointer;
    Rigidbody ballbody;
    PhotonView pw;

    private void Awake()
    {
        pw = GetComponent<PhotonView>();
        santra = santraPointer.GetComponent<Santra>();
        ballbody = pw.GetComponent<Rigidbody>();


    }

    private void Start()
    {
        if (!pw.IsMine)
        {
            Destroy(ballbody);
        }
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
