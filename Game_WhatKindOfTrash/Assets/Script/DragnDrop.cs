using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool Pressed = false;

    void OnMouseDown()                                          //Wenn Maus gedr�ckt OBJ wird Kinematic (Starr) und kann bewegt werden
    {
        if (!IngameMenu.Instance.isPaused && Countdown.Instance.Running)                        //ausf�hren falls nicht pausiert -> damit man sachen im pause ned bewegen kann
        {
            Pressed = true;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;  //dann f�llts einfach runter
            GetComponent<Rigidbody2D>().isKinematic = true;

            GetComponent<Rigidbody2D>().angularVelocity = 0;  //damit M�ll sich nicht weiter rotiert

        }
    }
    void OnMouseUp()                                            //Wenn Maus losgelassen OBJ wird Dynamik und bewegt sich wie zuvor weiter
    {
        if (!IngameMenu.Instance.isPaused && Countdown.Instance.Running)                       //ausf�hren falls nicht pausiert -> damit man sachen im pause ned bewegen kann
        {
            Pressed = false;
            GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Pressed)                                             //Maus Gedr�ckt halten -> OBJ folgt Mausposition
        {
            if (!Countdown.Instance.Running)
            {
                Pressed = false;
            }

            else if (IngameMenu.Instance.isPaused)              //wenn man Objekt in Hand hat und dann escape dr�ckt konnte man schummeln 
            { 
                Pressed = false;
                GetComponent<Rigidbody2D>().isKinematic = false;
            }
            else
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePos;
            }
        }

    }

}

