using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 15f; //hier Zeit die wir wollen

    public Image TimeImage;
    public Sprite TimeImageRed;
    public Sprite TimeImageGreen;
    public AudioSource MyAudioSource;
    public AudioSource MyOtherAudioSource;

    [SerializeField] Text countdownText;

    [SerializeField] Image GameOver;

    public LevelManager Manager;

    bool Running = false;

    // Update is called once per frame
    void Update()
    {
        if (!Running) return;
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");


        if (currentTime <= 0)
        {
            currentTime = 0;
            Manager.trashSpawner.StopTrashSpawn(); 
            GameOver.gameObject.SetActive(true);
        }

        if (currentTime == 0) 
        {
            MyOtherAudioSource.PlayOneShot(MyOtherAudioSource.clip);
        }

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
            TimeImage.sprite = TimeImageRed;
            MyAudioSource.PlayOneShot(MyAudioSource.clip);

        }
    }

    public void StartCountdown()
    {
        Running = true;
        currentTime = startingTime;
        GameOver.gameObject.SetActive(false);
        
    }

    public void ResetCountdown()
    {
        Running = false;
        currentTime = startingTime;
        countdownText.text = currentTime.ToString("0");
        TimeImage.sprite = TimeImageGreen;
    }
}
