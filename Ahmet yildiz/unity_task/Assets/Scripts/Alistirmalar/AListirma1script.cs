using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AListirma1script : MonoBehaviour
{
    // Start is called before the first frame update
    int sayac;
    void Start()
    {
        sayac = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //GetMouseButtonDown da masun sol k�sm�na tek tek bas�nca art�yor
        //GetMouseButton bas�ld��� andan itibaren ellini �ekene kadar art�yor.
        //GetkeyButton de ise belirledi�in 
        if (Input.GetMouseButtonDown(0))
        {
            sayac++;
            Debug.Log(sayac);
        }   
    }
}
