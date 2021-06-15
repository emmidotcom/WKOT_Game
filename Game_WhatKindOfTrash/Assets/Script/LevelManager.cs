using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Countdown countdown;
    public TrashSpawner trashSpawner;
    public GameObject EndTutorialButton;

    public GameObject Intro;

  
    public void StartLevel(int levelIndex)
    {
        if (levelIndex == 1)
        {
            EndTutorialButton.SetActive(false);
            Intro.SetActive(false);
        }
        else if (levelIndex == 2)
        {

        }
        else if (levelIndex == 3)
        {

        }


        countdown.StartCountdown();

        trashSpawner.StartTrashSpawn();

    }

    public void ResetLevel()
    {
        countdown.ResetCountdown();
    }

}
