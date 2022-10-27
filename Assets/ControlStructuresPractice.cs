using UnityEngine;

class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string parity;
    [SerializeField] string domain;
    [SerializeField] string danger;
    [SerializeField] string divideableBy3;
    void OnValidate()
    {
        //Elagazasok
        bool isEven = number % 2 == 0; //páros-e

        if (isEven)
        {
            parity = "PAROS";
        }
        else
        {
            parity = "PARATLAN";
        }
        //------------------------------
        if (number > 0)
        {
            domain = "POZITIV";
        }
        else if (number < 0)
        {
            domain = "NEGATIV";
        }
        else
        {
            domain = "NULLA";
        }

        //-----------------------------

        if (number < 10)
        {
            danger = "LOW";
        }
        else if (number < 35)
        {
            danger = "MEDIUM";
        }
        else if (number < 50)
        {
            danger = "HIGH";
        }
        else
        {
            danger = "VERY HIGH";
        }

        //---------------------------------------
        divideableBy3 = number % 3 == 0 ? "OSZTHATO" : "NEM OSZTHATO";
    }
    private void Start()
    {
        //Ciklusok
        int i = 1;
        while(i <= 5)
        {
            Debug.Log(i);
            i++;
        }

        for (int j = 0; j < 5; j++)
        {
            Debug.Log(j);
        }

        for (int j = 10; j >= 1; j--)
        {
            Debug.Log(j);
        }

        for (int k = 1; k <= 100; k+=3)
        {
            Debug.Log(k);
        }

        //1-100 oszthato 3-al és 7-el
        for (int l = 1; l < 100; l++)
        {
            if(l % 3 == 0 && l % 7 == 0)
            {
                Debug.Log(l);
            }
        }
        //vagy
        for (int l = 7; l < 100; l+=7)
        {
            if (l % 3 == 0)
            {
                Debug.Log(l);
            }
        }

    }
}
