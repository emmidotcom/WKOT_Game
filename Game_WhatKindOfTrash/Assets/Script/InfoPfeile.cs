using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPfeile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] InfoElemente;
    public GameObject PfeilL;
    public GameObject PfeilR;

    int AktuellesElement = 0;
    
    void Start()
    {
        // AktuellesElement aus InfoElemente suchen
    }

    public void PfeilRechts()
    {
        AktuellesElement += 1;
        print (AktuellesElement);
    }

    public void PfeilLinks()
    {
        AktuellesElement -= 1;
        print(AktuellesElement);
    }

}