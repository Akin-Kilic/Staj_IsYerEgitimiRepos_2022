using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistirma3 : MonoBehaviour
{
    //public bool denetim;
    //string sonuc;
    float ortalama;
    public float not1, not2, not3;
    void Start()
    {
        ortalama = (not1+not2+not3) / 3;
        Debug.Log(ortalama);
        if (ortalama >= 50)
        {
            Debug.Log("��renci ge�ti");
        }
        else
        {
            Debug.Log("��renci kald�");
        }
        //if(denetim == true)
        //{
        //    sonuc = "ba�arili";
        //}
        //else
        //{
        //    sonuc = "basarisiz";
        //}
        //Debug.Log(sonuc);
    }

    
}
