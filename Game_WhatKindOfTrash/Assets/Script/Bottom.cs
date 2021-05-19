using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("OrganicWaste"))
        {
            Destroy(other.gameObject);                          // wenn Tag richtig destroy OBJ
            ScoreManager.instance.AddTakePoint();               // Zugriff auf ScoreManager Script -> erhöhe Score um -10
            BottomPoints.instance.TakeBadPoint();
            
        }
        if (other.gameObject.CompareTag("PlasticWaste"))
        {
            Destroy(other.gameObject);                     // wenn Tag richtig destroy OBJ
            ScoreManager.instance.AddTakePoint();               // Zugriff auf ScoreManager Script -> erhöhe Score um -10
            BottomPoints.instance.TakeBadPoint();
        }

    }
}

// Beide Sorten Müll wird "geschluckt" Score wir gleichermaßen beeinflusst
