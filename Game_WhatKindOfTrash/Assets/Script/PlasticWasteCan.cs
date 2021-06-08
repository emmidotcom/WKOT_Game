using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlasticWasteCan : MonoBehaviour
{
    public Transform PointSpawnPosition; //position wo text spawnt

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlasticWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ
            ScoreManager.instance.AddPoint();               // Zugriff auf ScoreManager Script -> erh�he Score um +15
            GoodPoints.instance.AddGoodPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsGood(PointSpawnPosition.position, "+15"); //+15 neben m�lltonne
        }

        if (other.gameObject.CompareTag("OrganicWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ
            ScoreManager.instance.TakePoint();
            BadPoints.instance.TakeBadPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsBad(PointSpawnPosition.position, "-10"); //-10 neben m�lltonne

        }
    }
}

// Beide Sorten M�ll wird "geschluckt" aber der Score wird unterschiedlich beeinflusst
