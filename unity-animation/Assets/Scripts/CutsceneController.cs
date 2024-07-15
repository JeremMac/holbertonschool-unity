using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject timerCanvas;
    public PlayerController Player;

    private void Start()
    {

    }

    private void Update()
    {
            
    }
    
    void ActiveCompo()
    {
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        Player.enabled = true;
        gameObject.SetActive(false);
    }
}
