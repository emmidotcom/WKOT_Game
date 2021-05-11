using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    bool Pressed = false;

    void OnMouseDown()                                          //Wenn Maus gedrückt OBJ wird Kinematic (Starr) und kann bewegt werden
    {
        Pressed = true;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }
    void OnMouseUp()                                            //Wenn Maus losgelassen OBJ wird Dynamik und bewegt sich wie zuvor weiter
    {
        Pressed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Pressed)                                             //Maus Gedrückt halten -> OBJ folgt Mausposition
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }
}
