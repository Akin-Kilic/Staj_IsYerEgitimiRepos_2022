using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileDongusu : MonoBehaviour
{
    int a = 0;
    int b = 0;
    private void Start()
    {
        /*while(a<=10)// 0 dan 10 kadar tamsay� yazd�r.
          {
              Debug.Log(a);
              a++;
          }
         */

        /* while(b<=50)//0 dan 50 ye kadar olan �ift say�lar� yazd�r.
           {
               if(b%2==0)
               {
                   Debug.Log(b);

               }
               b++;
           }*/

        while (b <= 50)//0 dan 50 ye kadar olan �ift say�lar� yazd�r.
        {
            if (b % 2 == 1)
            {
                Debug.Log(b);

            }
            b++;
        }

    }
}
