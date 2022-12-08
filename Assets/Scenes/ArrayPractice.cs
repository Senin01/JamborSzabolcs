using System.Collections.Generic; //kell a List<int> intList-hez
using UnityEngine;
class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] intArray;
    [SerializeField] List<int> intList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            int element = intArray[i];
            Debug.Log(element);
        }

        foreach (int element in intArray)
        {
            Debug.Log(element);
        }

        for (int i = intArray.Length - 1; i >= 0 ; i--)
        {
            int element = intArray[i];
            Debug.Log(element);
        }

        int[] intArray2 = new int[10];
        for (int i = 0; i < intArray2.Length; i++)
        {
            intArray2[i] = (i + 1) * (i + 1);
        }

        int[] fibo = new int[10];
        fibo[0] = 1;
        fibo[1] = 1;
        for (int i = 2; i < fibo.Length; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }


        // Lists ---------------------------------------------------

        List<string> stringList = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            int num = (i + 1) * (i + 1);
            stringList.Add(num.ToString());
        }

        foreach (string e in stringList)
        {
            Debug.Log(e);
        }

        for (int i = 0; i < stringList.Count; i++)
        {
            string e = stringList[i];
            Debug.Log(e);
        }


        bool successfulRemove = stringList.Remove("50");
        stringList.RemoveAt(3);

        //stringList.Clear();
        for (int i = 0; i < stringList.Count; i++)
        {
            stringList.RemoveAt(0);
        }

        List<int> intList2 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            int random = Random.Range(1, 100);
            intList2.Add(random);
        }

 /*       for (int i = intList2.Count; i > 0; i--)
        {
            int element = intList2[i];
            if (element % 2 == 0)
            {
                stringList.RemoveAt(i);
            }
        }

        intList2.Sort();
 */

    }
}
