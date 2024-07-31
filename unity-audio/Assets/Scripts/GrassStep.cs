using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassStep : MonoBehaviour
{
    public GameObject grassstep;

    // Start is called before the first frame update
    void Start()
    {
        grassstep.SetActive(false);
        //FallSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ActiveSound();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            MuteSound();
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ActiveSound();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            MuteSound();
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActiveSound();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MuteSound();
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActiveSound();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            MuteSound();
        }
    }

    void ActiveSound()
    {
        grassstep.SetActive(true);
    }

    void MuteSound()
    {
        grassstep.SetActive(false);
    }
}
