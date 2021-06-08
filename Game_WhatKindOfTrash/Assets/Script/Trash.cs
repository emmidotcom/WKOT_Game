using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    Rigidbody2D rb; //wir erstellen einen Rigidbody2d und nennen ihn rb
    public float startForce = 15f; //wir legen eine Zahl fest, um eine startForce generieren

    //Rotation Force
    public float minRotation = 60;
    public float maxRotation = 150;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //wir nehmen uns die Daten unseres Rigidbodys für unseren "rb"
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse); //nun wird zu unserem rb eine Force hinzugefügt, damit unser Müll hochfliegt


        rb.AddTorque(Random.Range(minRotation, maxRotation)); //Rotation der Objekte
    }

}

