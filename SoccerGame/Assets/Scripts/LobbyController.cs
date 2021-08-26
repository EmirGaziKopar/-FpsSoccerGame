using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviourPunCallbacks
{


    ManageCodes mc;




    public void OdaKur()
    {
        SceneManager.LoadScene("MultiplayerMode");
        mc.OnJoinedLobby();
        
        

    }

    public void OdaKatýl()
    {
        SceneManager.LoadScene("MultiplayerMode");
        mc.RandomJoinRoom();
        
        



    }



}
