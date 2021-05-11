using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public Camera mainCam;
    public Camera menuCam;

    private bool ispaused;

    // Start is called before the first frame update
    void Start()
    {
        menuCam.gameObject.SetActive(false);
        mainCam.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (ispaused)
        {
            ispaused = false;                            //Wenn man im Spiel ist
            Time.timeScale = 1f;                         //Zeit an
            menuCam.gameObject.SetActive(false);        //Menü AUS
            mainCam.gameObject.SetActive(true);         //Spiel AN

        }
        else
        {
            ispaused = true;                            //Wenns pausiert ist
            Time.timeScale = 0f;                        //Zeit 0
            menuCam.gameObject.SetActive(true);        //Menü AN
            mainCam.gameObject.SetActive(false);       //Spiel AUS
        }
    }
}
