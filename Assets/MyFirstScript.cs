using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Hello " + name);

        // Comment
        /* Also a comment */

        int myFirstVariable;

        myFirstVariable = 6;
        myFirstVariable = 9;
        Debug.Log(myFirstVariable);

        int aaa = 456;

        int x, y, z;

        int integerNumber = 123;
        float myFloatingpointNumber = 3.4f;
        string myFirstString = "anything";
        bool myFirstBool = true;
        myFirstBool = false;


        int a = 1, b = 2, c = 3;
        int summa = a + b;
        Debug.Log(summa); // 3

        int dif = a - 55; // -52
        dif = dif - 5; // -57
        dif -= 5; // -62

        int num = 6;
        num = num + 1; // 7
        num += 1;
        num++;
        Debug.Log(num); // 9

        int product = a * 5; // 5
        int ratio = a / 5; // 0

        int modulo = 34 % a; // 0

        var iii = 123;
        var sss = "asdf";

        int xxx = 3 + 2 * 4; // 11
        xxx = (3 + 2) * 4; // 20

        string s1 = "Hello";
        string s2 = "World";

        string s3 = s1 + " " + s2; // Hello World

        int i1 = 3, i2 = 7;
        string s4 = s1 + i1; // Hello3
        string s5 = s1 + i1 + i2; // Hello37
        string s6 = i2.ToString();

        string s7 = i1 + i2 + s1; // 10Hello

        float ff1 = 3.5f;
        int ii1 = 4;

        int ii2 = (int)ff1;
        float ff2 = ii1;

        string numberText = "234";
        int ii3 = int.Parse(numberText);

    }
}