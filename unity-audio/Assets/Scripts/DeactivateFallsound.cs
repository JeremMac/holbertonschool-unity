using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateFallsound : MonoBehaviour
{
    public GameObject fall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fall.SetActive(false);
        }
    }
}
