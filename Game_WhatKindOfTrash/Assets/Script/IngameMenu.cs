using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;
    public GameObject PauseButton;
    public static IngameMenu Instance; //singleton (?)

    void Awake()
    {
        Instance = this;    //eigenes Objekt wird in singleton geladen
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");    //dann läds main menü szene
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        PauseButton.SetActive(true);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        PauseButton.SetActive(false);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}

