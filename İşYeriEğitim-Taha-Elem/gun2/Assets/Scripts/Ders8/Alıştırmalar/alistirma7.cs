using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alistirma7 : MonoBehaviour
{
    public bool denetim;
    string sonuc;
    void Start()
    {
        if(denetim==true)
        {
            sonuc = "Baa�ar�l�";
        }
        else
        {
            sonuc = "Ba�ar�s�z";
        }
        Debug.Log(sonuc);
    }

    
}
