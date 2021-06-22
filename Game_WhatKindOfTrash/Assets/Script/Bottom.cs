using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    public AudioSource MyAudioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hans")|| other.gameObject.CompareTag("hans"))
        {
            Destroy(other.gameObject);                          // wenn Tag richtig destroy OBJ
            ScoreManager.instance.AddTakePoint();               // Zugriff auf ScoreManager Script -> erh�he Score um -10
            BottomPoints.instance.TakeBadPoint();
            Vector3 spawnPoint = other.transform.position;
            VisualFeedbackSpawner.Instance.SpawnPointsBad(spawnPoint, "-15"); //-15 auf Boden
            MyAudioSource.Play();
        }

    }
}

// Beide Sorten M�ll wird "geschluckt" Score wir gleicherma�en beeinflusst
