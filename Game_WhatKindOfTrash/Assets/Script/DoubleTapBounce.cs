using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapBounce : MonoBehaviour
{

    public float tapForce = 10;                             //Stärke des Bounce -> in Unity selbst variierbar
    public float tiltSmooth = 2;                            //Smoothnes des Bounce -> in Unity selbst variierbar
    public Vector3 startPos;

    public int Tapsleft=5;                                  //so oft muss man tippen damit atom müll verschwindet
    public float shrinkValue=0.1f;                           //prozenturale verkleinerung des Atommülls
    public float SpamDelay=0.18f;                                 //damit man atommüll nicht spammen kann
    private float SpamDelayEnd;

    public float SpinForce=50;                                 //Rotationsdrall beim klicken

    Rigidbody2D rigidbody;                                  //OBJ einbinden
    Quaternion downRotation;                                //Fall-Rotation OBj
    Quaternion forwardRotation;                             //Jump-Rotation OBj
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, 30);          //Fall-Rotation festlegen zB 30
       // forwardRotation = Quaternion.Euler(0, 0, -30);      //Jump-Rotation festlegen zB -30
    }




    // Update is called once per frame
    void OnMouseDown()
    {
        if (!IngameMenu.Instance.isPaused&&Countdown.Instance.Running)
        {
            if (SpamDelayEnd <= Time.time)
            {
                SpamDelayEnd = Time.time + SpamDelay;       //hier wird der delay gesetzt
            }
            else return;

            rigidbody.AddTorque(SpinForce);                        //Jump-Rotation tritt ein
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);       //OBJ jumped/bounced mit TapForce (Stärke des Bounce)
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);        //Fall-Rotation nur während OBJ angeklickt wird
            transform.localScale*= 1 - shrinkValue;

            Tapsleft--;
            if (Tapsleft == 0)
            {
                Destroy(gameObject);
            }
        }
        
    }
}

//PROBLEM!!! Momentan ist egal so man auf den Screen klickt OBJ springt und kann sogar aus dem Bild springen 
