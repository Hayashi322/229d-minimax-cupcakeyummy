using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer; // ประกาศ thePlayer เป็น GameObject

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Collider>().enabled = false; // ปิด Collider ของวัตถุนี้

        // ปิดการใช้งานสคริปต์ของ Player
        thePlayer.GetComponent<Player>().enabled = false; // เรียกใช้งานคลาส Player ซึ่งไม่สามารถทำได้
    }
}
