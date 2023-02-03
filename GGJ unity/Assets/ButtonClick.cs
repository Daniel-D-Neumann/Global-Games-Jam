using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] public string levelSelectScene = "TestingGrounds";
    [SerializeField] public string optionsScene = "";
    public void PlayGameButton()
    {
        SceneManager.LoadScene(levelSelectScene);
    }

    public void QuitGameButtion()
    {
        Application.Quit();
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene(optionsScene);
    }
}
