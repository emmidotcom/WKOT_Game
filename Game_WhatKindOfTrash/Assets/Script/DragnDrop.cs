using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool Pressed = false;

    void OnMouseDown()                                          //Wenn Maus gedrückt OBJ wird Kinematic (Starr) und kann bewegt werden
    {
        if (!IngameMenu.Instance.isPaused)                        //ausführen falls nicht pausiert -> damit man sachen im pause ned bewegen kann
        {
            Pressed = true;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;  //dann fällts einfach runter
            GetComponent<Rigidbody2D>().isKinematic = true;

            GetComponent<Rigidbody2D>().angularVelocity = 0;  //damit Müll sich nicht weiter rotiert

        }
    }
    void OnMouseUp()                                            //Wenn Maus losgelassen OBJ wird Dynamik und bewegt sich wie zuvor weiter
    {
        if (!IngameMenu.Instance.isPaused)                       //ausführen falls nicht pausiert -> damit man sachen im pause ned bewegen kann
        {
            Pressed = false;
            GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Pressed)                                             //Maus Gedrückt halten -> OBJ folgt Mausposition
        {
            if (IngameMenu.Instance.isPaused)                  //wenn man Objekt in Hand hat und dann escape drückt konnte man schummeln 
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

