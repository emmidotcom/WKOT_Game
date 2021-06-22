using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPfeile : MonoBehaviour
{
    // Start is called before the first frame update
    [TextArea]
    public string[] InfoElemente;
    public TextMeshProUGUI TextL;
    public TextMeshProUGUI TextR;

    int AktuellesElement = 0;
    
    void Start()
    {
        TextL.text = InfoElemente[0];
        TextR.text = InfoElemente[1];
    }

    public void PfeilRechts()
    {
        if (AktuellesElement < InfoElemente.Length-2)
        {
            AktuellesElement+=2;
            TextL.text = InfoElemente[AktuellesElement];
            TextR.text = InfoElemente[AktuellesElement + 1];
        }
    }

    public void PfeilLinks()
    {
        if (AktuellesElement > 0)
        {
            AktuellesElement-=2;
            TextL.text = InfoElemente[AktuellesElement];
            TextR.text = InfoElemente[AktuellesElement + 1];
        }
    }

}