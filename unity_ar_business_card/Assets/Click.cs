using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Click : MonoBehaviour
{
    public string url;
    public AudioSource click;
    void OnMouseDown()
    {
        click.Play();
        Application.OpenURL(url);
        Debug.Log("clicked");
    }
}
