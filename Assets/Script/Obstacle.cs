using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
         
        // ตรวจสอบว่าวัตถุที่ชนเข้ามาเป็นผู้เล่นหรือไม่
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit the obstacle!");
            // หยุดการเคลื่อนไหวของผู้เล่น
            
            //UIManager.Instance.ShowGameOverUI();
        }
    }
}
