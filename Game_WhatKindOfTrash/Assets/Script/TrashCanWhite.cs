using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCanWhite : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trash2"))
        {
            Destroy (other.gameObject);                     // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.AddPoint();               // Zugriff auf ScoreManager Script -> erhöhe Score um +15
        }
        if (other.gameObject.CompareTag("Trash1"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.TakePoint();              // Zugriff auf ScoreManager Script -> erhöhe Score um -5
        }
    }
}

// Beide Sorten Müll wird "geschluckt" aber der Score wird unterschiedlich beeinflusst