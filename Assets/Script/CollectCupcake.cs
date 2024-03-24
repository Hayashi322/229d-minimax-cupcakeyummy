using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectCupcake : MonoBehaviour
{
    public AudioSource CupcakeFX;

    void OnTriggerEnter(Collider other)
    {
        CollectableControl.CupcakeCount += 1;
        if (CupcakeFX != null)
        {
            CupcakeFX.Play();

        }
        this.gameObject.SetActive(false);
    }

}
