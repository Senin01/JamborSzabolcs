using UnityEngine;

class FindMinMax : MonoBehaviour
{
    [SerializeField] int a, b;

    [SerializeField] int min, max;
    void OnValidate()
    {
        if (a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }
        max = a > b ? a : b;

        //-----
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);

        //-----
        min = Minimum(a, b);
        max = Maximum(a, b);
    }

    int Minimum(int n1, int n2)
    {
        return n1 > n2 ? n1 : n2;
    }
    int Maximum(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
}
