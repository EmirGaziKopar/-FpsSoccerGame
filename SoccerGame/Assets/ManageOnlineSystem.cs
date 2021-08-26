using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class ManageOnlineSystem : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); //servere ba�lanan kod
    }

    public override void OnConnectedToMaster()
    {
        
        Debug.Log("Connected to server");
        //servere girdik buradan da odaya giri� yapmal�y�z bunun i�in a�a��daki kodu yaz�yoruz
        
        PhotonNetwork.JoinLobby(); //e�er ba�ar�l� bir �ekilde giri� yapabilirsek onJoinedLobbyFonk �al��acakt�r

    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Lobby'e girildi ");
        PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default); //Buras� ba�ar�l� bir �ekilde �al���rsa OnJoinedRoom fonksiyonu �al��acakt�r
    }

    
    public override void OnJoinedRoom()
    {
        Debug.Log("odaya girildi"); //odaya girildi�i taktirde yap�lacaklar buraya yaz�l�r
        //PhotonNetwork.CurrentRoom.PlayerCount == 2
        GameObject yeni_oyuncu = PhotonNetwork.Instantiate("Character", new Vector3(50f, 9f, 160f), Quaternion.identity, 0);
        

        
    }


    public override void OnLeftLobby()
    {
        Debug.Log("lobiden �ikildi");
    }

    public override void OnLeftRoom()
    {
        Debug.Log("odadan �ikildi");
    }


}
