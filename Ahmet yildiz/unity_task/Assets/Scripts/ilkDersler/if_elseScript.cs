using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_elseScript : MonoBehaviour
{
    int a = 1;
    int b = 2;
    void Start()
    {
        if (a == 2)
        {
            Debug.Log(a);
        }
        else if (b == 2)
        {
            if (a == 1)
            {
                Debug.Log(b);
            }
            else
            {
                Debug.Log("b de�eri dogru iken a de�erin yanl��");
            }
        }
        else
        {
            Debug.Log("hatal� de�i�ken: ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
