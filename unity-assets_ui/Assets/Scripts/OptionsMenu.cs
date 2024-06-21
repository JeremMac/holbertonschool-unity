using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    int PreviousScene;
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Update()
    {
          if (SceneManager.GetActiveScene().name != "Options")
        {
            PreviousScene = SceneManager.GetActiveScene().buildIndex;
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(PreviousScene);
    }
}
