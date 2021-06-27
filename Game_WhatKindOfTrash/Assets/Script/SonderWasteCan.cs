using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonderWasteCan : MonoBehaviour
{
    public Transform PointSpawnPosition; //position wo text spawnt
    public AudioSource MyAudioSource;
    public AudioSource MyOtherAudioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SonderWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.AddPoint();               // Zugriff auf ScoreManager Script -> erhöhe Score um +15
            GoodPoints.instance.AddGoodPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsGood(PointSpawnPosition.position, "+15"); //+15 neben mülltonne
            MyAudioSource.Play();
        }
        if (other.gameObject.CompareTag("PlasticWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.TakePoint();              // Zugriff auf ScoreManager Script -> erhöhe Score um -5
            BadPoints.instance.TakeBadPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsBad(PointSpawnPosition.position, "-10"); //-10 neben mülltonne
            MyOtherAudioSource.Play();

        }
        if (other.gameObject.CompareTag("OrganicWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.TakePoint();              // Zugriff auf ScoreManager Script -> erhöhe Score um -5
            BadPoints.instance.TakeBadPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsBad(PointSpawnPosition.position, "-10"); //-10 neben mülltonne
            MyOtherAudioSource.Play();

        }
        if (other.gameObject.CompareTag("PaperWaste"))
        {
            Destroy(other.gameObject);                      // wenn Tag richtig destroy OBJ 
            ScoreManager.instance.TakePoint();              // Zugriff auf ScoreManager Script -> erhöhe Score um -5
            BadPoints.instance.TakeBadPoint();
            VisualFeedbackSpawner.Instance.SpawnPointsBad(PointSpawnPosition.position, "-10"); //-10 neben mülltonne
            MyOtherAudioSource.Play();

        }
    }
}

// Beide Sorten Müll wird "geschluckt" aber der Score wird unterschiedlich beeinflusst