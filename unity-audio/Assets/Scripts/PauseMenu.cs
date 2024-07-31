using System.Dynamic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isActive = false;

    public AudioMixerSnapshot unpaused;
    public AudioMixerSnapshot paused;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isActive)
            {
                Resume();
                unpaused.TransitionTo(-20.00f);
            }
            else
            {
                Pause();
                paused.TransitionTo(0.00f);
            }
        }
    }
    public void Pause()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.SetActive(true);
        isActive =  true;
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        isActive = false;
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        Time.timeScale = 1f;
    }
}
