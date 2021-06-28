using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapBounce : MonoBehaviour
{

    public float tapForce = 10;                             //St�rke des Bounce -> in Unity selbst variierbar
    public float tiltSmooth = 2;                            //Smoothnes des Bounce -> in Unity selbst variierbar
    public Vector3 startPos;

    //float currentx= 100%
    //float currenty= 100%
    //float currentz= 100%

    Rigidbody2D rigidbody;                                  //OBJ einbinden
    Quaternion downRotation;                                //Fall-Rotation OBj
    Quaternion forwardRotation;                             //Jump-Rotation OBj
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, 30);          //Fall-Rotation festlegen zB 30
        forwardRotation = Quaternion.Euler(0, 0, -30);      //Jump-Rotation festlegen zB -30
    }




    // Update is called once per frame
    void OnMouseDown()
    {
        if (!IngameMenu.Instance.isPaused)
        {
            transform.rotation = forwardRotation;           //Jump-Rotation tritt ein
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);       //OBJ jumped/bounced mit TapForce (St�rke des Bounce)
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);        //Fall-Rotation nur w�hrend OBJ angeklickt wird
            //transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }
        
    }
}

//PROBLEM!!! Momentan ist egal so man auf den Screen klickt OBJ springt und kann sogar aus dem Bild springen 
