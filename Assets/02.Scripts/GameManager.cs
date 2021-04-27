using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
   void Awake()
   {
        // PhotonNetwork.IsMessageQueueRunning = true;

        Vector3 pos = new Vector3(Random.Range(-150.0f, 150.0f),
                                  5.0f, 
                                  Random.Range(-150.0f, 150.0f));

        // 통신이 가능한 주인공 캐릭터(탱크) 생성
        PhotonNetwork.Instantiate("Tank",
                                   new Vector3(20.0f, 5.0f, 20.0f),
                                   Quaternion.identity,
                                   0);
   }
}
