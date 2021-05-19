using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganicWasteCan : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("OrganicWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.AddPoint();               // Zugriff auf ScoreManager Script -> erh�he Score um +15
            GoodPoints.instance.AddGoodPoint();
        }
        if (other.gameObject.CompareTag("PlasticWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.TakePoint();              // Zugriff auf ScoreManager Script -> erh�he Score um -5
            BadPoints.instance.TakeBadPoint();
        }
    }
}

// Beide Sorten M�ll wird "geschluckt" aber der Score wird unterschiedlich beeinflusst