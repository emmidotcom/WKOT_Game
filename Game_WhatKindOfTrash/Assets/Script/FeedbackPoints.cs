using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeedbackPoints : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void Awake()
    {
        Destroy(gameObject,1.5f); //nach 1,5 sek wird text destroyed
    }

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime); //jeder frame objekt geht nach oben
    }
}
