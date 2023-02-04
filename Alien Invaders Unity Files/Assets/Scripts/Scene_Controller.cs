using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scene_Controller : MonoBehaviour
{


    public Button playbutton;
    public Button quitbutton;
    public Button howtoplaybutton;
    public Button referencesbutton;
    public Button mainmenubutton;


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlayGame()
    {
        SceneManager.LoadScene(4);
    }

    public void References()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void How2()
    {
        SceneManager.LoadScene(5);
    }

    public void How3()
    {
        SceneManager.LoadScene(6);
    }

}