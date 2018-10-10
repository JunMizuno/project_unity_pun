using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PhotonUnityNetworkController : MonoBehaviour {
    /// <summary>
    /// 開始時
    /// </summary>
	void Start () {
        // マスターサーバーへ接続
        //PhotonNetwork.OfflineMode = false;
        PhotonNetwork.ConnectUsingSettings();
        //PhotonNetwork.JoinLobby();
        //PhotonNetwork.JoinRandomRoom();
	}
	
    /// <summary>
    /// 更新時
    /// </summary>
	void Update () {
		
	}
}
