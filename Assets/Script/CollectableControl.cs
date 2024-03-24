using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int CupcakeCount;
    public GameObject CupcakeCountDisplay;
    public GameObject CupcakeEndDisplay;

    private void Start()
    {
        CupcakeCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(CupcakeCountDisplay != null)
        {
            CupcakeCountDisplay.GetComponent<TMP_Text>().text = "" + CupcakeCount;
            CupcakeEndDisplay.GetComponent<TMP_Text>().text = "" + CupcakeCount;
        }
    }
}
