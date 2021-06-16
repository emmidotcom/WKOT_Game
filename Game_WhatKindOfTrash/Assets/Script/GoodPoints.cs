using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //WICHTIG!!! Script muss auf UnityEngine.UI zugreifen können sonst versteht das Script die Befehle nicht

public class GoodPoints : MonoBehaviour
{
    public static GoodPoints instance;    //Script wird für andere Sripte verwendbar
    public Text scoreText;                  //Welcher Text ist gemeint

    int score =  0;                          //Score am Anfang 0

    private void Awake()                    //Script wird für andere Sripte verwendbar             
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "" + score.ToString();   //Angezeigter Text = "x und ScoreKette (addierte Zahlen Kette)
    }

    public void AddGoodPoint()                          //Eine Score Variante +15  ->  richtig zugeordnet
    {
        score += 15;
        scoreText.text = "+" + score.ToString();
        
    }

}
