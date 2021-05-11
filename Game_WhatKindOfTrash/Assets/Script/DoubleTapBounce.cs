using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapBounce : MonoBehaviour
{
    public float tapForce = 10;                             //Stärke des Bounce -> in Unity selbst variierbar
    public float tiltSmooth = 2;                            //Smoothnes des Bounce -> in Unity selbst variierbar
    public Vector3 startPos;

    Rigidbody2D rigidbody;                                  //OBJ einbinden
    Quaternion downRotation;                                //Fall-Rotation OBj
    Quaternion forwardRotation;                             //Jump-Rotation OBj
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, 30);          //Fall-Rotation festlegen zB 30
        forwardRotation = Quaternion.Euler(0, 0, -30);      //Jump-Rotation festlegen zB -30
    }



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))                    //Wenn Maus Gedrückt dann:
        {
            transform.rotation = forwardRotation;           //Jump-Rotation tritt ein
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);       //OBJ jumped/bounced mit TapForce (Stärke des Bounce)
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);        //Fall-Rotation nur während OBJ angeklickt wird
    }
}

//PROBLEM!!! Momentan ist egal so man auf den Screen klickt OBJ springt und kann sogar aus dem Bild springen 
