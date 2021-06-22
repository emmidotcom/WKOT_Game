using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Countdown countdown;
    public TrashSpawner trashSpawner;
    public GameObject EndTutorialButton;
    public AudioSource MyHappySound;

    public GameObject Intro;

  
    public void StartLevel(int levelIndex)
    {
        if (levelIndex == 1)
        {
            EndTutorialButton.SetActive(false);
            Intro.SetActive(false);
            MyHappySound.Play();
        }
 
        countdown.StartCountdown();

        trashSpawner.StartTrashSpawn();

    }

    public void ResetLevel()
    {
        countdown.ResetCountdown();
    }

}
