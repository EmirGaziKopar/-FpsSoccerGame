using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class ManageOnlineSystem : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); //servere baðlanan kod
    }

    public override void OnConnectedToMaster()
    {
        
        Debug.Log("Connected to server");
        //servere girdik buradan da odaya giriþ yapmalýyýz bunun için aþaðýdaki kodu yazýyoruz
        
        PhotonNetwork.JoinLobby(); //eðer baþarýlý bir þekilde giriþ yapabilirsek onJoinedLobbyFonk çalýþacaktýr

    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Lobby'e girildi ");
        PhotonNetwork.JoinOrCreateRoom("oda", new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true }, TypedLobby.Default); //Burasý baþarýlý bir þekilde çalýþýrsa OnJoinedRoom fonksiyonu çalýþacaktýr
    }

    
    public override void OnJoinedRoom()
    {
        Debug.Log("odaya girildi"); //odaya girildiði taktirde yapýlacaklar buraya yazýlýr
        //PhotonNetwork.CurrentRoom.PlayerCount == 2
        GameObject yeni_oyuncu = PhotonNetwork.Instantiate("Character", new Vector3(50f, 9f, 160f), Quaternion.identity, 0);
        

        
    }


    public override void OnLeftLobby()
    {
        Debug.Log("lobiden çikildi");
    }

    public override void OnLeftRoom()
    {
        Debug.Log("odadan çikildi");
    }


}
