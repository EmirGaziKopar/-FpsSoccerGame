using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class CharacterPower : MonoBehaviourPunCallbacks
{

    PhotonView pw;

    int sayac = 0;
    int sayac1 = 0;

    new Rigidbody rigidbody;
    public AudioSource shoot_audio;
    public AudioSource dribbling_audio;
    GameObject top;
    [SerializeField]float power=50f;
    [SerializeField] float dribblingPower = 10f;
    bool touch;

    

    public static bool isTouchBall;

    
    private void Start()
    {
        pw = GetComponent<PhotonView>();
        if (pw.IsMine)
        {
            if (PhotonNetwork.IsMasterClient) //oyunu kuran
            {
                transform.position = new Vector3(50, 4, 160);
            }
            else
            {
                
                transform.position = new Vector3(50, 4, 70);
            }
        }
        if (!pw.IsMine) //Ben deðilsem sil
        {
            Destroy(GetComponentInChildren<Camera>().gameObject);
        }
    }

    [PunRPC]
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

    [PunRPC]
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
        if(touch==true && Input.GetMouseButtonUp(0) && pw.IsMine)
        {

            CrowdAnimation.goalControl = false;
            isTouchBall = true;
            GetComponent<PhotonView>().RPC("shoot",RpcTarget.All);
            
            Debug.Log("suuut ve gool");
            
        }

        else if (touch == true && Input.GetMouseButtonUp(1) && pw.IsMine)
        {

            CrowdAnimation.goalControl = false;
            isTouchBall = true;
            GetComponent<PhotonView>().RPC("dribbling", RpcTarget.All);
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
