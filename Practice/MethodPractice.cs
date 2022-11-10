using UnityEngine;

class MethodPractice : MonoBehaviour
{
    void Start()
    {
        Debug.Log("AAA");
        CountUntil("x", 17);
        Debug.Log("BBB");
        CountUntil("y",14);
        Debug.Log("CCC");
        CountUntil("z", 9);
        Debug.Log("---------------------------");

        int a = Power(5,3);
        int b = Power(4,6);
        int c = Power(2,10);
        Debug.Log($"{a} --- {b} --- {c}");
    }
    void CountUntil(string st, int count)
    {
        for (int i = 1; i < count; i++)
        {
            Debug.Log(st + " " + i);
        }
    }

    //hatványozás
    int Power(int basenumber, int exponent)
    {
        int a = 1;
        for (int i = 0; i < exponent; i++)
        {
            a *= basenumber;
        }
        return a;
    }
}
