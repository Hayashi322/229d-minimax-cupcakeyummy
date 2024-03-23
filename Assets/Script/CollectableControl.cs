using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int CupcakeCount;
    public GameObject CupcakeCountDisplay;

    
    // Update is called once per frame
    void Update()
    {
        if(CupcakeCountDisplay != null)
        {
            CupcakeCountDisplay.GetComponent<TMP_Text>().text = "" + CupcakeCount;
        }
    }
}
