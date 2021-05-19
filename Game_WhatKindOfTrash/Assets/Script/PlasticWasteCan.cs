using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlasticWasteCan : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlasticWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ
            ScoreManager.instance.AddPoint();               // Zugriff auf ScoreManager Script -> erhöhe Score um +15
            GoodPoints.instance.AddGoodPoint();
        }

        if (other.gameObject.CompareTag("OrganicWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ
            ScoreManager.instance.TakePoint();
            BadPoints.instance.TakeBadPoint();
        }
    }
}

// Beide Sorten Müll wird "geschluckt" aber der Score wird unterschiedlich beeinflusst
