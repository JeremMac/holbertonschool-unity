using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle isInverted;


    public void Back()
    {
        SceneController.instance.LoadPreviousScene();
    }
    public void Apply()
    {
        if (isInverted.isOn)
        {
            GameSettings.isInverted = true;
            SceneController.instance.LoadPreviousScene();
        }
        else
        {
            GameSettings.isInverted = false;
            SceneController.instance.LoadPreviousScene();
        }
    }
    
}
