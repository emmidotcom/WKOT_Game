using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
   // Bottom myAtomBottom;
   // public AudioSource MyAtomSource;
   // public GameObject AtomGameOver;


    public static Countdown Instance;
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

    public bool Running = false;
   // public bool isPaused;

    public ScoreManager ScoreManager;
    public GameObject NextLevelButton;
    public GameObject PunkteFehlen;
    public GameObject SchildiHappy;
    public GameObject SchildiSad;
    public GameObject Recycling1;
    public GameObject Recycling2;
    public GameObject Recycling3;

    private void Awake()
    {
        if (Instance == null) //darf nur einmal existieren
        {
            Instance = this;
        }
    }


    void Update()
    {
        if (!Running) return;
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");  

            if (currentTime <= 0) //&&!myAtomBottom.AtomKatastrophe)
            {
                Running = false;
                currentTime = 0;
                Manager.trashSpawner.StopTrashSpawn();
                GameOver.gameObject.SetActive(true);



                if (ScoreManager.score > 30)                 //Punkte die man braucht um Level zu bestehen hier angeben
                {
                    NextLevelButton.SetActive(true);
                    SchildiHappy.SetActive(true);
                    Recycling1.SetActive(true);
                    Recycling2.SetActive(true);

                }

                else
                {
                    PunkteFehlen.SetActive(true);
                    SchildiSad.SetActive(true);
                    Recycling1.SetActive(true);
                }


                if (ScoreManager.score > 100)
                {

                    Recycling3.SetActive(true);

                }

            }
        
       // if (myAtomBottom.AtomKatastrophe)
        //{
          //  Running = false;
          //  currentTime = 0;
          //  Manager.trashSpawner.StopTrashSpawn();
          //  AtomGameOver.SetActive(true); 
            
          //  if (currentTime == 0)
          //  {
          //      MyAtomSource.Play();
          //  }
       // }
       
        
            if (currentTime == 0)// && !myAtomBottom.AtomKatastrophe)
            {
                GameOverTon.PlayOneShot(GameOverTon.clip);
            }

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
            TimeImage.sprite = TimeImageRed;
        }


        if (Running)
        {
            Ticking.PlayDelayed(6.0f);
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
