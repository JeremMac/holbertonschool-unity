using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RockOrGrass : MonoBehaviour
{
    public GrassStep grassStep;
    // Start is called before the first frame update
    void Start()
    {
        grassStep = gameObject.GetComponent<GrassStep>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grass"))
        {
            grassStep.enabled = true;
            Debug.Log("Herbes!");
        }
        else
        {
            grassStep.enabled = false;
        }
    }
}
