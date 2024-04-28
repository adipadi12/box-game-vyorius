using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinMainGame : MonoBehaviourPunCallbacks
{
    public Text button;

    public void OnClickConnect()
    {
        
            button.text = "Connecting...";
            PhotonNetwork.ConnectUsingSettings();
        
    }
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Demo with terrain");
    }
}
