using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer BGM;
    public AudioMixer SFX;
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            float volumeValue = PlayerPrefs.GetFloat("musicVolume");
            BGM.SetFloat("BGM", Mathf.Log10(volumeValue) * 20);
        }

        if (PlayerPrefs.HasKey("effectVolume"))
        {
            float SFXvolumeValue = PlayerPrefs.GetFloat("effectVolume");
            SFX.SetFloat("SFX", Mathf.Log10(SFXvolumeValue) * 20);
        }
    }
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Debug.Log("Quitting! It's like trying but easier!");
        Application.Quit();
    }
}
