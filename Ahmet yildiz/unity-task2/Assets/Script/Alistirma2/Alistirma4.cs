using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alistirma4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    int rastgelesayi;
    int sayi;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //rastgelesayi = Random.Range(1, 11);
            //if (rastgelesayi % 2 == 0) { Debug.Log("��FT SAYI"); }
            //else { Debug.Log("tek say�"); }
            Debug.Log(sayi);
            sayi = Random.Range(1, 25);
            if (sayi > 15) { Debug.Log("15'den b�y�k"); }
            else if (sayi < 15) { Debug.Log("15'den k���k"); }
            else { Debug.Log("15'ye e��it"); }
        }
    }
}
