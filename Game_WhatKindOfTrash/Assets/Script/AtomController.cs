using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomController : MonoBehaviour
{
    public GameObject Atommuell;
    public float SpawnDelay=3f;                     //ab wann solls los gehen
    public GameObject blinkGameObject;
    public int intervallLeft = 5;                   //anzahl wie oft es blinkt
    public float blinkDuration = 0.5f;              //wie schnell blinkts

    private void Awake()
    {
        Atommuell.SetActive(false);
    }

    public void Start()
    {
        StartCoroutine("Blinking_C");

    }


    IEnumerator Blinking_C()
    {
        yield return new WaitUntil(()=>Countdown.Instance.Running);
        yield return new WaitForSeconds(SpawnDelay);

        while (intervallLeft > 0)
        {
            blinkGameObject.SetActive(!blinkGameObject.activeSelf);
            yield return new WaitForSeconds(blinkDuration);

           // if (intervallLeft % 2 == 0)             // % bedeutet "modulo" also der rest (bei jedem 2. blinken wird ton gespielt)
            {
              //  ton spielen
            }

            intervallLeft--;

            if (intervallLeft == 1)
            {
                Atommuell.SetActive(true);
            }
        }
    }
}
