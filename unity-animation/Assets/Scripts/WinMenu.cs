using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
