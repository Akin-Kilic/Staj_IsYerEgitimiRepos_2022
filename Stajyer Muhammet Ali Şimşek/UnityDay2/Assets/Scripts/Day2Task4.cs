using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task4 : MonoBehaviour
{
    int rastgele;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            rastgele = Random.Range(1, 11);
            Debug.Log(rastgele);
            if (rastgele%2==0)
            {
                Debug.Log("�ift say� de�eri atand�");
            }
            else
            {
                Debug.Log("Tek say� de�eri atand�");
            }
        }
    }
}
