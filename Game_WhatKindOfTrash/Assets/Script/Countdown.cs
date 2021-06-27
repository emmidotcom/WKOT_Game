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
    public AudioSource GameOverTon;
    public AudioSource Ticking;

    [SerializeField] Text countdownText;

    public GameObject GameOver;

    public LevelManager Manager;

    bool Running = false;

    public ScoreManager ScoreManager;
    public GameObject NextLevelButton;
    public GameObject PunkteFehlen;

    // Update is called once per frame

    private void Start()
    {
        Ticking.PlayDelayed(6.0f);
    }
    void Update()
    {
        if (!Running) return;
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");


        if (currentTime <= 0)
        {
            Running = false;
            currentTime = 0;
            Manager.trashSpawner.StopTrashSpawn(); 
            GameOver.gameObject.SetActive(true);

            if (ScoreManager.score > 10)                 //Punkte die man braucht um Level zu bestehen hier angeben
            {
                NextLevelButton.SetActive(true);
            }
            else
            {
                PunkteFehlen.SetActive(true);
            }
        }

        if (currentTime == 0) 
        {
            GameOverTon.PlayOneShot(GameOverTon.clip);
        }

  
        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
            TimeImage.sprite = TimeImageRed;
            //Ticking.PlayOneShot(Ticking.clip);
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
