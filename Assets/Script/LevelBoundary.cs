using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float LeftSide = -3.5f;
    public static float RightSide = 3.5f;
    public float InternalLeft;
    public float InternalRight;

    // Update is called once per frame
    void Update()
    {
        InternalLeft = LeftSide;
        InternalRight = RightSide;
    }
}
