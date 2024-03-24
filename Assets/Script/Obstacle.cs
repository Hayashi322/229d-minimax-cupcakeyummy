using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Player player; // ประกาศตัวแปร player ด้วยชื่อของคลาสที่ใช้ควบคุมการเคลื่อนไหวของผู้เล่น
    public GameObject endScreen;
    public GameObject CountDisplay;
    private void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าวัตถุที่ชนเข้ามาเป็นผู้เล่นหรือไม่
        if (other.CompareTag("obstacle"))
        {
            Debug.Log("Player hit the obstacle!");

            // หยุดการเคลื่อนไหวของผู้เล่น
            player.StopMovement();
            endScreen.SetActive(true);
            CountDisplay.SetActive(false);
        }
    }
}
