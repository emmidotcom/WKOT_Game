using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualFeedbackSpawner : MonoBehaviour
{
    public static VisualFeedbackSpawner Instance; //singleton (referenzieren wie ein statisches objekt aber trotzdem monobehaviour (dass man add component machen kann))
    public FeedbackPoints feedbackPointsPrefab; //prefab da wo text drin steht
    

    private void Awake()
    {
        Instance = this; //eigenes objekt wird statische instanz 
    }

    public void SpawnPointsGood(Vector3 spawnposition,string value) 
    {
        FeedbackPoints fp = Instantiate(feedbackPointsPrefab); //prefab wird erstellt
        fp.transform.position = spawnposition; //spawnt
        fp.Text.text = value;
        fp.Text.color = Color.green;
    }

    public void SpawnPointsBad(Vector3 spawnposition, string value)
    {
        FeedbackPoints fp = Instantiate(feedbackPointsPrefab);
        fp.transform.position = spawnposition;
        fp.Text.text = value;
        fp.Text.color = Color.red;
    }
}
