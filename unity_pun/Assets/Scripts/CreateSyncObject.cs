using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CreateSyncObject : MonoBehaviour {

    /// <summary>
    /// 開始時
    /// </summary>
	void Start () {
		
	}

    /// <summary>
    /// 更新時
    /// </summary>
	void Update () {
		float x = Random.Range(-10.0f, 10.0f);
		float y = Random.Range(-10.0f, 10.0f);
		float z = Random.Range(-10.0f, 10.0f);
		Vector3 newPos = new Vector3(x, y, z);

        // 左ボタンクリック時
        // プレハブ、座標、回転、ビューインデックス
        if (Input.GetMouseButtonDown(0)) {
            GameObject obj = PhotonNetwork.Instantiate("Cube", newPos, Quaternion.identity, 0);
            // 生成したオブジェクトに力を加える
            Rigidbody objRB = obj.GetComponent<Rigidbody>();
            objRB.AddForce(Vector3.forward * 20f, ForceMode.Impulse);
        }
    }
}
