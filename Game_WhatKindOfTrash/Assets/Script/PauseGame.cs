using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    private bool ispaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (ispaused)
        {
            ispaused = false;
            Time.timeScale = 1f;
        }
        else
        {
            ispaused = true;
            Time.timeScale = 0f;
        }

    }
}
