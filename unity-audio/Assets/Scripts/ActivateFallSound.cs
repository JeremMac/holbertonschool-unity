using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFallSound : MonoBehaviour
{
    public GameObject fall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fall.SetActive(true);
        }
    }
}
