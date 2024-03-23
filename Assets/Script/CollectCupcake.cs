using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCupcake : MonoBehaviour
{
    public AudioSource CupcakeFX;

    void OnTriggerEnter(Collider other)
    {
        CupcakeFX.Play();
        this.gameObject.SetActive(false);
    }
}
