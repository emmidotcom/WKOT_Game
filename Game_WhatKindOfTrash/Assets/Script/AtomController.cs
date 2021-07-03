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

    public AudioSource AtomAlarm;

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

        AtomAlarm.PlayOneShot(AtomAlarm.clip);

        while (intervallLeft > 0)
        {
            blinkGameObject.SetActive(!blinkGameObject.activeSelf);
            yield return new WaitForSeconds(blinkDuration);


            intervallLeft--;

            if (intervallLeft == 1)
            {
                Atommuell.SetActive(true);
            }
        }
    }
}
