using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnection : MonoBehaviourPunCallbacks
{
    void Start()
    {
        print("Connecting to server...");
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        // Locks users to version
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Connected!");
        print(PhotonNetwork.LocalPlayer.NickName);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server: "+ cause.ToString());
    }

}
