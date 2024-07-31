using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallSound : MonoBehaviour
{
    public AudioSource Fall;
    // Start is called before the first frame update
    void Start()
    {
        //Fall.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           // Fall.enabled = true;
            Fall.Play();
        }
    }
}
