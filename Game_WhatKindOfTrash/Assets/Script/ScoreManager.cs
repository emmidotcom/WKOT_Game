using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //WICHTIG!!! Script muss auf UnityEngine.UI zugreifen können sonst versteht das Script die Befehle nicht

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;    //Script wird für andere Sripte verwendbar

    public Text scoreText;                  //Welcher Text ist gemeint

    public int score = 0;                          //Score am Anfang 0

    private void Awake()                    //Script wird für andere Sripte verwendbar             
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "x " + score.ToString();   //Angezeigter Text = "x und ScoreKette (addierte Zahlen Kette)
    }

    public void AddPoint()                          //Eine Score Variante +15  ->  richtig zugeordnet
    {
        score += 15;
        scoreText.text = "x " + score.ToString();
        
    }

    public void TakePoint()                         //Zweite Score Variante -5  ->  falsch zugeordnet
    {
        score -= 10;
        scoreText.text = "x " + score.ToString();
    }

    public void AddTakePoint()                      //Dritte Score Variante -10  ->   garnicht zugeordnet/fällt auf den Boden
    {
        score -= 15;
        scoreText.text = "x " + score.ToString();
    }
}


// offensichtlich ist egal ob AddPoint / TakePoint / AddTakePoint weil ich letzeres erfunden habe.
// Es müssen nur verschiedene Varianten sein um den Befehl klar zu definieren