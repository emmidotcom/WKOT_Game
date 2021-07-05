using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

   // public GameObject LastLevelInfo;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void LoadLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }
}
