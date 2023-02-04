using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private string levelSelectScene = "Level Select";
    [SerializeField] public string optionsScene = "";
    [SerializeField] public string level1 = "Level1";
    [SerializeField] public string level2 = "Level2";
    [SerializeField] public string level3 = "Level3";
    [SerializeField] public string level4 = "Level4";
    [SerializeField] public string level5 = "Level5";
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

    public void Level1Button()
    {
        SceneManager.LoadScene(level1);
    }
    public void Level2Button()
    {
        SceneManager.LoadScene(level2);
    }
    public void Level3Button()
    {
        SceneManager.LoadScene(level3);
    }
    public void Level4Button()
    {
        SceneManager.LoadScene(level4);
    }
    public void Level5Button()
    {
        SceneManager.LoadScene(level5);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
