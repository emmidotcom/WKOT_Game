using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f; //hier Zeit die wir wollen

    [SerializeField] Text countdownText;

    [SerializeField] Image GameOver;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        GameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            Time.timeScale = 0f;
            GameOver.gameObject.SetActive(true);
        }

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }
    }
}
