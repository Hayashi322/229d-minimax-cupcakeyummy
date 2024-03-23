using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float LeftRightSpeed = 5;

    private bool isMoving = true;

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World);

            if (Input.GetKey(KeyCode.A))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.LeftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.RightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed * -1);
                }
            }
        }
            
    }

    public void StopMovement()
    {
        isMoving = false;
    }
}
