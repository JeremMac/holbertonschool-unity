using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScript : MonoBehaviour
{
    public GameObject github;
    public GameObject linkedIn;
    public GameObject gmail;
    public GameObject drive;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disppear()
    {
        github.gameObject.SetActive(false);
        linkedIn.gameObject.SetActive(false);
        gmail.gameObject.SetActive(false);
        drive.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
    }

    public void Appear() 
    {
        github.gameObject.SetActive(true);
        linkedIn.gameObject.SetActive(true);
        gmail.gameObject.SetActive(true);
        drive.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);
        text2.gameObject.SetActive(true);
        text3.gameObject.SetActive(true);
    }

    public void Github()
    {
        //Application.OpenURL("");
        Debug.Log("Clicked");
    }
}
