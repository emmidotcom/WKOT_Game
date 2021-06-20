using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");    //dann l�ds in level1 szene

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Infos()
    {
        SceneManager.LoadScene("Infos"); //dann l�ds in Infos Szene

    }
}
